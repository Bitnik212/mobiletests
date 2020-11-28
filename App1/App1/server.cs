using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Xml;
using System.Diagnostics;
using System.Threading.Tasks;

namespace App1
{
    class server
    {
        string url = "http://partner.market.yandex.ru/pages/help/YML.xml";
        HttpClient client = new HttpClient();
        XmlDocument xmlres = new XmlDocument();


        public async Task getProducts()
        {
            var res = await client.GetAsync(new Uri(this.url));
            xmlres.LoadXml(res.Content.ReadAsStringAsync().Result);
            Debug.WriteLine(xmlres);
        }
    }
}
