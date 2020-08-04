namespace Launcher
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dépannageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solutionsWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encreEtTonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.développementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "SBiiXpress Launcher";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.cleanerToolStripMenuItem,
            this.toolStripSeparator2,
            this.dépannageToolStripMenuItem,
            this.impressionToolStripMenuItem,
            this.venteToolStripMenuItem,
            this.solutionsWebToolStripMenuItem,
            this.encreEtTonerToolStripMenuItem,
            this.développementToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(159, 236);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.fontToolStripMenuItem.Text = "FontXpress";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // cleanerToolStripMenuItem
            // 
            this.cleanerToolStripMenuItem.Name = "cleanerToolStripMenuItem";
            this.cleanerToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.cleanerToolStripMenuItem.Text = "Cleaner";
            this.cleanerToolStripMenuItem.Click += new System.EventHandler(this.cleanerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // dépannageToolStripMenuItem
            // 
            this.dépannageToolStripMenuItem.Name = "dépannageToolStripMenuItem";
            this.dépannageToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.dépannageToolStripMenuItem.Text = "Dépannage";
            this.dépannageToolStripMenuItem.Click += new System.EventHandler(this.dépannageToolStripMenuItem_Click);
            // 
            // impressionToolStripMenuItem
            // 
            this.impressionToolStripMenuItem.Name = "impressionToolStripMenuItem";
            this.impressionToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.impressionToolStripMenuItem.Text = "Impression";
            this.impressionToolStripMenuItem.Click += new System.EventHandler(this.impressionToolStripMenuItem_Click);
            // 
            // venteToolStripMenuItem
            // 
            this.venteToolStripMenuItem.Name = "venteToolStripMenuItem";
            this.venteToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.venteToolStripMenuItem.Text = "Vente";
            this.venteToolStripMenuItem.Click += new System.EventHandler(this.venteToolStripMenuItem_Click);
            // 
            // solutionsWebToolStripMenuItem
            // 
            this.solutionsWebToolStripMenuItem.Name = "solutionsWebToolStripMenuItem";
            this.solutionsWebToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.solutionsWebToolStripMenuItem.Text = "Solutions web";
            this.solutionsWebToolStripMenuItem.Click += new System.EventHandler(this.solutionsWebToolStripMenuItem_Click);
            // 
            // encreEtTonerToolStripMenuItem
            // 
            this.encreEtTonerToolStripMenuItem.Name = "encreEtTonerToolStripMenuItem";
            this.encreEtTonerToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.encreEtTonerToolStripMenuItem.Text = "Encre et toner";
            this.encreEtTonerToolStripMenuItem.Click += new System.EventHandler(this.encreEtTonerToolStripMenuItem_Click);
            // 
            // développementToolStripMenuItem
            // 
            this.développementToolStripMenuItem.Name = "développementToolStripMenuItem";
            this.développementToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.développementToolStripMenuItem.Text = "Développement";
            this.développementToolStripMenuItem.Click += new System.EventHandler(this.développementToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launcher";
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem dépannageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solutionsWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encreEtTonerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem développementToolStripMenuItem;
    }
}

