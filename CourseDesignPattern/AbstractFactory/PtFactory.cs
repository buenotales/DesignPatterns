using CourseDesignPattern.Factory;
using CourseDesignPattern.Factory.Languages;

namespace CourseDesignPattern.AbstractFactory
{
    public class PtFactory : IAbstractFactory
    {
        public IFactory Instance()
        {
            return new Pt();
        }
    }
}
