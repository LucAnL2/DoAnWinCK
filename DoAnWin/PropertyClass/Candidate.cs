using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWin.PropertyClass
{
    public class Candidate: Worker
    {
        private string idWork;
        public Candidate() { }
        public Candidate(string idWorker, string nameWorker, string idWork, string rate) : base(idWorker, nameWorker, rate)
        {
            IdWork = idWork;
        }

        public string IdWork { get => idWork; set => idWork = value; }
    }
}
