using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stargate.Common.PowerSupplies;

namespace Stargate.Common.Gates
{
    public interface IGate : IGameObject
    {
        List<IGameObject> Buffer { get; }

        void OpenWormHole(IGate nextGate, IPowerSupply powerSupply);

        void Dematerialize(IGameObject material);

        IGameObject Materialize();
    }
}
