namespace CourseDesignPattern
{
    public interface IDiscount
    {
        double Calculate(Budget budget);
        IDiscount Discount { get; set; }
    }
}
