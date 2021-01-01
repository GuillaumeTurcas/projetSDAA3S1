using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_8_Noté_SDA___Turcas_Guillaume
{
    class Cellule
    {

        #region Exercice 1.1

        int info;
        Cellule suivante;
        Cellule precedente;

        public Cellule()
        {
            this.info = 0;
            this.suivante = null;
            this.precedente = null;
        }

        public Cellule(int info, Cellule suivante, Cellule precedente)
        {
            this.info = info;
            this.suivante = suivante;
            this.precedente = precedente;
        }

        public int Info
        {
            get { return this.info; }
            set { this.info = value; }
        }

        public Cellule Suivante
        {
            get { return this.suivante; }
            set { this.suivante = value; }
        }

        public Cellule Precedente
        {
            get { return this.precedente; }
            set { this.precedente = value; }
        }

        public override string ToString()
        {
            return Convert.ToString(this.info);
        }

        #endregion


    }
}
