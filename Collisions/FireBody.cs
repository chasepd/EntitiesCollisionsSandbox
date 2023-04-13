using Microsoft.Xna.Framework;
using MonoGame.Extended.Collisions;

namespace EntitiesCollisionsSandbox.Collisions
{
    internal class FireBody : Body
    {
        public FireBody(Vector2 position) : base(position) { }

        public override void OnCollision(CollisionEventArgs collisionData)
        {
        }
    }
}
