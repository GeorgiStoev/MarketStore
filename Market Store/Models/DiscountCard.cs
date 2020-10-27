using Market_Store.Models.Contracts;

namespace Market_Store.Models
{
    public abstract class DiscountCard : IDiscountCard
    {
        public DiscountCard(decimal turnover)
        {
            this.Turnover = turnover;
        }

        public decimal Turnover { get; set; }
        public decimal DiscountRate { get; set; }

        public abstract void CalculateDiscount();
    }
}
