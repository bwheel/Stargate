using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stargate.Common.PowerSupplies
{
    public class PowerCrystal : PowerSupplyBase
    {
        private const double MAX_ENERGY = 10000;
        private const double MASS = 5000;
        public override double Mass
        {
            get
            {
                return MASS;
            }
        }

        public override double Max_Energy
        {
            get
            {
                return MAX_ENERGY;
            }
        }
    }
}
