using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleSim
{
   public class ParticleInitialiser
    {
        private int particleCount;
        private List<Particle> particles = new List<Particle>();       

        public ParticleInitialiser()
        {
            
        }     

        public void AddNewParticle(Dictionary<string, object> config, int mode)
        {
            particleCount = particles.Count;
           
            int id = particleCount + 1;
            float mass = (float)config["mass"];
            float speed = (float)config["speed"];
            Vector2 position = (Vector2)config["position"];
            Color color = (Color)config["color"];          

            Vector2 velocity = new Vector2(speed, 0);

            Particle newParticle = new Particle(id, mass, 5, position, velocity, color);
            particles.Add(newParticle);

            ScaleRadii(particles, mode);
        }
        
        public Particle AddGasParticle(SimulationManager simManager, Dictionary<string,object> config, int mode, float heat )
        {
            particleCount = particles.Count;

            int id = particleCount + 1;
            float mass = (float)config["mass"];
            float avgSpeed = (float)config["speed"];
            float radius = (float)config["radius"];
            Vector2 position = (Vector2)config["position"];
            Color color = Color.Red;

            Vector2 velocity = DistributeGasVelocities(avgSpeed, heat);

            Particle newParticle = new Particle(id, mass, radius, position, velocity, color);
            particles.Add(newParticle);            
            
            return newParticle;
        }

        public Particle AddRelativisticParticle(Panel panel, float mass, float speed, Color color )
        {
            particleCount = particles.Count;
            int id = particleCount + 1;

            Vector2 position = new Vector2(0, 0);
            Vector2 direction = new Vector2(0, 0);

            if (id % 2 == 1)
            {
                position = new Vector2(panel.Height / 2, panel.Height / 2);
                direction = new Vector2(1, 0); // first particle goes right

            }
            if (id % 2 == 0)
            {   
                position = new Vector2(panel.Width - panel.Height / 2, panel.Height / 2);
                direction = new Vector2(-1, 0); // second particle goes left
            }

            Vector2 velocity = speed * direction;

            Particle newParticle = new Particle(id, mass, 10, position, velocity, color);
            particles.Add(newParticle);
            return newParticle;
        }

        public Vector2 DistributeGasVelocities(float avgSpeed, float heat)
        {
            float sigma = (float)(avgSpeed * Math.Sqrt(2.0 / Math.PI) * heat);

            float velocityX = (float)MathNet.Numerics.Distributions.Normal.Sample(0, sigma);
            float velocityY = (float)MathNet.Numerics.Distributions.Normal.Sample(0, sigma);

            return new Vector2(velocityX, velocityY);
        }


        public List<Particle> ScaleRadii(List<Particle> particles, int mode)
        {   
            if (mode == 1 || mode == 2)
            {
                float maxRadius = 25f;              // max and min bounds for the radius
                float minRadius = 15f;

                if (particles.Count == 0)
                {
                    return particles;               // nothing to scale
                }

                List<double> logMasses = particles.Select(p => Math.Log(p.mass)).ToList();       // get natural log of all masses and put in a list
                double logMax = logMasses.Max();                                                 // get max and min log masses
                double logMin = logMasses.Min();

                foreach (Particle p in particles)                                                 // loops through every particle
                {
                    float scaledRadius;
                    double logMass = Math.Log(p.mass);                                           // get log mass of current particle        

                    if (logMin == logMax)                                                        // if all masses are the same
                    {                                                                            // this is important for the first particle   
                        scaledRadius = maxRadius;
                    }
                    else
                    {                                                                            // scale radius logarithmically between min and max radius                
                        scaledRadius = (float)((logMass - logMin) / (logMax - logMin) * (maxRadius - minRadius) + minRadius);
                    }
                    p.radius = scaledRadius;                                                     // sets radius of particle
                }                
            }
            
            return particles;
        }

        public float GetGasRadius(int quantity, int[] bounds)
        {
            float areaPanel = bounds[0] * bounds[1];             // area of panel in pixels
            float areaParticles = areaPanel * 0.10f;             // particles occupy 10% of area
            float areaPerParticle = areaParticles / quantity;    // area allocated per particle

            float radius = (float)Math.Sqrt(areaPerParticle / Math.PI); // radius from area of circle formula

            return radius;
        }

        public List<Particle> GetParticles()
        {
            return particles;
        }

        public void ClearParticles()
        {
            particles.Clear();
        }
    }
}
