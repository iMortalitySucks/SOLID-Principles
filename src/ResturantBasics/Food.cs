namespace ResturantBasics
{
    public class Food : IFood
    {
        public FoodState FoodState { get; set; } = FoodState.Raw;
    }
}