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
    public partial class PatientRegister : Form
    {
        int _id;
        int _identNo;
        string _name;
        string _surname;
        int _old;
        string _illness;



        public int getId()
        {
             return _id; }
        public void setId(int id){
            _id = id; 
        }
        public int getIdentNo()
        {
            return _identNo;
        }
        public void setIdentNo(int identNo)
        {
            _identNo = identNo;
        }
        public string getName() { return _name; }
        public void setName(string name) {_name = name; }
        public string getSurName() { return _surname; }
        public void setSurName(string surname) { _surname = surname; }
        public int getOld() { return _old; }
        public void setOld(int old) { _old = old; }
        public string getIllness() {  return _illness; }
        public void setIllness(string illness){ _illness = illness; }

        PatientManager manager = new PatientManager(new MsSqlPatient());
        //Burada dependecy (Constructor) injection yaptığımız sınıfı veriyoruz...

        public PatientRegister()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2._id = getId();
            form2._identNo = getIdentNo();
            form2._name = getName();
            form2._surname = getSurName();
            form2._old = getOld();
            form2._illness = getIllness();
        
            form2.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = manager.getAllPatients();
        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete._id = getId();
            delete.Show();
            this.Hide();
           }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(txtName.Text)) || (string.IsNullOrEmpty(txtSur.Text)) || (string.IsNullOrEmpty(txtSick.Text))) {
                    MessageBox.Show("Boş Veri Konulamaz!!!", "Hatalı Girdi");
                }
                else { 
                var patient1 = new Patient()
                            {

                                IdentNo = Convert.ToInt32(txtIden.Text),
                                Name = txtName.Text,
                                Surname = txtSur.Text,
                                Old = Convert.ToInt32(txtOld.Text),
                                Illness = txtSick.Text
                            };
                            
            
                            manager.Add(patient1);
                            dataGridView1.DataSource= manager.getAllPatients();
                }
            }
            catch (System.FormatException)
            {

               MessageBox.Show("Kimlik No veya Yaş Bilgisi Hatalı!!!", "Hatalı Girdi");
            }
            


            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            txtIden.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtName.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();


            setId(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            setIdentNo(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString()));
            setName(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            setSurName(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            setOld(Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString()));
            setIllness(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            
            


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            
            string name = txtSearch.Text;
            dataGridView1.DataSource = manager.Search(name);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= manager.getAllPatients();
        }
    }
}
