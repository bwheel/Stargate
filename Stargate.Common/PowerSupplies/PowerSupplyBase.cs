using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stargate.Common.PowerSupplies
{
    public abstract class PowerSupplyBase : IPowerSupply
    {
        public abstract double Max_Energy { get;}

        public abstract double Mass { get; }

        public double Energy { get; private set; }
        
        public PowerSupplyBase(double energy = 0.0)
        {
            Energy = energy;
        }

        public void Charge(double energy)
        {
            double sum = energy + Energy;

            if (sum > Max_Energy)
            {
                Energy = Max_Energy;
            }
            else
            {
                Energy = sum;
            }
        }

        public void Consume(double energy)
        {
            double difference = Energy - energy;

            if( difference < 0.0)
            {
                Energy = 0.0;
            }
            else
            {
                Energy = difference;
            }
        }
    }
}
