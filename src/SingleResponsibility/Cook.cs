using ResturantBasics;

namespace SingleResponsibility
{
    internal class Cook: Worker
    {
        public Cook()
        {
        }

        internal void PrepareFood(string order)
        {
            CheckTask("prepare food");
        }

        internal void CookOrder(string order)
        {
            CheckTask("cook order");
        }

        internal Food PlateFood(string order)
        {
            CheckTask("plate food");

            return new Food();
        }
    }
}