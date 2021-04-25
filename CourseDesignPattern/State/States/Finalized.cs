using System;

namespace CourseDesignPattern.State.States
{
    public class Finalized : ICurrentState
    {
        public void Approve(Budget budget)
        {
            Console.WriteLine("Orçamento aprovado!");
            budget.CurrentState = new Approved();
        }

        public void Finalize(Budget budget)
        {
            Console.WriteLine("Orçamento já finalizado!");
        }

        public void Reprove(Budget budget)
        {
            Console.WriteLine("Orçamento reprovado!");
            budget.CurrentState = new Reproved();
        }
    }
}
