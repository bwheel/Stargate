using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stargate.Common.PowerSupplies
{
    public interface IPowerSupply : IGameObject
    {
        double Energy { get; }

        void Charge(double energy);

        void Consume(double energy);


    }
}
