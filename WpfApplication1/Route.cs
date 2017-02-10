using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace WpfApplication1
{
    public class Route : Forme
    {
        public Route(int x, int y, int rayon, int epaisseur)
        {
            this.x = x;
            this.y = y;
            this.rayon = rayon;
            this.epaisseur = epaisseur;
            this.color = Brushes.Maroon;
        }
    }
}
