namespace LemonadeStand
{
    public class IceCube : Item
    {

        public IceCube()
        {
            name = "pack of ice cubes";
            cost = 0.01;
        }

        public override void CalculateCost(double amount)
        {
            throw new System.NotImplementedException();
        }
    }
}