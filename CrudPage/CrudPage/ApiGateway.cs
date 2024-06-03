using CrudPage.Models;
using Newtonsoft.Json;
using System.Net;

namespace CrudPage
{
    public class ApiGateway
    {
        private string url = "https://localhost:7154/api/Node";
        private HttpClient httpClient = new HttpClient();

        
        public List<Node> Listnode(){
            List<Node> node = new List<Node>();
            if(url.Trim().Substring(0,5).ToLower()=="https")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    var datacol = JsonConvert.DeserializeObject<List<Node>>(result);
                    if (datacol != null)
                        node = datacol;
                }
                else
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error  occuredAPI " + result

                  );

                }
            }
            catch (Exception ex) {
                throw new Exception("error occure api end point " + ex.Message);

            }
            finally { }
            return node;
        }
        
    }
}
