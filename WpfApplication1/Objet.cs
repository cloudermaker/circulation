using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApplication1
{
    public class Forme
    {
        public int x;
        public int y;
        public int rayon;
        public int epaisseur;
        public Brush color;

        public Forme()
        {
        }

        public Forme(int x, int y, int rayon, int epaisseur)
        {
            this.x = x;
            this.y = y;
            this.rayon = rayon;
            this.epaisseur = epaisseur;
        }

        public Ellipse GetEllipse()
        {
            EllipseGeometry circle = new EllipseGeometry();

            Ellipse el = new Ellipse();
            el.Width = this.rayon;
            el.Height = this.rayon;

            el.SetValue(Canvas.LeftProperty, (Double)this.x);
            el.SetValue(Canvas.TopProperty, (Double)this.y);

            el.Fill = Brushes.Transparent;
            el.Stroke = color;
            el.StrokeThickness = this.epaisseur;

            return el;
        }
    }
}
