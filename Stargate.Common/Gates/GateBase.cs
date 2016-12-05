using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stargate.Common.PowerSupplies;

namespace Stargate.Common.Gates
{
    public class GateBase : IGate
    {
        public double Mass { get; private set; }



        public void OpenWormHole(IGate nextGate, IPowerSupply powerSupply)
        {
            throw new NotImplementedException();
        }
    }
}
