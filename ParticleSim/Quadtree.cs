using System.Collections.Generic;
using System.Drawing;

namespace ParticleSim
{
    internal class Quadtree
    {
        // node class
        private class Node
        {
            private RectangleF bounds;         
            private int capacity;           // number of particles in the node
            private int maxDepth;           
            private int depth;              
            private List<Particle> particles = new List<Particle>();

            private Node[] children;        

            public Node(RectangleF bounds, int capacity, int maxDepth, int depth)
            {
                this.bounds = bounds;       
                this.capacity = capacity;
                this.maxDepth = maxDepth;
                this.depth = depth;
            }

            // insert particle into node
            public bool Insert(Particle particle)
            {
                PointF point = new PointF(particle.position.X, particle.position.Y);    // particle position as PointF

                if (bounds.Contains(point) == false)                                    // check if particle is within bounds
                {
                    return false;                                                       // particle out of bounds
                }

                if (children == null)                                                   // if no children, is leaf node
                {
                    if (particles.Count < capacity || depth >= maxDepth)                // check capacity and depth
                    {
                        particles.Add(particle);                                        // add particle to this node
                        return true;                                                    // successfully inserted
                    }
                    else
                    {
                        Subdivide();                                                    // subdivide node    
                    }
                }

                foreach (Node child in children)                                        // try to insert into children
                {                                       
                    if (child.Insert(particle))                                         // recursive insert        
                    {
                        return true;
                    }
                }

                return true;                                                            // fallback but should not reach here
            }

            // subdivide node into 4 children
            private void Subdivide()
            {
                children = new Node[4];                                                 // create 4 child nodes       
                float halfWidth = bounds.Width / 2f;                                    // half width
                float halfHeight = bounds.Height / 2f;                                  // half height

                children[0] = new Node(new RectangleF(bounds.X, bounds.Y, halfWidth, halfHeight), capacity, maxDepth, depth + 1);                           // top-left
                children[1] = new Node(new RectangleF(bounds.X + halfWidth, bounds.Y, halfWidth, halfHeight), capacity, maxDepth, depth + 1);               // top-right
                children[2] = new Node(new RectangleF(bounds.X, bounds.Y + halfHeight, halfWidth, halfHeight), capacity, maxDepth, depth + 1);              // bottom-left
                children[3] = new Node(new RectangleF(bounds.X + halfWidth, bounds.Y + halfHeight, halfWidth, halfHeight), capacity, maxDepth, depth + 1);  // bottom-right

                List<Particle> tempParticles = new List<Particle>(particles);           // copy current particles
                particles.Clear();                                                      // clear current node particles
                foreach (Particle particle in tempParticles)
                {
                    Insert(particle);                                                   // re-insert particles into children
                }      
            }

            // query particles within range
            public void Query(RectangleF range, List<Particle> results)
            {
                if (!bounds.IntersectsWith(range))                                      // if no intersection, return
                {
                    return;
                }

                foreach (Particle particle in particles)                                // check particles in this node
                {
                    PointF point = new PointF(particle.position.X, particle.position.Y);// particle position as PointF
                    if (range.Contains(point))                                          // if within range
                    {
                        results.Add(particle);                                          // add to results
                    }
                }

                if (children != null)                                                   // if has children, query them
                {
                    foreach (Node child in children)
                    {
                        child.Query(range, results);                                    // recursive query
                    }
                }
            }

            // clear the node
            public void Clear()
            {
                particles.Clear();                               // clear particles
                if (children != null)                            // if has children
                {
                    foreach (Node child in children)
                    {
                        child.Clear();                           // recursive clear
                    }
                    children = null;                             // remove children
                }
            }
        }

        private Node root;

        // quadtree constructor
        public Quadtree(RectangleF bounds, int capacity, int maxDepth)
        {
            root = new Node(bounds, capacity, maxDepth, 0);                             // create root node
        }

        // insert particle into quadtree
        public bool Insert(Particle particle)
        {
            return root.Insert(particle);                                               // insert particle into quadtree
        }

        // query particles within range
        public List<Particle> Query(RectangleF range)
        {
            List<Particle> results = new List<Particle>();                              // list to hold results
            root.Query(range, results);                                                 // query root node
            return results;                                                             // return found particles
        }

        // clear the quadtree
        public void Clear()
        {
            root.Clear();                                                               // clear the quadtree
        }
    }
}    