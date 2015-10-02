namespace Tallon.Knocker.Core.Models
{
    public class PortInfo
    {
        public string DeviceId { get; set; }
        public string PnpDeviceId { get; set; }
        public string Name { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public string ProviderType { get; set; }
        public string Status { get; set; }

        public bool IsOnline()
        {
            return Status == "OK";
        }
    }
}
