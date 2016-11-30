using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stargate.Common.Address
{
    public abstract class GateAddressBase : IGateAddress
    {
        public abstract int Address_Size { get; }
        public List<GateSymbol> Address { get; private set; }

        public GateAddressBase()
        {
            Address = new List<GateSymbol>();
        }

        public void AddSymbol(GateSymbol symbol)
        {
            if(Address.Count() + 1 <= Address_Size)
            {
                Address.Add(symbol);
            }
            else
            {
                // Do nothing. 
            }
        }

        public void ClearAddress()
        {
            if (Address.Count() > 0)
            {
                Address.Clear();
            }
        }

        public void RemoveSymbol(GateSymbol symbol)
        {
            if (Address.Contains(symbol))
            {
                Address.Remove(symbol);
            }
            else
            {
                // do nothing. 
            }
        }
    }
}
