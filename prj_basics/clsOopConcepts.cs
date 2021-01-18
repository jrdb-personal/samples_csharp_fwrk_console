using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prj_basics_oop_concepts
{
    class SampleParentClass
    {
        public void showValue()
        {
            System.Console.WriteLine("Sample Value");
        }
    }

    class SampleChildClass : SampleParentClass
    {
        
    }

    interface IComputeSalary
    {
        decimal computeSalary();
    }

    interface ISetPromotion
    {
        string checkPromotion();
    }

    class Employee : IComputeSalary, ISetPromotion
    {
        public decimal computeSalary()
        {
            return 100;
        }

        public string checkPromotion()
        {
            return "for promotion";
        }
    }




}
