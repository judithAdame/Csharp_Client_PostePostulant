using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Client_PostePostulant
{
    [DataContract]
    class ListeCandidates
    {

        [DataMember]
        public List<Candidate> GetCandidatesResult { get; set; }
    }
}
