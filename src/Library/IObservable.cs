namespace Observer
{
    public interface IObservable
    {
        void Subscribe(IObserver x);
        void Unsubscribe(IObserver x);
        void Notify();
    }
}