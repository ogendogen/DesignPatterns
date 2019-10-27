using System;
using Composite.Types;

namespace Composite
{
    public class Car : Vehicle, IVehicle
    {
        public void GoBackToFleet()
        {
            throw new NotImplementedException();
        }

        public void GoForClient()
        {
            throw new NotImplementedException();
        }

        public void StandBy()
        {
            throw new NotImplementedException();
        }
    }
}
