using CourseDesignPattern.Factory;
using CourseDesignPattern.Factory.Languages;

namespace CourseDesignPattern.AbstractFactory
{
    public class EnFactory : IAbstractFactory
    {
        public IFactory Instance()
        {
            return new En();
        }
    }
}
