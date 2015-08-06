namespace Web_Browser
{
    partial class FrmWeb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeb));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnForward = new System.Windows.Forms.ToolStripMenuItem();
            this.direcciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtDireccion = new System.Windows.Forms.ToolStripComboBox();
            this.BtnIr = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.Menú = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnHome = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnContact = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnBack,
            this.BtnForward,
            this.direcciónToolStripMenuItem,
            this.TxtDireccion,
            this.BtnIr,
            this.BtnRefresh,
            this.tabToolStripMenuItem,
            this.Menú});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // BtnBack
            // 
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(28, 23);
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnForward
            // 
            this.BtnForward.Image = ((System.Drawing.Image)(resources.GetObject("BtnForward.Image")));
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(28, 23);
            this.BtnForward.Click += new System.EventHandler(this.toolStripMenuItm2_Click);
            // 
            // direcciónToolStripMenuItem
            // 
            this.direcciónToolStripMenuItem.Enabled = false;
            this.direcciónToolStripMenuItem.Name = "direcciónToolStripMenuItem";
            this.direcciónToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.direcciónToolStripMenuItem.Text = "Url:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(350, 23);
            this.TxtDireccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDireccion_KeyDown);
            // 
            // BtnIr
            // 
            this.BtnIr.Image = ((System.Drawing.Image)(resources.GetObject("BtnIr.Image")));
            this.BtnIr.Name = "BtnIr";
            this.BtnIr.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.BtnIr.Size = new System.Drawing.Size(42, 23);
            this.BtnIr.Text = "Ir";
            this.BtnIr.Click += new System.EventHandler(this.irToolStripMenuItem_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.BtnRefresh.Size = new System.Drawing.Size(28, 23);
            this.BtnRefresh.Click += new System.EventHandler(this.fToolStripMenuItem_Click);
            // 
            // tabToolStripMenuItem
            // 
            this.tabToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAdd,
            this.BtnClose});
            this.tabToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tabToolStripMenuItem.Image")));
            this.tabToolStripMenuItem.Name = "tabToolStripMenuItem";
            this.tabToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
            this.tabToolStripMenuItem.Text = "Páginas";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.BtnAdd.Size = new System.Drawing.Size(152, 22);
            this.BtnAdd.Text = "Añadir";
            this.BtnAdd.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.BtnClose.Size = new System.Drawing.Size(130, 22);
            this.BtnClose.Text = "Cerrar";
            this.BtnClose.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // Menú
            // 
            this.Menú.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnHome,
            this.BtnInfo,
            this.BtnContact,
            this.toolStripSeparator1,
            this.BtnHelp});
            this.Menú.Image = ((System.Drawing.Image)(resources.GetObject("Menú.Image")));
            this.Menú.Name = "Menú";
            this.Menú.Size = new System.Drawing.Size(66, 23);
            this.Menú.Text = "Menú";
            // 
            // BtnHome
            // 
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(152, 22);
            this.BtnHome.Text = "Home";
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnInfo
            // 
            this.BtnInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnInfo.Image")));
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.BtnInfo.Size = new System.Drawing.Size(152, 22);
            this.BtnInfo.Text = "Info";
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // BtnContact
            // 
            this.BtnContact.Image = ((System.Drawing.Image)(resources.GetObject("BtnContact.Image")));
            this.BtnContact.Name = "BtnContact";
            this.BtnContact.Size = new System.Drawing.Size(152, 22);
            this.BtnContact.Text = "Contáctenos";
            this.BtnContact.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // BtnHelp
            // 
            this.BtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("BtnHelp.Image")));
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.BtnHelp.Size = new System.Drawing.Size(152, 22);
            this.BtnHelp.Text = "Ayuda";
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 493);
            this.tabControl1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(989, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(250, 22);
            // 
            // FrmWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 520);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmWeb";
            this.Text = "Web Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem direcciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox TxtDireccion;
        private System.Windows.Forms.ToolStripMenuItem BtnIr;
        private System.Windows.Forms.ToolStripMenuItem BtnBack;
        private System.Windows.Forms.ToolStripMenuItem BtnForward;
        private System.Windows.Forms.ToolStripMenuItem BtnRefresh;
        private System.Windows.Forms.ToolStripMenuItem tabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnAdd;
        private System.Windows.Forms.ToolStripMenuItem BtnClose;
        private System.Windows.Forms.ToolStripMenuItem Menú;
        private System.Windows.Forms.ToolStripMenuItem BtnHome;
        private System.Windows.Forms.ToolStripMenuItem BtnInfo;
        private System.Windows.Forms.ToolStripMenuItem BtnHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem BtnContact;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

