namespace CourseDesignPattern
{
    /// <summary>
    /// Classe deteste
    /// </summary>
    public class TaxIss : ITax
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.06;
        }
    }
}
