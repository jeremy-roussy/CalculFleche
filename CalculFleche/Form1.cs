using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace CalculFleche
{
    public partial class Form1 : Form
    {
        private Formules formule;
        private DataImport dataImport;
        private Form2 form2;
        private Form3 form3;
        private Logger logger;

        private Dictionary<string, string> materiau;
        private Dictionary<string, string> section;

        private string date = DateTime.Now.ToString("dd-MM-yyyy");
        private string time = DateTime.Now.ToString("HH:mm");
        private string message;
        private string conclusion;

        public double hauteur;

        public Form1()
        {
            InitializeComponent();
            formule = new Formules();
            dataImport = new DataImport();
            form2 = new Form2(this);
            logger = new Logger("log.txt");
            materiau = new Dictionary<string, string>();
            section = new Dictionary<string, string>();

            labelLongueurAetM.Visible = false;
            textBoxLongueurAetM.Visible = false;
        }

        /// <summary>
        /// Méthode de remplissage de la comboBoxMateriau lors de la génération du premier formulaire
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            dataImport.FileToImport = "moduleYoung.abaque";

            materiau = dataImport.ImportDataFromFile();

            foreach (KeyValuePair<string, string> pair in materiau)
            {
                comboBoxMateriau.Items.Add(pair.Key);
            }
        }

        /// <summary>
        /// Méthode de changement d'image, des unités de charge
        /// et l'apparition de certain paramètres
        /// en fonction du contexte choisi dans la comboBox
        /// </summary>
        private void comboBoxContexte_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxContext.Image = imageListContexte.Images[comboBoxContexte.SelectedIndex];

            if (comboBoxContexte.SelectedIndex == 2 || comboBoxContexte.SelectedIndex == 4 || comboBoxContexte.SelectedIndex == 5 || comboBoxContexte.SelectedIndex == 8)
            {
                labelCharge.Text = "Charge appliquée (en kg/m) :";

                if(comboBoxContexte.SelectedIndex == 4)
                {
                    labelLongueurAetM.Visible = true;
                    textBoxLongueurAetM.Visible = true;
                    labelLongueurAetM.Text = "longueur m (en m) :";
                    textBoxLongueurAetM.Text = "";
                }

                else
                {
                    labelLongueurAetM.Visible = false;
                    textBoxLongueurAetM.Visible = false;
                    labelLongueurAetM.Text = "longueur a et m (en m) :";
                    textBoxLongueurAetM.Text = "0";
                }
            }

            else
            {
                labelCharge.Text = "Charge appliquée (en kg) :";

                if(comboBoxContexte.SelectedIndex == 1 || comboBoxContexte.SelectedIndex == 6)
                {
                    labelLongueurAetM.Visible = true;
                    textBoxLongueurAetM.Visible = true;
                    labelLongueurAetM.Text = "longueur a (en m) :";
                    textBoxLongueurAetM.Text = "";
                }

                else
                {
                    labelLongueurAetM.Visible = false;
                    textBoxLongueurAetM.Visible = false;
                    labelLongueurAetM.Text = "longueur a et m (en m) :";
                    textBoxLongueurAetM.Text = "0";
                }
            }
        }

        /// <summary>
        /// Méthode appelant les différentes fonctions de calcul de fleche,
        /// de contrainte et d'écriture dans le fichier de log en fonction
        /// du contexte choisi et affichant les résultats correspondant. 
        /// </summary>
        private void buttonCalculer_Click(object sender, EventArgs e)
        {
            try
            {
                double longueur = double.Parse(textBoxLongueur.Text);
                double charge = double.Parse(textBoxCharge.Text);
                double momentInertie = double.Parse(TextBoxMoment.Text);
                double moduleYoung = double.Parse(textBoxModule.Text);
                double dist_am = double.Parse(textBoxLongueurAetM.Text);
                double limite = double.Parse(textBoxLimite.Text);

                if (comboBoxContexte.SelectedIndex == 0)
                {
                    textBoxFleche.Text = formule.flecheConsoleChargePonctuelleExtremite(longueur, charge, momentInertie, moduleYoung).ToString();
                }

                else if (comboBoxContexte.SelectedIndex == 1)
                {
                    textBoxFleche.Text = formule.flecheConsoleChargePonctuelleDistanceA(longueur, dist_am, charge, momentInertie, moduleYoung).ToString();
                }

                else if (comboBoxContexte.SelectedIndex == 2)
                {
                    textBoxFleche.Text = formule.flecheConsoleChargeRepartieExtremite(longueur, charge, momentInertie, moduleYoung).ToString();
                }

                else if (comboBoxContexte.SelectedIndex == 3)
                {
                    textBoxFleche.Text = formule.flecheAppuisChargePonctuelleMillieu(longueur, charge, momentInertie, moduleYoung).ToString();
                }

                else if (comboBoxContexte.SelectedIndex == 4)
                {
                    textBoxFleche.Text = formule.flecheAppuisChargeRepartieLongueurM(longueur, charge, dist_am, momentInertie, moduleYoung).ToString();
                }

                else if (comboBoxContexte.SelectedIndex == 5)
                {
                    textBoxFleche.Text = formule.flecheAppuisChargeRepartie(longueur, charge, momentInertie, moduleYoung).ToString();
                }

                else if (comboBoxContexte.SelectedIndex == 6)
                {
                    textBoxFleche.Text = formule.flecheAppuisChargePonctuelleDistanceA(longueur, dist_am, charge, momentInertie, moduleYoung).ToString();
                }

                else if (comboBoxContexte.SelectedIndex == 7)
                {
                    textBoxFleche.Text = formule.flecheEncastreeChargePonctuelleMillieu(longueur, charge, momentInertie, moduleYoung).ToString();
                }

                else if (comboBoxContexte.SelectedIndex == 8)
                {
                    textBoxFleche.Text = formule.flecheEncastreeChargeRepartie(longueur, charge, momentInertie, moduleYoung).ToString();
                }

                else
                {
                    MessageBox.Show("Vous n'avez pas choisi de contexte.");
                }

                if (limite > formule.contrainte(longueur, hauteur, charge, momentInertie))
                {
                    conclusion = "\nLa poutre a résistée, la valeur de sa flèche maximale est de : " + textBoxFleche.Text + " m\n";
                    labelBool.Text = "oui";
                }

                else if (limite < formule.contrainte(longueur, hauteur, charge, momentInertie))
                {
                    conclusion = "\nLa poutre n'a pas résistée, la valeur de sa flèche maximale est de : " + textBoxFleche.Text + " m\n";
                    labelBool.Text = "non";

                    for (int i = 0; i < 10; i++)
                    {
                        this.Left += 10;
                        System.Threading.Thread.Sleep(10);
                        this.Left -= 10;
                        System.Threading.Thread.Sleep(10);
                    }
                }

                message = "------------------------------  " + date + " " + time + "  ------------------------------\n"
                    + "\nType de simulation :\n"
                    + "\n" + comboBoxContexte.Text + "\n"
                    + "\nParamètres :\n"
                    + "- longueur de la poutre : " + longueur.ToString() + " m\n"
                    + "- longueur a/m : " + dist_am.ToString() + " m\n"
                    + "- charge : " + charge.ToString() + " kg\n"
                    + "- matériau : " + comboBoxMateriau.Text + "\n"
                    + "- module d'Young : " + moduleYoung.ToString() + " Pa\n"
                    + "- type de section : " + comboBoxSection.Text + "\n"
                    + "- moment d'inertie : " + momentInertie.ToString() + " m^4\n"
                    + "- limite élastique : " + limite.ToString() + " Pa\n"
                    + conclusion;

                logger.Log(message);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Méthode affichant la valeur du module de Young dans la textBox correspondante
        /// en fonction du matériau choisi dans la comboBoxMateriau
        /// </summary>
        private void comboBoxMateriau_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxModule.Text = materiau[comboBoxMateriau.Text] + "000000000";
        }

        /// <summary>
        /// Méthode ouvrant le deuxieme formulaire
        /// </summary>
        private void comboBoxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            form2.forme = comboBoxSection.Text;
            form2.ShowDialog();
        }

        /// <summary>
        /// Méthode ouvrant le fichier de log
        /// </summary>
        private void buttonHistorique_Click(object sender, EventArgs e)
        {
            Process.Start(logger.Filepath);
        }

        /// <summary>
        /// Méthode permettant de choisir le fichier abaque et remplir la comboBoxMateriau
        /// </summary>
        private void buttonMateriau_Click(object sender, EventArgs e)
        {
            openFileDialogMateriau.ShowDialog();
            dataImport.FileToImport = openFileDialogMateriau.FileName;

            comboBoxMateriau.Items.Clear();

            materiau = dataImport.ImportDataFromFile();

            foreach (KeyValuePair<string, string> pair in materiau)
            {
                comboBoxMateriau.Items.Add(pair.Key);
            }
        }

        /// <summary>
        /// Méthode permettant de choisir son mode de saisie du module de Young
        /// </summary>
        private void checkBoxSaisieManuelle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSaisieManuelle.CheckState.ToString() == "Unchecked")
            {
                textBoxModule.ReadOnly = true;
                comboBoxMateriau.Enabled = true;
            }

            else
            {
                textBoxModule.ReadOnly = false;
                comboBoxMateriau.Enabled = false;
            }
        }

        /// <summary>
        /// Méthode surprenante, ne pas se spoiler et à tester directement dans l'application
        /// </summary>
        private void labelWTF_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            form3.Show();
        }
    }
}
