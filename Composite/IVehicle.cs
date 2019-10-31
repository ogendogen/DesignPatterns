using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public interface IVehicle
    {
        void GoForClient();
        void GoBackToFleet();
        void StandBy();
    }
}
