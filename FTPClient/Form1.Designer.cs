namespace FTPClient
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
            this.displayB = new System.Windows.Forms.Button();
            this.addressBarTE = new System.Windows.Forms.TextBox();
            this.userTE = new System.Windows.Forms.TextBox();
            this.pasTE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contentLB = new System.Windows.Forms.ListBox();
            this.downloadB = new System.Windows.Forms.Button();
            this.uploadB = new System.Windows.Forms.Button();
            this.directoryB = new System.Windows.Forms.Button();
            this.uploadTB = new System.Windows.Forms.TextBox();
            this.downloadTB = new System.Windows.Forms.TextBox();
            this.makedirectoryTB = new System.Windows.Forms.TextBox();
            this.moveB = new System.Windows.Forms.Button();
            this.destinationTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.uploadTB2 = new System.Windows.Forms.TextBox();
            this.deleteB = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayB
            // 
            this.displayB.Location = new System.Drawing.Point(558, 18);
            this.displayB.Name = "displayB";
            this.displayB.Size = new System.Drawing.Size(111, 23);
            this.displayB.TabIndex = 0;
            this.displayB.Text = "Dsiplay Content";
            this.displayB.UseVisualStyleBackColor = true;
            this.displayB.Click += new System.EventHandler(this.displayB_Click);
            // 
            // addressBarTE
            // 
            this.addressBarTE.Location = new System.Drawing.Point(334, 47);
            this.addressBarTE.Name = "addressBarTE";
            this.addressBarTE.Size = new System.Drawing.Size(346, 20);
            this.addressBarTE.TabIndex = 1;
            this.addressBarTE.Text = "127.0.0.1";
            // 
            // userTE
            // 
            this.userTE.Location = new System.Drawing.Point(107, 35);
            this.userTE.Name = "userTE";
            this.userTE.Size = new System.Drawing.Size(100, 20);
            this.userTE.TabIndex = 2;
            this.userTE.Text = "benglish";
            // 
            // pasTE
            // 
            this.pasTE.Location = new System.Drawing.Point(107, 71);
            this.pasTE.Name = "pasTE";
            this.pasTE.Size = new System.Drawing.Size(100, 20);
            this.pasTE.TabIndex = 3;
            this.pasTE.Text = "ben11";
            this.pasTE.UseSystemPasswordChar = true;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "fttp://";
            // 
            // contentLB
            // 
            this.contentLB.FormattingEnabled = true;
            this.contentLB.Location = new System.Drawing.Point(20, 57);
            this.contentLB.Name = "contentLB";
            this.contentLB.Size = new System.Drawing.Size(175, 290);
            this.contentLB.TabIndex = 10;
            // 
            // downloadB
            // 
            this.downloadB.Location = new System.Drawing.Point(558, 69);
            this.downloadB.Name = "downloadB";
            this.downloadB.Size = new System.Drawing.Size(111, 23);
            this.downloadB.TabIndex = 11;
            this.downloadB.Text = "Download";
            this.downloadB.UseVisualStyleBackColor = true;
            this.downloadB.Click += new System.EventHandler(this.downloadB_Click);
            // 
            // uploadB
            // 
            this.uploadB.Location = new System.Drawing.Point(558, 151);
            this.uploadB.Name = "uploadB";
            this.uploadB.Size = new System.Drawing.Size(111, 24);
            this.uploadB.TabIndex = 13;
            this.uploadB.Text = "Upload a file";
            this.uploadB.UseVisualStyleBackColor = true;
            this.uploadB.Click += new System.EventHandler(this.uploadB_Click);
            // 
            // directoryB
            // 
            this.directoryB.Location = new System.Drawing.Point(558, 219);
            this.directoryB.Name = "directoryB";
            this.directoryB.Size = new System.Drawing.Size(111, 24);
            this.directoryB.TabIndex = 14;
            this.directoryB.Text = "Make directory";
            this.directoryB.UseVisualStyleBackColor = true;
            this.directoryB.Click += new System.EventHandler(this.directoryB_Click);
            // 
            // uploadTB
            // 
            this.uploadTB.Location = new System.Drawing.Point(258, 125);
            this.uploadTB.Name = "uploadTB";
            this.uploadTB.Size = new System.Drawing.Size(283, 20);
            this.uploadTB.TabIndex = 15;
            this.uploadTB.Text = "E://1.txt";
            // 
            // downloadTB
            // 
            this.downloadTB.Location = new System.Drawing.Point(258, 70);
            this.downloadTB.Name = "downloadTB";
            this.downloadTB.Size = new System.Drawing.Size(283, 20);
            this.downloadTB.TabIndex = 16;
            this.downloadTB.Text = "E://";
            // 
            // makedirectoryTB
            // 
            this.makedirectoryTB.Location = new System.Drawing.Point(258, 218);
            this.makedirectoryTB.Name = "makedirectoryTB";
            this.makedirectoryTB.Size = new System.Drawing.Size(283, 20);
            this.makedirectoryTB.TabIndex = 17;
            this.makedirectoryTB.Text = "hello";
            // 
            // moveB
            // 
            this.moveB.Location = new System.Drawing.Point(558, 271);
            this.moveB.Name = "moveB";
            this.moveB.Size = new System.Drawing.Size(111, 23);
            this.moveB.TabIndex = 18;
            this.moveB.Text = "Move a file";
            this.moveB.UseVisualStyleBackColor = true;
            this.moveB.Click += new System.EventHandler(this.moveB_Click);
            // 
            // destinationTB
            // 
            this.destinationTB.Location = new System.Drawing.Point(258, 275);
            this.destinationTB.Name = "destinationTB";
            this.destinationTB.Size = new System.Drawing.Size(283, 20);
            this.destinationTB.TabIndex = 19;
            this.destinationTB.Text = "The name of the file to move";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addressBarTE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.userTE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pasTE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(51, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FTP features";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.uploadTB2);
            this.groupBox2.Controls.Add(this.deleteB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.downloadTB);
            this.groupBox2.Controls.Add(this.downloadB);
            this.groupBox2.Controls.Add(this.contentLB);
            this.groupBox2.Controls.Add(this.moveB);
            this.groupBox2.Controls.Add(this.destinationTB);
            this.groupBox2.Controls.Add(this.uploadTB);
            this.groupBox2.Controls.Add(this.uploadB);
            this.groupBox2.Controls.Add(this.directoryB);
            this.groupBox2.Controls.Add(this.makedirectoryTB);
            this.groupBox2.Controls.Add(this.displayB);
            this.groupBox2.Location = new System.Drawing.Point(51, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 361);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions to do ...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Directory of the second to-be-uploaded file";
            // 
            // uploadTB2
            // 
            this.uploadTB2.Location = new System.Drawing.Point(258, 168);
            this.uploadTB2.Name = "uploadTB2";
            this.uploadTB2.Size = new System.Drawing.Size(283, 20);
            this.uploadTB2.TabIndex = 26;
            this.uploadTB2.Text = "E://2.txt";
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(558, 322);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(111, 23);
            this.deleteB.TabIndex = 25;
            this.deleteB.Text = "Delete";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Name of destination address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Name of to-be-created folder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Directory of the first to-be-uploaded file";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Directory of to-be-downloaded file";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "List directory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 494);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button displayB;
        private System.Windows.Forms.TextBox addressBarTE;
        private System.Windows.Forms.TextBox userTE;
        private System.Windows.Forms.TextBox pasTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox contentLB;
        private System.Windows.Forms.Button downloadB;
        private System.Windows.Forms.Button uploadB;
        private System.Windows.Forms.Button directoryB;
        private System.Windows.Forms.TextBox uploadTB;
        private System.Windows.Forms.TextBox downloadTB;
        private System.Windows.Forms.TextBox makedirectoryTB;
        private System.Windows.Forms.Button moveB;
        private System.Windows.Forms.TextBox destinationTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox uploadTB2;
    }
}

