namespace BestFit
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.StartingAddressFree = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoleSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressdata = new System.Windows.Forms.TextBox();
            this.holedata = new System.Windows.Forms.TextBox();
            this.enterdatabtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstfit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.worstfit = new System.Windows.Forms.RadioButton();
            this.bestfit = new System.Windows.Forms.RadioButton();
            this.output = new System.Windows.Forms.Button();
            this.processsize = new System.Windows.Forms.TextBox();
            this.processid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enterprocessbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StartingAddressFree,
            this.HoleSize});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(164, 158);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // StartingAddressFree
            // 
            this.StartingAddressFree.Text = "Starting Address";
            this.StartingAddressFree.Width = 92;
            // 
            // HoleSize
            // 
            this.HoleSize.Text = "Hole Size";
            this.HoleSize.Width = 103;
            // 
            // addressdata
            // 
            this.addressdata.Location = new System.Drawing.Point(106, 27);
            this.addressdata.Name = "addressdata";
            this.addressdata.Size = new System.Drawing.Size(100, 20);
            this.addressdata.TabIndex = 1;
            // 
            // holedata
            // 
            this.holedata.Location = new System.Drawing.Point(106, 65);
            this.holedata.Name = "holedata";
            this.holedata.Size = new System.Drawing.Size(100, 20);
            this.holedata.TabIndex = 2;
            // 
            // enterdatabtn
            // 
            this.enterdatabtn.Location = new System.Drawing.Point(237, 27);
            this.enterdatabtn.Name = "enterdatabtn";
            this.enterdatabtn.Size = new System.Drawing.Size(117, 23);
            this.enterdatabtn.TabIndex = 3;
            this.enterdatabtn.Text = "Enter Data";
            this.enterdatabtn.UseVisualStyleBackColor = true;
            this.enterdatabtn.Click += new System.EventHandler(this.enterdatabtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Starting Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hole Size";
            // 
            // firstfit
            // 
            this.firstfit.AutoSize = true;
            this.firstfit.Location = new System.Drawing.Point(13, 32);
            this.firstfit.Name = "firstfit";
            this.firstfit.Size = new System.Drawing.Size(58, 17);
            this.firstfit.TabIndex = 6;
            this.firstfit.TabStop = true;
            this.firstfit.Text = "First Fit";
            this.firstfit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.worstfit);
            this.groupBox1.Controls.Add(this.bestfit);
            this.groupBox1.Controls.Add(this.firstfit);
            this.groupBox1.Location = new System.Drawing.Point(218, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 124);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // worstfit
            // 
            this.worstfit.AutoSize = true;
            this.worstfit.Location = new System.Drawing.Point(13, 77);
            this.worstfit.Name = "worstfit";
            this.worstfit.Size = new System.Drawing.Size(67, 17);
            this.worstfit.TabIndex = 8;
            this.worstfit.TabStop = true;
            this.worstfit.Text = "Worst Fit";
            this.worstfit.UseVisualStyleBackColor = true;
            // 
            // bestfit
            // 
            this.bestfit.AutoSize = true;
            this.bestfit.Location = new System.Drawing.Point(13, 54);
            this.bestfit.Name = "bestfit";
            this.bestfit.Size = new System.Drawing.Size(60, 17);
            this.bestfit.TabIndex = 7;
            this.bestfit.TabStop = true;
            this.bestfit.Text = "Best Fit";
            this.bestfit.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(231, 68);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(117, 23);
            this.output.TabIndex = 8;
            this.output.Text = "Output ";
            this.output.UseVisualStyleBackColor = true;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // processsize
            // 
            this.processsize.Location = new System.Drawing.Point(448, 71);
            this.processsize.Name = "processsize";
            this.processsize.Size = new System.Drawing.Size(100, 20);
            this.processsize.TabIndex = 9;
            // 
            // processid
            // 
            this.processid.Location = new System.Drawing.Point(448, 30);
            this.processid.Name = "processid";
            this.processid.Size = new System.Drawing.Size(100, 20);
            this.processid.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Process Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Process ID";
            // 
            // listView2
            // 
            this.listView2.AllowColumnReorder = true;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(403, 97);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(236, 158);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Process ID";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Starting Address";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Process Size";
            this.columnHeader3.Width = 73;
            // 
            // enterprocessbtn
            // 
            this.enterprocessbtn.Location = new System.Drawing.Point(556, 49);
            this.enterprocessbtn.Name = "enterprocessbtn";
            this.enterprocessbtn.Size = new System.Drawing.Size(117, 23);
            this.enterprocessbtn.TabIndex = 14;
            this.enterprocessbtn.Text = "Enter Process Data";
            this.enterprocessbtn.UseVisualStyleBackColor = true;
            this.enterprocessbtn.Click += new System.EventHandler(this.enterprocessbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 261);
            this.Controls.Add(this.enterprocessbtn);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.processid);
            this.Controls.Add(this.processsize);
            this.Controls.Add(this.output);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterdatabtn);
            this.Controls.Add(this.holedata);
            this.Controls.Add(this.addressdata);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader StartingAddressFree;
        private System.Windows.Forms.ColumnHeader HoleSize;
        private System.Windows.Forms.TextBox addressdata;
        private System.Windows.Forms.TextBox holedata;
        private System.Windows.Forms.Button enterdatabtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton firstfit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton worstfit;
        private System.Windows.Forms.RadioButton bestfit;
        private System.Windows.Forms.Button output;
        private System.Windows.Forms.TextBox processsize;
        private System.Windows.Forms.TextBox processid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button enterprocessbtn;
    }
}

