using System;

namespace SmartilleryUnityWrapper
{
    public class Launch
    {
		public int Id {get; set;}
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

		public override string ToString()
		{
			return string.Format("[Launch: Id={0}, ActualLanding={1}, TimeFired={2}, CurrentTime={3}, TimeLand={4}, Angle={5}, Velocity={6}, Bearing={7}, FiringLocation={8}, FiringBearing={9}, FiringVelocity={10}]", Id, ActualLanding, TimeFired, CurrentTime, TimeLand, Angle, Velocity, Bearing, FiringLocation, FiringBearing, FiringVelocity);
		}
    }
}

