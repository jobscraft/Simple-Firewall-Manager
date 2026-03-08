namespace SimpleFirewallManagerUI
{
    partial class RuleManaging
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
            System.Windows.Forms.Label title;
            System.Windows.Forms.GroupBox PortGB;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label1;
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.CB_Outbound = new System.Windows.Forms.CheckBox();
            this.CB_Inbound = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TB_RuleName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_cancel = new System.Windows.Forms.Button();
            this.BT_apply = new System.Windows.Forms.Button();
            this.TB_port = new System.Windows.Forms.TextBox();
            this.CB_TCP = new System.Windows.Forms.CheckBox();
            this.CB_UDP = new System.Windows.Forms.CheckBox();
            title = new System.Windows.Forms.Label();
            PortGB = new System.Windows.Forms.GroupBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            PortGB.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Dock = System.Windows.Forms.DockStyle.Fill;
            title.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title.Location = new System.Drawing.Point(3, 0);
            title.Name = "title";
            title.Size = new System.Drawing.Size(678, 30);
            title.TabIndex = 0;
            title.Text = "Rule Edit";
            title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PortGB
            // 
            PortGB.Controls.Add(this.tableLayoutPanel3);
            PortGB.Dock = System.Windows.Forms.DockStyle.Fill;
            PortGB.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PortGB.Location = new System.Drawing.Point(3, 3);
            PortGB.Name = "PortGB";
            PortGB.Size = new System.Drawing.Size(478, 147);
            PortGB.TabIndex = 1;
            PortGB.TabStop = false;
            PortGB.Text = "Port";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.CB_UDP, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.TB_port, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.CB_TCP, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(472, 122);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.tableLayoutPanel4);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox1.Location = new System.Drawing.Point(3, 178);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(478, 113);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Direction";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.CB_Outbound, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.CB_Inbound, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(472, 88);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // CB_Outbound
            // 
            this.CB_Outbound.AutoSize = true;
            this.CB_Outbound.Dock = System.Windows.Forms.DockStyle.Left;
            this.CB_Outbound.Location = new System.Drawing.Point(286, 3);
            this.CB_Outbound.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.CB_Outbound.Name = "CB_Outbound";
            this.CB_Outbound.Size = new System.Drawing.Size(97, 82);
            this.CB_Outbound.TabIndex = 4;
            this.CB_Outbound.Text = "Outbound";
            this.CB_Outbound.UseVisualStyleBackColor = true;
            // 
            // CB_Inbound
            // 
            this.CB_Inbound.AutoSize = true;
            this.CB_Inbound.Dock = System.Windows.Forms.DockStyle.Right;
            this.CB_Inbound.Location = new System.Drawing.Point(100, 3);
            this.CB_Inbound.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.CB_Inbound.Name = "CB_Inbound";
            this.CB_Inbound.Size = new System.Drawing.Size(86, 82);
            this.CB_Inbound.TabIndex = 3;
            this.CB_Inbound.Text = "Inbound";
            this.CB_Inbound.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TB_RuleName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TB_RuleName
            // 
            this.TB_RuleName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TB_RuleName.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_RuleName.Location = new System.Drawing.Point(150, 42);
            this.TB_RuleName.Margin = new System.Windows.Forms.Padding(150, 5, 150, 5);
            this.TB_RuleName.Name = "TB_RuleName";
            this.TB_RuleName.Size = new System.Drawing.Size(384, 29);
            this.TB_RuleName.TabIndex = 2;
            this.TB_RuleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(groupBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(PortGB, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(100, 79);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(100, 3, 100, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(484, 294);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BT_cancel);
            this.panel1.Controls.Add(this.BT_apply);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 79);
            this.panel1.TabIndex = 3;
            // 
            // BT_cancel
            // 
            this.BT_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_cancel.Location = new System.Drawing.Point(9, 47);
            this.BT_cancel.Name = "BT_cancel";
            this.BT_cancel.Size = new System.Drawing.Size(75, 23);
            this.BT_cancel.TabIndex = 1;
            this.BT_cancel.Text = "Cancel";
            this.BT_cancel.UseVisualStyleBackColor = true;
            this.BT_cancel.Click += new System.EventHandler(this.BT_cancel_Click);
            // 
            // BT_apply
            // 
            this.BT_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_apply.Location = new System.Drawing.Point(594, 47);
            this.BT_apply.Name = "BT_apply";
            this.BT_apply.Size = new System.Drawing.Size(75, 23);
            this.BT_apply.TabIndex = 0;
            this.BT_apply.Text = "Apply";
            this.BT_apply.UseVisualStyleBackColor = true;
            this.BT_apply.Click += new System.EventHandler(this.BT_apply_Click);
            // 
            // TB_port
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.TB_port, 2);
            this.TB_port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_port.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_port.Location = new System.Drawing.Point(100, 15);
            this.TB_port.Margin = new System.Windows.Forms.Padding(100, 15, 100, 10);
            this.TB_port.Name = "TB_port";
            this.TB_port.Size = new System.Drawing.Size(272, 22);
            this.TB_port.TabIndex = 2;
            this.TB_port.Text = "80";
            this.TB_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CB_TCP
            // 
            this.CB_TCP.AutoSize = true;
            this.CB_TCP.Dock = System.Windows.Forms.DockStyle.Right;
            this.CB_TCP.Location = new System.Drawing.Point(130, 75);
            this.CB_TCP.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.CB_TCP.Name = "CB_TCP";
            this.CB_TCP.Size = new System.Drawing.Size(56, 44);
            this.CB_TCP.TabIndex = 3;
            this.CB_TCP.Text = "TCP";
            this.CB_TCP.UseVisualStyleBackColor = true;
            // 
            // CB_UDP
            // 
            this.CB_UDP.AutoSize = true;
            this.CB_UDP.Dock = System.Windows.Forms.DockStyle.Left;
            this.CB_UDP.Location = new System.Drawing.Point(286, 75);
            this.CB_UDP.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.CB_UDP.Name = "CB_UDP";
            this.CB_UDP.Size = new System.Drawing.Size(59, 44);
            this.CB_UDP.TabIndex = 4;
            this.CB_UDP.Text = "UDP";
            this.CB_UDP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(label1, 2);
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 42);
            label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(466, 20);
            label1.TabIndex = 5;
            label1.Text = "exemple: 80, 443 , 5000-5010";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RuleManaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "RuleManaging";
            this.Text = "RuleManaging";
            PortGB.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TB_RuleName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.CheckBox CB_Outbound;
        private System.Windows.Forms.CheckBox CB_Inbound;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_cancel;
        private System.Windows.Forms.Button BT_apply;
        private System.Windows.Forms.CheckBox CB_UDP;
        private System.Windows.Forms.TextBox TB_port;
        private System.Windows.Forms.CheckBox CB_TCP;
    }
}