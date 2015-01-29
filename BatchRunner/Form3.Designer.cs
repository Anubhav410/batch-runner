namespace BatchRunner
{
    partial class Form3
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mc_2 = new System.Windows.Forms.Label();
            this.ip_2 = new System.Windows.Forms.Label();
            this.mc_1 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.ip1 = new System.Windows.Forms.TextBox();
            this.mc1 = new System.Windows.Forms.TextBox();
            this.ip2 = new System.Windows.Forms.TextBox();
            this.mc2 = new System.Windows.Forms.TextBox();
            this.ip_1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.mc_2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ip_2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mc_1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ok, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cancel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ip1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mc1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ip2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.mc2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ip_1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 121);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // mc_2
            // 
            this.mc_2.AutoSize = true;
            this.mc_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mc_2.Location = new System.Drawing.Point(3, 72);
            this.mc_2.Name = "mc_2";
            this.mc_2.Size = new System.Drawing.Size(224, 24);
            this.mc_2.TabIndex = 9;
            this.mc_2.Text = "Viewer Name";
            this.mc_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ip_2
            // 
            this.ip_2.AutoSize = true;
            this.ip_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ip_2.Location = new System.Drawing.Point(3, 48);
            this.ip_2.Name = "ip_2";
            this.ip_2.Size = new System.Drawing.Size(224, 24);
            this.ip_2.TabIndex = 8;
            this.ip_2.Text = "Viewer IP";
            this.ip_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mc_1
            // 
            this.mc_1.AutoSize = true;
            this.mc_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mc_1.Location = new System.Drawing.Point(3, 24);
            this.mc_1.Name = "mc_1";
            this.mc_1.Size = new System.Drawing.Size(224, 24);
            this.mc_1.TabIndex = 7;
            this.mc_1.Text = "Host Name";
            this.mc_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ok
            // 
            this.ok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ok.Location = new System.Drawing.Point(3, 99);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(224, 19);
            this.ok.TabIndex = 0;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancel.Location = new System.Drawing.Point(233, 99);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(224, 19);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ip1
            // 
            this.ip1.Location = new System.Drawing.Point(233, 3);
            this.ip1.Name = "ip1";
            this.ip1.Size = new System.Drawing.Size(224, 20);
            this.ip1.TabIndex = 2;
            this.ip1.TextChanged += new System.EventHandler(this.ip1_TextChanged);
            // 
            // mc1
            // 
            this.mc1.Location = new System.Drawing.Point(233, 27);
            this.mc1.Name = "mc1";
            this.mc1.Size = new System.Drawing.Size(224, 20);
            this.mc1.TabIndex = 3;
            // 
            // ip2
            // 
            this.ip2.Location = new System.Drawing.Point(233, 51);
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(224, 20);
            this.ip2.TabIndex = 4;
            // 
            // mc2
            // 
            this.mc2.Location = new System.Drawing.Point(233, 75);
            this.mc2.Name = "mc2";
            this.mc2.Size = new System.Drawing.Size(224, 20);
            this.mc2.TabIndex = 5;
            // 
            // ip_1
            // 
            this.ip_1.AutoSize = true;
            this.ip_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ip_1.Location = new System.Drawing.Point(3, 0);
            this.ip_1.Name = "ip_1";
            this.ip_1.Size = new System.Drawing.Size(224, 24);
            this.ip_1.TabIndex = 6;
            this.ip_1.Text = "Host IP";
            this.ip_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 121);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form3";
            this.Text = "Edit Machine Details";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox ip1;
        private System.Windows.Forms.TextBox mc1;
        private System.Windows.Forms.TextBox ip2;
        private System.Windows.Forms.TextBox mc2;
        private System.Windows.Forms.Label ip_1;
        private System.Windows.Forms.Label mc_2;
        private System.Windows.Forms.Label ip_2;
        private System.Windows.Forms.Label mc_1;
    }
}