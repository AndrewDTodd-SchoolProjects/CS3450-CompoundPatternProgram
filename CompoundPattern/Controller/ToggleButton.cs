using StatePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    internal class ToggleButton : IButton
    {
        private readonly IFanState _onState;
        private readonly IFanState _offState;
        private bool _active = false;
        private readonly int _ID;

        public ToggleButton(IFanState onState, IFanState offState, int id) => (_onState, _offState, _ID) = (onState, offState, id);

        public int ButtonID => _ID;

        public ICommand PushButton(CeilingFan fan)
        {
            if (_active)
            {
                _active = false;
                return new ToggleCommand(fan, _offState);
            }
            else
            {
                _active = true;
                return new ToggleCommand(fan, _onState);
            }
        }
    }
}
