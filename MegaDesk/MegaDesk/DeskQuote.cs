using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class DeskQuote
    {
        public string customerName { get; set; }
        public Desk deskOrder { get; set; }
        public Time productionTime { get; set; }
        public DateTime date { get; set; }
        public double quote { get; set; }

        int BASE_PRICE = 200;
        int EACH_DRAWER = 50;


        public void Calculate()
        {
            double area = deskOrder.width * deskOrder.depth;
            int drawerCost = deskOrder.drawers * EACH_DRAWER;
            int materialCost = GetMaterialCost(deskOrder.surfaceMaterial);
            int rushFee = GetRushFee(productionTime, area);

            if (area <= 1000) 
            {
                area = 0; 
            }

            quote = BASE_PRICE + drawerCost+ area + materialCost+ rushFee;

        }

        public static int GetRushFee(Time productionTime, double area)
        {
            switch(productionTime) 
            {
                case Time.TwoWeeks:
                    return 0;
                case Time.ThreeDays:
                    if (area < 1000)
                    {
                        return 60;
                    }
                    else if(area < 2000)
                    {
                        return 70;
                    }
                    else
                    {
                        return 80;
                    }
                case Time.FiveDays:
                    if (area < 1000)
                    {
                        return 40;
                    }
                    else if (area < 2000)
                    {
                        return 50;
                    }
                    else
                    {
                        return 60;
                    }
                case Time.OneWeek:
                    if (area < 1000)
                    {
                        return 30;
                    }
                    else if (area < 2000)
                    {
                        return 35;
                    }
                    else
                    {
                        return 40;
                    }
                default: return 999;
            }
        }

        public static int GetMaterialCost(DesktopMaterial material)
        {
            switch (material)
            {
                case DesktopMaterial.Laminate:
                    return 100;
                case DesktopMaterial.Oak:
                    return 200;
                case DesktopMaterial.Rosewood:
                    return 300;
                case DesktopMaterial.Veneer:
                    return 150;
                case DesktopMaterial.Pine:
                    return 50;
                default:
                    return 999;
            }
        }

    }
        public enum Time
        {
            TwoWeeks,
            OneWeek,
            FiveDays,
            ThreeDays
        }
}
