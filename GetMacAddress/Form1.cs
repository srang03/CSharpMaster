using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace GetMacAddress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Dictionary<string, string> macAddresses = new Dictionary<string, string>();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up || nic.OperationalStatus == OperationalStatus.Down)
                {
                    // macAddresses[nic.GetPhysicalAddress().ToString()] = nic.GetIPStatistics().BytesSent + nic.GetIPStatistics().BytesReceived;
                    // macAddresses[nic.GetPhysicalAddress().ToString()] = nic.NetworkInterfaceType.ToString();

                    listBox1.Items.Add($"name: {nic.Name}, key: {nic.GetPhysicalAddress()}, value: {nic.Id}, type: {nic.NetworkInterfaceType}");
                }
            }

        }
    }
}
