namespace LemonadeStand
{
    public class CupOfSugar : Item
    {

        public CupOfSugar()
        {
            name = "cup of sugar";
            cost = 0.07;
        }
        public override void CalculateCost(double amount)
        {
            throw new System.NotImplementedException();
        }
    }
}