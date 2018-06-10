namespace DataFileManager
{
    partial class LinesExtractor
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
            this.btnExtract = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_SrcFile = new System.Windows.Forms.TextBox();
            this.tbox_DestFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbox_LineStart = new System.Windows.Forms.TextBox();
            this.tbox_LineEnd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(112, 353);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 0;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LineStart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "LineEnd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SrcFile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DestFile";
            // 
            // tbox_SrcFile
            // 
            this.tbox_SrcFile.Location = new System.Drawing.Point(92, 64);
            this.tbox_SrcFile.Name = "tbox_SrcFile";
            this.tbox_SrcFile.Size = new System.Drawing.Size(484, 20);
            this.tbox_SrcFile.TabIndex = 5;
            // 
            // tbox_DestFile
            // 
            this.tbox_DestFile.Location = new System.Drawing.Point(92, 161);
            this.tbox_DestFile.Name = "tbox_DestFile";
            this.tbox_DestFile.Size = new System.Drawing.Size(484, 20);
            this.tbox_DestFile.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "..";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(614, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "..";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbox_LineStart
            // 
            this.tbox_LineStart.Location = new System.Drawing.Point(101, 223);
            this.tbox_LineStart.Name = "tbox_LineStart";
            this.tbox_LineStart.Size = new System.Drawing.Size(216, 20);
            this.tbox_LineStart.TabIndex = 9;
            // 
            // tbox_LineEnd
            // 
            this.tbox_LineEnd.Location = new System.Drawing.Point(101, 266);
            this.tbox_LineEnd.Name = "tbox_LineEnd";
            this.tbox_LineEnd.Size = new System.Drawing.Size(216, 20);
            this.tbox_LineEnd.TabIndex = 10;
            // 
            // LinesExtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 428);
            this.Controls.Add(this.tbox_LineEnd);
            this.Controls.Add(this.tbox_LineStart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbox_DestFile);
            this.Controls.Add(this.tbox_SrcFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExtract);
            this.Name = "LinesExtractor";
            this.Text = "LinesExtractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_SrcFile;
        private System.Windows.Forms.TextBox tbox_DestFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbox_LineStart;
        private System.Windows.Forms.TextBox tbox_LineEnd;
    }
}

