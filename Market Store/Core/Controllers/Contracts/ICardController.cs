using Market_Store.Models.Contracts;

namespace Market_Store.Core.Controllers.Contracts
{
    public interface ICardController
    {
        string Calculate(IDiscountCard card, decimal purchase);
    }
}
