using CourseDesignPattern.ChainOfResponsability.Discounts;
using CourseDesignPattern.State;
using CourseDesignPattern.State.States;
using System.Collections.Generic;

namespace CourseDesignPattern
{
    public class Budget
    {
        public ICurrentState CurrentState { get; set; }
        public double Value { get; set; }
        public IList<Item> Items { get; set; }

        public Budget(double valor)
        {
            Value = valor;
            Items = new List<Item>();
            CurrentState = new Pending();
        }

        public double CalculateTax(ITax imposto)
        {
            return imposto.Calculate(this);
        }

        public double CalculateDiscount()
        {
            IDiscount moreTree = new DiscountMoreTreeItems()
            {
                Discount = new DiscountMoreTenItems()
                {
                    Discount = new WithoutDiscount()
                }
            };

            return moreTree.Calculate(this);
        }

        public Budget Approve()
        {
            CurrentState.Approve(this);
            return this;
        }

        public Budget Reprove()
        {
            CurrentState.Reprove(this);
            return this;
        }

        public Budget Finallize()
        {
            CurrentState.Finalize(this);
            return this;
        }
    }

    public class Item
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Item(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
