namespace CourseDesignPattern.TemplateMethod
{
    public abstract class TemplateTaxConditional : ITax
    {
        public double Calculate(Budget budget)
        {
            if (MustUseMaxRate(budget))
            {
                return MaxRate(budget);
            }
            return MinRate(budget);
        }

        protected abstract bool MustUseMaxRate(Budget budget);
        protected abstract double MaxRate(Budget budget);
        protected abstract double MinRate(Budget budget);
    }
}
