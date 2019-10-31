using System;
using System.Collections.Generic;

namespace Composite
{
    public class Fleet : IVehicle
    {
        private List<IVehicle> vehicles;

        public Fleet()
        {
            vehicles = new List<IVehicle>();
        }

        public void AddVehicle(IVehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public bool RemoveVehicle(IVehicle vehicle)
        {
            return vehicles.Remove(vehicle);
        }

        public void GoBackToFleet()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.GoBackToFleet();
            }
        }

        public void GoForClient()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.GoForClient();
            }
        }

        public void StandBy()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.StandBy();
            }
        }
    }
}
