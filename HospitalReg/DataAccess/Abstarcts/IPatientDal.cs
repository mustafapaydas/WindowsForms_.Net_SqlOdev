using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalReg
{
    public interface IPatientDal
    {
        // Database metodlarını soyutluyoruz
        List<Patient> GetAllPatients();
        void add(Patient patient);

        List<Patient> search(int identCardNo);//Bu iki Satırda Overloading İşlemi yapılmaktadır.
        List<Patient> search(string name);

        void delete(int id);
        void update(Patient patient);
    }
}
