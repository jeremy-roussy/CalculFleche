using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculFleche
{
    class Formules
    {
        public Formules()
        {

        }

        // **************************************************************************************************************************************** //
        // *********************************************** Calcule des différents moments d'inertie *********************************************** //
        // **************************************************************************************************************************************** //

        public double momentQuadSectionRectangulaire(double hauteur, double largeur)
        {
            return (largeur * Math.Pow(hauteur, 3)) / 12;
        }

        public double momentQuadSectionCirculaire(double diametre)
        {
            return Math.PI * Math.Pow(diametre, 4) / 64;
        }

        public double momentQuadSectionAnnulaire(double diametreExt, double diametreInt)
        {
            return (Math.PI / 64) * (Math.Pow(diametreExt, 4) - Math.Pow(diametreInt, 4));
        }

        public double momentQuadSectionTriangulaire(double hauteur, double arrete)
        {
            return (hauteur * Math.Pow(arrete, 3)) / 36;
        }

        public double momentQuadSectionExagonale(double hauteur)
        {
            return 0.06014 * Math.Pow(hauteur, 4);
        }

        public double momentQuadIPN(double largeurAme, double hauteurAme, double epaisseurSemelle, double largeurSemelle)
        {
            return (largeurAme * Math.Pow((hauteurAme - 2 * epaisseurSemelle), 3)) / 12 - (largeurSemelle * Math.Pow(epaisseurSemelle, 3)) / 12;
        }

        // **************************************************************************************************************************************** //
        // *************************************************** Calcule des différentes fleches **************************************************** //
        // **************************************************************************************************************************************** //

        public double flecheConsoleChargePonctuelleExtremite(double longueur, double charge, double momentInertie, double moduleYoung)
        {
            return (charge * 9.81 * Math.Pow(longueur, 3)) / (3 * momentInertie * moduleYoung);
        }

        public double flecheConsoleChargePonctuelleDistanceA(double longueur, double dist_a, double charge, double momentInertie, double moduleYoung)
        {
            return (charge * Math.Pow(dist_a, 3) / (3 * moduleYoung * momentInertie));
        }

        public double flecheConsoleChargeRepartieExtremite(double charge, double longueur, double momentInertie, double moduleYoung)
        {
            return (charge * Math.Pow(longueur, 3) / (8 * moduleYoung * momentInertie));
        }

        public double flecheAppuisChargePonctuelleMillieu(double longueur, double charge, double momentInertie, double moduleYoung)
        {
            return (5 * charge * 9.81 * Math.Pow(longueur, 4)) / (48 * momentInertie * moduleYoung);
        }

        public double flecheAppuisChargeRepartieLongueurM(double charge, double longueur, double longueur_m, double momentInertie, double moduleYoung)
        {
            return (charge * Math.Pow(longueur, 3) / ((48 + (29 * longueur_m / momentInertie)) * moduleYoung * momentInertie));
        }

        public double flecheAppuisChargeRepartie(double longueur, double charge, double momentInertie, double moduleYoung)
        {
            return (charge * 9.81 * Math.Pow(longueur, 4)) / (384 * momentInertie * moduleYoung);
        }

        public double flecheAppuisChargePonctuelleDistanceA(double charge, double dist_a, double longueur, double momentInertie, double moduleYoung)
        {
            return (charge * Math.Pow(dist_a, 2) * Math.Pow((longueur - dist_a), 2) / (3 * moduleYoung * momentInertie * longueur));
        }

        public double flecheEncastreeChargePonctuelleMillieu(double charge, double longueur, double momentInertie, double moduleYoung)
        {
            return (charge * Math.Pow(longueur, 3) / (192 * moduleYoung * momentInertie));
        }

        public double flecheEncastreeChargeRepartie(double charge, double longueur, double momentInertie, double moduleYoung)
        {
            return (charge * Math.Pow(longueur, 3) / (384 * moduleYoung * momentInertie));
        }

        // **************************************************************************************************************************************** //
        // ******************************************************* Calcule de la contrainte ******************************************************* //
        // **************************************************************************************************************************************** //

        public double contrainte(double longueur, double hauteur, double charge, double momentInertie)
        {
            return ((longueur * charge * 9.81) * hauteur) / (2 * momentInertie);
        }
    }
}
