using INFITF;
using MECMOD;
using PARTITF;
using System;
using System.Windows;



namespace ConsoleApp1
{
    public class CatiaConnection
    {
        INFITF.Application hsp_catiaApp;
        MECMOD.PartDocument hsp_catiaPart;
        MECMOD.Sketch hsp_catiaProfil;

        public bool laeuftCatia()
        {
            try
            {
                object co =
            System.Runtime.InteropServices.Marshal.GetActiveObject("CATIA.Application");
                hsp_catiaApp = (INFITF.Application)co;
                
            }
            catch
            {
                MessageBox.Show("");
                return false;
            }
            return true;
        }

        public void erstelleBlock(double Laenge)
        {
            hsp_catiaPart.Part.InWorkObject = hsp_catiaPart.Part.MainBody;
            ShapeFactory shapeFact =(ShapeFactory) hsp_catiaPart.Part.ShapeFactory;
            shapeFact.AddNewPad(hsp_catiaProfil, Laenge);

            hsp_catiaProfil.CloseEdition();

            hsp_catiaPart.Part.Update();

        }

        public void erstelleSkizzenElemente()
        {
            Factory2D fact2D = hsp_catiaProfil.OpenEdition();

            // Eckpunkte erstellen

            Console.Write("Vertikale Länge Außen : ");
            double dL1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Horizontale Länge Außen : ");
            double dL2 = Convert.ToDouble(Console.ReadLine());

            Point2D P1 = fact2D.CreatePoint(dL2/2, dL1/2);
            Point2D P2 = fact2D.CreatePoint(dL2 / 2, -dL1 / 2);
            Point2D P3 = fact2D.CreatePoint(-dL2 / 2, -dL1 / 2);
            Point2D P4 = fact2D.CreatePoint(-dL2 / 2, dL1 / 2);

            Line2D L1 = fact2D.CreateLine(dL2 / 2, dL1 / 2, dL2/2, -dL1 / 2);
            Line2D L2 = fact2D.CreateLine(dL2 / 2, -dL1 / 2, -dL2/2, -dL1 / 2);
            Line2D L3 = fact2D.CreateLine(-dL2 / 2, -dL1 / 2, -dL2/2, dL1 / 2);
            Line2D L4 = fact2D.CreateLine(-dL2 / 2, dL1 / 2, dL2/2, dL1/2);

            L1.StartPoint = P1;
            L1.EndPoint = P2;

            L2.StartPoint = P2;
            L2.EndPoint = P3;

            L3.StartPoint = P3;
            L3.EndPoint = P4;

            L4.StartPoint = P4;
            L4.EndPoint = P1;


            Console.Write("Vertikale Länge Innen : ");
            double dL3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Horizontale Länge Innen : ");
            double dL4 = Convert.ToDouble(Console.ReadLine());

            Point2D P5 = fact2D.CreatePoint(dL4 / 2, dL3 / 2);
            Point2D P6 = fact2D.CreatePoint(dL4 / 2, -dL3 / 2);
            Point2D P7 = fact2D.CreatePoint(-dL4 / 2, -dL3 / 2);
            Point2D P8 = fact2D.CreatePoint(-dL4 / 2, dL3 / 2);

            Line2D L5 = fact2D.CreateLine(dL4 / 2, dL3 / 2, dL4 / 2, -dL3 / 2);
            Line2D L6 = fact2D.CreateLine(dL4 / 2, -dL3 / 2, -dL4 / 2, -dL3 / 2);
            Line2D L7 = fact2D.CreateLine(-dL4 / 2, -dL3 / 2, -dL4 / 2, dL3 / 2);
            Line2D L8 = fact2D.CreateLine(-dL4 / 2, dL3 / 2, dL4 / 2, dL3 / 2);

            L5.StartPoint = P5;
            L5.EndPoint = P6;

            L6.StartPoint = P6;
            L6.EndPoint = P7;

            L7.StartPoint = P7;
            L7.EndPoint = P8;

            L8.StartPoint = P8;
            L8.EndPoint = P5;


            hsp_catiaProfil.CloseEdition();

            hsp_catiaPart.Part.Update();



        }

        public void erstelleLeereSkizze()
        {
            HybridBodies catHybridBodies1 = hsp_catiaPart.Part.HybridBodies;
            HybridBody catHybridBody1 = catHybridBodies1.Item("Geometrisches Set.1");

            catHybridBody1.set_Name("Profile");

            Sketches catSketches1 = catHybridBody1.HybridSketches;
            OriginElements catOriginElements = hsp_catiaPart.Part.OriginElements;
            Reference catReference1 = (Reference)catOriginElements.PlaneYZ;

            hsp_catiaProfil = catSketches1.Add(catReference1);
        }

        public void erzeugePart()
        {
            // Erzeuge Part!
            Document partdoc= hsp_catiaApp.Documents.Add("Part");
         hsp_catiaPart =(PartDocument)partdoc;
            
        }



    }
}