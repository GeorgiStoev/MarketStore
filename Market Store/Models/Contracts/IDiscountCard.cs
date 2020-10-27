namespace Market_Store.Models.Contracts
{
    public interface IDiscountCard
    {
        decimal Turnover { get; set; }

        decimal DiscountRate { get; set; }

        void CalculateDiscount();
}
}
