using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFirewallManagerUI
{
    public class Rule
    {
        public RuleData Data;
        public Rule(RuleData data) { Data = data; }

        public void RemoveRule()
        {





        }

        public struct RuleData
        {
            public RuleData(string inName = "none", string inPort = "80", bool isTCP = true, bool isUDP = true, bool isInbound = true, bool isOutbound = true)
            {
                Name = inName;
                Port = inPort;
                TCP = isTCP;
                UDP = isUDP;
                Inbound = isInbound;
                Outbound = isOutbound;
            }
            public string Name { get; set; }
            public string Port { get; set; }
            public bool TCP { get; set; }
            public bool UDP { get; set; }
            public bool Inbound { get; set; }
            public bool Outbound { get; set; }
        }
        public struct FirewallPort
        {
            string Port { get; set; }
            public static bool ValidatePort(string portsList)
            {
                if (portsList == string.Empty)
                {
                    return false;
                }
                List<string> ports = new List<string>(portsList.Split(','));
                foreach (string portdata in ports)
                {

                    List<string> portrange = new List<string>(portdata.Split('-'));
                    foreach (string port in portrange)
                    {
                        string trimedPort = port.Trim();
                        if (trimedPort == string.Empty)
                        {
                            return false;
                        }
                        if (!int.TryParse(trimedPort, out int portNum))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }

}