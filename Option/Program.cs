using System;

namespace Option
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizetab = 10;

            int Glcont  = 0;
            int ABDcont = 0;
            int ASRcont = 0;

            Option[] listOption = new Option[3];
            listOption[0].setOption("GL", 22);
            listOption[1].setOption("ABD", 22);
            listOption[2].setOption("ASR", 22);

            for (int i=0; i<sizetab; i++)
            {
                //la partie qui ce trouve entre /* ... */ represente les valeur de notre liste des etudient ;

                /*--------------|en supose on à la Liste des Etudient _tree par moyen_ avec leur 3 choix|--------------*/
                string choix1 = "GL";
                string choix2 = "ABD";
                string choix3 = "ASR";

                string id = "12";
                string nom = "toto";
                string prenom = "roro";
                string moyen = "14";
                /*-----------------------------------------------------------------------------------------------------*/

                //Si le 1er choix est disponible ;

                if (listOption[0].getnbrPlaceOption()>Glcont && (listOption[0].getNomOption()==choix1))
                {
                    listOption[0].setEtudient(id, nom, prenom, moyen, Glcont);
                    Glcont++;
                    continue;
                }
                if (listOption[1].getnbrPlaceOption() > ABDcont && (listOption[1].getNomOption() == choix1))
                {
                    listOption[1].setEtudient(id, nom, prenom, moyen, ABDcont);
                    ABDcont++;
                    continue;
                }
                if (listOption[2].getnbrPlaceOption() > ASRcont && (listOption[2].getNomOption() == choix1))
                {
                    listOption[2].setEtudient(id, nom, prenom, moyen, ASRcont);
                    ASRcont++;
                    continue;
                }

                //Si le 2eme choix est disponible ;

                if (listOption[0].getnbrPlaceOption() > Glcont && (listOption[0].getNomOption() == choix2))
                {
                    listOption[0].setEtudient(id, nom, prenom, moyen, Glcont);
                    Glcont++;
                    continue;
                }
                if (listOption[1].getnbrPlaceOption() > ABDcont && (listOption[1].getNomOption() == choix2))
                {
                    listOption[1].setEtudient(id, nom, prenom, moyen, ABDcont);
                    ABDcont++;
                    continue;
                }
                if (listOption[2].getnbrPlaceOption() > ASRcont && (listOption[2].getNomOption() == choix2))
                {
                    listOption[2].setEtudient(id, nom, prenom, moyen, ASRcont);
                    ASRcont++;
                    continue;
                }

                //Si le 3eme choix est disponible ;

                if (listOption[0].getnbrPlaceOption() > Glcont && (listOption[0].getNomOption() == choix3))
                {
                    listOption[0].setEtudient(id, nom, prenom, moyen, Glcont);
                    Glcont++;
                    continue;
                }
                if (listOption[1].getnbrPlaceOption() > ABDcont && (listOption[1].getNomOption() == choix3))
                {
                    listOption[1].setEtudient(id, nom, prenom, moyen, ABDcont);
                    ABDcont++;
                    continue;
                }
                if (listOption[2].getnbrPlaceOption() > ASRcont && (listOption[2].getNomOption() == choix3))
                {
                    listOption[2].setEtudient(id, nom, prenom, moyen, ASRcont);
                    ASRcont++;
                    continue;
                }


            }
        }
    }
}
