using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculFleche
{
    public partial class Form2 : Form
    {
        private Form1 parentForm;
        private Formules formule;
        private bool visibility = false;
        
        public string forme;
        public Form2(Form1 parentForm)
        {
            InitializeComponent();
            formule = new Formules();
            this.parentForm = parentForm;
        }

        private void buttonConfirmer_Click(object sender, EventArgs e)
        {
            try
            {
                double hauteurRectangle = double.Parse(textBoxHauteurRect.Text);
                double largeurRectangle = double.Parse(textBoxLargeurRect.Text);
                double hauteurTriangle = double.Parse(textBoxHauteurTri.Text);
                double longeurArrete = double.Parse(textBoxArrete.Text);
                double hauteurExagone = double.Parse(textBoxHauteurExa.Text);
                double diametre = double.Parse(textBoxDiametre.Text);
                double diametreExterieur = double.Parse(textBoxDiametreExt.Text);
                double diametreInterieur = double.Parse(textBoxDiametreInt.Text);
                double hauteurAme = double.Parse(textBoxHauteurAme.Text);
                double largeurAme = double.Parse(textBoxLargeurAme.Text);
                double epaisseurSemelle = double.Parse(textBoxHauteurSem.Text);
                double largeurSemelle = double.Parse(textBoxLargeurSem.Text);

                if (forme == "Rectangulaire")
                {
                    parentForm.hauteur = hauteurRectangle;
                    parentForm.TextBoxMoment.Text = formule.momentQuadSectionRectangulaire(hauteurRectangle, largeurRectangle).ToString();
                }

                else if (forme == "Circulaire")
                {
                    parentForm.hauteur = diametre;
                    parentForm.TextBoxMoment.Text = formule.momentQuadSectionCirculaire(diametre).ToString();
                }

                else if (forme == "Annulaire")
                {
                    parentForm.hauteur = diametreExterieur;
                    parentForm.TextBoxMoment.Text = formule.momentQuadSectionAnnulaire(diametreExterieur, diametreInterieur).ToString();
                }

                else if (forme == "Triangulaire")
                {
                    parentForm.hauteur = hauteurTriangle;
                    parentForm.TextBoxMoment.Text = formule.momentQuadSectionTriangulaire(hauteurTriangle, longeurArrete).ToString();
                }

                else if (forme == "Exagonale")
                {
                    parentForm.hauteur = hauteurExagone;
                    parentForm.TextBoxMoment.Text = formule.momentQuadSectionExagonale(hauteurExagone).ToString();
                }

                else if (forme == "IPN")
                {
                    parentForm.hauteur = hauteurAme;
                    parentForm.TextBoxMoment.Text = formule.momentQuadIPN(largeurAme, hauteurAme, epaisseurSemelle, largeurSemelle).ToString();
                }
                
                this.Hide();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
            if(visibility == false)
            {
                if (forme == "Rectangulaire")
                {
                    textBoxHauteurRect.ReadOnly = false;
                    textBoxLargeurRect.ReadOnly = false;
                }

                else if (forme == "Circulaire")
                {
                    textBoxDiametre.ReadOnly = false;
                }

                else if (forme == "Annulaire")
                {
                    textBoxDiametreExt.ReadOnly = false;
                    textBoxDiametreInt.ReadOnly = false;
                }

                else if (forme == "Triangulaire")
                {
                    textBoxHauteurTri.ReadOnly = false;
                    textBoxArrete.ReadOnly = false;
                }

                else if (forme == "Exagonale")
                {
                    textBoxHauteurExa.ReadOnly = false;
                }

                else if (forme == "IPN")
                {
                    textBoxHauteurAme.ReadOnly = false;
                    textBoxLargeurAme.ReadOnly = false;
                    textBoxHauteurSem.ReadOnly = false;
                    textBoxLargeurSem.ReadOnly = false;
                }

                visibility = !visibility;
            }

            else
            {
                textBoxHauteurRect.ReadOnly = true;
                textBoxLargeurRect.ReadOnly = true;
                textBoxDiametre.ReadOnly = true;
                textBoxDiametreExt.ReadOnly = true;
                textBoxDiametreInt.ReadOnly = true;
                textBoxHauteurTri.ReadOnly = true;
                textBoxArrete.ReadOnly = true;
                textBoxHauteurExa.ReadOnly = true;
                textBoxHauteurAme.ReadOnly = true;
                textBoxLargeurAme.ReadOnly = true;
                textBoxHauteurSem.ReadOnly = true;
                textBoxLargeurSem.ReadOnly = true;

                visibility = !visibility;
            }
        }
    }
}
