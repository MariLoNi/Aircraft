﻿using System.Numerics;

namespace PlaneSim.PlaneSim
{
    public abstract class AComponent
    {
        public double Mass { get; set; }
        public string Name { get; set; }
        public Vector3 RelativePosition { get; set; }
    }
}