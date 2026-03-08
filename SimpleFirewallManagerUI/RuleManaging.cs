using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFirewallManagerUI
{
    public partial class RuleManaging : Form
    {
        public event EventHandler<Rule.RuleData> RuleUpdated;
        Rule CurrentRule;
        public RuleManaging(Rule rule)
        {
            InitializeComponent();
            CurrentRule = rule;
            TB_RuleName.Text = CurrentRule.Data.Name;
            TB_port.Text = CurrentRule.Data.Port;
            CB_TCP.Checked = CurrentRule.Data.TCP;
            CB_UDP.Checked = CurrentRule.Data.UDP;
            CB_Inbound.Checked = CurrentRule.Data.Inbound;
            CB_Outbound.Checked = CurrentRule.Data.Outbound;


        }

        private void BT_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_apply_Click(object sender, EventArgs e)
        {
            if (!Rule.FirewallPort.ValidatePort(TB_port.Text))
            {
                MessageBox.Show("Invalid port(s) format. Please enter a valid port or range of ports.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Rule.RuleData NewRule = new Rule.RuleData
            {
                Name = TB_RuleName.Text,
                Port = TB_port.Text,
                TCP = CB_TCP.Checked,
                UDP = CB_UDP.Checked,
                Inbound = CB_Inbound.Checked,
                Outbound = CB_Outbound.Checked
            };

            RuleUpdated?.Invoke(this, NewRule);
            this.Close();
        }
    }
}
