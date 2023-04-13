using Microsoft.Xna.Framework;
using MonoGame.Extended.Collisions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesCollisionsSandbox.Collisions
{
    internal class WaterBody : Body
    {
        public WaterBody(Vector2 position) : base(position) { }

        public override void OnCollision(CollisionEventArgs collisionData)
        {
            
        }
    }
}
