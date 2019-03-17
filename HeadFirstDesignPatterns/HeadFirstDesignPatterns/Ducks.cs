using System;


namespace Ducks
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public Duck()
        {
        }


        public abstract void display();

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
             quackBehavior.quack();
        }

        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void setQuackBehaviour(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }

    }

    public class MallardDuck:Duck
    {
            public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("I'm a Mallard Duck");
        }


    }

    public class ModelDuck: Duck
    {

        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }

        public override void display()
        {
            Console.WriteLine("I'm a model duckie.");
        }


    }

    public interface IFlyBehavior
    {
        void fly();
    }

    public class FlyRocketPowered:IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Rocket powered... vrooom!");
        }
    }

    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly...");
        }


    }

    public interface IQuackBehavior
    {
        void quack();
    }

    public class Squek:IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squek!");
        }
    }

    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack!");
        }
    }

    public class MuteQuack:IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }

}