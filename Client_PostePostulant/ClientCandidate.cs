using Client_PostePostulant;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web.Script.Serialization;

namespace Client_PosteCandidate
{
    class ClientCandidate
    {
        private static readonly string urlCandidate = "http://localhost:51034/Service.svc";
        private static JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
        public static Candidate CallGetById(int id) {
            WebClient webClient = new WebClient();
            string urlServ = "/postulants/" + id;
            string reponse = webClient.DownloadString(urlCandidate + urlServ);
            Candidate postulant = (Candidate)jsonSerializer.Deserialize<Candidate>(reponse);
            return postulant;
        }
        public static List<Candidate> CallGetAll()
        {
            WebClient webClient = new WebClient();
            string urlServ = "/postulants";
            string reponse = webClient.DownloadString(new Uri(urlCandidate + urlServ));
            var liste = (List<Candidate>)jsonSerializer.Deserialize<List<Candidate>>(reponse);
            return liste;
        }
        public static List<Candidate> CallGeCandidatetByLangages(int nbMatch, string lPostes)
        {

            lPostes= lPostes.Replace("#", "%23");
            WebClient webClient = new WebClient();
            string urlServ = "/postulants/nbMatch/" + nbMatch + "/langages/" + lPostes;
            Console.WriteLine(urlServ);
            string reponse = webClient.DownloadString(urlCandidate + urlServ);
            List<Candidate> liste = (List<Candidate>)jsonSerializer.Deserialize<List<Candidate>>(reponse);
            return liste;
        }
        public static int CallGetCount()
        {
            WebClient webClient = new WebClient();
            string urlService = "/postulants/count";
            string reponse = webClient.DownloadString(urlCandidate + urlService);
            return Int32.Parse(reponse);
        }
        public static void CallAdd(Candidate postulant)
        {
            WebClient webClient = new WebClient();
            string urlService = "/postulants";
            string reponse = webClient.DownloadString(urlCandidate + urlService);
            jsonSerializer.Deserialize<List<Candidate>>(reponse);
        }
        public static void CallDelete(int id)
        {
            WebClient webClient = new WebClient();
            string urlService = "/postulants/" + id;
            string reponse = webClient.DownloadString(urlCandidate + urlService);
            jsonSerializer.Deserialize<List<Candidate>>(reponse);
        }
        public static void CallUpdate(int id, Candidate postulant)
        {
            WebClient webClient = new WebClient();
            string urlService = "/postulants/" + id;
            string reponse = webClient.DownloadString(urlCandidate + urlService);
            jsonSerializer.Deserialize<List<Candidate>>(reponse);
        }
    }
} 
