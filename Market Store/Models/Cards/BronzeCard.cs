namespace Market_Store.Models.Cards
{
    public class BronzeCard : DiscountCard
    {
        public BronzeCard(decimal turnover) : base(turnover)
        {
        }

        public override void CalculateDiscount()
        {
            if (this.Turnover >= 100 && this.Turnover <= 300)
            {
                this.DiscountRate = 0.01M;
            }
            else if (this.Turnover > 300)
            {
                this.DiscountRate = 0.025M;
            }
        }
    }
}
