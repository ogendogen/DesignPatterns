using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    interface IVehicle
    {
        void GoForClient();
        void GoBackToFleet();
        void StandBy();
    }
}
