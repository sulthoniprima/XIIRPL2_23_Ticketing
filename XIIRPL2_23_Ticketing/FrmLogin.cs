using XIIRPL2_23_Ticketing.MasterForm;

namespace XIIRPL2_23_Ticketing
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rigister frmrigister = new rigister();
            frmrigister.Show();
            this.Close();

        }
    }
}