namespace Chef.Contracts
{
    public interface IChef
    {
        void Cook();

        void Cook(IVegetable vegetable);
    }
}