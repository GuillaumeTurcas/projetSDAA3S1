using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_8_Noté_SDA___Turcas_Guillaume
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TD8 Noté (SDA) - Guillaume Turcas - TD F");
            ListeDouble liste = CreationListeDouble();
            Console.Clear();
            Console.Write("\nAffichage de la liste : ");
            liste.AfficherListeRec(liste.Liste);
            //bool sym = liste.EstListeSym();
            //if (sym == true) Console.WriteLine("\nLa liste est symétrique !");
            //if (sym == false) Console.WriteLine("\nLa liste n'est pas symétrique !");
            int nbre = liste.LongueurListeRecTerm(liste.Liste, 0);
            Console.WriteLine("\nLa liste créée est de longueur : " + nbre);
            Console.WriteLine("\nSaisissez un nombre : ");
            int nbreOcc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nLe chiffre " + nbreOcc + " apparait " + liste.NbreOccurenceRec(liste.Liste, nbreOcc) + " fois dans la liste");
            Console.ReadKey();
        }

        static ListeDouble CreationListeDouble()
        {
            ListeDouble liste = new ListeDouble();
            liste.AjouterCellule();
            bool continuer = true;
            do
            {
                Console.WriteLine("\nVoulez-vous continuer ? (true / false)");
                continuer = Convert.ToBoolean(Console.ReadLine());
                if (continuer == true) liste.AjouterCellule();
            } while (continuer == true);
            return liste;
        }
    }
}
