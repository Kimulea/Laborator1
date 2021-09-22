using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1
{
    class Group
    {
        public string Name { get; set; }
        public int NrStudents { get; set; }
        public int Promotia { get; set; }
        public string LimbaStudii { get; set; } = "Ro";
        public bool Buget { get; set; }

        public Group(string name, int nrStudents, int promotia, bool buget)
        {
            Name = name;
            NrStudents = nrStudents;
            Promotia = promotia;
            Buget = buget;
        }

        public Group(string name, int nrStudents, int promotia, bool buget, string limbaStudii)
        {
            Name = name;
            NrStudents = nrStudents;
            Promotia = promotia;
            Buget = buget;
            LimbaStudii = limbaStudii;
        }

        public override string ToString()
        {
            return "{" + Name + ", " + NrStudents + ", " + Promotia + ", " + Buget + ", " + LimbaStudii + "}";
        }
    }
}
