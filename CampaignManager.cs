using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager:ICampaignService
    {
        List<Campaign> campaigns = new List<Campaign>();
        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine(campaign.CampaignName + " " + "Koduyla Kampanya Eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
