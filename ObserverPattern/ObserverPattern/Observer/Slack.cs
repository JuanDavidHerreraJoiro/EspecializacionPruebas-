namespace ObserverPattern.Observer
{
    public class Slack : IObserver
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Mensaje enviado por Slack: {message}");
        }
    }
}
