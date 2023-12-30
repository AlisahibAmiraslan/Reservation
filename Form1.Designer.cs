namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.filtercb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roomcbx = new System.Windows.Forms.ComboBox();
            this.chOutPc = new System.Windows.Forms.DateTimePicker();
            this.chOutlbl = new System.Windows.Forms.Label();
            this.resDatePc = new System.Windows.Forms.DateTimePicker();
            this.availibilitycbx = new System.Windows.Forms.ComboBox();
            this.avalbl = new System.Windows.Forms.Label();
            this.reslbl = new System.Windows.Forms.Label();
            this.roomlbl = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.roomdgw = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btnCheckOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomdgw)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(431, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(713, 236);
            this.dataGridView1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(431, 51);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(882, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1036, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 40);
            this.button4.TabIndex = 7;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // filtercb
            // 
            this.filtercb.FormattingEnabled = true;
            this.filtercb.Items.AddRange(new object[] {
            "free",
            "busy",
            "reserv"});
            this.filtercb.Location = new System.Drawing.Point(659, 49);
            this.filtercb.Name = "filtercb";
            this.filtercb.Size = new System.Drawing.Size(202, 24);
            this.filtercb.TabIndex = 8;
            this.filtercb.SelectedIndexChanged += new System.EventHandler(this.filtercb_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox1.Controls.Add(this.roomcbx);
            this.groupBox1.Controls.Add(this.chOutPc);
            this.groupBox1.Controls.Add(this.chOutlbl);
            this.groupBox1.Controls.Add(this.resDatePc);
            this.groupBox1.Controls.Add(this.availibilitycbx);
            this.groupBox1.Controls.Add(this.avalbl);
            this.groupBox1.Controls.Add(this.reslbl);
            this.groupBox1.Controls.Add(this.roomlbl);
            this.groupBox1.Location = new System.Drawing.Point(13, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 317);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // roomcbx
            // 
            this.roomcbx.FormattingEnabled = true;
            this.roomcbx.Location = new System.Drawing.Point(146, 39);
            this.roomcbx.Name = "roomcbx";
            this.roomcbx.Size = new System.Drawing.Size(220, 24);
            this.roomcbx.TabIndex = 9;
            this.roomcbx.SelectedIndexChanged += new System.EventHandler(this.roomcbx_SelectedIndexChanged);
            this.roomcbx.SelectionChangeCommitted += new System.EventHandler(this.roomcbx_SelectionChangeCommitted);
            // 
            // chOutPc
            // 
            this.chOutPc.Location = new System.Drawing.Point(146, 163);
            this.chOutPc.Name = "chOutPc";
            this.chOutPc.Size = new System.Drawing.Size(220, 22);
            this.chOutPc.TabIndex = 8;
            // 
            // chOutlbl
            // 
            this.chOutlbl.AutoSize = true;
            this.chOutlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chOutlbl.Location = new System.Drawing.Point(7, 163);
            this.chOutlbl.Name = "chOutlbl";
            this.chOutlbl.Size = new System.Drawing.Size(112, 25);
            this.chOutlbl.TabIndex = 7;
            this.chOutlbl.Text = "Check Out:";
            // 
            // resDatePc
            // 
            this.resDatePc.Location = new System.Drawing.Point(146, 112);
            this.resDatePc.Name = "resDatePc";
            this.resDatePc.Size = new System.Drawing.Size(220, 22);
            this.resDatePc.TabIndex = 6;
            // 
            // availibilitycbx
            // 
            this.availibilitycbx.FormattingEnabled = true;
            this.availibilitycbx.Items.AddRange(new object[] {
            "free",
            "busy",
            "reserv"});
            this.availibilitycbx.Location = new System.Drawing.Point(146, 212);
            this.availibilitycbx.Name = "availibilitycbx";
            this.availibilitycbx.Size = new System.Drawing.Size(220, 24);
            this.availibilitycbx.TabIndex = 5;
            // 
            // avalbl
            // 
            this.avalbl.AutoSize = true;
            this.avalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.avalbl.Location = new System.Drawing.Point(7, 212);
            this.avalbl.Name = "avalbl";
            this.avalbl.Size = new System.Drawing.Size(103, 25);
            this.avalbl.TabIndex = 4;
            this.avalbl.Text = "Availibility:";
            // 
            // reslbl
            // 
            this.reslbl.AutoSize = true;
            this.reslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reslbl.Location = new System.Drawing.Point(7, 112);
            this.reslbl.Name = "reslbl";
            this.reslbl.Size = new System.Drawing.Size(98, 25);
            this.reslbl.TabIndex = 2;
            this.reslbl.Text = "Res Date:";
            // 
            // roomlbl
            // 
            this.roomlbl.AutoSize = true;
            this.roomlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.roomlbl.Location = new System.Drawing.Point(7, 39);
            this.roomlbl.Name = "roomlbl";
            this.roomlbl.Size = new System.Drawing.Size(115, 25);
            this.roomlbl.TabIndex = 0;
            this.roomlbl.Text = "Room Num:";
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.Black;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Location = new System.Drawing.Point(55, 445);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(254, 55);
            this.sendBtn.TabIndex = 10;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // roomdgw
            // 
            this.roomdgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomdgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomdgw.Location = new System.Drawing.Point(531, 627);
            this.roomdgw.Name = "roomdgw";
            this.roomdgw.RowHeadersWidth = 51;
            this.roomdgw.RowTemplate.Height = 24;
            this.roomdgw.Size = new System.Drawing.Size(603, 304);
            this.roomdgw.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(767, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Rooms";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(882, 487);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(882, 528);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 15;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(40, 669);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(162, 83);
            this.btnCheckOut.TabIndex = 16;
            this.btnCheckOut.Text = "Count Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 953);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomdgw);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.filtercb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomdgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox filtercb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label avalbl;
        private System.Windows.Forms.Label reslbl;
        private System.Windows.Forms.Label roomlbl;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.ComboBox availibilitycbx;
        private System.Windows.Forms.DateTimePicker resDatePc;
        private System.Windows.Forms.DateTimePicker chOutPc;
        private System.Windows.Forms.Label chOutlbl;
        private System.Windows.Forms.DataGridView roomdgw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox roomcbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btnCheckOut;
    }
}

