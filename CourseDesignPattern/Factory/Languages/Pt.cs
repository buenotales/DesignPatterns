using System;

namespace CourseDesignPattern.Factory.Languages
{
    public class Pt : IFactory
    {
        public void Speak()
        {
            Console.WriteLine("Falou em português!");
        }
    }
}
