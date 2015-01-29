namespace BatchRunner
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.selectFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listUnSelectedTCs = new System.Windows.Forms.CheckedListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.makeBatch = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.profile1_radio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.listSelectedTCs = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nightlyRadio = new System.Windows.Forms.RadioButton();
            this.localRadio = new System.Windows.Forms.RadioButton();
            this.integrationRadio = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.add = new System.Windows.Forms.Button();
            this.machine_details = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.04792F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.95208F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.selectFolder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listUnSelectedTCs, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1276, 581);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(554, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(716, 56);
            this.label2.TabIndex = 2;
            this.label2.Text = "List Of Selected TestCase ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectFolder
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.selectFolder, 2);
            this.selectFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectFolder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectFolder.Location = new System.Drawing.Point(6, 6);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(1264, 50);
            this.selectFolder.TabIndex = 0;
            this.selectFolder.Text = "Select Folder";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "List Of TestCase Files in  Folder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listUnSelectedTCs
            // 
            this.listUnSelectedTCs.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listUnSelectedTCs.CheckOnClick = true;
            this.listUnSelectedTCs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUnSelectedTCs.FormattingEnabled = true;
            this.listUnSelectedTCs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listUnSelectedTCs.Location = new System.Drawing.Point(6, 124);
            this.listUnSelectedTCs.Name = "listUnSelectedTCs";
            this.listUnSelectedTCs.Size = new System.Drawing.Size(539, 333);
            this.listUnSelectedTCs.TabIndex = 3;
            this.listUnSelectedTCs.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.makeBatch);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(554, 466);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(716, 109);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // makeBatch
            // 
            this.makeBatch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.makeBatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.makeBatch.Location = new System.Drawing.Point(3, 3);
            this.makeBatch.Name = "makeBatch";
            this.makeBatch.Size = new System.Drawing.Size(707, 100);
            this.makeBatch.TabIndex = 1;
            this.makeBatch.Text = "Execute batch";
            this.makeBatch.UseVisualStyleBackColor = true;
            this.makeBatch.Click += new System.EventHandler(this.makeBatch_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.listSelectedTCs, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(554, 124);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(716, 333);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.profile1_radio);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(361, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 161);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // profile1_radio
            // 
            this.profile1_radio.AutoSize = true;
            this.profile1_radio.Checked = true;
            this.profile1_radio.Location = new System.Drawing.Point(112, 62);
            this.profile1_radio.Name = "profile1_radio";
            this.profile1_radio.Size = new System.Drawing.Size(105, 17);
            this.profile1_radio.TabIndex = 5;
            this.profile1_radio.TabStop = true;
            this.profile1_radio.Text = "integration_xp_i3";
            this.profile1_radio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "PROFILE";
            // 
            // listSelectedTCs
            // 
            this.listSelectedTCs.AllowDrop = true;
            this.listSelectedTCs.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listSelectedTCs.CheckOnClick = true;
            this.listSelectedTCs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSelectedTCs.FormattingEnabled = true;
            this.listSelectedTCs.HorizontalExtent = 1;
            this.listSelectedTCs.HorizontalScrollbar = true;
            this.listSelectedTCs.Location = new System.Drawing.Point(3, 3);
            this.listSelectedTCs.Name = "listSelectedTCs";
            this.tableLayoutPanel2.SetRowSpan(this.listSelectedTCs, 2);
            this.listSelectedTCs.Size = new System.Drawing.Size(352, 327);
            this.listSelectedTCs.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nightlyRadio);
            this.groupBox1.Controls.Add(this.localRadio);
            this.groupBox1.Controls.Add(this.integrationRadio);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(361, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 160);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "PROPERTIES";
            // 
            // nightlyRadio
            // 
            this.nightlyRadio.AutoSize = true;
            this.nightlyRadio.Location = new System.Drawing.Point(112, 123);
            this.nightlyRadio.Name = "nightlyRadio";
            this.nightlyRadio.Size = new System.Drawing.Size(72, 17);
            this.nightlyRadio.TabIndex = 2;
            this.nightlyRadio.TabStop = true;
            this.nightlyRadio.Text = "NIGHTLY";
            this.nightlyRadio.UseVisualStyleBackColor = true;
            // 
            // localRadio
            // 
            this.localRadio.AutoSize = true;
            this.localRadio.Checked = true;
            this.localRadio.Location = new System.Drawing.Point(112, 89);
            this.localRadio.Name = "localRadio";
            this.localRadio.Size = new System.Drawing.Size(59, 17);
            this.localRadio.TabIndex = 1;
            this.localRadio.TabStop = true;
            this.localRadio.Text = "LOCAL";
            this.localRadio.UseVisualStyleBackColor = true;
            this.localRadio.CheckedChanged += new System.EventHandler(this.localRadio_CheckedChanged);
            // 
            // integrationRadio
            // 
            this.integrationRadio.AutoSize = true;
            this.integrationRadio.Location = new System.Drawing.Point(112, 57);
            this.integrationRadio.Name = "integrationRadio";
            this.integrationRadio.Size = new System.Drawing.Size(99, 17);
            this.integrationRadio.TabIndex = 0;
            this.integrationRadio.TabStop = true;
            this.integrationRadio.Text = "INTEGRATION";
            this.integrationRadio.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.add);
            this.flowLayoutPanel2.Controls.Add(this.machine_details);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 466);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(539, 109);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(3, 3);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(234, 100);
            this.add.TabIndex = 0;
            this.add.Text = "Add Selected TestCases";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // machine_details
            // 
            this.machine_details.Location = new System.Drawing.Point(243, 3);
            this.machine_details.Name = "machine_details";
            this.machine_details.Size = new System.Drawing.Size(284, 100);
            this.machine_details.TabIndex = 1;
            this.machine_details.Text = "Edit Machine Details";
            this.machine_details.UseVisualStyleBackColor = true;
            this.machine_details.Click += new System.EventHandler(this.machine_detials_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 581);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Batch Runner";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox listUnSelectedTCs;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button makeBatch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckedListBox listSelectedTCs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton nightlyRadio;
        private System.Windows.Forms.RadioButton localRadio;
        private System.Windows.Forms.RadioButton integrationRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton profile1_radio;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button machine_details;
        private System.Windows.Forms.Label label1;
    }
}

