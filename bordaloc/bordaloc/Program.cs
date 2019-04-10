using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Client;


namespace bordaloc
{
    class Program
    {
        static void Main(string[] args)
        {
            SetBingMapsKey();
            Console.WriteLine("Bing Maps set successfully");
        }
        static private void SetBingMapsKey()
        {

            ClientContext context = new ClientContext("https://bordahq.sharepoint.com/hq");
            Web web = context.Web;
            web.AllProperties["BING_MAPS_KEY"] = "AjSyOhKZ3wJzqrbCJyma41p8wKncW6gSl3aQii-Joj5vvMdjnGlcBuE8BZZSe5RY";
               web.Update();
            context.ExecuteQuery();
        }
    }

}
