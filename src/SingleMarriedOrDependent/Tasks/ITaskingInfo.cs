using ResturantBasics;

namespace SingleMarriedOrDependent
{
    public interface ITaskingInfo
    {
        IOrderInfo OrderInfo { get; }

        IWorker Worker { get; }
    }
}
