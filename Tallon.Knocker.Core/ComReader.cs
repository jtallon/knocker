using System;
using System.IO.Ports;
using System.Linq;
using Tallon.Knocker.Core.Helpers;

namespace Tallon.Knocker.Core
{
    public static class ComReader
    {
        private static SerialPort _port;

        private static SerialPort Port
        {
            get
            {
                if (_port == null)
                {
                    FoundPort();
                    _port = new SerialPort(ConfigHelper.PortName, ConfigHelper.BaudRate);
                }

                if (!_port.IsOpen)
                {
                    _port.Open();
                }

                return _port;
            }
        }

        public static void Register(Action<string> callAction)
        {
            Port.DataReceived += (sender, args) => callAction(Port.ReadLine());
        }

        public static bool FoundPort()
        {
            var portName = ConfigHelper.PortName;
            if (string.IsNullOrEmpty(portName))
            {
                throw new Exception("Data for portname is incorrect. Please check your App.config file.");
            }
            var results = (from y in SerialPort.GetPortNames() where y.ToLower().Contains(portName.ToLower()) select y).FirstOrDefault();
            return results != null;
        }
    }
}
