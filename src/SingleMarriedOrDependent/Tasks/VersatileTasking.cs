using ResturantBasics;

namespace SingleMarriedOrDependent.Tasks
{
    public abstract class VersatileTasking : Tasking, ITasking
    {
        protected readonly ICustomer _customer;
        protected readonly IOrderInfoProvider _orderInfoProvider;

        public VersatileTasking(string name,
            ICustomer customer,
            IOrderInfoProvider orderInfoProvider) : base(name)
        {
            _customer = customer;
            _orderInfoProvider = orderInfoProvider;
        }

        public override bool DoTask()
        {
            if (_customer.CurrentMood != Mood.Unhappy)
            {
                DoTaskInternal();
                return base.DoTask();
            }
            else
            {
                return false;
            }
        }

        protected abstract void DoTaskInternal();
    }
}
