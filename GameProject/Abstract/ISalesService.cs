using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
   public interface ISalesService
    {
        public void Add(Gamer gamer,Game game,Campaign campaign);
        public void Delete(Gamer gamer,Game game, Campaign campaign);
        public void Update(Gamer gamer,Game game, Campaign campaign);
    }
}
