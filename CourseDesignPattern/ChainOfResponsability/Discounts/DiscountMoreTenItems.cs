namespace CourseDesignPattern.ChainOfResponsability.Discounts
{
    public class DiscountMoreTenItems : IDiscount
    {
        public const int MINIMUMITEMS = 10;

        public IDiscount Discount { get; set; }

        public double Calculate(Budget budget)
        {
            if (budget.Items.Count > MINIMUMITEMS)
                return budget.Value - (budget.Value * 0.2);

            return Discount.Calculate(budget);
        }
    }
}
