using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Client_PostePostulant
{
    [DataContract]
    class Candidate
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nom { get; set; }
        [DataMember]
        public string Courriel { get; set; }
        [DataMember]
        public string Langages { get; set; }

        public override string ToString() {
            return "Id: " + Id + " Nom: " + Nom + ", Email " + Courriel;
        }
    }
}
