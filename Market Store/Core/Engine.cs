using Market_Store.Core.Contracts;
using Market_Store.IO;
using Market_Store.IO.Contracts;
using Market_Store.Utilities;
using Market_Store.Core.Factories.CardFactory.Contracts;
using Market_Store.Core.Factories.CardFactory;
using Market_Store.Core.Controllers.Contracts;
using Market_Store.Core.Controllers;

namespace Market_Store.Core
{
    public class Engine : IEngine
    {
        private readonly ICardController cardController;
        private readonly ICardFactory cardFactory;

        private readonly IWriter writer;
        private readonly IReader reader;

        public Engine()
        {
            this.cardController = new CardController();
            this.cardFactory = new CardFactory();

            this.writer = new Writer();
            this.reader = new Reader();
        }

        public void Run()
        {
            while (true)
            {
                this.writer.WriteLine(Constants.CardMenu);

                var cardTypeFromMenu = this.reader.ReadLine();
                var cardType = this.cardFactory.GetCardType(cardTypeFromMenu);

                this.writer.WriteLine(Constants.TurnoverMessage);

                var turnoverAsString = this.reader.ReadLine();
                var turnover = this.cardFactory.IsTurnoverValid(turnoverAsString);

                var card = this.cardFactory.CreateCard(cardType, turnover);

                this.writer.WriteLine(Constants.PurchaseMessage);

                var purchaseAsString = this.reader.ReadLine();
                var purchase = this.cardFactory.IsPurchaseValid(purchaseAsString);

                var result = this.cardController.Calculate(card, purchase);

                this.writer.WriteLine(result);
            }
        }
    }
}
