using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Client_PostePostulant
{
    class ClientJob
    {
        private static readonly string urlJob = "http://localhost:43741/WRestFul_Poste/webresources/service";
        private static JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
        public static List<Job> CallGetJobByLangages(int nbMatch, string lPostulant)
        {
            string urlServ = "/postes/nbMatch/" + nbMatch + "/langages/" + lPostulant;
            WebClient webClient = new WebClient();
            string response = webClient.DownloadString(urlJob + urlServ);
            List<Job> liste = (List<Job>)jsonSerializer.Deserialize<List<Job>>(response);
            return liste;
        }
        public static void CallAdd(Job poste)
        {
            WebClient webClient = new WebClient();
            string urlService = "/postes";
            string reponse = webClient.DownloadString(urlJob + urlService);
            jsonSerializer.Deserialize<List<Job>>(reponse);
        }
        public static void CallDelete(int id)
        {
            WebClient webClient = new WebClient();
            string urlService = "/postes/" + id;
            string reponse = webClient.DownloadString(urlJob + urlService);
            jsonSerializer.Deserialize<List<Job>>(reponse);
        }
        public static void CallUpdate(int id, Job poste)
        {
            WebClient webClient = new WebClient();
            string urlService = "/postes/" + id;
            string reponse = webClient.DownloadString(urlJob + urlService);
            jsonSerializer.Deserialize<List<Job>>(reponse);
        }
        public static Job CallGetById(int id)
        {
            WebClient webClient = new WebClient();
            string urlService = "/postes/" + id;
            string reponse = webClient.DownloadString(urlJob + urlService);
            Job poste = (Job)jsonSerializer.Deserialize<Job>(reponse);
            return poste;
        }
        public static List<Job> CallGetAll()
        {
            WebClient webClient = new WebClient();
            string urlService = "/postes";
            string reponse = webClient.DownloadString(urlJob + urlService);
            List<Job> liste = (List<Job>)jsonSerializer.Deserialize<List<Job>>(reponse);
            return liste;
        }
        public static int CallGetCount()
        {
            WebClient webClient = new WebClient();
            string urlService = "/postes/count";
            string reponse = webClient.DownloadString(urlJob + urlService);
            return Int32.Parse(reponse);
        }
    }
}
