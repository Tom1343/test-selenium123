using System;
using System.Xml;
using System.IO;
using System.Linq;
using System.Net;

namespace CGI_OUTBOUND_BC_Scenarios.Utilities
{
    public class LaunchQGWebService
    {
        private static string _url = "https://at_cgi_all:T+RhKS4*fvp3@s-be-ki-bct07b1.itglo.net:7047/POWER/WS/BASELINE/Codeunit/POWAutoTestingWS?tenant=baseline";
        private static string _action = "urn:microsoft-dynamics-schemas/codeunit/AutoTestingWS:LaunchQueueGroup";

        public static void LaunchQueueGroupWebService(string queueGroup)
        {
            XmlDocument soapEnvelopeXml = CreateSoapEnvelope(queueGroup);
            HttpWebRequest webRequest = CreateWebRequest(_url, _action);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            // begin async call to web request.
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

            // suspend this thread until call is complete. You might want to
            // do something usefull here like update your UI.
            asyncResult.AsyncWaitHandle.WaitOne();

            // get the response from the completed web request.
            string soapResult;
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                }
                Console.Write(soapResult);
            }
        }

        private static HttpWebRequest CreateWebRequest(string url, string action)
        {

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(_url);
            webRequest.Headers.Add("SOAPAction", action);
            webRequest.ContentType = "text/xml;charset=utf-8";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            webRequest.UseDefaultCredentials = true;
            webRequest.PreAuthenticate = true;
            webRequest.Credentials = CredentialCache.DefaultCredentials;
            return webRequest;
        }

        private static XmlDocument CreateSoapEnvelope(string p0)
        {
            string currentDirectoryPath = Directory.GetCurrentDirectory();
            string[] filePath = Directory.GetFiles(currentDirectoryPath, p0, SearchOption.AllDirectories);

            XmlDocument soapEnvelopeDocument = new XmlDocument();
            // soapEnvelopeDocument.Load("C:\\Users\\Aliu\\Desktop\\file.xml");
            //soapEnvelopeDocument.Load("//ktn.group/Public/BE-KI/Datashares/Share Analyze Consumers/21 TEST TEAM/Bashkim/BCData/PutawaySAM/PackageSAM_BB_PUTWAY.xml");
            soapEnvelopeDocument.Load(filePath.FirstOrDefault());
            return soapEnvelopeDocument;
        }

        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }
    }
}
