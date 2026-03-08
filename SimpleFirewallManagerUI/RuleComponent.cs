using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SimpleFirewallManagerUI.MainWindow;

namespace SimpleFirewallManagerUI
{
    public partial class RuleComponent : UserControl
    {
        public event EventHandler<RuleSelectionArgs> RuleSelected;
        public Rule CurrentRule;
        public class RuleSelectionArgs : EventArgs
        {
            public RuleComponent SelectedRule { get; set; }
        }
        public RuleComponent(Rule rule, int flowLayoutWidth)
        {
            InitializeComponent();
            CurrentRule = rule;
            UpdateUI();
            Width = flowLayoutWidth;
        }

        public void resetSelection()
        {
            BackColor = SystemColors.ActiveBorder;
        }

        public void SelectRule()
        {
            BackColor = SystemColors.ActiveCaption;
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            RuleSelected?.Invoke(this, new RuleSelectionArgs { SelectedRule = this });
        }

        public void OnRuleDataUpdated(object sender, Rule.RuleData Editedrule)
        {
            CurrentRule.Data = Editedrule;
            UpdateUI();
        }

        private void UpdateUI()
        {
            ruleLabel.Text = CurrentRule.Data.Name;
            string description = $"ports:\"{CurrentRule.Data.Port}\" ";
            if (CurrentRule.Data.TCP)
            {
                description += "TCP ";
            }
            if (CurrentRule.Data.UDP)
            {
                description += "UDP ";
            }
            if (CurrentRule.Data.Inbound)
            {
                description += "Inbound ";
            }
            if (CurrentRule.Data.Outbound)
            {
                description += "Outbound";
            }
            ruleParamettersLabel.Text = description;
        }

        public void RemoveRule()
        {
            CurrentRule.RemoveRule();
        }
    }
}
