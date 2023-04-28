namespace StatePattern
{
    internal class HighSpeedState : IFanState
    {
        public string StateDescription => "Switching fan to High Speed";

        public void HandlePullChain(CeilingFan fan)
        {
            Console.WriteLine("Switching fan OFF");
            fan.ChangeState(new OffState());
        }
    }
}