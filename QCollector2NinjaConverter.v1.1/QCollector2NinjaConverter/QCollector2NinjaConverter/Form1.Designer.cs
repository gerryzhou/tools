namespace QCollector2NinjaConverter
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
         this.label1 = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.buttonConvert = new System.Windows.Forms.Button();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.radioButtonYYYYMMDD = new System.Windows.Forms.RadioButton();
         this.radioButtonMMDDYYYY = new System.Windows.Forms.RadioButton();
         this.statusStrip1.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(22, 33);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(75, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "QCollector File";
         // 
         // textBox1
         // 
         this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.textBox1.Location = new System.Drawing.Point(25, 60);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(526, 20);
         this.textBox1.TabIndex = 1;
         // 
         // button1
         // 
         this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.button1.Location = new System.Drawing.Point(568, 57);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(27, 23);
         this.button1.TabIndex = 2;
         this.button1.Text = "..";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.button2.Location = new System.Drawing.Point(569, 132);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(27, 23);
         this.button2.TabIndex = 5;
         this.button2.Text = "..";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // textBox2
         // 
         this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.textBox2.Location = new System.Drawing.Point(26, 135);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(526, 20);
         this.textBox2.TabIndex = 4;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(23, 108);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(50, 13);
         this.label2.TabIndex = 3;
         this.label2.Text = "Ninja File";
         // 
         // buttonConvert
         // 
         this.buttonConvert.Location = new System.Drawing.Point(26, 194);
         this.buttonConvert.Name = "buttonConvert";
         this.buttonConvert.Size = new System.Drawing.Size(75, 23);
         this.buttonConvert.TabIndex = 6;
         this.buttonConvert.Text = "Convert";
         this.buttonConvert.UseVisualStyleBackColor = true;
         this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
         this.statusStrip1.Location = new System.Drawing.Point(0, 240);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(607, 22);
         this.statusStrip1.TabIndex = 7;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // toolStripProgressBar1
         // 
         this.toolStripProgressBar1.Name = "toolStripProgressBar1";
         this.toolStripProgressBar1.Size = new System.Drawing.Size(300, 16);
         this.toolStripProgressBar1.Step = 1;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.radioButtonMMDDYYYY);
         this.groupBox1.Controls.Add(this.radioButtonYYYYMMDD);
         this.groupBox1.Location = new System.Drawing.Point(127, 167);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(424, 49);
         this.groupBox1.TabIndex = 8;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Input Date Format";
         // 
         // radioButtonYYYYMMDD
         // 
         this.radioButtonYYYYMMDD.AutoSize = true;
         this.radioButtonYYYYMMDD.Checked = true;
         this.radioButtonYYYYMMDD.Location = new System.Drawing.Point(7, 27);
         this.radioButtonYYYYMMDD.Name = "radioButtonYYYYMMDD";
         this.radioButtonYYYYMMDD.Size = new System.Drawing.Size(79, 17);
         this.radioButtonYYYYMMDD.TabIndex = 0;
         this.radioButtonYYYYMMDD.TabStop = true;
         this.radioButtonYYYYMMDD.Text = "yyyy-mm-dd";
         this.radioButtonYYYYMMDD.UseVisualStyleBackColor = true;
         // 
         // radioButtonMMDDYYYY
         // 
         this.radioButtonMMDDYYYY.AutoSize = true;
         this.radioButtonMMDDYYYY.Location = new System.Drawing.Point(110, 27);
         this.radioButtonMMDDYYYY.Name = "radioButtonMMDDYYYY";
         this.radioButtonMMDDYYYY.Size = new System.Drawing.Size(79, 17);
         this.radioButtonMMDDYYYY.TabIndex = 1;
         this.radioButtonMMDDYYYY.Text = "mm-dd-yyyy";
         this.radioButtonMMDDYYYY.UseVisualStyleBackColor = true;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(607, 262);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.buttonConvert);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "QCollector 2 NinjaTrader File Converter";
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button buttonConvert;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.RadioButton radioButtonMMDDYYYY;
      private System.Windows.Forms.RadioButton radioButtonYYYYMMDD;
   }
}

