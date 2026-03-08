namespace SimpleFirewallManagerUI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.FlowLayoutPanel Flow_RulesMenuBar;
            System.Windows.Forms.Label label_Folders;
            System.Windows.Forms.Label label_Rules;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FLP_folders = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_RulesMenu = new System.Windows.Forms.Panel();
            this.FLP_FirewallRules = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_AddRule = new System.Windows.Forms.Button();
            this.btn_DeleteRule = new System.Windows.Forms.Button();
            this.btn_EditRule = new System.Windows.Forms.Button();
            this.btn_Deactivate = new System.Windows.Forms.Button();
            Flow_RulesMenuBar = new System.Windows.Forms.FlowLayoutPanel();
            label_Folders = new System.Windows.Forms.Label();
            label_Rules = new System.Windows.Forms.Label();
            Flow_RulesMenuBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel_RulesMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Flow_RulesMenuBar
            // 
            Flow_RulesMenuBar.Controls.Add(this.btn_AddRule);
            Flow_RulesMenuBar.Controls.Add(this.btn_DeleteRule);
            Flow_RulesMenuBar.Controls.Add(this.btn_EditRule);
            Flow_RulesMenuBar.Controls.Add(this.btn_Deactivate);
            Flow_RulesMenuBar.Dock = System.Windows.Forms.DockStyle.Fill;
            Flow_RulesMenuBar.Location = new System.Drawing.Point(0, 0);
            Flow_RulesMenuBar.Margin = new System.Windows.Forms.Padding(0);
            Flow_RulesMenuBar.Name = "Flow_RulesMenuBar";
            Flow_RulesMenuBar.Size = new System.Drawing.Size(1032, 73);
            Flow_RulesMenuBar.TabIndex = 0;
            // 
            // label_Folders
            // 
            label_Folders.AutoSize = true;
            label_Folders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label_Folders.Dock = System.Windows.Forms.DockStyle.Fill;
            label_Folders.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_Folders.Location = new System.Drawing.Point(0, 0);
            label_Folders.Margin = new System.Windows.Forms.Padding(0);
            label_Folders.Name = "label_Folders";
            label_Folders.Size = new System.Drawing.Size(150, 30);
            label_Folders.TabIndex = 2;
            label_Folders.Text = "Folders";
            label_Folders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Rules
            // 
            label_Rules.AutoSize = true;
            label_Rules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label_Rules.Dock = System.Windows.Forms.DockStyle.Fill;
            label_Rules.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_Rules.Location = new System.Drawing.Point(150, 0);
            label_Rules.Margin = new System.Windows.Forms.Padding(0);
            label_Rules.Name = "label_Rules";
            label_Rules.Size = new System.Drawing.Size(1034, 30);
            label_Rules.TabIndex = 3;
            label_Rules.Text = "Rules";
            label_Rules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.FLP_folders, 0, 2);
            this.tableLayoutPanel1.Controls.Add(label_Rules, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel_RulesMenu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(label_Folders, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FLP_FirewallRules, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 761);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FLP_folders
            // 
            this.FLP_folders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLP_folders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_folders.Location = new System.Drawing.Point(0, 105);
            this.FLP_folders.Margin = new System.Windows.Forms.Padding(0);
            this.FLP_folders.Name = "FLP_folders";
            this.FLP_folders.Size = new System.Drawing.Size(150, 656);
            this.FLP_folders.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 75);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button3);
            this.flowLayoutPanel2.Controls.Add(this.button4);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(148, 73);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // panel_RulesMenu
            // 
            this.panel_RulesMenu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel_RulesMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_RulesMenu.Controls.Add(Flow_RulesMenuBar);
            this.panel_RulesMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_RulesMenu.Location = new System.Drawing.Point(150, 30);
            this.panel_RulesMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panel_RulesMenu.Name = "panel_RulesMenu";
            this.panel_RulesMenu.Size = new System.Drawing.Size(1034, 75);
            this.panel_RulesMenu.TabIndex = 0;
            // 
            // FLP_FirewallRules
            // 
            this.FLP_FirewallRules.AutoScroll = true;
            this.FLP_FirewallRules.AutoScrollMinSize = new System.Drawing.Size(0, 571);
            this.FLP_FirewallRules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLP_FirewallRules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLP_FirewallRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_FirewallRules.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLP_FirewallRules.Location = new System.Drawing.Point(150, 105);
            this.FLP_FirewallRules.Margin = new System.Windows.Forms.Padding(0);
            this.FLP_FirewallRules.Name = "FLP_FirewallRules";
            this.FLP_FirewallRules.Size = new System.Drawing.Size(1034, 656);
            this.FLP_FirewallRules.TabIndex = 4;
            this.FLP_FirewallRules.WrapContents = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::SimpleFirewallManagerUI.Properties.Resources.icons8_ajouter_48;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(3, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::SimpleFirewallManagerUI.Properties.Resources.icons8_supprimer_pour_toujours_48;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(49, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_AddRule
            // 
            this.btn_AddRule.BackgroundImage = global::SimpleFirewallManagerUI.Properties.Resources.icons8_ajouter_48;
            this.btn_AddRule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddRule.Location = new System.Drawing.Point(3, 3);
            this.btn_AddRule.Name = "btn_AddRule";
            this.btn_AddRule.Size = new System.Drawing.Size(60, 60);
            this.btn_AddRule.TabIndex = 0;
            this.btn_AddRule.UseVisualStyleBackColor = true;
            this.btn_AddRule.Click += new System.EventHandler(this.btn_AddRule_Click);
            // 
            // btn_DeleteRule
            // 
            this.btn_DeleteRule.BackgroundImage = global::SimpleFirewallManagerUI.Properties.Resources.icons8_supprimer_pour_toujours_48;
            this.btn_DeleteRule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_DeleteRule.Location = new System.Drawing.Point(69, 3);
            this.btn_DeleteRule.Name = "btn_DeleteRule";
            this.btn_DeleteRule.Size = new System.Drawing.Size(60, 60);
            this.btn_DeleteRule.TabIndex = 1;
            this.btn_DeleteRule.UseVisualStyleBackColor = true;
            this.btn_DeleteRule.Click += new System.EventHandler(this.btn_DeleteRule_Click);
            // 
            // btn_EditRule
            // 
            this.btn_EditRule.BackgroundImage = global::SimpleFirewallManagerUI.Properties.Resources.icons8_créer_un_nouveau_48;
            this.btn_EditRule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_EditRule.Location = new System.Drawing.Point(135, 3);
            this.btn_EditRule.Name = "btn_EditRule";
            this.btn_EditRule.Size = new System.Drawing.Size(60, 60);
            this.btn_EditRule.TabIndex = 3;
            this.btn_EditRule.UseVisualStyleBackColor = true;
            this.btn_EditRule.Click += new System.EventHandler(this.btn_EditRule_Click);
            // 
            // btn_Deactivate
            // 
            this.btn_Deactivate.BackgroundImage = global::SimpleFirewallManagerUI.Properties.Resources.icons8_minus_48;
            this.btn_Deactivate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Deactivate.Location = new System.Drawing.Point(201, 3);
            this.btn_Deactivate.Name = "btn_Deactivate";
            this.btn_Deactivate.Size = new System.Drawing.Size(60, 60);
            this.btn_Deactivate.TabIndex = 2;
            this.btn_Deactivate.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            Flow_RulesMenuBar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel_RulesMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_RulesMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_AddRule;
        private System.Windows.Forms.Button btn_DeleteRule;
        private System.Windows.Forms.Button btn_Deactivate;
        private System.Windows.Forms.FlowLayoutPanel FLP_folders;
        private System.Windows.Forms.FlowLayoutPanel FLP_FirewallRules;
        private System.Windows.Forms.Button btn_EditRule;
    }
}

