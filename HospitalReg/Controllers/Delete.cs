using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalReg
{
    public partial class Delete : Form
    {
        DialogResult dialog = new DialogResult();
        PatientRegister patientRegister = new PatientRegister();
        public int _id;
        PatientManager manager = new PatientManager(new MsSqlPatient());
        //Burada manager sınıfındaki IPatientDal türünde aldığımız sınıflardan birini veriyoruz. Burada bizim Sınıfımız MsSqlPatient sınıfı

        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            txtDelete.Text = _id.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dialog = MessageBox.Show("Hasta Kaydı Silinsin mi?", "R U Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtDelete.Text);
                manager.Delete(id);
                this.Hide();
                
                patientRegister.Show();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi!");
                this.Close();
                patientRegister.Show();
            }
        }
    }
}
