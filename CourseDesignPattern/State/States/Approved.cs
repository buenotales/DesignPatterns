using System;

namespace CourseDesignPattern.State.States
{
    public class Approved : ICurrentState
    {
        public void Approve(Budget budget)
        {
            Console.WriteLine("Orçamento já aprovado!");
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
