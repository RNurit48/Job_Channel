using System.Drawing;

namespace Job_Channel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_Titre = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Publier = new System.Windows.Forms.Button();
            this.DTP_DatePublication = new System.Windows.Forms.DateTimePicker();
            this.TxB_Titre = new Job_Channel.TextBoxAdv();
            this.TxB_Description = new Job_Channel.TextBoxAdv();
            this.TxB_Lien = new Job_Channel.TextBoxAdv();
            this.CB_Poste = new System.Windows.Forms.ComboBox();
            this.CB_Contrat = new System.Windows.Forms.ComboBox();
            this.CB_Region = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Consulter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 331F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LBL_Titre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LBL_Titre
            // 
            this.LBL_Titre.AutoSize = true;
            this.LBL_Titre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Titre.Font = new System.Drawing.Font("Segoe Script", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titre.ForeColor = System.Drawing.Color.Black;
            this.LBL_Titre.Location = new System.Drawing.Point(274, 0);
            this.LBL_Titre.Name = "LBL_Titre";
            this.LBL_Titre.Size = new System.Drawing.Size(325, 93);
            this.LBL_Titre.TabIndex = 0;
            this.LBL_Titre.Text = "JOB CHANNEL";
            this.LBL_Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.BTN_Publier, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.DTP_DatePublication, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.TxB_Titre, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxB_Description, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxB_Lien, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.CB_Poste, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.CB_Contrat, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.CB_Region, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 96);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.03861F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.81081F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.615385F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.53846F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(265, 351);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // BTN_Publier
            // 
            this.BTN_Publier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Publier.Location = new System.Drawing.Point(3, 305);
            this.BTN_Publier.Name = "BTN_Publier";
            this.BTN_Publier.Size = new System.Drawing.Size(259, 43);
            this.BTN_Publier.TabIndex = 7;
            this.BTN_Publier.Text = "Valider";
            this.BTN_Publier.UseVisualStyleBackColor = true;
            this.BTN_Publier.Click += new System.EventHandler(this.BTN_Publier_Click);
            // 
            // DTP_DatePublication
            // 
            this.DTP_DatePublication.CalendarFont = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_DatePublication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTP_DatePublication.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_DatePublication.Location = new System.Drawing.Point(3, 143);
            this.DTP_DatePublication.MinDate = new System.DateTime(2020, 3, 2, 0, 0, 0, 0);
            this.DTP_DatePublication.Name = "DTP_DatePublication";
            this.DTP_DatePublication.Size = new System.Drawing.Size(259, 20);
            this.DTP_DatePublication.TabIndex = 8;
            // 
            // TxB_Titre
            // 
            this.TxB_Titre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxB_Titre.ForeColor = System.Drawing.Color.Gray;
            this.TxB_Titre.Location = new System.Drawing.Point(3, 3);
            this.TxB_Titre.Multiline = true;
            this.TxB_Titre.Name = "TxB_Titre";
            this.TxB_Titre.Size = new System.Drawing.Size(259, 37);
            this.TxB_Titre.TabIndex = 9;
            this.TxB_Titre.Text = "Entrer le titre de l\'offre";
            // 
            // TxB_Description
            // 
            this.TxB_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxB_Description.ForeColor = System.Drawing.Color.Gray;
            this.TxB_Description.Location = new System.Drawing.Point(3, 46);
            this.TxB_Description.Multiline = true;
            this.TxB_Description.Name = "TxB_Description";
            this.TxB_Description.Size = new System.Drawing.Size(259, 37);
            this.TxB_Description.TabIndex = 10;
            this.TxB_Description.Text = "Entrer la description de l\'offre";
            // 
            // TxB_Lien
            // 
            this.TxB_Lien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxB_Lien.ForeColor = System.Drawing.Color.Gray;
            this.TxB_Lien.Location = new System.Drawing.Point(3, 168);
            this.TxB_Lien.Multiline = true;
            this.TxB_Lien.Name = "TxB_Lien";
            this.TxB_Lien.Size = new System.Drawing.Size(259, 89);
            this.TxB_Lien.TabIndex = 13;
            this.TxB_Lien.Text = "Entrer le lien de l\'offre";
            // 
            // CB_Poste
            // 
            this.CB_Poste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Poste.FormattingEnabled = true;
            this.CB_Poste.Location = new System.Drawing.Point(3, 89);
            this.CB_Poste.Name = "CB_Poste";
            this.CB_Poste.Size = new System.Drawing.Size(259, 21);
            this.CB_Poste.TabIndex = 15;
            this.CB_Poste.Text = "Poste proposé";
            // 
            // CB_Contrat
            // 
            this.CB_Contrat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Contrat.FormattingEnabled = true;
            this.CB_Contrat.Location = new System.Drawing.Point(3, 115);
            this.CB_Contrat.Name = "CB_Contrat";
            this.CB_Contrat.Size = new System.Drawing.Size(259, 21);
            this.CB_Contrat.TabIndex = 16;
            this.CB_Contrat.Text = "Contrat proposé";
            // 
            // CB_Region
            // 
            this.CB_Region.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Region.FormattingEnabled = true;
            this.CB_Region.Location = new System.Drawing.Point(3, 270);
            this.CB_Region.Name = "CB_Region";
            this.CB_Region.Size = new System.Drawing.Size(259, 21);
            this.CB_Region.TabIndex = 17;
            this.CB_Region.Text = "Région de l\'offre";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.BTN_Consulter, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(274, 96);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 351F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(325, 351);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // BTN_Consulter
            // 
            this.BTN_Consulter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Consulter.Location = new System.Drawing.Point(3, 3);
            this.BTN_Consulter.Name = "BTN_Consulter";
            this.BTN_Consulter.Size = new System.Drawing.Size(319, 345);
            this.BTN_Consulter.TabIndex = 1;
            this.BTN_Consulter.Text = "Consulter";
            this.BTN_Consulter.UseVisualStyleBackColor = true;
            this.BTN_Consulter.Click += new System.EventHandler(this.BTN_Consulter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(605, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 93);
            this.label1.TabIndex = 5;
            this.label1.Text = "Publier une offre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

      

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LBL_Titre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
       
        private System.Windows.Forms.Button BTN_Publier;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BTN_Consulter;
        private System.Windows.Forms.DateTimePicker DTP_DatePublication;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TextBoxAdv TxB_Titre;
        private TextBoxAdv TxB_Description;
        private TextBoxAdv TxB_Lien;
        private System.Windows.Forms.ComboBox CB_Poste;
        private System.Windows.Forms.BindingSource BindingSourcePoste;
        private System.Windows.Forms.ComboBox CB_Contrat;
        private System.Windows.Forms.ComboBox CB_Region;
        private System.Windows.Forms.Label label1;
    }
}

