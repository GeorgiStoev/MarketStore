using Market_Store.Utilities;

namespace Market_Store.Models.Cards
{
    public class SilverCard : DiscountCard
    {
        public SilverCard(decimal turnover) : base(turnover)
        {
            this.DiscountRate = Constants.SilverCardInitDiscount;
        }

        public override void CalculateDiscount()
        {
            if (this.Turnover > 300)
            {
                this.DiscountRate = 0.035M;
            }
        }
    }
}
