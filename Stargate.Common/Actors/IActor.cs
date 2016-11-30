using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stargate.Common.Actors
{
    public interface IActor : IGameObject
    {
        double Health { get; }

        double Armour { get; }

        int Ammo { get; }


    }
}
