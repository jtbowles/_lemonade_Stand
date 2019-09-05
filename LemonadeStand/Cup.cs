namespace LemonadeStand
{
    public class Cup : Item
    {
        public Cup()
        {
            name = "cup";
            cost = 0.04;
        }
        public override void CalculateCost(double amount)
        {
            throw new System.NotImplementedException();
        }
    }
}