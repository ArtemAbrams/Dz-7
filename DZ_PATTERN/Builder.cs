using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_7
{
    class Pizza
    {
        string dough;
        string sauce;
        string topping;
        public Pizza() { }
        public void SetDough(string d) { dough = d; }
        public void SetSauce(string s) { sauce = s; }
        public void SetTopping(string t) { topping = t; }
        public void Info()
        {
            Console.WriteLine("Dough: {0}\nSause: {1}\nTopping: {2}\n", dough, sauce, topping);
        }
    }
    //Abstract Builder
    abstract class PizzaBuilder
    {
        protected Pizza pizza;
        public PizzaBuilder() { }
        public Pizza GetPizza() { return pizza; }
        public void CreateNewPizza() { pizza = new Pizza(); }
        public abstract void BuildDough();
        public abstract void BuildSauce();
        public abstract void BuildTopping();
    }
    //Concrete Builder
    class HawaiianPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough() { pizza.SetDough("cross"); }
        public override void BuildSauce() { pizza.SetSauce("mild"); }
        public override void BuildTopping()
        {
            pizza.SetTopping("ham+pineapple");
        }
    }
    //Concrete Builder
    class SpicyPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.SetDough("panbaked");
        }
        public override void BuildSauce() { pizza.SetSauce("hot"); }
        public override void BuildTopping()
        {
            pizza.SetTopping("pepparoni+salami");
        }
    }
    class MargaritaPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.SetDough("cross");
        }
        public override void BuildSauce()
        {
            pizza.SetSauce("mild blood of russian children");
        }
        public override void BuildTopping()
        {
            pizza.SetTopping("russian children + bio weapons + margarita");
        }
    }
    /** "Director" */
    class Waiter
    {
        private PizzaBuilder pizzaBuilder;
        public void SetPizzaBuilder(PizzaBuilder pb)
        {
            pizzaBuilder = pb;
        }
        public Pizza GetPizza() { return pizzaBuilder.GetPizza(); }
        public void ConstructPizza()
        {
            pizzaBuilder.CreateNewPizza();
            pizzaBuilder.BuildDough();
            pizzaBuilder.BuildSauce();
            pizzaBuilder.BuildTopping();
        }
    }
}
