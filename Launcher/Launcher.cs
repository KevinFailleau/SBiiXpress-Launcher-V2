using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Launcher : Form
    {
        #region Variables
        private string pathCleaner, pathFont;
        private int NePlusDemander;
        #endregion

        #region Initialisation

        /// <summary>
        /// Cette méthode s'exéute à l'appel de l'application
        /// </summary>
        public Launcher()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized; //On mets l'application dans la zone des notifications
            this.ShowInTaskbar = false;
            if ((Process.GetProcessesByName("Launcher").Length > 0)) //On vérifie que le Launcher n'est pas déjà lancé (pas sûr que cela fonctionne)
            {
                //MessageBox.Show("Le launcher n'est pas en cours d'exécution");
                RegistryView rV;
                if (Environment.Is64BitOperatingSystem) //On détermine l'architecture de Windows (32 ou 64 bits)
                {
                    rV = RegistryView.Registry64;
                }
                else
                {
                    rV = RegistryView.Registry32;
                }
                pathFont = Registre.LectureValeur(@"SOFTWARE\\SBiiXpress\\Font\\", "path", rV); //On récupère le chemin d'installation de FontXpress
                pathCleaner = Registre.LectureValeur(@"SOFTWARE\\SBiiXpress\\Cleaner\\", "path", rV); //On récupère le chemin d'installation du Cleaner
                if (!File.Exists(pathCleaner + "Cleaner.exe")) cleanerToolStripMenuItem.Enabled = false; //Si Cleaner n'est pas installé alors on désactive son bouton dans le menu
                if (!File.Exists(pathFont + "FontXpress.exe")) fontToolStripMenuItem.Enabled = false; //Si FontXpress n'est pas installé alors on désactive son bouton dans le menu
                try
                {
                    NePlusDemander = Convert.ToInt32(Registre.LectureValeur(@"SOFTWARE\\SBiiXpress", "NePlusDemander", rV)); //On essaie de lire la valeur NePlusDemander dans la base de registre
                    //Cette valeur permet à l'utilisateur de choisir s'il veut masquer la messageBox lui disant d'installer les logiciels
                }
                catch (Exception e)
                {}

                if (NePlusDemander == 0)
                { //Si NePlusDemander a sa valeur à zéro alors l'utilisateur n'a pas coché la case
                    if (!fontToolStripMenuItem.Enabled || !cleanerToolStripMenuItem.Enabled || !fontToolStripMenuItem.Enabled && !cleanerToolStripMenuItem.Enabled)
                    {
                        CustomMessageBox CM;
                        if (!fontToolStripMenuItem.Enabled && !cleanerToolStripMenuItem.Enabled)
                        {
                            //Si Cleaner et FontXpress ne sont pas installé, on affiche un message
                            CM = new CustomMessageBox("Cleaner et FontXpress ne semblent pas installés, voulez-vous visiter le site pour les télécharger ?", rV); //Appel de la CustomMessageBox avec message correspondant
                            CM.Show();
                        }
                        else if (!fontToolStripMenuItem.Enabled && cleanerToolStripMenuItem.Enabled)
                        {
                            //Si FontXpress n'est pas installé, on affiche un message
                            CM = new CustomMessageBox("FontXpress ne semble pas installé, voulez-vous visiter le site pour le télécharger ?", rV); //Appel de la CustomMessageBox avec message correspondant
                            CM.Show();
                        }
                        else if (!cleanerToolStripMenuItem.Enabled && fontToolStripMenuItem.Enabled)
                        {
                            //Si Cleaner n'est pas installé, on affiche un message
                            CM = new CustomMessageBox("Cleaner ne semble pas installé, voulez-vous visiter le site pour le télécharger ?", rV); //Appel de la CustomMessageBox avec message correspondant
                            CM.Show();
                        }
                    }
                }
            }
            else if((Process.GetProcessesByName("Launcher").Length > 1)) //Si le Launcher est déjà lancé alors on en n'ouvre pas d'autre et on affiche un message
            {
                this.notifyIcon.ContextMenuStrip = null;
                this.notifyIcon.Visible = false;
                MessageBox.Show("Le launcher SBiiXpress est déjà lancé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion

        #region Evénements

        /// <summary>
        /// Méthode qui s'exécute au lancement de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Launcher_Load(object sender, EventArgs e)
        {
            this.notifyIcon.Icon = this.Icon; //On défini l'icône qui sera dans la zone des notification
        }

        /// <summary>
        /// Cette méthode d'exécute quand l'utilisateur clique sur "Quitter"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //L'application se ferme
        }

        /// <summary>
        /// Méthode qui s'exécute lorsque l'utilisateur clique sur FontXpress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(pathFont + "FontXpress.exe"))
            {
                fontToolStripMenuItem.Enabled = false; //Si FontXpress n'est pas installé alors on désactive le bouton dans le menu
            }
            else
            {
                Exec(pathFont + "FontXpress.exe"); //Sinon on lance FontXpress
            }
        }

        /// <summary>
        /// Méthode qui s'exécute lorsque l'utilisateur clique sur Cleaner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cleanerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(pathCleaner + "Cleaner.exe"))
            {
                cleanerToolStripMenuItem.Enabled = false; //Si le Cleaner n'est pas installé, alors on désactive le bouton dans le menu
            }
            else
            {
                Exec(pathCleaner + "Cleaner"); //Sinon on lance le Cleaner
            }
        }

        /// <summary>
        /// Méthode qui s'active lorsque le client clique sur Dépannage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dépannageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.sbiixpress.fr/depanxpress-maintenance-informatique-reseau/"); //On ouvre la page Internet correspondante
        }

        /// <summary>
        /// Méthode qui s'active lorsque le client clique sur Impression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void impressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.sbiixpress.fr/imprimxpress-impression-numerique-et-3d/"); //On ouvre la page Internet correspondante
        }

        /// <summary>
        /// Méthode qui s'active lorsque le client clique sur Vente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void venteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.sbiixpress.fr/ventexpress-vente-de-produits-informatiques-multimedias-et-high-tech/"); //On ouvre la page Internet correspondante
        }

        /// <summary>
        /// Méthode qui s'active lorsque le client clique sur Solutions Web
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void solutionsWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.sbiixpress.fr/webxpress-conception-de-sites-internets-e-commerce-et-communautaire/"); //On ouvre la page Internet correspondante
        }

        /// <summary>
        /// Méthode qui s'active lorsque le client clique sur Encre et toner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void encreEtTonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.sbiixpress.fr/inkxpress-cartouche-jet-dencre-et-toner-laser/"); //On ouvre la page correspondante
        }

        /// <summary>
        /// Méthode qui s'active lorsque le client clique sur Développement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void développementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.sbiixpress.fr/codeurxpress/"); //On ouvre la page correspondante
        }
        #endregion

        #region Exécution de programmes
        /// <summary>
        /// Cette méthode permet d'exécuter des programmes
        /// </summary>
        /// <param name="path">Nom ou chemin de l'application à lancer</param>
        public void Exec(string path)
        {
            Process p = new Process();
            p.StartInfo.FileName = path;
            p.StartInfo.Verb = "runas"; //On exécutera l'application en tant qu'administrateur
            p.Start(); //On exécute
        }
        #endregion
    }
}
