using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Car : IVehicle
    {
        public int ID { get; set; }

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
