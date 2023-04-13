using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesCollisionsSandbox.Collisions
{
    public struct AxisAlignedBoundingBox
    {
            public AxisAlignedBoundingBox(Vector2 min, Vector2 max)
            {
                Min = min;
                Max = max;
            }

            public Vector2 Min;
            public Vector2 Max;
            public Vector2 Center => new Vector2(CenterX, CenterY);
            public float CenterX => (Max.X - Min.X) / 2f;
            public float CenterY => (Max.Y - Min.Y) / 2f;
            public float Width => Max.X - Min.X;
            public float Height => Max.Y - Min.Y;
        
    }
}
