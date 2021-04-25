using CourseDesignPattern.Factory;
using System.Collections.Generic;

namespace CourseDesignPattern.AbstractFactory
{
    public class AbstractFactory
    {
        private readonly IDictionary<LanguageType, IAbstractFactory> languages;

        public AbstractFactory()
        {
            languages = new Dictionary<LanguageType, IAbstractFactory>();
            languages.Add(LanguageType.PT, new PtFactory());
            languages.Add(LanguageType.EN, new EnFactory());
        }

        public IFactory Speak(LanguageType type)
        {
            IFactory factory = languages[type].Instance();
            factory.Speak();
            return factory;
        }
    }
}
