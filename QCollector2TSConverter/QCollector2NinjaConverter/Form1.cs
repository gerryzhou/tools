using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QCollector2NinjaConverter
{
   public partial class Form1 : Form
   {
      String[] aFileNames;
      QC2NT qc2NT;

      public Form1()
      {
         InitializeComponent();
         qc2NT = new QC2NT();
      }

      private DialogResult setFileName(TextBox textBox)
      {
         OpenFileDialog ofd = new OpenFileDialog();        

         ofd.Multiselect = true;
         ofd.RestoreDirectory = true;
         DialogResult dialogResult = ofd.ShowDialog(this);
         if (DialogResult.OK == dialogResult)
         {
            if (ofd.FileNames.Length == 1)
            {
               textBox.Text = ofd.FileNames[0];
               aFileNames = null;
            }
            else
            {
               textBox.Text = "[multiple selection cached and ready]";
               aFileNames = ofd.FileNames;
            }
         }
         return dialogResult;
      }

      private void button1_Click(object sender, EventArgs e)
      {
         if (DialogResult.OK == setFileName(textBox1))
         {
            // if single file selected
            if (aFileNames == null)
            {
               textBox2.Text = qc2NT.OutputFileFromInputFile(textBox1.Text);
            }
            else
            {
               textBox2.Text = @"[input file directory]\Converted";// Path.GetDirectoryName(aFileNames[0]);
            }
         }
      }

      private void button2_Click(object sender, EventArgs e)
      {
         setFileName(textBox2);
      }

      private void SetDateFormat()
      {
         if (radioButtonMMDDYYYY.Checked)
            qc2NT.DateFormat = QC2NT.EDateFormat.mmddyyyy;
         else
            qc2NT.DateFormat = QC2NT.EDateFormat.yyyymmdd;
      }

      private void buttonConvert_Click(object sender, EventArgs e)
      {
         Cursor.Current = Cursors.WaitCursor;
         SetDateFormat();
         if (aFileNames == null)
         {
            qc2NT.ConvertFile(textBox1.Text, textBox2.Text);
         }
         else
         {
            this.toolStripProgressBar1.Maximum = aFileNames.Length;
            qc2NT.ConvertFiles(aFileNames, new QC2NT.OnFileConverted(OnFileConverted));
         }
         Cursor.Current = Cursors.Default;
      }

      private void OnFileConverted(String strFileConverted, int count)
      {
         toolStripProgressBar1.Value = count;
      }
   }
}
