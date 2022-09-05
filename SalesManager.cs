using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject

   

{
   class SalesManager : ISalesService
    {

        public void AddToCart(Game game, Campaign campaign, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " " + game.GamePrice + " " + campaign.CampaignName +" ile " + gamer.FirstName + " " + gamer.LastName + "'ye " + "Satıldı");
        }
    }
}
