namespace Record_CameraIP
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
               this.txtIP_Address = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.btnRecord = new System.Windows.Forms.Button();
               this.btnStop = new System.Windows.Forms.Button();
               this.btnStart = new System.Windows.Forms.Button();
               this.label2 = new System.Windows.Forms.Label();
               this.panel1 = new System.Windows.Forms.Panel();
               this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
               this.label3 = new System.Windows.Forms.Label();
               this.txtPass = new System.Windows.Forms.TextBox();
               this.label4 = new System.Windows.Forms.Label();
               this.txtUser = new System.Windows.Forms.TextBox();
               this.groupBox1.SuspendLayout();
               this.SuspendLayout();
               // 
               // txtIP_Address
               // 
               this.txtIP_Address.Location = new System.Drawing.Point(76, 362);
               this.txtIP_Address.Name = "txtIP_Address";
               this.txtIP_Address.Size = new System.Drawing.Size(502, 20);
               this.txtIP_Address.TabIndex = 1;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(12, 365);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(58, 13);
               this.label1.TabIndex = 2;
               this.label1.Text = "IP Address";
               // 
               // groupBox1
               // 
               this.groupBox1.Controls.Add(this.btnRecord);
               this.groupBox1.Controls.Add(this.btnStop);
               this.groupBox1.Controls.Add(this.btnStart);
               this.groupBox1.Location = new System.Drawing.Point(16, 500);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(563, 70);
               this.groupBox1.TabIndex = 3;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Controls";
               // 
               // btnRecord
               // 
               this.btnRecord.Location = new System.Drawing.Point(438, 31);
               this.btnRecord.Name = "btnRecord";
               this.btnRecord.Size = new System.Drawing.Size(75, 23);
               this.btnRecord.TabIndex = 9;
               this.btnRecord.Text = "Record";
               this.btnRecord.UseVisualStyleBackColor = true;
               this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
               // 
               // btnStop
               // 
               this.btnStop.Location = new System.Drawing.Point(259, 31);
               this.btnStop.Name = "btnStop";
               this.btnStop.Size = new System.Drawing.Size(75, 23);
               this.btnStop.TabIndex = 8;
               this.btnStop.Text = "Stop";
               this.btnStop.UseVisualStyleBackColor = true;
               this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
               // 
               // btnStart
               // 
               this.btnStart.Location = new System.Drawing.Point(61, 31);
               this.btnStart.Name = "btnStart";
               this.btnStart.Size = new System.Drawing.Size(75, 23);
               this.btnStart.TabIndex = 7;
               this.btnStart.Text = "Start";
               this.btnStart.UseVisualStyleBackColor = true;
               this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(271, 9);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(41, 13);
               this.label2.TabIndex = 4;
               this.label2.Text = "Display";
               // 
               // panel1
               // 
               this.panel1.Location = new System.Drawing.Point(15, 34);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(563, 310);
               this.panel1.TabIndex = 8;
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(12, 462);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(53, 13);
               this.label3.TabIndex = 10;
               this.label3.Text = "Password";
               // 
               // txtPass
               // 
               this.txtPass.Location = new System.Drawing.Point(76, 459);
               this.txtPass.Name = "txtPass";
               this.txtPass.Size = new System.Drawing.Size(502, 20);
               this.txtPass.TabIndex = 9;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(13, 414);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(55, 13);
               this.label4.TabIndex = 12;
               this.label4.Text = "Username";
               // 
               // txtUser
               // 
               this.txtUser.Location = new System.Drawing.Point(77, 411);
               this.txtUser.Name = "txtUser";
               this.txtUser.Size = new System.Drawing.Size(502, 20);
               this.txtUser.TabIndex = 11;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(593, 582);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.txtUser);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.txtPass);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.groupBox1);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.txtIP_Address);
               this.Name = "Form1";
               this.Text = "Form1";
               this.groupBox1.ResumeLayout(false);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
          private System.Windows.Forms.TextBox txtIP_Address;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.GroupBox groupBox1;
          private System.Windows.Forms.Button btnRecord;
          private System.Windows.Forms.Button btnStop;
          private System.Windows.Forms.Button btnStart;
          private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.TextBox txtPass;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.TextBox txtUser;
     }
}

