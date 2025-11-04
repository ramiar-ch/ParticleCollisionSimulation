using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleSim
{
    public class SimulationManager
    {
        private float boundsWidth = 0f;
        
        public SimulationManager()
        {
           
        }

        public void SetBounds(int width)
        {
            boundsWidth = width;
        }
        
        public List<Particle> UpdateParticles(List<Particle> particles, float timeChange)
        {
            List<Particle> updatedParticles = new List<Particle>(particles.Count);
            foreach (Particle p in particles)
            {
                p.position = p.position + p.velocity * (timeChange / 1000f);
                EnforceBoundary(p);
                updatedParticles.Add(p);
            }
            
            return updatedParticles;
        }               
         
        public void DetectCollisions(List<Particle> particles)
        {
            if (particles == null || particles.Count < 2)   // null check
                return;

            // check each unique pair of particles for collision
            for (int i = 0; i < particles.Count - 1; i++)
            {
                Particle particleA = particles[i];
                for (int j = i + 1; j < particles.Count; j++)
                {
                    Particle particleB = particles[j];

                    Vector2 displacement = particleB.position - particleA.position; // vector from A to B

                    float distanceSquared = displacement.LengthSquared();   // avoid sqrt for efficiency
                    float radiusSum = particleA.radius + particleB.radius;  // sum of radii
                    if (distanceSquared <= radiusSum * radiusSum)           // collision detected 
                    {
                        ResolveCollisions(particleA, particleB, 1f);        // resolve collision with restitution of 1 (elastic)
                    }
                }
            }
        }  

        public void ResolveCollisions(Particle particleA, Particle particleB, float restitution)
        {               
            if (particleA == null || particleB == null || particleA.mass <= 0f || particleB.mass <= 0f)
            {
                return;                                 // null check and mass check
            }
            // get the penetration and move this to prototype 4 when i fix this issue properly
            /*
            float penetration = (particleA.radius + particleB.radius) - Math.Abs(particleB.position.X - particleA.position.X); // penetration depth
            if (penetration > 0f)   // if overlapping
            {
                float correctionPercent = 0.5f;   // push each particle half the penetration distance                    

                if (particleA.velocity.X > 0 && particleB.velocity.X < 0) // A moving right, B moving left
                {
                    particleA.position.X -= penetration * correctionPercent; // move A left
                    particleB.position.X += penetration * correctionPercent; // move B right
                }
                else if (particleA.velocity.X < 0 && particleB.velocity.X > 0) // A moving left, B moving right
                {
                    particleA.position.X += penetration * correctionPercent; // move A right
                    particleB.position.X -= penetration * correctionPercent; // move B left
                }
            }*/

            float speedA = particleA.velocity.X;        // get speeds
            float speedB = particleB.velocity.X;                
                
            if (particleA.position.X < particleB.position.X && speedA <= speedB)
            {
                return;                                 // if separating do nothing
            } 
                    
            if (particleA.position.X > particleB.position.X && speedA >= speedB)
            {
                return;                                 // if separating do nothing
            }                    

            float massA = particleA.mass;               // variables for masses
            float massB = particleB.mass;
            float inverseMass = 1f / (massA + massB);   // easier to have it saved for later calculation

            float velocityA = (speedA * (massA - massB) + 2f * massB * speedB) * inverseMass;       // compute velocities
            float velocityB = (speedB * (massB - massA) + 2f * massA * speedA) * inverseMass;

            velocityA = speedA + (velocityA - speedA) * Math.Max(0f, Math.Min(1f, restitution));    // apply restitution
            velocityB = speedB + (velocityB - speedB) * Math.Max(0f, Math.Min(1f, restitution));

            particleA.velocity = new Vector2(velocityA, particleA.velocity.Y);                      // update velocities
            particleB.velocity = new Vector2(velocityB, particleB.velocity.Y);            
        }                     
                
        public void EnforceBoundary(Particle particle)
        {
            if (particle == null)
            {
                return;
            }

            float radius = particle.radius;

            // left boundary 
            if (particle.position.X - radius < 0f)          
            {
                particle.position.X = radius;                   // reset position to boundary
                particle.velocity.X = -particle.velocity.X;     // reverse velocity    
            }

            // right boundary
            if (particle.position.X + radius > boundsWidth)     
            {
                particle.position.X = boundsWidth - radius;     // reset position to boundary
                particle.velocity.X = -particle.velocity.X;     // reverse velocity
            }
        }
    }
}
