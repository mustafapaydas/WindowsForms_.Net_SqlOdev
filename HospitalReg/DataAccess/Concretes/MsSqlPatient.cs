using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HospitalReg
{
    public class MsSqlPatient : IPatientDal
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PRegister.mdf;Integrated Security=True");
        SqlCommand command;

        public void add(Patient patient)
        {
           
            string insertQuery = 
                "insert into [patients](identCardNo,name,surname,old,illness) " +
                "VALUES(@IdentityCardNo,@ad,@surname,@old,@illness)";

            SqlCommand command = new SqlCommand(insertQuery, connection);            
            command.Parameters.AddWithValue("@IdentityCardNo", patient.IdentNo);
            command.Parameters.AddWithValue("@ad", patient.Name);
            command.Parameters.AddWithValue("@surname", patient.Surname);
            command.Parameters.AddWithValue("@old", patient.Old);
            command.Parameters.AddWithValue("@illness", patient.Illness);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }

        
           
        

        public void delete(int id)
        {
            command = new SqlCommand("delete from patients where Id=@id",connection);
            command.Parameters.AddWithValue("@id",id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();  
        }

        public List<Patient> GetAllPatients()
        {
            List<Patient> patients = new List<Patient>();
            string query = "Select * from patients";
            command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Patient patient = new Patient();
                patient.Id = Convert.ToInt32(reader[0]);
                patient.IdentNo = Convert.ToInt32(reader[1]);
                patient.Name = reader[2].ToString();
                patient.Surname = reader[3].ToString();
                patient.Old = Convert.ToInt32(reader[4]);
                patient.Illness = reader[5].ToString();
                patient.Date = Convert.ToDateTime(reader[6]);
                patients.Add(patient);
            }
            reader.Close();
            connection.Close();
            return patients;
        }

        public List<Patient> search(int identCardNo)
        {
            List<Patient> patients = new List<Patient>();
            string query = "select * from patients where identCardNo=@idcn";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idcn", identCardNo);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Patient patient = new Patient();
                patient.Id = Convert.ToInt32(reader[0]);
                patient.IdentNo = Convert.ToInt32(reader[1]);
                patient.Name = reader[2].ToString();
                patient.Surname = reader[3].ToString();
                patient.Old = Convert.ToInt32(reader[4]);
                patient.Illness = reader[5].ToString();
                patient.Date = Convert.ToDateTime(reader[6]);
                patients.Add(patient);
            }
            reader.Close();
            connection.Close();
            return patients;
            
        }

        public List<Patient> search(string name)
        {
            List<Patient> patients = new List<Patient>();
            string query = $"select * from patients where name like '%{name}%'";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Patient patient = new Patient();
                patient.Id = Convert.ToInt32(reader[0]);
                patient.IdentNo = Convert.ToInt32(reader[1]);
                patient.Name = reader[2].ToString();
                patient.Surname = reader[3].ToString();
                patient.Old = Convert.ToInt32(reader[4]);
                patient.Illness = reader[5].ToString();
                patient.Date = Convert.ToDateTime(reader[6]);
                patients.Add(patient);
            }
            reader.Close();
            connection.Close();
            return patients;
        }

        public void update(Patient patient)
        {

            connection.Open();
            string query =
                "update patients set identCardNo=@idCN,name=@name,surname=@surname,old=@old,illness=@ill where Id=@id";
            command = new SqlCommand(query, connection);
            //command.Parameters.AddWithValue("@id", patient.Id);
            
            command.Parameters.AddWithValue("@name", patient.Name);
            command.Parameters.AddWithValue("@surname", patient.Surname);
            command.Parameters.AddWithValue("@old", patient.Old);
            command.Parameters.AddWithValue("@ill", patient.Illness);
            command.Parameters.AddWithValue("@idCN", patient.IdentNo);
            command.Parameters.AddWithValue("@id", patient.Id);
            command.ExecuteNonQuery();
            connection.Close();
           


        }
    }
}
