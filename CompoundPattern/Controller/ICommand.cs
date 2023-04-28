using StatePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    internal interface ICommand
    {
        public void Do();
        public void Undo();
    }
}
