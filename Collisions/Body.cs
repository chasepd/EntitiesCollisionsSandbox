using Microsoft.Xna.Framework;

namespace EntitiesCollisionsSandbox.Collisions
{
    public enum BodyType
    {
        Static, Dynamic
    }

    public class Body
    {
        public BodyType BodyType = BodyType.Static;
        public Vector2 Position;
        public Vector2 Velocity;
        public AxisAlignedBoundingBox BoundingBox => new AxisAlignedBoundingBox(Position - Size / 2f, Position + Size / 2f);
        public Vector2 Size;
    }
}
