using Market_Store.Core.Factories.CardFactory.Contracts;
using Market_Store.IO;
using Market_Store.IO.Contracts;
using Market_Store.Models.Contracts;
using Market_Store.Utilities;
using System;
using System.Linq;
using System.Reflection;

namespace Market_Store.Core.Factories.CardFactory
{
    public class CardFactory : ICardFactory
    {
        private readonly IWriter writer;

        public CardFactory()
        {
            this.writer = new Writer();
        }

        public IDiscountCard CreateCard(string cardType, decimal turnover)
        {
            var type = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .Where(x => x.Name.StartsWith(cardType))
                .FirstOrDefault();

            var parameters = new object[] { turnover };
            return (IDiscountCard)Activator.CreateInstance(type, parameters);
        }

        public string GetCardType(string cardTypeFromMenu)
        {
            var cardType = string.Empty;

            if (cardTypeFromMenu == "1")
            {
                cardType = Constants.BronzeCardName;
            }
            else if (cardTypeFromMenu == "2")
            {
                cardType = Constants.SilverCardName;
            }
            else if (cardTypeFromMenu == "3")
            {
                cardType = Constants.GoldCardName;
            }
            else
            {
                this.writer.WriteLine(Constants.InvalidCardTypeMessage);
                Environment.Exit(0);
            }

            return cardType;
        }

        public decimal IsTurnoverValid(string turnoverAsString)
        {
            var turnover = 0M;
            try
            {
                turnover = decimal.Parse(turnoverAsString);
            }
            catch (Exception)
            {
                this.writer.WriteLine(Constants.InvalidTurnoverValueMessage);
                Environment.Exit(0);
            }

            return turnover;
        }

        public decimal IsPurchaseValid(string purchaseAsString)
        {
            var purchase = 0M;
            try
            {
                purchase = decimal.Parse(purchaseAsString);
            }
            catch (Exception)
            {
                this.writer.WriteLine(Constants.InvalidPurchaseValueMessage);
                Environment.Exit(0);
            }

            return purchase;
        }
    }
}
