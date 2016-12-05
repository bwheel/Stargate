using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stargate.Common.Gates;
using Stargate.Common.PowerSupplies;
using Stargate.Common.Address;

namespace Stargate.Common.Dhds
{
    public abstract class DhdBase : IDhd
    {
        public IGateAddress Address { get; private set; }

        public IGate Gate { get; private set; }

        public IPowerSupply PowerSupply { get; private set; }

        public double Mass { get; set; }

        public IGate Activate()
        {
            IDictionary<IGateAddress, IGate> gateSystem = new Dictionary<IGateAddress, IGate>();
            var nextGate = gateSystem[Address];
            Gate.OpenWormHole(nextGate, PowerSupply);
            return Gate;
        }

        public void AttachGate(IGate gate)
        {
            Gate = gate;
        }

        public void AttachPowerSupply(IPowerSupply supply)
        {
            PowerSupply = supply;
        }

        public void EnterSymbol(GateSymbol symbol)
        {
            Address.AddSymbol(symbol);
        }
    }
}
