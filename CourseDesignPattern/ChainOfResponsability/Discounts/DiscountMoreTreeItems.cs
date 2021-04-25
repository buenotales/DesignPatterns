namespace CourseDesignPattern.ChainOfResponsability.Discounts
{
    public class DiscountMoreTreeItems : IDiscount
    {
        private const int MINIMUMITEMS = 3;
        private const int MAXMUMITEMS = 10;

        public IDiscount Discount { get; set; }

        public double Calculate(Budget budget)
        {
            if (budget.Items.Count >= MINIMUMITEMS && budget.Items.Count < MAXMUMITEMS)
                return budget.Value - (budget.Value * 0.1);

            return Discount.Calculate(budget);
        }
    }
}
