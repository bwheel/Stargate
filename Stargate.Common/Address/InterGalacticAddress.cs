using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stargate.Common.Address
{
    public class InterGalacticAddress : GateAddressBase
    {
        private const int ADDRESS_SIZE = 8;
        public override int Address_Size
        {
            get
            {
                return ADDRESS_SIZE;
            }
        }
    }
}
