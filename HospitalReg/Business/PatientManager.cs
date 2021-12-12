using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalReg
{
    class PatientManager
    {
        // IPatientDal türünü burada Constructor (Dependency) Injection uyguluyoruz.
        IPatientDal _patientDal;
        public PatientManager(IPatientDal patientDal)
        {
            _patientDal = patientDal;
        }

        public List<Patient> getAllPatients()
        {
            return _patientDal.GetAllPatients();
        }
        public void Add(Patient patient)
        {
            _patientDal.add(patient);
        }
        public void Update(Patient patient)
        {
            _patientDal.update(patient);
        }
        public void Delete(int id)
        {
            _patientDal.delete(id);
        }
        public List<Patient> Search(int identNo)
        {
            return _patientDal.search(identNo);
        }
        public List<Patient> Search(string name)
        {
            return _patientDal.search(name);
        }

    }
}
