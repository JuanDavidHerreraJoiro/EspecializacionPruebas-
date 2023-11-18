namespace ObserverPattern.Observer
{
    public class Subject
    {
        public List<IObserver> Observers { get; set; } = new();

        public void Subscribe(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in Observers)
            {
                observer.SendMessage(message);
            }
        }
    }
}
