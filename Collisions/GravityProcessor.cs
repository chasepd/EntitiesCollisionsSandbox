using Microsoft.Xna.Framework;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesCollisionsSandbox.Collisions
{
    internal class GravityProcessor
    {
        public Vector2 Gravity {  get; set; }
        private readonly List<Body> _bodies;
        public GravityProcessor(Vector2 gravity)
        {
            Gravity = gravity;
            _bodies = new List<Body>();
        }

        public void AddBody(Body body)
        {
            _bodies.Add(body);
        }

        public void RemoveBody(Body body)
        {
            _bodies.Remove(body);
        }

        public void Update(GameTime gameTime)
        {
            foreach (var body in _bodies)
            {
                body.Velocity += Gravity * gameTime.GetElapsedSeconds();

                body.Position.Y += body.Velocity.Y * gameTime.GetElapsedSeconds();
                body.Position.X += body.Velocity.X * gameTime.GetElapsedSeconds();
            }
        }
    }
}
