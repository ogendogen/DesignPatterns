using System;
using Composite.Types;

namespace Composite
{
    public class Car : Vehicle, IVehicle
    {
        public void GoBackToFleet()
        {
            Status = Status.InFleet;
        }

        public void GoForClient()
        {
            Status = Status.Working;
        }

        public void StandBy()
        {
            Status = Status.StandBy;
        }
    }
}
