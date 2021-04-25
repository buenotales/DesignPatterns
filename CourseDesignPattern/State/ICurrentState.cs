namespace CourseDesignPattern.State
{
    public interface ICurrentState
    {
        void Reprove(Budget budget);
        void Approve(Budget budget);
        void Finalize(Budget budget);
    }
}
