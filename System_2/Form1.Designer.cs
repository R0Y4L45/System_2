namespace System_2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileOpen1 = new System.Windows.Forms.Button();
            this.fileOpen2 = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.abort = new System.Windows.Forms.Button();
            this.resume = new System.Windows.Forms.Button();
            this.suspend = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.percent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(64, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(554, 33);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(64, 65);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(554, 33);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // fileOpen1
            // 
            this.fileOpen1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileOpen1.Location = new System.Drawing.Point(641, 14);
            this.fileOpen1.Name = "fileOpen1";
            this.fileOpen1.Size = new System.Drawing.Size(107, 33);
            this.fileOpen1.TabIndex = 4;
            this.fileOpen1.Text = "File...";
            this.fileOpen1.UseVisualStyleBackColor = true;
            this.fileOpen1.Click += new System.EventHandler(this.button_Click);
            // 
            // fileOpen2
            // 
            this.fileOpen2.Enabled = false;
            this.fileOpen2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileOpen2.Location = new System.Drawing.Point(641, 65);
            this.fileOpen2.Name = "fileOpen2";
            this.fileOpen2.Size = new System.Drawing.Size(107, 33);
            this.fileOpen2.TabIndex = 5;
            this.fileOpen2.Text = "File...";
            this.fileOpen2.UseVisualStyleBackColor = true;
            this.fileOpen2.Click += new System.EventHandler(this.button_Click);
            // 
            // copy
            // 
            this.copy.Enabled = false;
            this.copy.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy.Location = new System.Drawing.Point(641, 132);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(107, 33);
            this.copy.TabIndex = 6;
            this.copy.Text = "Copy";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.button_Click);
            // 
            // abort
            // 
            this.abort.Enabled = false;
            this.abort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abort.Location = new System.Drawing.Point(539, 132);
            this.abort.Name = "abort";
            this.abort.Size = new System.Drawing.Size(79, 33);
            this.abort.TabIndex = 7;
            this.abort.Text = "Abort";
            this.abort.UseVisualStyleBackColor = true;
            this.abort.Click += new System.EventHandler(this.button_Click);
            // 
            // resume
            // 
            this.resume.Enabled = false;
            this.resume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resume.Location = new System.Drawing.Point(453, 132);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(79, 33);
            this.resume.TabIndex = 8;
            this.resume.Text = "Resume";
            this.resume.UseVisualStyleBackColor = true;
            this.resume.Click += new System.EventHandler(this.button_Click);
            // 
            // suspend
            // 
            this.suspend.Enabled = false;
            this.suspend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suspend.Location = new System.Drawing.Point(366, 132);
            this.suspend.Name = "suspend";
            this.suspend.Size = new System.Drawing.Size(79, 33);
            this.suspend.TabIndex = 9;
            this.suspend.Text = "Suspend";
            this.suspend.UseVisualStyleBackColor = true;
            this.suspend.Click += new System.EventHandler(this.button_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Olive;
            this.progressBar1.Location = new System.Drawing.Point(15, 132);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(345, 33);
            this.progressBar1.TabIndex = 10;
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.BackColor = System.Drawing.Color.Transparent;
            this.percent.Cursor = System.Windows.Forms.Cursors.Default;
            this.percent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.Location = new System.Drawing.Point(13, 109);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(36, 20);
            this.percent.TabIndex = 11;
            this.percent.Text = "0 %";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 192);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.suspend);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.abort);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.fileOpen2);
            this.Controls.Add(this.fileOpen1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(794, 231);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(794, 231);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fileOpen1;
        private System.Windows.Forms.Button fileOpen2;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button abort;
        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.Button suspend;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label percent;
    }
}

