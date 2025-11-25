using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ParticleSim
{
    public class SimulationManager
    {
        private int[] bounds = new int[2];          // first value is width, second is height
        private float restitution = 1f;             // default to elastic
        private Random rng = new Random();          // random number generator
        private Quadtree quadtree;                  // quadtree for spatial partitioning

        private Queue<float> impulseHistory = new Queue<float>(30);

        public SimulationManager()
        {

        }

        public void SetBounds(int width, int height)
        {
            bounds[0] = width;
            bounds[1] = height;

            quadtree = new Quadtree(new RectangleF(0, 0, width, height), capacity: 6, maxDepth: 8); // initialize quadtree
        }

        public void SetElasticity(float elasticity)
        {
            restitution = elasticity;
        }

        public List<Particle> UpdateParticles(List<Particle> particles, float timeChange, int mode, float heat = 1)
        {
            List<Particle> updatedParticles = new List<Particle>(particles.Count);         
            
            
            foreach (Particle p in particles)
            {
                p.position = p.position + (p.velocity * heat) * (timeChange / 1000f);
                EnforceBoundary(p);
                updatedParticles.Add(p);
            }
            

            return updatedParticles;
        }

        public List<Particle> UpdateRelativisticParticles(List<Particle> particles, float timeChange, int frame)
        {
            List<Particle> updatedParticles = new List<Particle>(2);

            if (frame == 1)
            {
                foreach (Particle p in particles)
                {
                    p.position.X = p.position.X + (p.velocity.X * 100) * (timeChange / 1000f);
                    updatedParticles.Add(p);
                }
            }
            else if (frame == 2)
            {
                float velocityCM = GetCMVelocity(particles);

                foreach (Particle p in particles)
                {
                    float labVelocityX = p.velocity.X;
                    float cmVelocityX = (labVelocityX - velocityCM) / (1f - velocityCM * labVelocityX);
                    p.position.X = p.position.X + (cmVelocityX * 100) * (timeChange / 1000f);
                    updatedParticles.Add(p);
                }
            }


            return updatedParticles;
        }

        public float GetCMVelocity(List<Particle> particles)
        {
            float momentum = 0f;
            float energy = 0f;
            foreach (Particle p in particles)
            {
                float labVelocityX = p.velocity.X;
                float gamma = 1f / (float)Math.Sqrt(1f - labVelocityX * labVelocityX);
                momentum += gamma * p.mass * labVelocityX;
                energy += gamma * p.mass;
            }
            float velocityCM = momentum / energy;
            return velocityCM;
        }

        public void GetCMTime(TimeSpan labTime)
        {
            float momentum = 0f;
            float energy = 0f;

            

            float velocityCM = momentum / energy;
        }

        public Vector2 GetValidPosition(float radius)
        {   
            int width = bounds[0];                                      // area dimensions
            int height = bounds[1];

            float margin = radius + 2f;                                 // margin avoiding boundary issues
            int attempts = 50;                                          // attempts to find valid position

            for (int attempt = 0; attempt < attempts; attempt++)        
            {
                float x = (float)(rng.NextDouble() * (bounds[0] - 2 * margin) + margin);   // generate random position
                float y = (float)(rng.NextDouble() * (bounds[1] - 2 * margin) + margin);

                float searchRadius = radius * 2f + 2f;
                RectangleF searchBox = new RectangleF(                  // create search box
                    x - searchRadius,
                    y - searchRadius,
                    searchRadius * 2f,
                    searchRadius * 2f);

                List<Particle> candidates = quadtree.Query(searchBox);  // query quadtree for nearby particles

                bool overlap = false;                                   // flag for overlap detection

                foreach (Particle candidate in candidates)              // check each candidate for overlap
                {
                    Vector2 displacement = candidate.position - new Vector2(x, y);          // disp from candidate to new pos
                    float distanceSquared = displacement.LengthSquared();                   // avoid sqrt for efficiency
                    float radiusSum = radius + candidate.radius;        // sum of radii
                    if (distanceSquared <= radiusSum * radiusSum)       // overlap detected
                    {
                        overlap = true;                                 // set flag and break
                        break;
                    }
                }

                if (overlap == false)
                {
                    return new Vector2(x, y);                           // valid position found                    
                }
            }

            float fallbackX = (float)(rng.NextDouble() * (width - 2 * margin) + margin);
            float fallbackY = (float)(rng.NextDouble() * (height - 2 * margin) + margin);

            return new Vector2(fallbackX, fallbackY);               // return last generated position as fallback
        }

        public void DetectCollisions(List<Particle> particles, int mode, bool lab = false)
        {
            if (particles == null || particles.Count < 2)
            {
                return;                                                     // null check
            }

            if (mode == 1 || mode == 2) 
            {
                for (int i = 0; i < particles.Count - 1; i++)                   // check each unique particle pair
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
                            if (lab)
                            {
                                LabCollision(particleA, particleB);            // resolve collision in lab frame
                            }
                            else
                            {
                                CMCollision(particleA, particleB);             // resolve collision in center of mass frame
                            }                         
                        }
                    }
                }
            }

            if (mode == 3)
            {
                for (int i = 0; i < particles.Count - 1; i++)                   // check each unique particle pair
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
                            ResolveCollisions(particleA, particleB, restitution);        // resolve collision                         
                        }
                    }
                }
            }

            if (mode == 4)
            {
                quadtree.Clear();
                if (quadtree != null)
                {
                    foreach (Particle particle in particles)
                    {
                        quadtree.Insert(particle);                             // insert particles into quadtree
                    }
                }

                foreach (Particle particle in particles)
                {
                    float queryRadius = particle.radius * 2f;                  // query radius for potential collisions
                    RectangleF queryBox = new RectangleF(                      // create query box
                        particle.position.X - queryRadius,
                        particle.position.Y - queryRadius,
                        queryRadius * 2f,
                        queryRadius * 2f);

                    List<Particle> candidates = quadtree.Query(queryBox);      // get potential colliding particles

                    foreach (Particle candidate in candidates)
                    {
                        if (candidate.id <= particle.id)
                        {
                            continue;                                          // avoid double checking and self-collision
                        }
                        Vector2 displacement = candidate.position - particle.position; // vector from A to candidate
                        float distanceSquared = displacement.LengthSquared();  // avoid sqrt for efficiency
                        float radiusSum = particle.radius + candidate.radius;  // sum of radii
                        if (distanceSquared <= radiusSum * radiusSum)          // collision detected 
                        {
                            ResolveCollisions(particle, candidate, restitution);       // resolve collision                         
                        }
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

        public void LabCollision(Particle particleA, Particle particleB)
        {
            if (particleA == null || particleB == null || particleA.mass <= 0f || particleB.mass <= 0f)
            {
                return;                                 // null check and mass check
            }

            float velocityA = particleA.velocity.X;
            float velocityB = particleB.velocity.X;

            float gammaA = 1f / (float)Math.Sqrt(1f - velocityA * velocityA);
            float gammaB = 1f / (float)Math.Sqrt(1f - velocityB * velocityB);

            float momentumA = gammaA * particleA.mass * velocityA;
            float momentumB = gammaB * particleB.mass * velocityB;
            float energyTotal = gammaA * particleA.mass + gammaB * particleB.mass; // total energy  

            float velocityCoM = (momentumA + momentumB) / energyTotal;    // center of mass velocity

            float velocityACoM = (velocityA - velocityCoM) / (1f - velocityCoM * velocityA);   // velocity of A in CoM frame
            float velocityBCoM = (velocityB - velocityCoM) / (1f - velocityCoM * velocityB);   // velocity of B in CoM frame

            velocityA = (velocityCoM + -velocityACoM) / (1f + velocityCoM * -velocityACoM); // A's new velocity in lab frame
            velocityB = (velocityCoM + -velocityBCoM) / (1f + velocityCoM * -velocityBCoM); // B's new velocity in lab frame

            particleA.velocity = new Vector2(velocityA, 0f);    // update velocities
            particleB.velocity = new Vector2(velocityB, 0f);

        }

        public void CMCollision(Particle particleA, Particle particleB)
        {
            if (particleA == null || particleB == null || particleA.mass <= 0f || particleB.mass <= 0f)
            {
                return;                                 // null check and mass check
            }

            float velocityA = particleA.velocity.X;
            float velocityB = particleB.velocity.X;

            float gammaA = 1f / (float)Math.Sqrt(1f - velocityA * velocityA);
            float gammaB = 1f / (float)Math.Sqrt(1f - velocityB * velocityB);

            float momentumA = gammaA * particleA.mass * velocityA;
            float momentumB = gammaB * particleB.mass * velocityB;
            float energyTotal = gammaA * particleA.mass + gammaB * particleB.mass; // total energy  

            float velocityCoM = (momentumA + momentumB) / energyTotal;    // center of mass velocity

            velocityA = (velocityA - velocityCoM) / (1f - velocityCoM * velocityA);   // velocity of A in CoM frame
            velocityB = (velocityB - velocityCoM) / (1f - velocityCoM * velocityB);   // velocity of B in CoM frame


            particleA.velocity = new Vector2(velocityA, 0f);    // update velocities
            particleB.velocity = new Vector2(velocityB, 0f);
        }

        
        public void EnforceBoundary(Particle particle)
        {
            int width = bounds[0];
            int height = bounds[1];

            Vector2 normal = new Vector2();
            float impulse = 0f;
            float impulseTotal = 0f;
            
            if (particle == null)
            {
                return;
            }

            float radius = particle.radius;
            

            // left boundary 
            if (particle.position.X - radius < 0f)
            {
                normal = new Vector2(1, 0);
                impulse = Vector2.Dot(particle.velocity, normal) * particle.mass;
                impulseTotal += Math.Abs(impulse);
                particle.position.X = radius;                   // reset position to boundary
                particle.velocity.X = -particle.velocity.X;     // reverse velocity    
            }

            // right boundary
            if (particle.position.X + radius > width)
            {
                normal = new Vector2(-1, 0);
                impulse = Vector2.Dot(particle.velocity, normal) * particle.mass;
                impulseTotal += Math.Abs(impulse);
                particle.position.X = width - radius;           // reset position to boundary
                particle.velocity.X = -particle.velocity.X;     // reverse velocity
            }

            // bottom boundary
            if (particle.position.Y + radius > height)
            {
                normal = new Vector2(0, 1);
                impulse = Vector2.Dot(particle.velocity, normal) * particle.mass;
                impulseTotal += Math.Abs(impulse);
                particle.position.Y = height - radius;          // reset position to boundary
                particle.velocity.Y = -particle.velocity.Y;     // reverse velocity
            }

            // top boundary
            if (particle.position.Y - radius < 0f)              
            {
                normal = new Vector2(0, -1);
                impulse = Vector2.Dot(particle.velocity, normal) * particle.mass;
                impulseTotal += Math.Abs(impulse);
                particle.position.Y = radius;                   // reset position to boundary
                particle.velocity.Y = -particle.velocity.Y;     // reverse velocity    
            }

            impulseHistory.Enqueue(impulseTotal);
        }

        public float GetPressure()
        {   
            if (impulseHistory.Count >= 30)
            {
                impulseHistory.Dequeue();                
            }

            float totalImpulse = 0f;
            foreach(float impulse in impulseHistory)
            {
                totalImpulse += impulse;
            }
                        
            float wallLength = 2f * (bounds[0] + bounds[1]);      // total wall length

            float interval = impulseHistory.Count / 30f;
            float pressure = totalImpulse / (wallLength * interval);

            return pressure;
        }

        public void InsertParticleToQuadtree(Particle particle)
        {
            if (quadtree != null && particle != null)           // null checks
            {
                quadtree.Insert(particle);                      // insert particle to quadtree
            }
        }

        public void ClearQuadtree()
        {
            quadtree.Clear();                                   // clear quadtree
        }
    }
}
