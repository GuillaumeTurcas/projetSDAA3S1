using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_8_Noté_SDA___Turcas_Guillaume
{
    class ListeDouble
    {
        Cellule liste; //tête de liste
        
        #region Exercice 1

        public ListeDouble()
        {
            this.liste = null;
        }

        public ListeDouble(Cellule x) //constructeur
        {
            this.liste = x;
        }

        public Cellule Liste 
        {
            set { this.liste = value; }
            get { return this.liste; }
        }
       
        public Cellule DerniereCellule()
        {
            Cellule c = this.liste; //tête de la liste
            if (this.liste != null) while (c.Suivante != null) c = c.Suivante;
            return c;
        }

        public void AjouterCellule()
        {
            if (this.liste != null)
            {
                Cellule c = this.DerniereCellule(); //afin de rajouter en fin de liste
                Cellule nouv = CreationCellule();
                c.Suivante = nouv;
            }
            else this.liste = CreationCellule();
        }

        public Cellule CreationCellule()
        {
            Console.WriteLine("\nVeuillez saisir l'information de la nouvelle cellule :");
            int info = Convert.ToInt32(Console.ReadLine());
            Cellule c = new Cellule(info, null, this.DerniereCellule());
            return c;
        }

        public void AfficherListeRec(Cellule c) //recursif
        {
            if (c != null)
            {
                if (c.Suivante != null) { Console.Write(c.ToString() + " ");  AfficherListeRec(c.Suivante); }
                else Console.Write(c.ToString() + "\n");
            }            
        }

        #endregion

        #region Exercice 2

        public int ElementFinListeRec(Cellule c)
        {
            if (c != null)
            {
                if (c.Suivante != null) return ElementFinListeRec(c.Suivante);
                else return c.Info;
            }
            else return -1;
        }

        public int LongueurListeRecTerm(Cellule c, int index)
        {
            if (c != null) return LongueurListeRecTerm(c.Suivante, index + 1);
            else return index;
        }

        public bool EstListeSym()
        {
            bool sym = true;
            if (this.Liste != null)
            {
                Cellule c = this.liste; //tete de liste
                Cellule d = this.DerniereCellule(); //derniere cellule de la liste;
                while (c.Suivante !=null || d.Precedente != null)
                {
                    if (c.Info   != d.Info) sym = false;
                    c = c.Suivante;
                    d = d.Precedente;
                }
            }
            return sym;
        }

        public int NbreOccurenceRec(Cellule c, int info)
        {
            if (c != null)
            {
                if (c.Info == info) return 1 + NbreOccurenceRec(c.Suivante, info);
                else return NbreOccurenceRec(c.Suivante, info);
            }
            else return 0;
        }

        #endregion


    }
}
