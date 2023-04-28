using StatePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    internal interface IButton
    {
        public int ButtonID { get; }

        public ICommand PushButton(CeilingFan fan);
    }
}
