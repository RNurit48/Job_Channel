using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Job_Channel
{
    public partial class Form1 : Form
    {
        ToolTip title_tool = new ToolTip();
        private Controller objcontroller;

        #region BindingSources

        #region Poste
        private BindingSource bsPoste = new BindingSource();
        private Poste PosteCourant;
        #endregion
        #region Contrat
        private BindingSource bsContrat = new BindingSource();
        private Contrat ContratCourant;
        #endregion
        #region Region
        private BindingSource bsRegion = new BindingSource();
        private BO.Region RegionCourant;
        #endregion
        #endregion
        public Form1()
        {
         
            InitializeComponent();
            objcontroller = new Controller();
            title_tool.SetToolTip(DTP_DatePublication, "Date  de publication de l'offre");
            BTN_Publier.Enabled = false;

            //La Combobox est liée à une collection d'objets métiers 

            // Liaison entre la ComboBox et définition de l'élément à afficher, et celui utilisé
            #region CB_Poste

            List<Poste> ListPostes = new List<Poste>
            {
                new Poste() { Id_Poste = -1, Type = "--  Type poste  --" }
            };
            ListPostes.AddRange(objcontroller.GetAllPostes());
            bsPoste.DataSource = ListPostes;
            CB_Poste.DataSource = bsPoste;

            //bsPoste.DataSource = objcontroller.GetAllPostes();
            //CB_Poste.DataSource = bsPoste;
            CB_Poste.DisplayMember = "Type";
            CB_Poste.ValueMember = "Id_Poste";
            #endregion
            #region CB_Contrat

            List<Contrat> ListContrat = new List<Contrat>
            {
                new Contrat() { Id_Contrat = -1, Type = "--  Type Contrat  --" }
            };
            ListContrat.AddRange(objcontroller.GetAllContrats());
            bsContrat.DataSource = ListContrat;
            CB_Contrat.DataSource = bsContrat;

            //bsContrat.DataSource = objcontroller.GetAllContrats();
            //CB_Contrat.DataSource = bsContrat;
            CB_Contrat.DisplayMember = "Type";
            CB_Contrat.ValueMember = "Id_Contrat";
            #endregion
            #region CB_Region

            List<BO.Region> listRegions = new List<BO.Region>
            {
                new BO.Region() { Id_Region = -1, Nom = "--  Region  --" }
            };
            listRegions.AddRange(objcontroller.GetAllRegions());
            bsRegion.DataSource = listRegions;
            CB_Region.DataSource = bsRegion;

            //bsRegion.DataSource = objcontroller.GetAllRegions();
            //CB_Region.DataSource = bsRegion;
            CB_Region.DisplayMember = "Nom";
            CB_Region.ValueMember = "Id_Region";
            this.CB_Poste.SelectedIndexChanged += new System.EventHandler(this.CB_Poste_SelectedIndexChanged);
            this.CB_Contrat.SelectedIndexChanged += new System.EventHandler(this.CB_Contrat_SelectedIndexChanged);
            this.CB_Region.SelectedIndexChanged += new System.EventHandler(this.CB_Region_SelectedIndexChanged);
            #endregion
        }

        #region CB_SelectedIndexChanged

        private void CB_Poste_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Quand un nouveau département est sélectionné dans la combo
            //Les employés du département sont affichés dans la DataGrid

            if (((Poste)CB_Poste.SelectedItem).Id_Poste != -1)
            {
                PosteCourant = (Poste)CB_Poste.SelectedItem;
                BTN_Publier.Enabled = true;
            }
            else
            {
                BTN_Publier.Enabled = false;
            }
        }

        private void CB_Contrat_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (((Contrat)CB_Contrat.SelectedItem).Id_Contrat != -1)
            {
                ContratCourant = (Contrat)CB_Contrat.SelectedItem;
              
                BTN_Publier.Enabled = true;
            }
            else
            {
                BTN_Publier.Enabled = false;
            }
        }

        private void CB_Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((BO.Region)CB_Region.SelectedItem).Id_Region != -1)
            {
                RegionCourant = (BO.Region)CB_Region.SelectedItem;
                BTN_Publier.Enabled = true;
            }
            else
            {
                BTN_Publier.Enabled = false;
            }

        }


        #endregion

        private void BTN_Publier_Click(object sender, EventArgs e)
        {
          
            
            Contrat c = (Contrat)CB_Contrat.SelectedItem;
            BO.Region r = (BO.Region)CB_Region.SelectedItem;
            Poste p = (Poste)CB_Poste.SelectedItem;

            
            Offre f = new Offre(TxB_Titre.Text, TxB_Description.Text, DTP_DatePublication.Value, r, c, p,TxB_Lien.Text);


            int resultat = Convert.ToInt32(objcontroller.PostOffre(f));

          



            
                MessageBox.Show($"{resultat} offre ajouté");
           
           
        }

        private void BTN_Consulter_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }

       
    }
}
