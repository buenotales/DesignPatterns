namespace CourseDesignPattern.ChainOfResponsability.Discounts
{
    public class WithoutDiscount : IDiscount
    {
        public IDiscount Discount { get; set; }

        public double Calculate(Budget budget)
        {
            return 0;
        }
    }
}
