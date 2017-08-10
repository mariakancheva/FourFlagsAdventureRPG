using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourFlagsRPG.Models.Models.Items
{
    using FourFlagsRPG.Models.Enums;

    public class HealthPotion:Item
    {
        public HealthPotion(int id, string name, string namePlural,HealthPotionSize healthPotionSize)
            : base(id, name, namePlural)
        {
            this.HealthPotionSize = healthPotionSize;
        }

        public int HealthRestore
        {
            get
            {
                return (int)this.HealthPotionSize;
            }
        }

        public HealthPotionSize HealthPotionSize { get; set; }
    }
}
