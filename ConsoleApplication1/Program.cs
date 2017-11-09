using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string zipCode = "";

            Console.WriteLine("Please enter your Zip Code that you want to search around.");

            zipCode = Console.ReadLine();
            while (true)
            {
                //CheckForIPhoneX(zipCode, "ATT/US");
                CheckForIPhoneX(zipCode, "TMOBILE/US");
                //CheckForIPhoneX(zipCode, "VERIZON/US");
                //CheckForIPhoneX(zipCode, "SPRINT/US");
            }
        }

        private static void CheckForIPhoneX(string zipCode, string carrier)
        {
            try
            {
                var client = new WebClient();
                //https://www.apple.com/shop/retail/pickup-message?pl=true&cppart=TMOBILE/US&parts.0=MQAM2LL/A&location=15106
                //https://www.apple.com/shop/retail/pickup-message?pl=true&cppart=TMOBILE/US&parts.0=MQAM2LL/A&location={zipCode}
                var jsonString = client.DownloadString($@"https://www.apple.com/shop/retail/pickup-message?pl=true&cppart={carrier}&parts.0=MQAU2LL/A&parts.1=MQAQ2LL/A&parts.2=MQAR2LL/A&parts.3=MQAV2LL/A&location={zipCode}");

                var response = JsonConvert.DeserializeObject<AppleResponse>(jsonString);

                if (response.body.stores.Any(x => x.partsAvailability != null && x.partsAvailability.Count > 0))
                {

                    foreach (var store in response.body.stores.Where(x => x.partsAvailability != null && x.partsAvailability.Count > 0))
                    {
                        foreach (var part in store.partsAvailability.Where(x => x.Value.pickupDisplay != "unavailable"))
                        {
                            Console.WriteLine($"{carrier}: Phone {part.Value.storePickupProductTitle} found at {store.storeName}");
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
