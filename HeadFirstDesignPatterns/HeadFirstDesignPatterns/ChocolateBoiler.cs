using System;

namespace ChocolateFactory
{

    public class ChocolateBoiler
    {
        private Boolean empty;
        private Boolean boiled;

        public static ChocolateBoiler uniqueBoiler;

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler getInstance()
        {
            if (uniqueBoiler == null)
            {
                uniqueBoiler = new ChocolateBoiler();
            }
            return uniqueBoiler;

        }

        public void fill()
        {
            if (isEmpty())
            {
                empty = false;
                boiled = false;
            }
        }

        public void drain()
        {
            if (!isEmpty() && isBoiled())
            {
                empty = true;
            }
        }

        public void boil()
        {
            if (!isEmpty() && !isBoiled())
            {
                boiled = true;
            }
        }

        public Boolean isEmpty() { return empty; }
        public Boolean isBoiled() { return boiled; }

    }

}