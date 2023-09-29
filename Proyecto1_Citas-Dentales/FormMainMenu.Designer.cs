namespace Proyecto1_Citas_Dentales
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSideMenu = new Panel();
            buttonReportDoctor = new Button();
            buttonReportClient = new Button();
            buttonReportDate = new Button();
            label4 = new Label();
            buttonAdmDoctors = new Button();
            buttonAdmClients = new Button();
            label3 = new Label();
            buttonNewQueryType = new Button();
            buttonNewDates = new Button();
            label2 = new Label();
            panelLogo = new Panel();
            label1 = new Label();
            panelDesktopPanel = new Panel();
            pictureBox1 = new PictureBox();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AccessibleName = "PanelSideMenu";
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(17, 17, 34);
            panelSideMenu.Controls.Add(buttonReportDoctor);
            panelSideMenu.Controls.Add(buttonReportClient);
            panelSideMenu.Controls.Add(buttonReportDate);
            panelSideMenu.Controls.Add(label4);
            panelSideMenu.Controls.Add(buttonAdmDoctors);
            panelSideMenu.Controls.Add(buttonAdmClients);
            panelSideMenu.Controls.Add(label3);
            panelSideMenu.Controls.Add(buttonNewQueryType);
            panelSideMenu.Controls.Add(buttonNewDates);
            panelSideMenu.Controls.Add(label2);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(220, 461);
            panelSideMenu.TabIndex = 0;
            panelSideMenu.Paint += panel1_Paint;
            // 
            // buttonReportDoctor
            // 
            buttonReportDoctor.Dock = DockStyle.Top;
            buttonReportDoctor.FlatAppearance.BorderSize = 0;
            buttonReportDoctor.FlatStyle = FlatStyle.Flat;
            buttonReportDoctor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReportDoctor.ForeColor = Color.LightGray;
            buttonReportDoctor.Location = new Point(0, 403);
            buttonReportDoctor.Name = "buttonReportDoctor";
            buttonReportDoctor.Padding = new Padding(16, 0, 0, 0);
            buttonReportDoctor.Size = new Size(220, 45);
            buttonReportDoctor.TabIndex = 9;
            buttonReportDoctor.Text = "Por Doctor";
            buttonReportDoctor.TextAlign = ContentAlignment.MiddleLeft;
            buttonReportDoctor.UseVisualStyleBackColor = true;
            buttonReportDoctor.Click += buttonReportDoctor_Click;
            // 
            // buttonReportClient
            // 
            buttonReportClient.Dock = DockStyle.Top;
            buttonReportClient.FlatAppearance.BorderSize = 0;
            buttonReportClient.FlatStyle = FlatStyle.Flat;
            buttonReportClient.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReportClient.ForeColor = Color.LightGray;
            buttonReportClient.Location = new Point(0, 358);
            buttonReportClient.Name = "buttonReportClient";
            buttonReportClient.Padding = new Padding(16, 0, 0, 0);
            buttonReportClient.Size = new Size(220, 45);
            buttonReportClient.TabIndex = 8;
            buttonReportClient.Text = "Por Cliente";
            buttonReportClient.TextAlign = ContentAlignment.MiddleLeft;
            buttonReportClient.UseVisualStyleBackColor = true;
            buttonReportClient.Click += buttonReportClient_Click;
            // 
            // buttonReportDate
            // 
            buttonReportDate.Dock = DockStyle.Top;
            buttonReportDate.FlatAppearance.BorderSize = 0;
            buttonReportDate.FlatStyle = FlatStyle.Flat;
            buttonReportDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReportDate.ForeColor = Color.LightGray;
            buttonReportDate.Location = new Point(0, 313);
            buttonReportDate.Name = "buttonReportDate";
            buttonReportDate.Padding = new Padding(16, 0, 0, 0);
            buttonReportDate.Size = new Size(220, 45);
            buttonReportDate.TabIndex = 7;
            buttonReportDate.Text = "Por Fecha";
            buttonReportDate.TextAlign = ContentAlignment.MiddleLeft;
            buttonReportDate.UseVisualStyleBackColor = true;
            buttonReportDate.Click += buttonReportDate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 292);
            label4.Name = "label4";
            label4.Padding = new Padding(6, 0, 0, 0);
            label4.Size = new Size(83, 21);
            label4.TabIndex = 6;
            label4.Text = "Reportes";
            // 
            // buttonAdmDoctors
            // 
            buttonAdmDoctors.Dock = DockStyle.Top;
            buttonAdmDoctors.FlatAppearance.BorderSize = 0;
            buttonAdmDoctors.FlatStyle = FlatStyle.Flat;
            buttonAdmDoctors.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdmDoctors.ForeColor = Color.LightGray;
            buttonAdmDoctors.Location = new Point(0, 247);
            buttonAdmDoctors.Name = "buttonAdmDoctors";
            buttonAdmDoctors.Padding = new Padding(16, 0, 0, 0);
            buttonAdmDoctors.Size = new Size(220, 45);
            buttonAdmDoctors.TabIndex = 5;
            buttonAdmDoctors.Text = "Doctores";
            buttonAdmDoctors.TextAlign = ContentAlignment.MiddleLeft;
            buttonAdmDoctors.UseVisualStyleBackColor = true;
            buttonAdmDoctors.Click += buttonAdmDoctors_Click;
            // 
            // buttonAdmClients
            // 
            buttonAdmClients.Dock = DockStyle.Top;
            buttonAdmClients.FlatAppearance.BorderSize = 0;
            buttonAdmClients.FlatStyle = FlatStyle.Flat;
            buttonAdmClients.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdmClients.ForeColor = Color.LightGray;
            buttonAdmClients.Location = new Point(0, 202);
            buttonAdmClients.Name = "buttonAdmClients";
            buttonAdmClients.Padding = new Padding(16, 0, 0, 0);
            buttonAdmClients.Size = new Size(220, 45);
            buttonAdmClients.TabIndex = 4;
            buttonAdmClients.Text = "Clientes";
            buttonAdmClients.TextAlign = ContentAlignment.MiddleLeft;
            buttonAdmClients.UseVisualStyleBackColor = true;
            buttonAdmClients.Click += buttonAdmClients_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 181);
            label3.Name = "label3";
            label3.Padding = new Padding(6, 0, 0, 0);
            label3.Size = new Size(126, 21);
            label3.TabIndex = 1;
            label3.Text = "Administración";
            // 
            // buttonNewQueryType
            // 
            buttonNewQueryType.Dock = DockStyle.Top;
            buttonNewQueryType.FlatAppearance.BorderSize = 0;
            buttonNewQueryType.FlatStyle = FlatStyle.Flat;
            buttonNewQueryType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNewQueryType.ForeColor = Color.LightGray;
            buttonNewQueryType.Location = new Point(0, 136);
            buttonNewQueryType.Name = "buttonNewQueryType";
            buttonNewQueryType.Padding = new Padding(16, 0, 0, 0);
            buttonNewQueryType.Size = new Size(220, 45);
            buttonNewQueryType.TabIndex = 3;
            buttonNewQueryType.Text = "Tipo Consulta";
            buttonNewQueryType.TextAlign = ContentAlignment.MiddleLeft;
            buttonNewQueryType.UseVisualStyleBackColor = true;
            buttonNewQueryType.Click += buttonNewQueryType_Click;
            // 
            // buttonNewDates
            // 
            buttonNewDates.Dock = DockStyle.Top;
            buttonNewDates.FlatAppearance.BorderSize = 0;
            buttonNewDates.FlatStyle = FlatStyle.Flat;
            buttonNewDates.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNewDates.ForeColor = Color.LightGray;
            buttonNewDates.Location = new Point(0, 91);
            buttonNewDates.Name = "buttonNewDates";
            buttonNewDates.Padding = new Padding(16, 0, 0, 0);
            buttonNewDates.Size = new Size(220, 45);
            buttonNewDates.TabIndex = 2;
            buttonNewDates.Text = "Citas";
            buttonNewDates.TextAlign = ContentAlignment.MiddleLeft;
            buttonNewDates.UseVisualStyleBackColor = true;
            buttonNewDates.Click += buttonNewDates_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 70);
            label2.Name = "label2";
            label2.Padding = new Padding(6, 0, 0, 0);
            label2.Size = new Size(78, 21);
            label2.TabIndex = 1;
            label2.Text = "Registro";
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 70);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Droid Sans Mono Dotted for Powe", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(73, 22);
            label1.Name = "label1";
            label1.Size = new Size(66, 24);
            label1.TabIndex = 0;
            label1.Text = "MENU";
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDesktopPanel.BackColor = Color.FromArgb(25, 25, 50);
            panelDesktopPanel.Controls.Add(pictureBox1);
            panelDesktopPanel.Location = new Point(220, 0);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(564, 461);
            panelDesktopPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.home_image;
            pictureBox1.Location = new Point(134, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(784, 461);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelSideMenu);
            Name = "FormMainMenu";
            Text = "Gestion de Citas";
            Load += Form1_Load;
            panelSideMenu.ResumeLayout(false);
            panelSideMenu.PerformLayout();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelDesktopPanel.ResumeLayout(false);
            panelDesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogo;
        private Label label1;
        private Button buttonNewDates;
        private Label label2;
        private Label label3;
        private Button buttonNewQueryType;
        private Button buttonAdmDoctors;
        private Button buttonAdmClients;
        private Button buttonReportDoctor;
        private Button buttonReportClient;
        private Button buttonReportDate;
        private Label label4;
        private Panel panelDesktopPanel;
        private PictureBox pictureBox1;
    }
}