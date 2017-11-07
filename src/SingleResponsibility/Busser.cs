using ResturantBasics;

namespace SingleResponsibility
{
    internal class Busser: Worker
    {
        public Busser()
        {
        }

        internal void BusTable(int tableNumber)
        {
            CheckTask("bus table");
        }
    }
}