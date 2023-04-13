using Microsoft.Xna.Framework;
using MonoGame.Extended;
using MonoGame.Extended.Collisions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesCollisionsSandbox.Collisions
{
    internal abstract class Body : ICollisionActor
    {
        public IShapeF Bounds => new RectangleF(Position.X, Position.Y, 1, 1);
        public Vector2 Position;
        public Vector2 Velocity;

        public Body(Vector2 position) 
        {
            Position = position;
            Velocity = Vector2.Zero;
        }

        public abstract void OnCollision(CollisionEventArgs collisionData);
    }
}
