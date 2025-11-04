using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSim
{

    public class Particle
    {
        public int id;
        public float mass;
        public float radius;
        public Vector2 position;
        public Vector2 velocity;
        public Color color;
        public Particle(int Id, float Mass, float Radius, Vector2 Position, Vector2 Velocity, Color Color)
        {
            id = Id;
            mass = Mass;
            radius = Radius;
            position = Position;
            velocity = Velocity;
            color = Color;
        }        
    }
}
