using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Entities
{
    public class Sales : IEntity
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
