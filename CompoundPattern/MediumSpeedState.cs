namespace StatePattern
{
    internal class MediumSpeedState : IFanState
    {
        public string StateDescription => "Switching fan to Medium Speed";

        public void HandlePullChain(CeilingFan fan)
        {
            Console.WriteLine("Switching fan to High Speed");
            fan.ChangeState(new HighSpeedState());
        }
    }
}