using Stargate.Common.Address;
using Stargate.Common.Gates;
using Stargate.Common.PowerSupplies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stargate.Common.Dhds
{
    public interface IDhd : IGameObject
    {
        IGate Gate { get; }
        IPowerSupply PowerSupply { get; }

        IGateAddress Address { get; }
        void EnterSymbol(GateSymbol symbol);

        IGate Activate();

        void AttachGate(IGate gate);

        void AttachPowerSupply(IPowerSupply powerSupply);
    }
}
