using BLL;
using BO;
using BO.DTO;
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
    public partial class Form2 : Form
    {
        private void AppelDonnées()
        {

            BindingSourceOffre.DataSource = controller.GetAllOffres();
            DGV_Offre.DataSource = BindingSourceOffre;
        }

        private Controller controller = new Controller();
        private BO.Region RegionCourante = null;
        private Contrat ContratCourant = null;
        private Poste PosteCourant = null;
        private Filtre filterOffreRequest = new Filtre();


        #region BindingSources

        private BindingSource BindingSourceOffre = new BindingSource();
      
        #endregion
        public Form2()
        {          
            InitializeComponent();

            AppelDonnées();
            #region ComboBox
            CB_Contrat.DataSource = controller.GetAllContrats();
            CB_Poste.DataSource = controller.GetAllPostes();
            CB_Region.DataSource = controller.GetAllRegions();
            #endregion

            #region Filtre
            CB_FiltreR.DataSource = controller.GetAllRegions();
            CB_FiltreP.DataSource = controller.GetAllPostes();
            CB_FiltreC.DataSource = controller.GetAllContrats();

            /// Ajout aux combobox d'une valeur par défaut 
            List<Contrat> ListContrat = new List<Contrat>
            {
                new Contrat() { Id_Contrat = -1, Type = "--  Filtre Contrat  --" }
            };
            ListContrat.AddRange(controller.GetAllContrats());
            CB_FiltreC.DataSource = ListContrat;

            List<Poste> ListPostes = new List<Poste>
            {
                new Poste() { Id_Poste = -1, Type = "--  Filtre poste  --" }
            };
            ListPostes.AddRange(controller.GetAllPostes());
            CB_FiltreP.DataSource = ListPostes;

            List<BO.Region> listRegions = new List<BO.Region>
            {
                new BO.Region() { Id_Region = -1, Nom = "--  Filtre region  --" }
            };
            listRegions.AddRange(controller.GetAllRegions());
            CB_FiltreR.DataSource = listRegions;
            #endregion
        }

        private void DGV_Offre_SelectionChanged(object sender, EventArgs e)
        { 

            CB_Poste.Text = DGV_Offre.CurrentRow.Cells["Poste"].Value.ToString();
            CB_Region.Text = DGV_Offre.CurrentRow.Cells["Region"].Value.ToString();
            CB_Contrat.Text = DGV_Offre.CurrentRow.Cells["Contrat"].Value.ToString();
            TxB_Titre.Text = DGV_Offre.CurrentRow.Cells["Titre"].Value.ToString();
            TxB_Lien.Text = DGV_Offre.CurrentRow.Cells["Lien"].Value.ToString();
            TxB_Descri.Text = DGV_Offre.CurrentRow.Cells["Description"].Value.ToString();
            DTP_Publi.Text = DGV_Offre.CurrentRow.Cells["DatePublication"].Value.ToString();
                      

        }


        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            #region Mise à jour
            Contrat c = (Contrat)CB_Contrat.SelectedItem;
            BO.Region r = (BO.Region)CB_Region.SelectedItem;
            Poste p = (Poste)CB_Poste.SelectedItem;

            Offre f = new Offre(TxB_Titre.Text, TxB_Descri.Text, DTP_Publi.Value, r, c, p, TxB_Lien.Text, Convert.ToInt32(DGV_Offre.CurrentRow.Cells["NUMOFFRE"].Value));
            int resultat = controller.UpdateOffre(f);

            MessageBox.Show($"{resultat} offre mise à jour");
            #endregion

            AppelDonnées();
        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            #region Delete
            if ((MessageBox.Show(Properties.Settings.Default.Confirmation, Properties.Settings.Default.TitreSuppr, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))

            {
                Offre f = new Offre(Convert.ToInt32(DGV_Offre.CurrentRow.Cells["NUMOFFRE"].Value));
                int resultat = controller.DeleteOffre(f);

                MessageBox.Show($"{resultat} offre supprimée");
                
                
            }
#endregion

            AppelDonnées();           
        }

        private void CB_FiltreR_SelectedIndexChanged(object sender, EventArgs e)
        {
            BO.Region region = (BO.Region)CB_FiltreR.SelectedValue;
            if (region.Id_Region != -1)
            {
               filterOffreRequest.region = region;
            }
            else filterOffreRequest.region = null;

        }

        private void  CB_FilterC_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshOffreSelectioned();
        }

        private void CB_FilterP_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshOffreSelectioned();
        }

        public  void RefreshOffreSelectioned()
        {

            BO.Region region = (BO.Region)CB_FiltreR.SelectedItem;
            Contrat contrat = (Contrat)CB_FiltreC.SelectedItem;
            Poste poste = (Poste)CB_FiltreP.SelectedItem;
            

            // Fix Bug out of Range exception
            offreSource.DataSource = null;

            try
            {
                var t = controller.GetAllOffres(new FilterOffreRequest(region, contrat, poste));
                offreSource.DataSource = t.Result;

            }
            catch { }

            if (DGV_Offre.RowCount > 0)
            {
                this.DGV_Offre.Columns["Id"].Visible = false;
            }

           
        }
    }
}
