using System;

namespace SmartilleryUnityWrapper
{
    public class Player
    {
		public int Id {get;set;}
		public string Name { get; set; }
		public Location CurrentLocation {get;set;}
		public Location Destination {get;set;}
		public double Velocity {get;set;}

		public override string ToString()
		{
			return string.Format("[Player: Id={0}, Name={1}, CurrentLocation={2}, Destination={3}, Velocity={4}]", Id, Name, CurrentLocation, Destination, Velocity);
		}
    }
}

