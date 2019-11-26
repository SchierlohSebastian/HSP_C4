using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Profilrechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            grid_dreieck.Visibility = Visibility.Hidden;
            grid_rechteck.Visibility = Visibility.Hidden;
            grid_kasten.Visibility = Visibility.Hidden;
            grid_lprofil.Visibility = Visibility.Hidden;
            grid_kreis.Visibility = Visibility.Hidden;
            grid_ellipse.Visibility = Visibility.Hidden;
            grid_startseite.Visibility = Visibility.Visible;
            trv_profil.Visibility = Visibility.Visible;
            img_jadehs.Visibility = Visibility.Visible;
            btn_berechne.IsEnabled = false;

        }

        private void tvi_dreieck_Selected_1(object sender, RoutedEventArgs e)
        {
            btn_berechne.IsEnabled = true;
            grid_dreieck.Visibility = Visibility.Visible;
            grid_rechteck.Visibility = Visibility.Hidden;
            grid_kasten.Visibility = Visibility.Hidden;
            grid_lprofil.Visibility = Visibility.Hidden;
            grid_kreis.Visibility = Visibility.Hidden;
            grid_ellipse.Visibility = Visibility.Hidden;
            grid_startseite.Visibility = Visibility.Hidden;
            trv_profil.Visibility = Visibility.Visible;
            img_jadehs.Visibility = Visibility.Visible;
        }

        private void tvi_rechteck_Selected(object sender, RoutedEventArgs e)
        {
            btn_berechne.IsEnabled = true;
            grid_dreieck.Visibility = Visibility.Hidden;
            grid_rechteck.Visibility = Visibility.Visible;
            grid_kasten.Visibility = Visibility.Hidden;
            grid_lprofil.Visibility = Visibility.Hidden;
            grid_kreis.Visibility = Visibility.Hidden;
            grid_ellipse.Visibility = Visibility.Hidden;
            grid_startseite.Visibility = Visibility.Hidden;
            trv_profil.Visibility = Visibility.Visible;
            img_jadehs.Visibility = Visibility.Visible;
        }

        private void tvi_kasten_Selected(object sender, RoutedEventArgs e)
        {
            btn_berechne.IsEnabled = true;
            grid_dreieck.Visibility = Visibility.Hidden;
            grid_rechteck.Visibility = Visibility.Hidden;
            grid_kasten.Visibility = Visibility.Visible;
            grid_lprofil.Visibility = Visibility.Hidden;
            grid_kreis.Visibility = Visibility.Hidden;
            grid_ellipse.Visibility = Visibility.Hidden;
            grid_startseite.Visibility = Visibility.Hidden;
            trv_profil.Visibility = Visibility.Visible;
            img_jadehs.Visibility = Visibility.Visible;
        }

        private void tvi_lprofil_Selected(object sender, RoutedEventArgs e)
        {
            btn_berechne.IsEnabled = true;
            grid_dreieck.Visibility = Visibility.Hidden;
            grid_rechteck.Visibility = Visibility.Hidden;
            grid_kasten.Visibility = Visibility.Hidden;
            grid_lprofil.Visibility = Visibility.Visible;
            grid_kreis.Visibility = Visibility.Hidden;
            grid_ellipse.Visibility = Visibility.Hidden;
            grid_startseite.Visibility = Visibility.Hidden;
            trv_profil.Visibility = Visibility.Visible;
            img_jadehs.Visibility = Visibility.Visible;
        }

        private void tvi_kreis_Selected(object sender, RoutedEventArgs e)
        {
            btn_berechne.IsEnabled = true;
            grid_dreieck.Visibility = Visibility.Hidden;
            grid_rechteck.Visibility = Visibility.Hidden;
            grid_kasten.Visibility = Visibility.Hidden;
            grid_lprofil.Visibility = Visibility.Hidden;
            grid_kreis.Visibility = Visibility.Visible;
            grid_ellipse.Visibility = Visibility.Hidden;
            grid_startseite.Visibility = Visibility.Hidden;
            trv_profil.Visibility = Visibility.Visible;
            img_jadehs.Visibility = Visibility.Visible;
        }

        private void tvi_ellipse_Selected(object sender, RoutedEventArgs e)
        {
            btn_berechne.IsEnabled = true;
            grid_dreieck.Visibility = Visibility.Hidden;
            grid_rechteck.Visibility = Visibility.Hidden;
            grid_kasten.Visibility = Visibility.Hidden;
            grid_lprofil.Visibility = Visibility.Hidden;
            grid_kreis.Visibility = Visibility.Hidden;
            grid_ellipse.Visibility = Visibility.Visible;
            grid_startseite.Visibility = Visibility.Hidden;
            trv_profil.Visibility = Visibility.Visible;
            img_jadehs.Visibility = Visibility.Visible;
        }
        private void btn_berechne_Click(object sender, RoutedEventArgs e)
        {
            

            string strlaenge;
            string strkleinb;
            string strkleinh;
            string strgroßb;
            string strgroßh;
            string strdurchmesser;
            string stra;
            string strb;
            double dlaenge;
            double dkleinb;
            double dkleinh;
            double dgroßb;
            double dgroßh;
            double de1;
            double ddurchmesser;
            double da;
            double db;
            double dflaeche;
            double dvolumen;
            double dgewicht;
            double dftm;
            double pi = 3.14159;
            double gewichtstahl = 7.85;
            string flaeche;
            string volumen;
            string gewicht;
            string ftm;





            if (tvi_dreieck.IsSelected)
            {
                strkleinb = tb_b_dreieck.Text;
                strkleinh = tb_h_dreieck.Text;
                strlaenge = tb_l_dreieck.Text;

                dkleinb = Convert.ToDouble(strkleinb);
                dkleinh = Convert.ToDouble(strkleinh);
                dlaenge = Convert.ToDouble(strlaenge);

                dflaeche = (dkleinh * dkleinb) / 2;
                dvolumen = dflaeche * dlaenge;
                dgewicht = dvolumen * gewichtstahl;
                dftm = (dkleinb * (Math.Pow(dkleinh, 3))) / 36;

                flaeche = Convert.ToString(dflaeche);
                volumen = Convert.ToString(dvolumen);
                gewicht = Convert.ToString(dgewicht);
                ftm = Convert.ToString(dftm);


                tb_flaeche_dreieck.Text = flaeche;
                tb_volumen_dreieck.Text = volumen;
                tb_gewicht_dreieck.Text = gewicht;
                tb_ftm_dreieck.Text = ftm;
            }

            if (tvi_rechteck.IsSelected)
            {
                strkleinb = tb_b_rechteck.Text;
                strkleinh = tb_h_rechteck.Text;
                strlaenge = tb_l_rechteck.Text;

                dkleinb = Convert.ToDouble(strkleinb);
                dkleinh = Convert.ToDouble(strkleinh);
                dlaenge = Convert.ToDouble(strlaenge);

                dflaeche = (dkleinh * dkleinb);
                dvolumen = dflaeche * dlaenge;
                dgewicht = dvolumen * gewichtstahl;
                dftm = (dkleinb * (Math.Pow(dkleinh, 3))) / 12;

                flaeche = Convert.ToString(dflaeche);
                volumen = Convert.ToString(dvolumen);
                gewicht = Convert.ToString(dgewicht);
                ftm = Convert.ToString(dftm);


                tb_flaeche_rechteck.Text = flaeche;
                tb_volumen_rechteck.Text = volumen;
                tb_gewicht_rechteck.Text = gewicht;
                tb_ftm_rechteck.Text = ftm;
            }

            if (tvi_kasten.IsSelected)
            {
                strgroßb = tb_großb_kasten.Text;
                strgroßh = tb_großh_kasten.Text;
                strkleinb = tb_kleinb_kasten.Text;
                strkleinh = tb_kleinh_kasten.Text;
                strlaenge = tb_Laenge_kasten.Text;

                dgroßb = Convert.ToDouble(strgroßb);
                dgroßh = Convert.ToDouble(strgroßh);
                dkleinb = Convert.ToDouble(strkleinb);
                dkleinh = Convert.ToDouble(strkleinh);
                dlaenge = Convert.ToDouble(strlaenge);

                dflaeche = (dgroßb * dgroßh) - (dkleinh * dkleinb);
                dvolumen = dflaeche * dlaenge;
                dgewicht = dvolumen * gewichtstahl;
                dftm = ((dgroßb * (Math.Pow(dgroßh,3))) - (dkleinb * (Math.Pow(dkleinh, 3)))) / 12;

                flaeche = Convert.ToString(dflaeche);
                volumen = Convert.ToString(dvolumen);
                gewicht = Convert.ToString(dgewicht);
                ftm = Convert.ToString(dftm);


                tb_flaeche_kasten.Text = flaeche;
                tb_volumen_kasten.Text = volumen;
                tb_gewicht_kasten.Text = gewicht;
                tb_ftm_kasten.Text = ftm;
            }

            if (tvi_lprofil.IsSelected)
            {
                strgroßb = tb_großb_lprofil.Text;
                strgroßh = tb_großh_lprofil.Text;
                strkleinb = tb_kleinb_lprofil.Text;
                strkleinh = tb_kleinh_lprofil.Text;
                strlaenge = tb_Laenge_lprofil.Text;

                dgroßb = Convert.ToDouble(strgroßb);
                dgroßh = Convert.ToDouble(strgroßh);
                dkleinb = Convert.ToDouble(strkleinb);
                dkleinh = Convert.ToDouble(strkleinh);
                dlaenge = Convert.ToDouble(strlaenge);

                dflaeche = (dgroßb * dgroßh) - (dkleinh * dkleinb);
                dvolumen = dflaeche * dlaenge;
                dgewicht = dvolumen * gewichtstahl;

                de1 = ((dgroßb * Math.Pow(dgroßh,2)) + (dkleinb * Math.Pow(dkleinh,2))) / ((dgroßb * dgroßh) + (dkleinb * dkleinh));
                dftm = (((dgroßb * (Math.Pow(dgroßh, 3))) + (dkleinb * (Math.Pow(dkleinh, 3)))) / 3) - (((dgroßb * dgroßh) + (dkleinb * dkleinh)) * de1);

                

                flaeche = Convert.ToString(dflaeche);
                volumen = Convert.ToString(dvolumen);
                gewicht = Convert.ToString(dgewicht);
                ftm = Convert.ToString(dftm);


                tb_flaeche_lprofil.Text = flaeche;
                tb_volumen_lprofil.Text = volumen;
                tb_gewicht_lprofil.Text = gewicht;
                tb_ftm_lprofil.Text = ftm;
            }

            if (tvi_kreis.IsSelected)
            {
                strdurchmesser = tb_d_kreis.Text;
                strlaenge = tb_l_kreis.Text;


                ddurchmesser = Convert.ToDouble(strdurchmesser);
                dlaenge = Convert.ToDouble(strlaenge);

                dflaeche = (Math.Pow(ddurchmesser,2) * pi) / 4;
                dvolumen = dflaeche * dlaenge;
                dgewicht = dvolumen * gewichtstahl;
                dftm = (pi * (Math.Pow(ddurchmesser, 4))) / 64;

                flaeche = Convert.ToString(dflaeche);
                volumen = Convert.ToString(dvolumen);
                gewicht = Convert.ToString(dgewicht);
                ftm = Convert.ToString(dftm);


                tb_flaeche_kreis.Text = flaeche;
                tb_volumen_kreis.Text = volumen;
                tb_gewicht_kreis.Text = gewicht;
                tb_ftm_kreis.Text = ftm;
            }

            if (tvi_ellipse.IsSelected)
            {
                stra = tb_a_ellipse.Text;
                strb = tb_b_ellipse.Text;
                strlaenge = tb_l_ellipse.Text;

                da = Convert.ToDouble(stra);
                db = Convert.ToDouble(strb);
                dlaenge = Convert.ToDouble(strlaenge);

                dflaeche = da * db * pi;
                dvolumen = dflaeche * dlaenge;
                dgewicht = dvolumen * gewichtstahl;
                dftm = (pi * (Math.Pow(da, 3) * db)) / 4;

                flaeche = Convert.ToString(dflaeche);
                volumen = Convert.ToString(dvolumen);
                gewicht = Convert.ToString(dgewicht);
                ftm = Convert.ToString(dftm);


                tb_flaeche_ellipse.Text = flaeche;
                tb_volumen_ellipse.Text = volumen;
                tb_gewicht_ellipse.Text = gewicht;
                tb_ftm_ellipse.Text = ftm;
            }

        }

        private void btn_Beenden_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
