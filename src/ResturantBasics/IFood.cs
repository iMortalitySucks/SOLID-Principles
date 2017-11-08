namespace ResturantBasics
{
    public enum FoodState
    {
        Raw,
        Cooked,
        Plated
    }

    public interface IFood
    {
        FoodState FoodState { get; set; }
    }
}
