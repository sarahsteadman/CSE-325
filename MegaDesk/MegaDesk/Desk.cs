using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class Desk
    {
        public double width{ get; set; }
        public double depth{ get; set; }
        public int drawers{ get; set; }
        public DesktopMaterial surfaceMaterial;
        public DesktopMaterial SurfaceMaterial
        {
            get { return surfaceMaterial; }
            set { surfaceMaterial = value; }
        }

        public int MAX_WIDTH = 96;
        public int MIN_WIDTH = 24;
        public int MAX_DEPTH = 48;
        public int MIN_DEPTH = 12;
        public int MAX_DRAWERS = 7;
        public int MIN_DRAWERS = 0;
    }

    public enum DesktopMaterial{
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }
}
