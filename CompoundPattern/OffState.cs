namespace StatePattern
{
    internal class OffState : IFanState
    {
        public string StateDescription => "Switching fan Off";

        public void HandlePullChain(CeilingFan fan)
        {
            Console.WriteLine("Switching fan to Low Speed");
            fan.ChangeState(new LowSpeedState());
        }
    }
}