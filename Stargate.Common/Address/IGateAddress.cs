using Stargate.Common.Dhds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stargate.Common.Address
{
    public interface IGateAddress
    {
        List<GateSymbol> Address { get; }

        void AddSymbol(GateSymbol symbol);

        void RemoveSymbol(GateSymbol symbol);

        void ClearAddress();
    }
}
