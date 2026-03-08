using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SimpleFirewallManagerUI.RuleComponent;

namespace SimpleFirewallManagerUI
{
    public partial class MainWindow : Form
    {
        //debug
        int ruleCount = 0;

        //values
        RuleManaging RuleEditWindow;
        RuleComponent CurentSelectedRule;

        // UI interaction events
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddRule_Click(object sender, EventArgs e)
        {
            ruleCount++;
            Rule newRule = new Rule(new Rule.RuleData($"test{ruleCount}"));
            RuleComponent rule = new RuleComponent(newRule, FLP_FirewallRules.Width-25);
            rule.RuleSelected += OnRuleSelected;
            FLP_FirewallRules.Controls.Add(rule);
        }



        //Methods
        
        public void OnRuleSelected(object sender, RuleSelectionArgs args)
        {
            if (CurentSelectedRule == args.SelectedRule)
            {
                return;
            }

            if (CurentSelectedRule != null)
            {
                CurentSelectedRule.resetSelection();
            }
            CurentSelectedRule = args.SelectedRule;
            CurentSelectedRule.SelectRule();



            /*            if (RuleEditWindow != null)
                        {
                            RuleEditWindow.Close();
                        }
                        RuleEditWindow = new RuleManaging(new Rule(new ruleData("title")));
                        RuleEditWindow.Show();
                        Console.WriteLine(rule.ruleLabel);*/
        }

        private void btn_EditRule_Click(object sender, EventArgs e)
        {
            if (RuleEditWindow != null)
            {
                RuleEditWindow.Close();
            }
            RuleEditWindow = new RuleManaging(CurentSelectedRule.CurrentRule);
            RuleEditWindow.RuleUpdated += CurentSelectedRule.OnRuleDataUpdated;
            RuleEditWindow.Show();
        }

        private void btn_DeleteRule_Click(object sender, EventArgs e)
        {
            if (CurentSelectedRule != null)
            {
                CurentSelectedRule.RemoveRule();
                FLP_FirewallRules.Controls.Remove(CurentSelectedRule);
            }
            CurentSelectedRule = null;
        }
    }
}
