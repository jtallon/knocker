using System;
using System.Net;
using System.ServiceProcess;
using RestSharp;
using Tallon.Knocker.Core;

namespace Tallon.Knocker.Service
{
    public partial class MainService : ServiceBase
    {
        public MainService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            EventLog.WriteEntry("Knocker Service Starting...");
            Action<string> foundAction = s =>
            {
                EventLog.WriteEntry(s);
 
                // launch the application
                ApplicationLoader.PROCESS_INFORMATION procInfo;
                ApplicationLoader.StartProcessAndBypassUAC(@"C:\Services\Tallon.Knocker.Notification.exe", out procInfo);

                //var client = new RestClient("https://www.size.com");
                //var request = new RestRequest("/doorbell.asp", Method.POST);
                //client.Proxy = new WebProxy("proxy...");
                //client.Execute(request);
                
            };
            ComReader.Register(foundAction);
        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("Knocker Service Stopped...");
        }
    }
}
