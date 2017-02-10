using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace WpfApplication1
{
    public class Vehicule : Forme
    {
        public int xInit;
        public int yInit;
        public int angleCumu;
        public int angleMvt;

        public Vehicule(int x, int y, int rayon, int epaisseur, int angle)
        {
            this.x = x;
            this.y = y;
            this.xInit = x;
            this.yInit = y;
            this.angleCumu = angle;
            this.angleMvt = angle;
            this.rayon = rayon;
            this.epaisseur = epaisseur;
            this.color = Brushes.Blue;
        }

        public void Avance()
        {
            double angleRad = Math.PI * this.angleCumu / 180.0;
            //double dist = Math.Sqrt( 2 * this.rayon * this.rayon - 2 * this.rayon * this.rayon * Math.Cos(angleRad) );

            double cos = (this.xInit - 2 * this.rayon) * Math.Cos(angleRad);
            double sin = (this.xInit - 2 * this.rayon) * Math.Sin(angleRad);

            this.x = this.xInit + (int)cos;
            this.y = this.yInit + (int)sin;
            this.angleCumu += this.angleMvt;
        }

        public void Freine()
        {
            if (this.angleMvt > 0)
                this.angleMvt--;
        }

        public void Accelere()
        {
            this.angleMvt++;
        }
    }
}
