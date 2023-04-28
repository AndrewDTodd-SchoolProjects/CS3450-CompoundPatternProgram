using CompoundPattern;

namespace StatePattern
{
    internal class Program
    {
        static void Main()
        {
            CeilingFan fan = new(new OffState());
            OffState off = new();
            Controller fanController = new(fan, 
                new ToggleButton(new HighSpeedState(), off, 1), 
                new ToggleButton(new MediumSpeedState(), off, 2),
                new ToggleButton(new LowSpeedState(), off, 3),
                new CycleButton(4));

            Console.WriteLine("Enter 1 to press the fan controllers first button, 2 for its second, 3 for its third, or 4 for its fourth\n" +
                    "Press q or esc to exit\n" +
                    "Button One (1): toggle between high speed and off\n" +
                    "Button Two (2): toggle between medium speed and off\n" +
                    "Button Three (3): toggle between low speed and off\n" +
                    "Button Four (4): cycle through the fan's speeds from the current setting");

            do
            {
                ConsoleKey input = Console.ReadKey().Key;
                Console.WriteLine();

                switch(input)
                {
                    case ConsoleKey.NumPad1:
                        fanController.PressButton(1);
                        break;
                    case ConsoleKey.D1:
                        fanController.PressButton(1);
                        break;

                    case ConsoleKey.NumPad2:
                        fanController.PressButton(2);
                        break;
                    case ConsoleKey.D2:
                        fanController.PressButton(2);
                        break;

                    case ConsoleKey.NumPad3:
                        fanController.PressButton(3);
                        break;
                    case ConsoleKey.D3:
                        fanController.PressButton(3);
                        break;

                    case ConsoleKey.NumPad4:
                        fanController.PressButton(4);
                        break;
                    case ConsoleKey.D4:
                        fanController.PressButton(4);
                        break;

                    case ConsoleKey.Q:
                        return;
                    case ConsoleKey.Escape:
                        return;

                    default:
                        Console.WriteLine("Unsupported input. That isn't a button on the controller");
                        break;
                }
            } while (true);
        }
    }
}