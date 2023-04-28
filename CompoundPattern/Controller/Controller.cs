using StatePattern;

namespace CompoundPattern
{
    internal class Controller
    {

        private readonly CeilingFan _fan;

        private readonly List<IButton> _buttons = new();

        public Controller(CeilingFan fan, params IButton[] buttons)
        {
            _fan = fan;

            _buttons.AddRange(buttons);
        }

        public void PressButton(int buttonID)
        {
            foreach (var button in _buttons)
            {
                if(button.ButtonID == buttonID)
                {
                    _fan.ControllerInvoker.InvokeCommand(button.PushButton(_fan));

                    return;
                }
            }

            throw new ArgumentException($"No button with ID: {buttonID}");
        }
    }
}