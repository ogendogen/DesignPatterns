using System;
using Composite.Types;

namespace Composite
{
    public class VAN : IVehicle
    {
        public int ID { get; set; }
        public Status Status { get; set; }

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
