using Market_Store.Core.Controllers.Contracts;
using Market_Store.Models.Contracts;
using System.Text;

namespace Market_Store.Core.Controllers
{
    public class CardController : ICardController
    {
        public string Calculate(IDiscountCard card, decimal purchase)
        {
            card.CalculateDiscount();

            var discount = purchase * card.DiscountRate;

            var total = purchase - discount;

            var result = new StringBuilder();
            result.AppendLine($"Purchase value: ${purchase:F2}");
            result.AppendLine($"Discount rate: {card.DiscountRate * 100:F1}%");
            result.AppendLine($"Discount: ${discount:F2}");
            result.AppendLine($"Total: ${total:F2}");

            return result.ToString().TrimEnd();
        }
    }
}
