using CourseDesignPattern.AbstractFactory;
using CourseDesignPattern.Factory;
using CourseDesignPattern.Observer.Executes;
using CourseDesignPattern.TemplateMethod;
using CourseDesignPattern.TemplateMethod.Taxs;
using System;

namespace CourseDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strategy - decrease ifs

            Console.WriteLine("Strategy");

            ITax iss = new TaxIss();
            ITax icms = new TaxIcms();

            Budget budget = new Budget(500.0);

            Console.WriteLine(budget.CalculateTax(icms));
            Console.WriteLine(budget.CalculateTax(iss));

            #endregion

            #region ChainOfResponsability - execute multiples verifications

            Console.WriteLine("ChainOfResponsability");

            budget.Items.Add(new Item("Item 1", 10));
            budget.Items.Add(new Item("Item 2", 20));
            budget.Items.Add(new Item("Item 3", 30));
            budget.Items.Add(new Item("Item 4", 40));

            Console.WriteLine(budget.CalculateDiscount());

            budget.Items.Add(new Item("Item 5", 50));
            budget.Items.Add(new Item("Item 6", 60));
            budget.Items.Add(new Item("Item 7", 70));
            budget.Items.Add(new Item("Item 8", 80));
            budget.Items.Add(new Item("Item 9", 90));
            budget.Items.Add(new Item("Item 10", 100));
            budget.Items.Add(new Item("Item 11", 110));

            Console.WriteLine(budget.CalculateDiscount());

            #endregion

            #region Template Method - decrease code repeted

            Console.WriteLine("Template Method");

            TemplateTaxConditional icpp = new Icpp();
            Console.WriteLine(icpp.Calculate(budget));

            TemplateTaxConditional ikcv = new Ikcv();
            Console.WriteLine(ikcv.Calculate(budget));

            #endregion

            #region State - manage state of the object

            budget
                .Approve()
                .Approve()
                .Approve()
                .Reprove()
                .Approve()
                .Finallize();

            #endregion

            #region Observer

            Invoice invoice = new Invoice();
            invoice.Subscribe(new Email());
            invoice.Subscribe(new Print());

            // do which need do

            invoice.Submit();

            #endregion

            #region Factory - instance a class dynamic

            IFactory factoryPT = Factory.Factory.Create(LanguageType.PT);
            factoryPT.Speak();

            IFactory factoryEN = Factory.Factory.Create(LanguageType.EN);
            factoryEN.Speak();

            #endregion

            #region AbstractFactory

            AbstractFactory.AbstractFactory abstractFactory = new AbstractFactory.AbstractFactory();

            abstractFactory.Speak(LanguageType.PT);
            abstractFactory.Speak(LanguageType.EN);

            #endregion

            Console.ReadKey();
        }
    }
}
