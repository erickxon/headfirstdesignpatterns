using System;
using ChocolateFactory;
using Ducks;

namespace HeadFirstDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //***** DUCKS
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
            mallard.display();
            mallard.setQuackBehaviour(new Squek());
            mallard.performQuack();

            Duck model = new ModelDuck();
            model.performQuack();
            model.display();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();

            Console.ReadKey();

            //***** CHOCOLATE FACTORY 
            /*
            ChocolateBoiler CB = ChocolateBoiler.getInstance();
            CB.fill();
            CB.boil();

            Console.WriteLine("Hello World! Is the chocolate factory boiled? "+ CB.isBoiled());
            Console.ReadKey();
            */



        }
    }
}
