namespace CefSharp.MinimalExample.WinForms
{
    partial class BrowserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserForm));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.lblDeadContador = new System.Windows.Forms.Label();
            this.lblLiveContador = new System.Windows.Forms.Label();
            this.lblDead = new System.Windows.Forms.Label();
            this.lblLive = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblCargadas = new System.Windows.Forms.Label();
            this.lstRechazadas = new System.Windows.Forms.ListBox();
            this.lstAprobadas = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.dgwDataCard = new System.Windows.Forms.DataGridView();
            this.statusLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.forwardButton = new System.Windows.Forms.ToolStripButton();
            this.urlTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.goButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDataCard)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.lblDeadContador);
            this.toolStripContainer.ContentPanel.Controls.Add(this.lblLiveContador);
            this.toolStripContainer.ContentPanel.Controls.Add(this.lblDead);
            this.toolStripContainer.ContentPanel.Controls.Add(this.lblLive);
            this.toolStripContainer.ContentPanel.Controls.Add(this.lblContador);
            this.toolStripContainer.ContentPanel.Controls.Add(this.lblCargadas);
            this.toolStripContainer.ContentPanel.Controls.Add(this.lstRechazadas);
            this.toolStripContainer.ContentPanel.Controls.Add(this.lstAprobadas);
            this.toolStripContainer.ContentPanel.Controls.Add(this.lblStatus);
            this.toolStripContainer.ContentPanel.Controls.Add(this.btnInit);
            this.toolStripContainer.ContentPanel.Controls.Add(this.btnOpen);
            this.toolStripContainer.ContentPanel.Controls.Add(this.dgwDataCard);
            this.toolStripContainer.ContentPanel.Controls.Add(this.statusLabel);
            this.toolStripContainer.ContentPanel.Controls.Add(this.outputLabel);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(937, 534);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(937, 559);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // lblDeadContador
            // 
            this.lblDeadContador.AutoSize = true;
            this.lblDeadContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadContador.ForeColor = System.Drawing.Color.Red;
            this.lblDeadContador.Location = new System.Drawing.Point(392, 248);
            this.lblDeadContador.Name = "lblDeadContador";
            this.lblDeadContador.Size = new System.Drawing.Size(28, 13);
            this.lblDeadContador.TabIndex = 13;
            this.lblDeadContador.Text = "000";
            // 
            // lblLiveContador
            // 
            this.lblLiveContador.AutoSize = true;
            this.lblLiveContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiveContador.ForeColor = System.Drawing.Color.Lime;
            this.lblLiveContador.Location = new System.Drawing.Point(389, 22);
            this.lblLiveContador.Name = "lblLiveContador";
            this.lblLiveContador.Size = new System.Drawing.Size(28, 13);
            this.lblLiveContador.TabIndex = 12;
            this.lblLiveContador.Text = "000";
            // 
            // lblDead
            // 
            this.lblDead.AutoSize = true;
            this.lblDead.ForeColor = System.Drawing.Color.Red;
            this.lblDead.Location = new System.Drawing.Point(349, 248);
            this.lblDead.Name = "lblDead";
            this.lblDead.Size = new System.Drawing.Size(39, 13);
            this.lblDead.TabIndex = 11;
            this.lblDead.Text = "Dead: ";
            // 
            // lblLive
            // 
            this.lblLive.AutoSize = true;
            this.lblLive.ForeColor = System.Drawing.Color.Lime;
            this.lblLive.Location = new System.Drawing.Point(349, 22);
            this.lblLive.Name = "lblLive";
            this.lblLive.Size = new System.Drawing.Size(33, 13);
            this.lblLive.TabIndex = 10;
            this.lblLive.Text = "Live: ";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(72, 107);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(28, 13);
            this.lblContador.TabIndex = 9;
            this.lblContador.Text = "000";
            // 
            // lblCargadas
            // 
            this.lblCargadas.AutoSize = true;
            this.lblCargadas.Location = new System.Drawing.Point(16, 107);
            this.lblCargadas.Name = "lblCargadas";
            this.lblCargadas.Size = new System.Drawing.Size(58, 13);
            this.lblCargadas.TabIndex = 8;
            this.lblCargadas.Text = "Cargadas: ";
            // 
            // lstRechazadas
            // 
            this.lstRechazadas.FormattingEnabled = true;
            this.lstRechazadas.Location = new System.Drawing.Point(349, 267);
            this.lstRechazadas.Name = "lstRechazadas";
            this.lstRechazadas.Size = new System.Drawing.Size(576, 251);
            this.lstRechazadas.TabIndex = 7;
            // 
            // lstAprobadas
            // 
            this.lstAprobadas.FormattingEnabled = true;
            this.lstAprobadas.Location = new System.Drawing.Point(349, 41);
            this.lstAprobadas.Name = "lstAprobadas";
            this.lstAprobadas.Size = new System.Drawing.Size(576, 186);
            this.lstAprobadas.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 80);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 5;
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(160, 15);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(142, 43);
            this.btnInit.TabIndex = 4;
            this.btnInit.Text = "Iniciar";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 15);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(142, 43);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Abrir";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // dgwDataCard
            // 
            this.dgwDataCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDataCard.Location = new System.Drawing.Point(12, 126);
            this.dgwDataCard.Name = "dgwDataCard";
            this.dgwDataCard.Size = new System.Drawing.Size(290, 303);
            this.dgwDataCard.TabIndex = 2;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel.Location = new System.Drawing.Point(0, 508);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 1;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outputLabel.Location = new System.Drawing.Point(0, 521);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.forwardButton,
            this.urlTextBox,
            this.goButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(937, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Layout += new System.Windows.Forms.LayoutEventHandler(this.HandleToolStripLayout);
            // 
            // backButton
            // 
            this.backButton.Enabled = false;
            this.backButton.Image = global::CefSharp.MinimalExample.WinForms.Properties.Resources.nav_left_green;
            this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(52, 22);
            this.backButton.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // forwardButton
            // 
            this.forwardButton.Enabled = false;
            this.forwardButton.Image = global::CefSharp.MinimalExample.WinForms.Properties.Resources.nav_right_green;
            this.forwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(70, 22);
            this.forwardButton.Text = "Forward";
            this.forwardButton.Click += new System.EventHandler(this.ForwardButtonClick);
            // 
            // urlTextBox
            // 
            this.urlTextBox.AutoSize = false;
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(500, 25);
            this.urlTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UrlTextBoxKeyUp);
            // 
            // goButton
            // 
            this.goButton.Image = global::CefSharp.MinimalExample.WinForms.Properties.Resources.nav_plain_green;
            this.goButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(42, 22);
            this.goButton.Text = "Go";
            this.goButton.Click += new System.EventHandler(this.GoButtonClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitMenuItemClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 583);
            this.Controls.Add(this.toolStripContainer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BrowserForm";
            this.Text = "BrowserForm";
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ContentPanel.PerformLayout();
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDataCard)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton backButton;
        private System.Windows.Forms.ToolStripButton forwardButton;
        private System.Windows.Forms.ToolStripTextBox urlTextBox;
        private System.Windows.Forms.ToolStripButton goButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.DataGridView dgwDataCard;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox lstRechazadas;
        private System.Windows.Forms.ListBox lstAprobadas;
        private System.Windows.Forms.Label lblDeadContador;
        private System.Windows.Forms.Label lblLiveContador;
        private System.Windows.Forms.Label lblDead;
        private System.Windows.Forms.Label lblLive;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblCargadas;
    }
}