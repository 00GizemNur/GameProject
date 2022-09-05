using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer 
            { 
                Id = 1,
                BirthYear = 2000, 
                FirstName = "Gizem", 
                LastName = "Kahveci", 
                IdentityNumber = 12345 });
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign
            {
                Id = 1,
                CampaignName = "% 60 İNDİRİM",
                CampaignContent = "Football Manager 2022 Steam’de Yüzde 60 İndirime Girdi!"


            });
            ISalesService salesManager = new SalesManager();
            salesManager.AddToCart(
                
                new Game { GameName = "Football Manager 2022", GameCategory = "spor", GamePrice = 89.99 },
                new Campaign { CampaignName = "%60 indirim"},
                new Gamer
                {
                    Id = 1,
                    BirthYear = 2000,
                    FirstName = "Gizem",
                    LastName = "Kahveci",
                    IdentityNumber = 12345
                }) ;
            Console.ReadLine();

        }
    }
}
