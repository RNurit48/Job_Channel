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

            //La Combobox est liée à une collection d'objets métiers 

            // Liaison entre la ComboBox et définition de l'élément à afficher, et celui utilisé
            #region CB_Poste

            bsPoste.DataSource = objcontroller.GetAllPostes();
            CB_Poste.DataSource = bsPoste;
            CB_Poste.DisplayMember = "Type";
            CB_Poste.ValueMember = "Id_Poste";
            #endregion
            #region CB_Contrat

            bsContrat.DataSource = objcontroller.GetAllContrats();
            CB_Contrat.DataSource = bsContrat;
            CB_Contrat.DisplayMember = "Type";
            CB_Contrat.ValueMember = "Id_Contrat";
            #endregion
            #region CB_Region

            bsRegion.DataSource = objcontroller.GetAllRegions();
            CB_Region.DataSource = bsRegion;
            CB_Region.DisplayMember = "Nom";
            CB_Region.ValueMember = "Id_Region";
            #endregion
        }

        #region CB_SelectedIndexChanged

        private void CB_Poste_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Quand un nouveau département est sélectionné dans la combo
            //Les employés du département sont affichés dans la DataGrid

            if (CB_Poste.SelectedValue != null)
            {
                PosteCourant = (Poste)CB_Poste.SelectedItem;
                bsPoste.DataSource = PosteCourant.Type;
               
            }

        }
        private void CB_Contrat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Contrat.SelectedValue != null)
            {
                ContratCourant = (Contrat)CB_Contrat.SelectedItem;
                bsContrat.DataSource = ContratCourant.Type;
            }

        }
        private void CB_Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Region.SelectedValue != null)
            {
                RegionCourant = (BO.Region)CB_Region.SelectedItem;
                bsRegion.DataSource = RegionCourant.Nom;
            }

        }
        #endregion

        private void BTN_Publier_Click(object sender, EventArgs e)
        {
                      
            Contrat c = (Contrat)CB_Contrat.SelectedItem;
            BO.Region r = (BO.Region)CB_Region.SelectedItem;
            Poste p = (Poste)CB_Poste.SelectedItem;

            
            Offre f = new Offre(TxB_Titre.Text, TxB_Description.Text, DTP_DatePublication.Value, r, c, p,TxB_Lien.Text);


            int resultat = objcontroller.PostOffre(f);

          
            
                MessageBox.Show($"{resultat} offre ajouté");
           
           
        }

        
    }
}
