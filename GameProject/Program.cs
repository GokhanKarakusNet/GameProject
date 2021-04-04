using System;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            {
                IdentityNumber = 11111111111,
                FirstName = "Gökhan",
                LastName = "Karakuş",
                BirthYear = 1111
            };
            Game game = new Game
            {
                GameName = "Snake",
                GamePrice = 99
            };
            Campaign campaign = new Campaign
            {
                CampaignName = "3 al 1 öde",
                CapmpaignDiscount = 0.70
            };
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer);
            SalesManager salesManager = new SalesManager();
            salesManager.Add(gamer,game,campaign);

        }
    }
}
