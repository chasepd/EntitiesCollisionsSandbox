using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesCollisionsSandbox
{
    internal static class GameState
    {
        public static double FireTemperature { get; set; }
        public const double WaterTemperature = 20;
        public const double SandTemperature = 20;
        public const int ParticleSize = 10;
    }
}
