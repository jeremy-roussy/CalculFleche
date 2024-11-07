
using System.Windows.Forms;

namespace CalculFleche
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxContexte = new System.Windows.Forms.ComboBox();
            this.labelLongueur = new System.Windows.Forms.Label();
            this.labelCharge = new System.Windows.Forms.Label();
            this.labelMateriau = new System.Windows.Forms.Label();
            this.labelSection = new System.Windows.Forms.Label();
            this.buttonCalculer = new System.Windows.Forms.Button();
            this.groupBoxParametres = new System.Windows.Forms.GroupBox();
            this.textBoxLimite = new System.Windows.Forms.TextBox();
            this.labelLimite = new System.Windows.Forms.Label();
            this.textBoxLongueurAetM = new System.Windows.Forms.TextBox();
            this.labelLongueurAetM = new System.Windows.Forms.Label();
            this.checkBoxSaisieManuelle = new System.Windows.Forms.CheckBox();
            this.labelWTF = new System.Windows.Forms.Label();
            this.labelMoment = new System.Windows.Forms.Label();
            this.labelModule = new System.Windows.Forms.Label();
            this.textBoxMoment = new System.Windows.Forms.TextBox();
            this.textBoxModule = new System.Windows.Forms.TextBox();
            this.textBoxCharge = new System.Windows.Forms.TextBox();
            this.textBoxLongueur = new System.Windows.Forms.TextBox();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.comboBoxMateriau = new System.Windows.Forms.ComboBox();
            this.groupBoxResultats = new System.Windows.Forms.GroupBox();
            this.textBoxFleche = new System.Windows.Forms.TextBox();
            this.labelBool = new System.Windows.Forms.Label();
            this.labelSupport = new System.Windows.Forms.Label();
            this.labelFleche = new System.Windows.Forms.Label();
            this.buttonMateriau = new System.Windows.Forms.Button();
            this.openFileDialogMateriau = new System.Windows.Forms.OpenFileDialog();
            this.buttonHistorique = new System.Windows.Forms.Button();
            this.pictureBoxContext = new System.Windows.Forms.PictureBox();
            this.imageListContexte = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxParametres.SuspendLayout();
            this.groupBoxResultats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContext)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxContexte
            // 
            this.comboBoxContexte.FormattingEnabled = true;
            this.comboBoxContexte.Items.AddRange(new object[] {
            "Poutre console avec charge ponctuelle p à une extrémité",
            "Poutre console avec charge ponctuelle p à une distance a",
            "Poutre console avec une charge p uniformément répartie",
            "Poutre sur deux appuis simples avec une charge ponctuelle p au millieu",
            "Poutre sur deux appuis simples avec une charge p uniformément répartie sur une lo" +
                "ngueur m",
            "Poutre sur deux appuis simples avec une charge p uniformément répartie",
            "Poutre sur deux appuis simples avec une charge ponctuelle p à une distance a",
            "Poutre bi-encastrée avec une charge ponctuelle p au millieu",
            "Poutre bi-encastrée avec une charge p uniformément répartie"});
            this.comboBoxContexte.Location = new System.Drawing.Point(14, 13);
            this.comboBoxContexte.Name = "comboBoxContexte";
            this.comboBoxContexte.Size = new System.Drawing.Size(775, 24);
            this.comboBoxContexte.TabIndex = 0;
            this.comboBoxContexte.Text = "-- Veuillez choisir le contexte --";
            this.comboBoxContexte.SelectedIndexChanged += new System.EventHandler(this.comboBoxContexte_SelectedIndexChanged);
            // 
            // labelLongueur
            // 
            this.labelLongueur.AutoSize = true;
            this.labelLongueur.Location = new System.Drawing.Point(6, 43);
            this.labelLongueur.Name = "labelLongueur";
            this.labelLongueur.Size = new System.Drawing.Size(202, 17);
            this.labelLongueur.TabIndex = 1;
            this.labelLongueur.Text = "Longueur de la poutre (en m) :";
            // 
            // labelCharge
            // 
            this.labelCharge.AutoSize = true;
            this.labelCharge.Location = new System.Drawing.Point(6, 78);
            this.labelCharge.Name = "labelCharge";
            this.labelCharge.Size = new System.Drawing.Size(128, 17);
            this.labelCharge.TabIndex = 2;
            this.labelCharge.Text = "Charge appliquée :";
            // 
            // labelMateriau
            // 
            this.labelMateriau.AutoSize = true;
            this.labelMateriau.Location = new System.Drawing.Point(6, 113);
            this.labelMateriau.Name = "labelMateriau";
            this.labelMateriau.Size = new System.Drawing.Size(71, 17);
            this.labelMateriau.TabIndex = 3;
            this.labelMateriau.Text = "Matériau :";
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.Location = new System.Drawing.Point(6, 148);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(140, 17);
            this.labelSection.TabIndex = 4;
            this.labelSection.Text = "Forme de la section :";
            // 
            // buttonCalculer
            // 
            this.buttonCalculer.Location = new System.Drawing.Point(362, 416);
            this.buttonCalculer.Name = "buttonCalculer";
            this.buttonCalculer.Size = new System.Drawing.Size(75, 25);
            this.buttonCalculer.TabIndex = 5;
            this.buttonCalculer.Text = "Calculer";
            this.buttonCalculer.UseVisualStyleBackColor = true;
            this.buttonCalculer.Click += new System.EventHandler(this.buttonCalculer_Click);
            // 
            // groupBoxParametres
            // 
            this.groupBoxParametres.Controls.Add(this.textBoxLimite);
            this.groupBoxParametres.Controls.Add(this.labelLimite);
            this.groupBoxParametres.Controls.Add(this.textBoxLongueurAetM);
            this.groupBoxParametres.Controls.Add(this.labelLongueurAetM);
            this.groupBoxParametres.Controls.Add(this.checkBoxSaisieManuelle);
            this.groupBoxParametres.Controls.Add(this.labelWTF);
            this.groupBoxParametres.Controls.Add(this.labelMoment);
            this.groupBoxParametres.Controls.Add(this.labelModule);
            this.groupBoxParametres.Controls.Add(this.textBoxMoment);
            this.groupBoxParametres.Controls.Add(this.textBoxModule);
            this.groupBoxParametres.Controls.Add(this.textBoxCharge);
            this.groupBoxParametres.Controls.Add(this.textBoxLongueur);
            this.groupBoxParametres.Controls.Add(this.comboBoxSection);
            this.groupBoxParametres.Controls.Add(this.comboBoxMateriau);
            this.groupBoxParametres.Controls.Add(this.labelMateriau);
            this.groupBoxParametres.Controls.Add(this.labelLongueur);
            this.groupBoxParametres.Controls.Add(this.labelSection);
            this.groupBoxParametres.Controls.Add(this.labelCharge);
            this.groupBoxParametres.Location = new System.Drawing.Point(14, 50);
            this.groupBoxParametres.Name = "groupBoxParametres";
            this.groupBoxParametres.Size = new System.Drawing.Size(774, 229);
            this.groupBoxParametres.TabIndex = 6;
            this.groupBoxParametres.TabStop = false;
            this.groupBoxParametres.Text = "Choix des paramètres";
            // 
            // textBoxLimite
            // 
            this.textBoxLimite.Location = new System.Drawing.Point(215, 180);
            this.textBoxLimite.Name = "textBoxLimite";
            this.textBoxLimite.Size = new System.Drawing.Size(121, 22);
            this.textBoxLimite.TabIndex = 19;
            // 
            // labelLimite
            // 
            this.labelLimite.AutoSize = true;
            this.labelLimite.Location = new System.Drawing.Point(6, 183);
            this.labelLimite.Name = "labelLimite";
            this.labelLimite.Size = new System.Drawing.Size(165, 17);
            this.labelLimite.TabIndex = 18;
            this.labelLimite.Text = "Limite élastique (en Pa) :";
            // 
            // textBoxLongueurAetM
            // 
            this.textBoxLongueurAetM.Location = new System.Drawing.Point(584, 40);
            this.textBoxLongueurAetM.Name = "textBoxLongueurAetM";
            this.textBoxLongueurAetM.Size = new System.Drawing.Size(121, 22);
            this.textBoxLongueurAetM.TabIndex = 17;
            this.textBoxLongueurAetM.Text = "0";
            // 
            // labelLongueurAetM
            // 
            this.labelLongueurAetM.AutoSize = true;
            this.labelLongueurAetM.Location = new System.Drawing.Point(399, 43);
            this.labelLongueurAetM.Name = "labelLongueurAetM";
            this.labelLongueurAetM.Size = new System.Drawing.Size(165, 17);
            this.labelLongueurAetM.TabIndex = 16;
            this.labelLongueurAetM.Text = "Longueur a et m (en m) :";
            // 
            // checkBoxSaisieManuelle
            // 
            this.checkBoxSaisieManuelle.AutoSize = true;
            this.checkBoxSaisieManuelle.Location = new System.Drawing.Point(585, 77);
            this.checkBoxSaisieManuelle.Name = "checkBoxSaisieManuelle";
            this.checkBoxSaisieManuelle.Size = new System.Drawing.Size(129, 21);
            this.checkBoxSaisieManuelle.TabIndex = 15;
            this.checkBoxSaisieManuelle.Text = "Saisie manuelle";
            this.checkBoxSaisieManuelle.UseVisualStyleBackColor = true;
            this.checkBoxSaisieManuelle.CheckedChanged += new System.EventHandler(this.checkBoxSaisieManuelle_CheckedChanged);
            // 
            // labelWTF
            // 
            this.labelWTF.AutoSize = true;
            this.labelWTF.BackColor = System.Drawing.SystemColors.Control;
            this.labelWTF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelWTF.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelWTF.Location = new System.Drawing.Point(750, 11);
            this.labelWTF.Name = "labelWTF";
            this.labelWTF.Size = new System.Drawing.Size(20, 17);
            this.labelWTF.TabIndex = 13;
            this.labelWTF.Text = "   ";
            this.labelWTF.Click += new System.EventHandler(this.labelWTF_Click);
            // 
            // labelMoment
            // 
            this.labelMoment.AutoSize = true;
            this.labelMoment.Location = new System.Drawing.Point(399, 148);
            this.labelMoment.Name = "labelMoment";
            this.labelMoment.Size = new System.Drawing.Size(180, 17);
            this.labelMoment.TabIndex = 12;
            this.labelMoment.Text = "Moment d\'inertie (en m^4) :";
            // 
            // labelModule
            // 
            this.labelModule.AutoSize = true;
            this.labelModule.Location = new System.Drawing.Point(399, 113);
            this.labelModule.Name = "labelModule";
            this.labelModule.Size = new System.Drawing.Size(169, 17);
            this.labelModule.TabIndex = 11;
            this.labelModule.Text = "Module d\'Young (en Pa) :";
            // 
            // textBoxMoment
            // 
            this.textBoxMoment.Location = new System.Drawing.Point(585, 145);
            this.textBoxMoment.Name = "textBoxMoment";
            this.textBoxMoment.ReadOnly = true;
            this.textBoxMoment.Size = new System.Drawing.Size(120, 22);
            this.textBoxMoment.TabIndex = 10;
            // 
            // textBoxModule
            // 
            this.textBoxModule.Location = new System.Drawing.Point(585, 110);
            this.textBoxModule.Name = "textBoxModule";
            this.textBoxModule.ReadOnly = true;
            this.textBoxModule.Size = new System.Drawing.Size(120, 22);
            this.textBoxModule.TabIndex = 9;
            // 
            // textBoxCharge
            // 
            this.textBoxCharge.Location = new System.Drawing.Point(215, 75);
            this.textBoxCharge.Name = "textBoxCharge";
            this.textBoxCharge.Size = new System.Drawing.Size(121, 22);
            this.textBoxCharge.TabIndex = 8;
            // 
            // textBoxLongueur
            // 
            this.textBoxLongueur.Location = new System.Drawing.Point(215, 40);
            this.textBoxLongueur.Name = "textBoxLongueur";
            this.textBoxLongueur.Size = new System.Drawing.Size(121, 22);
            this.textBoxLongueur.TabIndex = 7;
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Items.AddRange(new object[] {
            "Rectangulaire",
            "Circulaire",
            "Annulaire",
            "Triangulaire",
            "Exagonale",
            "IPN"});
            this.comboBoxSection.Location = new System.Drawing.Point(215, 145);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSection.TabIndex = 6;
            this.comboBoxSection.Text = "-- Sélectionnez le type de section --";
            this.comboBoxSection.SelectedIndexChanged += new System.EventHandler(this.comboBoxSection_SelectedIndexChanged);
            // 
            // comboBoxMateriau
            // 
            this.comboBoxMateriau.FormattingEnabled = true;
            this.comboBoxMateriau.Location = new System.Drawing.Point(215, 110);
            this.comboBoxMateriau.Name = "comboBoxMateriau";
            this.comboBoxMateriau.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMateriau.TabIndex = 5;
            this.comboBoxMateriau.Text = "-- Selectionnez le matériau --";
            this.comboBoxMateriau.SelectedIndexChanged += new System.EventHandler(this.comboBoxMateriau_SelectedIndexChanged);
            // 
            // groupBoxResultats
            // 
            this.groupBoxResultats.Controls.Add(this.textBoxFleche);
            this.groupBoxResultats.Controls.Add(this.labelBool);
            this.groupBoxResultats.Controls.Add(this.labelSupport);
            this.groupBoxResultats.Controls.Add(this.labelFleche);
            this.groupBoxResultats.Location = new System.Drawing.Point(14, 285);
            this.groupBoxResultats.Name = "groupBoxResultats";
            this.groupBoxResultats.Size = new System.Drawing.Size(774, 118);
            this.groupBoxResultats.TabIndex = 7;
            this.groupBoxResultats.TabStop = false;
            this.groupBoxResultats.Text = "Résultats";
            // 
            // textBoxFleche
            // 
            this.textBoxFleche.Location = new System.Drawing.Point(194, 47);
            this.textBoxFleche.Name = "textBoxFleche";
            this.textBoxFleche.ReadOnly = true;
            this.textBoxFleche.Size = new System.Drawing.Size(156, 22);
            this.textBoxFleche.TabIndex = 3;
            // 
            // labelBool
            // 
            this.labelBool.AutoSize = true;
            this.labelBool.Location = new System.Drawing.Point(642, 50);
            this.labelBool.Name = "labelBool";
            this.labelBool.Size = new System.Drawing.Size(0, 17);
            this.labelBool.TabIndex = 2;
            // 
            // labelSupport
            // 
            this.labelSupport.AutoSize = true;
            this.labelSupport.Location = new System.Drawing.Point(506, 50);
            this.labelSupport.Name = "labelSupport";
            this.labelSupport.Size = new System.Drawing.Size(130, 17);
            this.labelSupport.TabIndex = 1;
            this.labelSupport.Text = "Charge supportée :";
            // 
            // labelFleche
            // 
            this.labelFleche.AutoSize = true;
            this.labelFleche.Location = new System.Drawing.Point(9, 50);
            this.labelFleche.Name = "labelFleche";
            this.labelFleche.Size = new System.Drawing.Size(179, 17);
            this.labelFleche.TabIndex = 0;
            this.labelFleche.Text = "Valeur de la flèche (en m) :";
            // 
            // buttonMateriau
            // 
            this.buttonMateriau.Location = new System.Drawing.Point(14, 416);
            this.buttonMateriau.Name = "buttonMateriau";
            this.buttonMateriau.Size = new System.Drawing.Size(155, 25);
            this.buttonMateriau.TabIndex = 8;
            this.buttonMateriau.Text = "Import des matériaux";
            this.buttonMateriau.UseVisualStyleBackColor = true;
            this.buttonMateriau.Click += new System.EventHandler(this.buttonMateriau_Click);
            // 
            // openFileDialogMateriau
            // 
            this.openFileDialogMateriau.FileName = "openFileDialog1";
            // 
            // buttonHistorique
            // 
            this.buttonHistorique.Location = new System.Drawing.Point(630, 416);
            this.buttonHistorique.Name = "buttonHistorique";
            this.buttonHistorique.Size = new System.Drawing.Size(158, 25);
            this.buttonHistorique.TabIndex = 10;
            this.buttonHistorique.Text = "Historique des calculs";
            this.buttonHistorique.UseVisualStyleBackColor = true;
            this.buttonHistorique.Click += new System.EventHandler(this.buttonHistorique_Click);
            // 
            // pictureBoxContext
            // 
            this.pictureBoxContext.Location = new System.Drawing.Point(794, 13);
            this.pictureBoxContext.Name = "pictureBoxContext";
            this.pictureBoxContext.Size = new System.Drawing.Size(454, 428);
            this.pictureBoxContext.TabIndex = 11;
            this.pictureBoxContext.TabStop = false;
            // 
            // imageListContexte
            // 
            this.imageListContexte.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListContexte.ImageStream")));
            this.imageListContexte.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListContexte.Images.SetKeyName(0, "montage1.jpg");
            this.imageListContexte.Images.SetKeyName(1, "montage2.jpg");
            this.imageListContexte.Images.SetKeyName(2, "montage3.jpg");
            this.imageListContexte.Images.SetKeyName(3, "montage4.jpg");
            this.imageListContexte.Images.SetKeyName(4, "montage5.jpg");
            this.imageListContexte.Images.SetKeyName(5, "montage6.jpg");
            this.imageListContexte.Images.SetKeyName(6, "montage7.jpg");
            this.imageListContexte.Images.SetKeyName(7, "montage8.jpg");
            this.imageListContexte.Images.SetKeyName(8, "montage9.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1254, 450);
            this.Controls.Add(this.pictureBoxContext);
            this.Controls.Add(this.buttonHistorique);
            this.Controls.Add(this.buttonMateriau);
            this.Controls.Add(this.groupBoxResultats);
            this.Controls.Add(this.groupBoxParametres);
            this.Controls.Add(this.buttonCalculer);
            this.Controls.Add(this.comboBoxContexte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1272, 497);
            this.MinimumSize = new System.Drawing.Size(1272, 497);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcul de la flèche";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxParametres.ResumeLayout(false);
            this.groupBoxParametres.PerformLayout();
            this.groupBoxResultats.ResumeLayout(false);
            this.groupBoxResultats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxContexte;
        private System.Windows.Forms.Label labelLongueur;
        private System.Windows.Forms.Label labelCharge;
        private System.Windows.Forms.Label labelMateriau;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.Button buttonCalculer;
        private System.Windows.Forms.GroupBox groupBoxParametres;
        private System.Windows.Forms.GroupBox groupBoxResultats;
        private System.Windows.Forms.Label labelSupport;
        private System.Windows.Forms.Label labelFleche;
        private System.Windows.Forms.TextBox textBoxCharge;
        private System.Windows.Forms.TextBox textBoxLongueur;
        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.ComboBox comboBoxMateriau;
        private System.Windows.Forms.TextBox textBoxFleche;
        private System.Windows.Forms.Label labelBool;
        private System.Windows.Forms.Label labelMoment;
        private System.Windows.Forms.Label labelModule;
        private System.Windows.Forms.TextBox textBoxMoment;
        private System.Windows.Forms.TextBox textBoxModule;
        private System.Windows.Forms.Button buttonMateriau;
        private System.Windows.Forms.OpenFileDialog openFileDialogMateriau;
        private System.Windows.Forms.Button buttonHistorique;
        private Label labelWTF;
        private CheckBox checkBoxSaisieManuelle;
        private PictureBox pictureBoxContext;
        private ImageList imageListContexte;
        private Label labelLongueurAetM;
        private TextBox textBoxLongueurAetM;
        private TextBox textBoxLimite;
        private Label labelLimite;

        public TextBox TextBoxMoment { get => textBoxMoment; set => textBoxMoment = value; }
    }
}

