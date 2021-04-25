using CourseDesignPattern.Observer;
using System.Collections.Generic;

namespace CourseDesignPattern
{
    public class Invoice
    {
        public IList<IObserver> Observers { get; private set; }

        public Invoice()
        {
            Observers = new List<IObserver>();
        }

        public void Subscribe(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Submit()
        {
            foreach (var o in Observers)
                o.Execute();
        }
    }
}
