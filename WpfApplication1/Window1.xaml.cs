using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    public partial class Window1 : Window
    {
        public List<Vehicule> all = new List<Vehicule>();
        public int rayon = 100;
        public int rayonVehicule = 10;
        public int i = 0;
        public int angle = 5;
        public Route route;
        public delegate void Affichage();

        public Window1()
        {
            InitializeComponent();

            this.route = new Route(25, 25, 250, 2);
            Affichage action = new Affichage(Affiche);

            this.Lancement();
        }

        public void Lancement()
        {
            
            //while (true)
            for(int z = 0; z < 10; z++)
            {
                textBox.Text = string.Format("Nombre de tour: {0}", this.i);

                foreach (Vehicule v in all)
                {
                    v.Avance();
                }

                if (i % 2 == 0)
                {
                    Vehicule v = new Vehicule(145, 145, 10, 2, 10);
                    this.all.Add(v);
                }

                //this.Affiche();
                
                System.Threading.Thread.Sleep(500);

                this.i++;
            }
        }

        private void Button_exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_clear(object sender, RoutedEventArgs e)
        {
            this.MainCanvas.Children.Clear();
        }

        private void Button_next(object sender, RoutedEventArgs e)
        {
            this.Lancement();
        }

        public void Affiche()
        {
            MainCanvas.Children.Clear();
            this.Draw(route);

            foreach (Vehicule v in all)
            {
                this.Draw(v);
            }
        }

        private void Draw(Forme o)
        {
            MainCanvas.Children.Add( o.GetEllipse());
        }
    }
}
