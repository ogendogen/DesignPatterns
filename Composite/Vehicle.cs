using Composite.Types;
using System;

namespace Composite
{
    public abstract class Vehicle
    {
        public int ID { get; set; }
        public double MaxV { get; set; }
        public int NumberOfPassengers { get; set; }
        public double MaxLoad { get; set; }
        private Status _status;
        public Status Status 
        { 
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                OnStatusChanged(null);
            }
        }

        public event EventHandler StatusChanged;
        protected virtual void OnStatusChanged(EventArgs e)
        {
            StatusChanged?.Invoke(this, e);
        }
    }
}
