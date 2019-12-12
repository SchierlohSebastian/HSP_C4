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