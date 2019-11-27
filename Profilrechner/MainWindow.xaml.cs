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
            InitializeComponent();                                                              // Nur die Startseite anzeigen lassen
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

        private void tvi_dreieck_Selected_1(object sender, RoutedEventArgs e)                   // Anzeigen von Dreieck bei Auswahl in Treeview
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

        private void tvi_rechteck_Selected(object sender, RoutedEventArgs e)                    // Anzeigen von Rechteck bei Auswahl in Treeview
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

        private void tvi_kasten_Selected(object sender, RoutedEventArgs e)                      // Anzeigen von Kasten bei Auswahl in Treeview
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

        private void tvi_lprofil_Selected(object sender, RoutedEventArgs e)                     // Anzeigen von L-Profil Bei Auswahl in Treeview
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
        
        private void tvi_kreis_Selected(object sender, RoutedEventArgs e)                       // Anzeigen von Kreis bei Auswahl in Treeview
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

        private void tvi_ellipse_Selected(object sender, RoutedEventArgs e)                     // Anzeigen von Ellipse bei Auswahl in Treeview
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
        private void btn_berechne_Click(object sender, RoutedEventArgs e)                       // Funktion von Button Berechne 
        {

            // Variablen deklarieren

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
            double gewichtstahl = 0.00785;
            string flaeche;
            string volumen;
            string gewicht;
            string ftm;


            if (tvi_dreieck.IsSelected)                                 // Dreieck                                                          
            {
    // Textbox Eingaben an String übergeben 
                strkleinb = tb_b_dreieck.Text;
                strkleinh = tb_h_dreieck.Text;
                strlaenge = tb_l_dreieck.Text;

     // Überprüfung der Eingaben 
     
                if (strkleinh.Contains(".") | strkleinh.Contains("-") | strkleinh.Contains("+") | strkleinh.Contains("*") | strkleinh.Contains("/"))                    
                {
                    MessageBox.Show("Wert h ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_h_dreieck.Focus();
                    tb_h_dreieck.SelectAll();             
                }
                else if (strkleinb.Contains(".") | strkleinb.Contains("-") | strkleinb.Contains("+") | strkleinb.Contains("*") | strkleinb.Contains("/"))
                {
                    MessageBox.Show("Wert b ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_b_dreieck.Focus();
                    tb_b_dreieck.SelectAll();
                }
                else if (strlaenge.Contains(".") | strlaenge.Contains("-") | strlaenge.Contains("+") | strlaenge.Contains("*") | strlaenge.Contains("/"))
                {
                    MessageBox.Show("Wert Länge ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_l_dreieck.Focus();
                    tb_l_dreieck.SelectAll();
                }
                else if (strkleinh.Contains("0"))
                {
                    MessageBox.Show("Alle ausgegeben Werte werden 0, da für h Null eingegeben wurde", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_h_dreieck.Focus();
                    tb_h_dreieck.SelectAll();                  
                }
                else if (strkleinb.Contains("0"))
                {
                    MessageBox.Show("Alle ausgegeben Werte werden 0, da für b Null eingegeben wurde", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_b_dreieck.Focus();
                    tb_b_dreieck.SelectAll();
                }
                else if (strlaenge.Contains("0"))
                {
                    MessageBox.Show("Die Werte werden Volumen und Gewicht werden 0, da für Länge Null eingegeben wurde", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_l_dreieck.Focus();
                    tb_l_dreieck.SelectAll();
                }
                else
                {
    
                    dkleinb = Convert.ToDouble(strkleinb);      // Konvertierung der überprüften Eingaben in double 
                    dkleinh = Convert.ToDouble(strkleinh);
                    dlaenge = Convert.ToDouble(strlaenge);
                                                                // Berechnungen für Dreieck durchführen                    
                    dflaeche = (dkleinh * dkleinb) / 2;         
                    dvolumen = dflaeche * dlaenge;
                    dgewicht = dvolumen * gewichtstahl;
                    dftm = (dkleinb * (Math.Pow(dkleinh, 3))) / 36;

                    flaeche = Convert.ToString(dflaeche);       // Konvertierung der Ergebnisse zu string für Ausgabe  
                    volumen = Convert.ToString(dvolumen);
                    gewicht = Convert.ToString(dgewicht);
                    ftm = Convert.ToString(dftm);

                    tb_flaeche_dreieck.Text = flaeche;          // Ausgabe in Ausgabe Textboxen für Dreieck
                    tb_volumen_dreieck.Text = volumen;
                    tb_gewicht_dreieck.Text = gewicht;
                    tb_ftm_dreieck.Text = ftm; 
                }
            }

            else if (tvi_rechteck.IsSelected)                               //Rechteck
            {

    // Textboxeingaben übergeben an string 

                strkleinb = tb_b_rechteck.Text;
                strkleinh = tb_h_rechteck.Text;
                strlaenge = tb_l_rechteck.Text;

    // Überprüfung der Eingaben 

                if (strkleinh.Contains(".") | strkleinh.Contains("-") | strkleinh.Contains("+") | strkleinh.Contains("*") | strkleinh.Contains("/"))
                {
                    MessageBox.Show("Wert h ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_h_rechteck.Focus();
                    tb_h_rechteck.SelectAll();
                }
                else if (strkleinb.Contains(".") | strkleinb.Contains("-") | strkleinb.Contains("+") | strkleinb.Contains("*") | strkleinb.Contains("/"))
                {
                    MessageBox.Show("Wert b ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_b_rechteck.Focus();
                    tb_b_rechteck.SelectAll();
                }
                else if (strlaenge.Contains(".") | strlaenge.Contains("-") | strlaenge.Contains("+") | strlaenge.Contains("*") | strlaenge.Contains("/"))
                {
                    MessageBox.Show("Wert Länge ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_l_rechteck.Focus();
                    tb_l_rechteck.SelectAll();
                }
                else if (strkleinh.Contains("0"))
                {
                    MessageBox.Show("Alle ausgegeben Werte werden 0, da für h Null eingegeben wurde", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_h_rechteck.Focus();
                    tb_h_rechteck.SelectAll();                  
                }
                else if (strkleinb.Contains("0"))
                {
                    MessageBox.Show("Alle ausgegeben Werte werden 0, da für b Null eingegeben wurde", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_b_rechteck.Focus();
                    tb_b_rechteck.SelectAll();
                }
                else if (strlaenge.Contains("0"))
                {
                    MessageBox.Show("Die Werte werden Volumen und Gewicht werden 0, da für Länge Null eingegeben wurde", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_l_rechteck.Focus();
                    tb_l_rechteck.SelectAll();
                }
                else
                {
                    dkleinb = Convert.ToDouble(strkleinb);                  // Konvertierung der Überprüften strings in double Variablen
                    dkleinh = Convert.ToDouble(strkleinh);
                    dlaenge = Convert.ToDouble(strlaenge);
                                                                            // Durchführen der Rechnung an Rechteck
                    dflaeche = (dkleinh * dkleinb);             
                    dvolumen = dflaeche * dlaenge;
                    dgewicht = dvolumen * gewichtstahl;
                    dftm = (dkleinb * (Math.Pow(dkleinh, 3))) / 12;

                    flaeche = Convert.ToString(dflaeche);                   // Konvertierung der Ergebnisse in string für Ausgabe
                    volumen = Convert.ToString(dvolumen);
                    gewicht = Convert.ToString(dgewicht);
                    ftm = Convert.ToString(dftm);

                    tb_flaeche_rechteck.Text = flaeche;                     // Ausgabe der Ergebnisse in Ausgabe Textboxen für Rechteck 
                    tb_volumen_rechteck.Text = volumen;
                    tb_gewicht_rechteck.Text = gewicht;
                    tb_ftm_rechteck.Text = ftm;
                }
            }
            else if (tvi_kasten.IsSelected)                         // Kasten
            {   

    // Übergabe der Textboxeingaben an string 

                strkleinb = tb_kleinb_kasten.Text;
                strkleinh = tb_kleinh_kasten.Text;
                strgroßb = tb_großb_kasten.Text;
                strgroßh = tb_großh_kasten.Text;             
                strlaenge = tb_l_kasten.Text;
                
    // Konvertierung der strings in double

                dgroßb = Convert.ToDouble(strgroßb);
                dgroßh = Convert.ToDouble(strgroßh);
                dkleinb = Convert.ToDouble(strkleinb);
                dkleinh = Convert.ToDouble(strkleinh);
                dlaenge = Convert.ToDouble(strlaenge);

    // Überprüfung der Eingegebenen Werten

                if (strkleinh.Contains(".") | strkleinh.Contains("-") | strkleinh.Contains("+") | strkleinh.Contains("*") | strkleinh.Contains("/"))
                {
                    MessageBox.Show("Wert h ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_kleinh_kasten.Focus();
                    tb_kleinh_kasten.SelectAll();
                }
                else if (strkleinb.Contains(".") | strkleinb.Contains("-") | strkleinb.Contains("+") | strkleinb.Contains("*") | strkleinb.Contains("/"))
                {
                    MessageBox.Show("Wert b ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_kleinb_kasten.Focus();
                    tb_kleinb_kasten.SelectAll();
                }
                else if (strgroßh.Contains(".") | strgroßh.Contains("-") | strgroßh.Contains("+") | strgroßh.Contains("*") | strgroßh.Contains("/"))
                {
                    MessageBox.Show("Wert H ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_großh_kasten.Focus();
                    tb_großh_kasten.SelectAll();
                }
                else if (strgroßb.Contains(".") | strgroßb.Contains("-") | strgroßb.Contains("+") | strgroßb.Contains("*") | strgroßb.Contains("/"))
                {
                    MessageBox.Show("Wert B ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_großb_kasten.Focus();
                    tb_großb_kasten.SelectAll();
                }
                else if (strlaenge.Contains(".") | strlaenge.Contains("-") | strlaenge.Contains("+") | strlaenge.Contains("*") | strlaenge.Contains("/"))
                {
                    MessageBox.Show("Wert Länge ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_l_kasten.Focus();
                    tb_l_kasten.SelectAll();
                }
                else if (dgroßh < dkleinh )
                {
                    MessageBox.Show("Die Maße h und H wurde nicht korrekt gewählt, da h größer als H ist", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_kleinh_kasten.Focus();
                    tb_kleinh_kasten.SelectAll();
                }
                else if (dgroßh == dkleinh)
                {
                    MessageBox.Show("Das Maß h oder H wurden nicht korrekt gewählt, da h genau so groß wie H ist", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_kleinh_kasten.Focus();
                    tb_kleinh_kasten.SelectAll();
                }
                else if (dgroßb < dkleinb)
                {
                    MessageBox.Show("Das Maß b oder B wurde nicht korrekt gewählt, da b größer als B ist", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_kleinb_kasten.Focus();
                    tb_kleinb_kasten.SelectAll();
                }
                else if (dgroßb == dkleinb)
                {
                    MessageBox.Show("Das Maß b oder B wurden nicht korrekt gewählt, da b genau so groß wie B ist", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_kleinb_kasten.Focus();
                    tb_kleinb_kasten.SelectAll();
                }
                else if (strlaenge.Contains("0"))
                {
                    MessageBox.Show("Die Werte werden Volumen und Gewicht werden 0, da für Länge Null eingegeben wurde", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_l_kasten.Focus();
                    tb_l_kasten.SelectAll();
                }
                else
                {
                    dflaeche = (dgroßb * dgroßh) - (dkleinh * dkleinb);                                     // Berechnung für L-Profil
                    dvolumen = dflaeche * dlaenge;
                    dgewicht = dvolumen * gewichtstahl;
                    dftm = ((dgroßb * (Math.Pow(dgroßh, 3))) - (dkleinb * (Math.Pow(dkleinh, 3)))) / 12;
                                                            
                    flaeche = Convert.ToString(dflaeche);                                                   // Konvertierung der Ergebnisse zu string für Ausgabe
                    volumen = Convert.ToString(dvolumen);
                    gewicht = Convert.ToString(dgewicht);
                    ftm = Convert.ToString(dftm);


                    tb_flaeche_kasten.Text = flaeche;                   // Ausgabe der Werte in Ausgabetextboxen für L-Kasten
                    tb_volumen_kasten.Text = volumen;
                    tb_gewicht_kasten.Text = gewicht;
                    tb_ftm_kasten.Text = ftm;
                }
            }

            else if (tvi_lprofil.IsSelected)                            // L-Profil
            {

    // Übergabe der Eingaben in string

                strgroßb = tb_großb_lprofil.Text;
                strgroßh = tb_großh_lprofil.Text;
                strkleinb = tb_kleinb_lprofil.Text;
                strkleinh = tb_kleinh_lprofil.Text;
                strlaenge = tb_l_lprofil.Text;
    
    // Konvertierung der Strings in double

                dgroßb = Convert.ToDouble(strgroßb);
                dgroßh = Convert.ToDouble(strgroßh);
                dkleinb = Convert.ToDouble(strkleinb);
                dkleinh = Convert.ToDouble(strkleinh);
                dlaenge = Convert.ToDouble(strlaenge);

                if (strkleinh.Contains(".") | strkleinh.Contains("-") | strkleinh.Contains("+") | strkleinh.Contains("*") | strkleinh.Contains("/"))
                {
                    MessageBox.Show("Wert h ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_kleinh_lprofil.Focus();
                    tb_kleinh_lprofil.SelectAll();
                }
                else if (strkleinb.Contains(".") | strkleinb.Contains("-") | strkleinb.Contains("+") | strkleinb.Contains("*") | strkleinb.Contains("/"))
                {
                    MessageBox.Show("Wert b ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_kleinb_lprofil.Focus();
                    tb_kleinb_lprofil.SelectAll();
                }
                else if (strgroßh.Contains(".") | strgroßh.Contains("-") | strgroßh.Contains("+") | strgroßh.Contains("*") | strgroßh.Contains("/"))
                {
                    MessageBox.Show("Wert H ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_großh_lprofil.Focus();
                    tb_großh_lprofil.SelectAll();
                }
                else if (strgroßb.Contains(".") | strgroßb.Contains("-") | strgroßb.Contains("+") | strgroßb.Contains("*") | strgroßb.Contains("/"))
                {
                    MessageBox.Show("Wert B ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_großb_lprofil.Focus();
                    tb_großb_lprofil.SelectAll();
                }
                else if (strlaenge.Contains(".") | strlaenge.Contains("-") | strlaenge.Contains("+") | strlaenge.Contains("*") | strlaenge.Contains("/"))
                {
                    MessageBox.Show("Wert Länge ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_l_lprofil.Focus();
                    tb_l_lprofil.SelectAll();
                }
                else if (dgroßh < dkleinh)
                {
                    MessageBox.Show("Das Maß h oder H wurde nicht korrekt gewählt, da h größer als H ist", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_kleinh_lprofil.Focus();
                    tb_kleinh_lprofil.SelectAll();
                }
                else if (dgroßh == dkleinh)
                {
                    MessageBox.Show("Das Maß h oder H wurden nicht korrekt gewählt, da h genau so groß wie H ist", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_kleinh_lprofil.Focus();
                    tb_kleinh_lprofil.SelectAll();
                }

                else if (dgroßb < dkleinb)
                {
                    MessageBox.Show("Das Maß b oder B wurde nicht korrekt gewählt, da b größer als B ist", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_kleinb_lprofil.Focus();
                    tb_kleinb_lprofil.SelectAll();
                }
                else if (dgroßb == dkleinb)
                {
                    MessageBox.Show("Das Maß b oder B wurden nicht korrekt gewählt, da b genau so groß wie B ist", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_kleinb_lprofil.Focus();
                    tb_kleinb_lprofil.SelectAll();
                }

                else if (strlaenge.Contains("0"))
                {
                    MessageBox.Show("Die Werte werden Volumen und Gewicht werden 0, da für Länge Null eingegeben wurde", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_l_lprofil.Focus();
                    tb_l_lprofil.SelectAll();
                }
                else
                {
                    dflaeche = (dgroßb * dgroßh) - (dkleinh * dkleinb);                     // Durchführung der Berechnung für L-Profil
                    dvolumen = dflaeche * dlaenge;
                    dgewicht = dvolumen * gewichtstahl;

                    de1 = ((dgroßb * Math.Pow(dgroßh, 2)) + (dkleinb * Math.Pow(dkleinh, 2))) / ((dgroßb * dgroßh) + (dkleinb * dkleinh)) / 2;
                    dftm = (((dgroßb * (Math.Pow(dgroßh, 3))) + (dkleinb * (Math.Pow(dkleinh, 3)))) / 3) - (((dgroßb * dgroßh) + (dkleinb * dkleinh)) * de1);



                    flaeche = Convert.ToString(dflaeche);                           // Konvertierung der Ergenisse in string für Ausgabe
                    volumen = Convert.ToString(dvolumen);
                    gewicht = Convert.ToString(dgewicht);
                    ftm = Convert.ToString(dftm);


                    tb_flaeche_lprofil.Text = flaeche;                              // Ausgabe der Ergebnisse in Ausgabetextboxen für L-Profil
                    tb_volumen_lprofil.Text = volumen;
                    tb_gewicht_lprofil.Text = gewicht;
                    tb_ftm_lprofil.Text = ftm;
                }
            }

            else if (tvi_kreis.IsSelected)                          // Kreis
            {
    
    // Übergabe der Eingegebenen Wert in strings

                strdurchmesser = tb_d_kreis.Text;
                strlaenge = tb_l_kreis.Text;

    // Überprüfung der eingegebenen werte

                if (strdurchmesser.Contains(".") | strdurchmesser.Contains("-") | strdurchmesser.Contains("+") | strdurchmesser.Contains("*") | strdurchmesser.Contains("/"))
                {
                    MessageBox.Show("Wert d ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_d_kreis.Focus();
                    tb_d_kreis.SelectAll();
                }
                else if (strlaenge.Contains(".") | strlaenge.Contains("-") | strlaenge.Contains("+") | strlaenge.Contains("*") | strlaenge.Contains("/"))
                {
                    MessageBox.Show("Wert Länge ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_l_kreis.Focus();
                    tb_l_kreis.SelectAll();
                }
                else if (strdurchmesser.Contains("0"))
                {
                    MessageBox.Show("Alle ausgegeben Werte werden 0, da für d Null eingegeben wurde", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_d_kreis.Focus();
                    tb_d_kreis.SelectAll();
                }
                else if (strlaenge.Contains("0"))
                {
                    MessageBox.Show("Die Werte werden Volumen und Gewicht werden 0, da für Länge Null eingegeben wurde", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_l_kreis.Focus();
                    tb_l_kreis.SelectAll();
                }
                else
                {
                    ddurchmesser = Convert.ToDouble(strdurchmesser);            // Konvertierung der Eingabewerte in doubles  
                    dlaenge = Convert.ToDouble(strlaenge);

                    dflaeche = (Math.Pow(ddurchmesser, 2) * pi) / 4;            // Berechnungen für Kreis
                    dvolumen = dflaeche * dlaenge;
                    dgewicht = dvolumen * gewichtstahl;
                    dftm = (pi * (Math.Pow(ddurchmesser, 4))) / 64;

                    flaeche = Convert.ToString(dflaeche);                       // Konvertierung der Ergebnisse für Ausgabe
                    volumen = Convert.ToString(dvolumen);
                    gewicht = Convert.ToString(dgewicht);
                    ftm = Convert.ToString(dftm);
                    

                    tb_flaeche_kreis.Text = flaeche;                            // Ausgabe der werte in ausgabetextbox für Kreis
                    tb_volumen_kreis.Text = volumen;
                    tb_gewicht_kreis.Text = gewicht;
                    tb_ftm_kreis.Text = ftm;
                }
            }

            else if (tvi_ellipse.IsSelected)                    // Ellipse
            {

    // Übergabe der Eingabewerte zu string

                stra = tb_a_ellipse.Text;
                strb = tb_b_ellipse.Text;
                strlaenge = tb_l_ellipse.Text;

    // Überprüfung der Eingabewerte

                if (stra.Contains(".") | stra.Contains("-") | stra.Contains("+") | stra.Contains("*") | stra.Contains("/"))
                {
                    MessageBox.Show("Wert a ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_a_ellipse.Focus();
                    tb_a_ellipse.SelectAll();
                }
                else if (strb.Contains(".") | strb.Contains("-") | strb.Contains("+") | strb.Contains("*") | strb.Contains("/"))
                {
                    MessageBox.Show("Wert b ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_b_ellipse.Focus();
                    tb_b_ellipse.SelectAll();
                }
                else if (strlaenge.Contains(".") | strlaenge.Contains("-") | strlaenge.Contains("+") | strlaenge.Contains("*") | strlaenge.Contains("/"))
                {
                    MessageBox.Show("Wert Länge ist negativ oder enthält '.'", "Eingabefehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    tb_l_ellipse.Focus();
                    tb_l_ellipse.SelectAll();
                }
                else if (stra.Contains("0"))
                {
                    MessageBox.Show("Alle ausgegeben Werte werden 0, da für a Null eingegeben wurde", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_a_ellipse.Focus();
                    tb_a_ellipse.SelectAll();
                }
                else if (strb.Contains("0"))
                {
                    MessageBox.Show("Alle ausgegeben Werte werden 0, da für b Null eingegeben wurde", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_b_ellipse.Focus();
                    tb_b_ellipse.SelectAll();
                }
                else if (strlaenge.Contains("0"))
                {
                    MessageBox.Show("Die Werte werden Volumen und Gewicht werden 0, da für Länge Null eingegeben wurde", "Achtung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_l_ellipse.Focus();
                    tb_l_ellipse.SelectAll();
                }
                else
                {
                    da = Convert.ToDouble(stra);                        // Konvertierung der überprüften eingaben in double
                    db = Convert.ToDouble(strb);
                    dlaenge = Convert.ToDouble(strlaenge);

                    dflaeche = da * db * pi;                            // Berechnungen für Ellipse
                    dvolumen = dflaeche * dlaenge;
                    dgewicht = dvolumen * gewichtstahl;
                    dftm = (pi * (Math.Pow(da, 3) * db)) / 4;

                    flaeche = Convert.ToString(dflaeche);               // Konvertierung der Ergebnisse für Ausgabe
                    volumen = Convert.ToString(dvolumen);
                    gewicht = Convert.ToString(dgewicht);
                    ftm = Convert.ToString(dftm);


                    tb_flaeche_ellipse.Text = flaeche;                  // Ausgabe in Ausgabe Textboxen für Ellipse 
                    tb_volumen_ellipse.Text = volumen;
                    tb_gewicht_ellipse.Text = gewicht;
                    tb_ftm_ellipse.Text = ftm;
                }
            }
        }
        private void btn_Beenden_Click(object sender, RoutedEventArgs e)
        
        // Beenden des Programmes
        {
            switch(MessageBox.Show("Wollen sie das Programm wirklich beenden?", "Programmbeendung", MessageBoxButton.YesNo, MessageBoxImage.Question))
            {
                case MessageBoxResult.Yes:
                    Application.Current.Shutdown();
                break;
            }
        }
    }
}
