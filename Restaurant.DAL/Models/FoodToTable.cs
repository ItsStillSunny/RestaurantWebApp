using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL.Models
{
    public class FoodToTable
    {
        public int ID { get; set; }

        public int TableID { get; set; }
        public Table OrderTable { get; set; } = null!;

        public int FoodID { get; set; }
        public Food OrderFood { get; set; } = null!;
    }
}
