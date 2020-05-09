using System;

namespace WS_Call_service_Pirko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Call WS:\n");
            CallWS();
            Console.WriteLine("WS called");
            Console.ReadKey();

        }

        static void CallWS()
        {
            ServiceReference1.GeneratedNg_predmetyServiceClient client = new ServiceReference1.GeneratedNg_predmetyServiceClient();
            var resp = client.searchSimplePredmetyAsync(new ServiceReference1.searchSimplePredmety("", "", "", "", "IC++1", "", "", "", "", "", "", "", "", "", ""));

            foreach (var subject in resp.Result.ws_stag_predmety_SearchSimplePredmety)
            {
                Console.WriteLine("Finded: " + subject.nazev + " " + subject.rokVarianty);
            }
        }
    }
}
