using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleSim
{
    public class DisplayFrame
    {
        public DisplayFrame()
        {
            Panel panelDisplayArea = new Panel();
            panelDisplayArea.Visible = true;
        }

        public void RenderParticles(Graphics g, List<Particle> particles, Panel panelDisplayArea, int mode)
        {
            foreach (Particle p in particles)                                                                   // loops through each particle
            {
                float x = p.position.X;
                float y = p.position.Y;
                float radius = p.radius;
                if (mode == 1)
                {
                    y = panelDisplayArea.Height / 2f;                                                           // y value in centre
                }
                RectangleF particleBounds = new RectangleF(x - radius, y - radius, 2 * radius, 2 * radius);     // bounds for the particle circle
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;                             // makes circles smoother

                using (Brush brush = new SolidBrush(p.color))
                {
                    g.FillEllipse(brush, particleBounds);                                                       // draw filled circle for particle using bounds
                }

                using (Pen border = new Pen(Color.White))
                {
                    g.DrawEllipse(border, particleBounds);      // draw white border around particle
                }
            }
        }

        public void DrawGrid(Graphics g, Panel panelDisplayArea)
        {
            Pen gridPen = new Pen(Color.LightSalmon);

            int gridlines = 100;                    // how many gridlines drawn horizontally and vertically
            int spacing = 10;                       // space between gridlines in pixels

            for (int i = 0; i <= gridlines; i++)    // draw horizontal gridlines
            {
                g.DrawLine(gridPen, i * spacing, 0, i * spacing, panelDisplayArea.Height);
            }

            for (int j = 0; j <= gridlines; j++)    // draw vertical gridlines
            {
                g.DrawLine(gridPen, 0, j * spacing, panelDisplayArea.Width, j * spacing);
            }
        }

        public void DrawArrows(Graphics g, List<Particle> particles, Panel panelDisplayArea, int mode)
        {
            float arrowLengthScale = 0.4f;                      // pixels per m/s
            float headLengthScale = 1f;                         // arrowhead length for radius 1px
            float headWidthScale = 0.8f;                        // arrowhead width for radius 1px
            float arrowThickness = 4f;                          // arrow shaft thickness for radius 1px
            float outlineThickness = 2.5f;                      // arrow outline thickness for radius 1px

            foreach (Particle p in particles)
            {
                float radius = p.radius;                        // radius of the particle
                float headLength = radius * headLengthScale;    // length of arrowhead
                float headWidth = radius * headWidthScale;      // width of arrowhead

                Vector2 velocity = p.velocity;                  // get velocity vector
                float speed = velocity.Length();                // get speed (magnitude of velocity)

                Vector2 normal = velocity / speed;              // normalize velocity to get direction
                Vector2 start = p.position;                     // start at particle position

                if (mode == 1 && panelDisplayArea != null)
                {
                    start.Y = panelDisplayArea.Height / 2f;
                }

                Vector2 end = start + (normal * speed * arrowLengthScale);      // end point based on speed and direction

                using (Pen outlineArrow = new Pen(Color.Black, outlineThickness * 2f + arrowThickness))
                {
                    outlineArrow.StartCap = System.Drawing.Drawing2D.LineCap.Round;     // configurations make arrow round
                    outlineArrow.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    outlineArrow.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                    g.DrawLine(outlineArrow, start.X, start.Y, end.X - headLength * normal.X, end.Y - headLength * normal.Y);
                }

                using (Pen arrowPen = new Pen(p.color, arrowThickness))                 // draw arrow shaft
                {
                    arrowPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    arrowPen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
                    arrowPen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                    g.DrawLine(arrowPen, start.X, start.Y, end.X, end.Y);
                }

                Vector2 baseCenter = end - normal * headLength;             // center point of the triangle base
                Vector2 perp = new Vector2(-normal.Y, normal.X);            // perpendicular to direction

                Vector2 left = baseCenter + perp * (headWidth * 0.5f);      // left base point
                Vector2 right = baseCenter - perp * (headWidth * 0.5f);     // right base point

                PointF[] triangle = new PointF[]                            // triangle points in an array
                {
                    new PointF(end.X, end.Y),                               // tip
                    new PointF(left.X, left.Y),                             // left base
                    new PointF(right.X, right.Y)                            // right base
                };

                using (Brush b = new SolidBrush(p.color))                   // fill triangle
                {
                    g.FillPolygon(b, triangle);
                }

                using (Pen triangleOutline = new Pen(Color.Black, outlineThickness))    // outline triangle
                {   
                    triangleOutline.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                    g.DrawPolygon(triangleOutline, triangle);
                }
            }
        }
    }
}
