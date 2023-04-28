using StatePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    internal class CycleButton : IButton
    {
        private readonly int _buttonID;

        public int ButtonID => _buttonID;

        public CycleButton(int buttonID)
        {
            _buttonID = buttonID;
        }

        public ICommand PushButton(CeilingFan fan)
        {
            return new CycleCommand(fan);
        }
    }
}
