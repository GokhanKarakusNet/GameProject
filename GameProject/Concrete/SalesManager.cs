using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Add(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("'{0}' oyunu '{1}' a '{2}' kampanyası ile {3} '$' karşılığında  satıldı", game.GameName, gamer.FirstName,campaign.CampaignName,game.GamePrice);
        }

        public void Delete(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Satış silindi");
        }

        public void Update(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Satış güncellendi");
        }

    }
}
