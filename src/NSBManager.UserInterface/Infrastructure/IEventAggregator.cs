namespace NSBManager.UserInterface.Infrastructure
{
    public interface IEventAggregator
    {
        void Publish<T>(T message);
        void AddListener(object listener);
    }
}