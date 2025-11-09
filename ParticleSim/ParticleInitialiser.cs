using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSim
{
   public class ParticleInitialiser
    {
        private int particleCount;
        private List<Particle> particles = new List<Particle>();       

        public ParticleInitialiser()
        {
            
        }       

        public void AddNewParticle(Dictionary<string, object> config)
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

            ScaleRadii(particles);
        }
        public List<Particle> ScaleRadii(List<Particle> particles)
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

            foreach(Particle p in particles)                                                 // loops through every particle
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

            return particles;            
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
