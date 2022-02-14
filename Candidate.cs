using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Ex4_3
{
    internal class Candidate
    {
        public string Name { get; set; }
        private static int num;
        public static int Num
        {
            get { return num; }
        }
        public Candidate()
        {
            num++;
        }
        public Candidate(string name)
        {
            num++;
        }
    }
}
