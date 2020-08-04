using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Launcher
{
    public partial class CustomMessageBox : Form
    {
        #region Variables
        [DllImportAttribute("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr LoadImage(int Hinstance, string name, int type, int width, int height, int load);
        private RegistryView rV;
        #endregion

        #region Initialisation
        /// <summary>
        /// Cette méthode est exécutée à l'appel de la form
        /// </summary>
        /// <param name="q">Question à afficher</param>
        /// <param name="rV">Type de registre (32 ou 64 bits)</param>
        public CustomMessageBox(string q, RegistryView rV)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; //On affiche la messageBox au centre de l'écran
            PictureBox.Image = Bitmap.FromHicon(new Icon(SystemIcons.Question, new Size(48, 48)).Handle); //On défini l'icône de la form comme étant un point d'interrogation
            Texte.Text = q; //On affiche la question voulue
            Texte.TextAlign = ContentAlignment.MiddleCenter; //On centre la question dans la zone de texte
            this.rV = rV;
        }
        #endregion

        #region Evénements

        /// <summary>
        /// Cette méthode s'exécute lorsque l'utilisateur cliques sur le bouton "Oui"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Oui_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.SBiiXpress.fr"); //On ouvre la page d'accueil du site
            this.Close(); //On ferme la messageBox
        }

        /// <summary>
        /// Cette méthode s'exécute lorsque l'utilisateur clique sur "Non"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Non_Click(object sender, EventArgs e)
        {
            this.Close(); //On ferme la messageBox
        }

        /// <summary>
        /// Cette méthode s'exécute lorsque l'utilisateur ferme la messageBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomMessageBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Cb_NePlusDemander.Checked)
            {
                Registre.EcrireRegistre(@"SOFTWARE\\SBiiXpress\\", "NePlusDemander", 1, RegistryValueKind.DWord, rV); //Si la checkBox a été cochée alors on stocke "1" dans la valeur "NePlusDemander" dans la base de registre
            }
        }
        #endregion
    }
}
