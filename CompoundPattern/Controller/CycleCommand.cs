using StatePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    internal class CycleCommand : ICommand
    {
        private readonly CeilingFan _fan;
        private IFanState? _oldState = null;

        public CycleCommand(CeilingFan fan) => _fan = fan;

        public void Do()
        {
            _oldState = _fan.CurrentState;

            _fan.PullChain();
        }

        public void Undo()
        {
            if (_oldState != null)
            {
                _fan.ChangeState(_oldState);
                _fan.DisplayState();
            }
        }
    }
}
