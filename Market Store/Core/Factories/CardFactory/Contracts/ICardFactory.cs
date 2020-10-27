using Market_Store.Models.Contracts;

namespace Market_Store.Core.Factories.CardFactory.Contracts
{
    public interface ICardFactory
    {
        IDiscountCard CreateCard(string cardTypeFromMenu, decimal turnover);

        public decimal IsTurnoverValid(string turnoverAsString);

        string GetCardType(string cardTypeFromMenu);

        decimal IsPurchaseValid(string purchaseAsString);
    }
}
