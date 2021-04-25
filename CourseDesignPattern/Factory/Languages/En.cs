using System;

namespace CourseDesignPattern.Factory.Languages
{
    public class En : IFactory
    {
        public void Speak()
        {
            Console.WriteLine("Spoke in english!");
        }
    }
}
