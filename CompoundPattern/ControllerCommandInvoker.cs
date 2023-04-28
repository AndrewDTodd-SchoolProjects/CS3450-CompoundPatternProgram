using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    internal class ControllerCommandInvoker
    {
        private readonly List<ICommand> _commands = new();

        public void InvokeCommand(ICommand command)
        {
            command.Do();
            _commands.Add(command);
        }

        public void UndoLastCommand()
        {
            if (_commands.Count > 0)
            {
                _commands.Last().Undo();
                _commands.RemoveAt(_commands.Count - 1);
            }
        }

        public void UndoCommands()
        {
            while (_commands.Count > 0)
            {
                _commands.Last().Undo();
                _commands.RemoveAt(_commands.Count - 1);
            }
        }
    }
}
