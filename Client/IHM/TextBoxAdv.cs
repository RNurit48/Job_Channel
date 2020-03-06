using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Channel
{
    class TextBoxAdv : TextBox
    {
        string infos = "";
        ToolTip toolTip = new ToolTip();
      
        

        public TextBoxAdv(): base() {
            MouseClick += TextBoxAdv_MouseClick;
            MouseLeave += TextBoxAdv_Leave;
            DoubleBuffered = true;
            infos = "";
                    
            toolTip.AutoPopDelay = 2000;
            toolTip.InitialDelay = 100;
            toolTip.ReshowDelay = 1000;
            toolTip.ShowAlways = true;


        }
        public TextBoxAdv(string messageInfo) : base()
        {
            DoubleBuffered = true;
            infos = messageInfo;


            toolTip.AutoPopDelay = 2000;
            toolTip.InitialDelay = 100;
            toolTip.ReshowDelay = 1000;
            toolTip.ShowAlways = true;

        }

       

        private void TextBoxAdv_MouseClick(object sender, EventArgs e)
        {

            toolTip.Show(infos, this);
                       
            switch (Name)
            {    
                    case "TxB_Titre": if (Text == "Entrer le titre de l\'offre") { Text = infos; }; break;
                    case "TxB_Description":if (Text == "Entrer la description de l\'offre") { Text = infos; }; break;
                    case "TxB_Lien": if (Text == "Entrer le lien de l\'offre") { Text = infos; }; break;
                 
                    default: break; 
            }

        }
        private void TextBoxAdv_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Text))
            {
                switch (Name)
                {
                    case "TxB_Titre": Text = "Entrer le titre de l\'offre"; break;
                    case "TxB_Description": Text = "Entrer la description de l\'offre"; break; 
                    case "TxB_Lien": Text = "Entrer le lien de l\'offre"; break;
                        
                }
            }
            toolTip.Hide(this);
        }
    }
}
