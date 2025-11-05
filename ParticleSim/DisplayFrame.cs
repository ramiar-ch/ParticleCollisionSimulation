using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleSim
{
    public class DisplayFrame
    {
        private int width;
        public DisplayFrame()
        {
            Panel panelDisplayArea = new Panel(); 
            width = panelDisplayArea.Width;
            panelDisplayArea.Visible = true;
        }        

        public void RenderParticles(Graphics g, List<Particle> particles, Panel panelDisplayArea, int mode)
        {
            foreach (Particle p in particles)                   // loops through each particle
            {
                float x = p.position.X;
                float y = p.position.Y;
                float radius = p.radius;
                if (mode == 1)
                {
                    y = panelDisplayArea.Height / 2f;   // the y value for each particle should be the center of the display panel in 1D
                }
                RectangleF particleBounds = new RectangleF(x - radius, y - radius, 2 * radius, 2 * radius);   // bounds for the particle circle
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // makes circles smoother

                using (Brush brush = new SolidBrush(p.color))
                {
                    g.FillEllipse(brush, particleBounds);       // draw filled circle for particle using bounds
                }

                using (Pen border = new Pen(Color.White))
                {
                    g.DrawEllipse(border, particleBounds);      // draw white border around particle
                }                
            }
        }

        public int GetPanelBounds()
        {
            return width;
        }
    }
}
