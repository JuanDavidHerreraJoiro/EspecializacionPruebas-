namespace ObserverPattern.Observer
{
    internal class Email : IObserver
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Mensaje enviado por correo: {message}");
        }
    }
}
