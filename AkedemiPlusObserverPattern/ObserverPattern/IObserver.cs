using AkedemiPlusObserverPattern.DAL;

namespace AkedemiPlusObserverPattern.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
