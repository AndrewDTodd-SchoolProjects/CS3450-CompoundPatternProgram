using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal interface IFanState
    {
        public void HandlePullChain(CeilingFan fan);

        public string StateDescription { get; }
    }
}
