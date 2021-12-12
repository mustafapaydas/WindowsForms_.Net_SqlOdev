using System;

using System.Windows.Forms;

namespace HospitalReg
{
    public partial class Form2 : Form
    {

        public int _id;
        public int _identNo;
        public string _name;
        public string _surname;
        public int _old;
        public string _illness;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtId.Text = _id.ToString();
            txtIden.Text = _identNo.ToString();
            txtName.Text = _name;
            txtSur.Text = _surname;
            txtOld.Text = _old.ToString();
            txtIll.Text = _illness;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientManager manager = new PatientManager(new MsSqlPatient());
            Patient patient = new Patient
            {
                Id = Convert.ToInt32(txtId.Text),
                IdentNo = Convert.ToInt32(txtIden.Text),
                Name = txtName.Text,
                Surname=txtSur.Text,
                Old = Convert.ToInt32(txtOld.Text),
                Illness=txtIll.Text
            };

            manager.Update(patient);
            this.Hide();
            PatientRegister form1 = new PatientRegister();
            form1.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
