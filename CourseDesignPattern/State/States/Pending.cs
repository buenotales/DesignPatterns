using System;

namespace CourseDesignPattern.State.States
{
    public class Pending : ICurrentState
    {
        public void Approve(Budget budget)
        {
            Console.WriteLine("Orçamento aprovado!");
            budget.CurrentState = new Approved();
        }

        public void Finalize(Budget budget)
        {
            Console.WriteLine("Orçamento finalizado!");
            budget.CurrentState = new Finalized();
        }

        public void Reprove(Budget budget)
        {
            Console.WriteLine("Orçamento reprovado!");
            budget.CurrentState = new Reproved();
        }
    }
}
