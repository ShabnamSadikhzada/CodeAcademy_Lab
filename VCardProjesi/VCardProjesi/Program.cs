using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VCardProjesi.Models;

namespace VCardProjesi;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("lutfen kac adet vcard olusturmak istediginizi giriniz: ");
        int count = Convert.ToInt32(Console.ReadLine());

        string url = "https://randomuser.me/api/?results=1";
        using HttpClient client = new HttpClient();

        string basePath = Directory.GetCurrentDirectory();
        basePath = Path.Combine(basePath, "..", "..", "..", "VCards");

        for (int i = 0;i < count; i++)
        {
            using HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            //var vCards = JsonConvert.DeserializeObject<VCard[]>(responseBody);  //bunu ben yazdım ama yanlış, nedenini bilmiyorum
            //aşağıdakı 3 satırı gpt yazdı, anladım mı ? hayır
            var jsonObject = JsonConvert.DeserializeObject<JObject>(responseBody);
            var results = jsonObject["results"].ToString();
            var vCards = JsonConvert.DeserializeObject<VCard[]>(results);

            string filePath;
            foreach (var vcard in vCards)
            {
                string vcardStr = vcard.VCardDonusturme();
                Console.WriteLine(vcardStr);
                filePath = Path.Combine(basePath, $"{vcard.Name.First}_{vcard.Name.Last}.vcf");
                //File.Create(filePath);
                //File.WriteAllText(filePath, vcardStr);

                using FileStream fS = File.Create(filePath);


                using (StreamWriter writer = new StreamWriter(fS))
                {
                    writer.Write(vcardStr);
                }
            }
        }


        Console.ReadKey();
        
    }
}