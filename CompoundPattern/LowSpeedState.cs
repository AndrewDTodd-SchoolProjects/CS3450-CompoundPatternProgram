using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class LowSpeedState : IFanState
    {
        public string StateDescription => "Switching fan to Low Speed";

        public void HandlePullChain(CeilingFan fan)
        {
            Console.WriteLine("Switching fan to Medium Speed");
            fan.ChangeState(new MediumSpeedState());
        }
    }
}
