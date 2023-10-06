using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalReg
{
    public class Patient
    {
        int _id;
        int _identNo;
        string _name;
        string _surname;
        int _old;
        string _illness;
        DateTime date;

        public int Id { get => _id; set => _id = value; }
        public int IdentNo { get => _identNo; set => _identNo = value; }
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public int Old { get => _old; set => _old = value; }
        public string Illness { get => _illness; set => _illness = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
