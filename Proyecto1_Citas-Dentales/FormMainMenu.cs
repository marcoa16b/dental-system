using Proyecto1_Citas_Dentales.Classes;
using System.ComponentModel;

namespace Proyecto1_Citas_Dentales
{
    public partial class FormMainMenu : Form
    {

        // Fields
        private Button currentButton;
        private Form activeForm;
        public static BindingList<QueryType> queryTypesList = new BindingList<QueryType>(); 

        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }
        private void panel1_Paint(object sender, PaintEventArgs e)
        { }

        // Dar formato al boton seleccionado
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(25, 25, 50);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        // Dar formato por defecto a los botones
        private void DisableButton()
        {
            foreach (Control previousBtn in panelSideMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    Color color = Color.FromArgb(17, 17, 34);
                    previousBtn.BackColor = color;
                    previousBtn.ForeColor = Color.LightGray;
                    previousBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        // open a child form
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }


        // handlers para los clicks en botones
        private void buttonNewDates_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAppointments(), sender);
        }

        private void buttonNewQueryType_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormQueryTypes(), sender);
        }

        private void buttonAdmClients_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAdminClients(), sender);
        }

        private void buttonAdmDoctors_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAdminDoctors(), sender);
        }

        private void buttonReportDate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReportDate(), sender);
        }

        private void buttonReportClient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReportClient(), sender);
        }

        private void buttonReportDoctor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReportDoctor(), sender);
        }
    }
}