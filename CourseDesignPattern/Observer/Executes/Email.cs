using System;
using System.Threading;

namespace CourseDesignPattern.Observer.Executes
{
    public class Email : IObserver
    {
        public void Execute()
        {
            Thread.Sleep(500);
            Console.WriteLine("Email enviado!");
        }
    }
}
