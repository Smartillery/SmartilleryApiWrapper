using System;

namespace SmartilleryUnityWrapper
{
    public class Launch
    {
		public Location ActualLanding {get;set;}
		public DateTime TimeFired {get;set;}
		public DateTime CurrentTime { get; set; }
		public DateTime TimeLand {get;set;}
		public double Angle {get;set;}
		public double Velocity {get;set;}
		public double Bearing {get;set;}
		public Location FiringLocation {get;set;}
		public double FiringBearing { get; set; }
		public double FiringVelocity {get;set;}
    }
}

