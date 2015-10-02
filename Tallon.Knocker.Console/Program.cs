using System;
using System.Net;
using RestSharp;
using Tallon.Knocker.Core;

namespace Tallon.Knocker.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> foundAction = s =>
            {
                //var client = new RestClient("https://www.size.com");
                //var request = new RestRequest("/doorbell.asp", Method.POST);
                //client.Proxy = new WebProxy("proxy...");
                //client.Execute(request);
                System.Console.WriteLine(s);
            };
            ComReader.Register(foundAction);
            System.Console.ReadLine();
        }

    }
}
