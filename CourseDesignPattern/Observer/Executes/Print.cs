using System;
using System.Threading;

namespace CourseDesignPattern.Observer.Executes
{
    public class Print : IObserver
    {
        public void Execute()
        {
            Thread.Sleep(500);
            Console.WriteLine("Impressoção concluida!");
        }
    }
}
