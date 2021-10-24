using System;
using System.Collections.Generic;
using System.Text;

namespace Option
{
    public class Option
    {
        static int nbrPlace = 0;
        private string nomOption ;
        private string[,] listEtudient;


        public void setOption(string nom,int Place) 
        {
            nbrPlace = Place;
            nomOption = nom;
        }
        public int getnbrPlaceOption()
        {
           return nbrPlace;
        }
        public void setList(int nbrEtudient)
        {
            listEtudient = new string[nbrEtudient, 4];
        }
        public string getNomOption()
        {
            return nomOption;
        }
        public void setEtudient(string id, string nom, string prenom, string moyen,int i)
        {
            listEtudient[i,0] = id;
            listEtudient[i,1] = nom;
            listEtudient[i,2] = prenom;
            listEtudient[i,3] = moyen;
        }


    }
}
