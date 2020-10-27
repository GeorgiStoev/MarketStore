using Market_Store.Utilities;
using System;

namespace Market_Store.Models.Cards
{
    public class GoldCard : DiscountCard
    {
        public GoldCard(decimal turnover) : base(turnover)
        {
            this.DiscountRate = Constants.GoldCardInitDiscount;
        }

        public override void CalculateDiscount()
        {
            var discountGrow = (int)Math.Floor(this.Turnover / 100);

            this.DiscountRate += discountGrow;

            if (this.DiscountRate > 10)
            {
                this.DiscountRate = 0.1M;
            }
        }
    }
}
