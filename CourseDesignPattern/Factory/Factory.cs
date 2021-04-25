using CourseDesignPattern.Factory.Languages;
using System;

namespace CourseDesignPattern.Factory
{
    public static class Factory
    {
        public static IFactory Create(LanguageType type)
        {
            if (type == LanguageType.PT) return new Pt();
            if (type == LanguageType.EN) return new En();

            throw new NotSupportedException("Tipo da classe não existe.");
        }
    }
}
