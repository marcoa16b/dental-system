namespace Proyecto1_Citas_Dentales.Forms
{
    partial class FormAdminClients
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
            button1 = new Button();
            panel1 = new Panel();
            buttonNewClient = new Button();
            label1 = new Label();
            clientDataViewer = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientDataViewer).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(25, 25, 50);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1277, 17);
            button1.Name = "button1";
            button1.Padding = new Padding(8, 4, 8, 4);
            button1.Size = new Size(101, 35);
            button1.TabIndex = 2;
            button1.Text = "Agregar tipo";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 17, 34);
            panel1.Controls.Add(buttonNewClient);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 70);
            panel1.TabIndex = 1;
            // 
            // buttonNewClient
            // 
            buttonNewClient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNewClient.AutoSize = true;
            buttonNewClient.BackColor = Color.FromArgb(25, 25, 50);
            buttonNewClient.FlatStyle = FlatStyle.Flat;
            buttonNewClient.ForeColor = Color.White;
            buttonNewClient.Location = new Point(668, 17);
            buttonNewClient.Name = "buttonNewClient";
            buttonNewClient.Padding = new Padding(8, 4, 8, 4);
            buttonNewClient.Size = new Size(110, 35);
            buttonNewClient.TabIndex = 3;
            buttonNewClient.Text = "Nuevo Cliente";
            buttonNewClient.UseVisualStyleBackColor = false;
            buttonNewClient.Click += buttonNewClient_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(137, 45);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            // 
            // clientDataViewer
            // 
            clientDataViewer.BackgroundColor = Color.FromArgb(25, 25, 50);
            clientDataViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientDataViewer.Dock = DockStyle.Top;
            clientDataViewer.Location = new Point(0, 70);
            clientDataViewer.Name = "clientDataViewer";
            clientDataViewer.RowTemplate.Height = 25;
            clientDataViewer.Size = new Size(800, 287);
            clientDataViewer.TabIndex = 2;
            // 
            // FormAdminClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 50);
            ClientSize = new Size(800, 450);
            Controls.Add(clientDataViewer);
            Controls.Add(panel1);
            Name = "FormAdminClients";
            Text = "FormAdminClients";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clientDataViewer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label1;
        private Button buttonNewClient;
        private DataGridView clientDataViewer;
    }
}