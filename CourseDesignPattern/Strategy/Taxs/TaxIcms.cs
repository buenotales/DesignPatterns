namespace CourseDesignPattern
{
    public class TaxIcms : ITax
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.1;
        }
    }
}
