using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Timers;
using Tallon.Knocker.Core.Helpers;
using Tallon.Knocker.Core.Models;

namespace Tallon.Knocker.Core
{
    public static class ComReader
    {
        private static SerialPort _port;
        private static Timer _timer;
        private static Timer _waitTimer;
        private static bool _waiting;

        private static SerialPort Port
        {
            get
            {
                if (_port == null)
                {
                    FoundPort();
                    _port = new SerialPort(ConfigHelper.PortName, ConfigHelper.BaudRate);
                }
                return _port;
            }
        }

        public static List<PortInfo> GetConnected()
        {
            var managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_SerialPort");
            var managementObjectCollection = managementObjectSearcher.Get();

            return (from ManagementObject m in managementObjectCollection
                select new PortInfo
                {
                    DeviceId = m["DeviceID"].ToString(), 
                    PnpDeviceId = m["PNPDeviceID"].ToString(), Name = m["Name"].ToString(), 
                    Caption = m["Caption"].ToString(), Description = m["Description"].ToString(), 
                    ProviderType = m["ProviderType"].ToString(), Status = m["Status"].ToString()
                }).ToList();
        }

        public static bool IsAvailable()
        {
            var items = GetConnected();
            foreach (var i in items)
            {
                if ((i.DeviceId == ConfigHelper.PortName) &&  (i.IsOnline()) && (i.Name.Contains(ConfigHelper.PortWildCard)))
                {
                    return true;
                }
            }

            return false;
        }


        public static void Register(Action<string> callAction)
        {
            _waitTimer = new Timer(5000); //Wait five seconds
            _waitTimer.Elapsed += (o, eventArgs) =>
            {
                _waiting = false;
                _waitTimer.Stop();
            };
            _waitTimer.Enabled = true;

            _timer = new Timer(3000); //Every three seconds check...
            _timer.Elapsed += (sender, args) =>
            {
                if (IsAvailable())
                {
                    if (!_port.IsOpen)
                    {
                        _port.Open();
                    }
                }
                else
                {
                    if (_port.IsOpen)
                    {
                        _port.Close();
                    }
                }
            };
            _timer.Enabled = true;
            Port.DataReceived += (sender, args) =>
            {
                _waitTimer.Start();
                if (!_waiting)
                {
                    callAction(Port.ReadLine());
                }
                _waiting = true;
            };
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
