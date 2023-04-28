using StatePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CompoundPattern
{
    internal class ToggleCommand : ICommand
    {
        private readonly CeilingFan _fan;
        private IFanState? _oldState = null;
        private readonly IFanState _newState;

        public ToggleCommand(CeilingFan fan, IFanState newState) => (_fan, _newState) = (fan, newState);

        public void Do()
        {
            _oldState = _fan.CurrentState;
            _fan.ChangeState(_newState);
            _fan.DisplayState();
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
