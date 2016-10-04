namespace WindowsFormsApplication1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resizebutton1 = new System.Windows.Forms.Button();
            this.openbutton1 = new System.Windows.Forms.Button();
            this.savebutton1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.xlabel = new System.Windows.Forms.Label();
            this.newXlabel = new System.Windows.Forms.Label();
            this.ylabel = new System.Windows.Forms.Label();
            this.newYlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.infolabel = new System.Windows.Forms.Label();
            this.clearbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(4, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // resizebutton1
            // 
            this.resizebutton1.Location = new System.Drawing.Point(335, 433);
            this.resizebutton1.Name = "resizebutton1";
            this.resizebutton1.Size = new System.Drawing.Size(91, 23);
            this.resizebutton1.TabIndex = 1;
            this.resizebutton1.Text = "Resize";
            this.resizebutton1.UseVisualStyleBackColor = true;
            this.resizebutton1.Click += new System.EventHandler(this.resizebutton1_Click);
            // 
            // openbutton1
            // 
            this.openbutton1.Location = new System.Drawing.Point(4, 433);
            this.openbutton1.Name = "openbutton1";
            this.openbutton1.Size = new System.Drawing.Size(75, 23);
            this.openbutton1.TabIndex = 2;
            this.openbutton1.Text = "Open";
            this.openbutton1.UseVisualStyleBackColor = true;
            this.openbutton1.Click += new System.EventHandler(this.openbutton1_Click);
            // 
            // savebutton1
            // 
            this.savebutton1.Location = new System.Drawing.Point(465, 433);
            this.savebutton1.Name = "savebutton1";
            this.savebutton1.Size = new System.Drawing.Size(75, 23);
            this.savebutton1.TabIndex = 3;
            this.savebutton1.Text = "Save";
            this.savebutton1.UseVisualStyleBackColor = true;
            this.savebutton1.Click += new System.EventHandler(this.savebutton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.Location = new System.Drawing.Point(43, 9);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(13, 13);
            this.xlabel.TabIndex = 4;
            this.xlabel.Text = "0";
            // 
            // newXlabel
            // 
            this.newXlabel.AutoSize = true;
            this.newXlabel.Location = new System.Drawing.Point(290, 9);
            this.newXlabel.Name = "newXlabel";
            this.newXlabel.Size = new System.Drawing.Size(13, 13);
            this.newXlabel.TabIndex = 5;
            this.newXlabel.Text = "0";
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Location = new System.Drawing.Point(43, 42);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(13, 13);
            this.ylabel.TabIndex = 6;
            this.ylabel.Text = "0";
            // 
            // newYlabel
            // 
            this.newYlabel.AutoSize = true;
            this.newYlabel.Location = new System.Drawing.Point(290, 42);
            this.newYlabel.Name = "newYlabel";
            this.newYlabel.Size = new System.Drawing.Size(13, 13);
            this.newYlabel.TabIndex = 7;
            this.newYlabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "X=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "New X=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "New Y=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "DIVISOR INFO:";
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Location = new System.Drawing.Point(402, 26);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(24, 13);
            this.infolabel.TabIndex = 13;
            this.infolabel.Text = "info";
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(122, 433);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 14;
            this.clearbutton.Text = "Clear Image";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 468);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newYlabel);
            this.Controls.Add(this.ylabel);
            this.Controls.Add(this.newXlabel);
            this.Controls.Add(this.xlabel);
            this.Controls.Add(this.savebutton1);
            this.Controls.Add(this.openbutton1);
            this.Controls.Add(this.resizebutton1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Visual Custom Picture Resizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button resizebutton1;
        private System.Windows.Forms.Button openbutton1;
        private System.Windows.Forms.Button savebutton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label xlabel;
        private System.Windows.Forms.Label newXlabel;
        private System.Windows.Forms.Label ylabel;
        private System.Windows.Forms.Label newYlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Button clearbutton;
    }
}

