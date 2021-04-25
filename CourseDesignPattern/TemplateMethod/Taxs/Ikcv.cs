namespace CourseDesignPattern.TemplateMethod.Taxs
{
    public class Ikcv : TemplateTaxConditional
    {
        protected override bool MustUseMaxRate(Budget budget)
        {
            return budget.Value >= 500;
        }

        protected override double MaxRate(Budget budget)
        {
            return budget.Value * 0.7;
        }

        protected override double MinRate(Budget budget)
        {
            return budget.Value * 0.1;
        }
    }
}
