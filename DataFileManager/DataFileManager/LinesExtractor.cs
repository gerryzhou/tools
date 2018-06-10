using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFileManager
{
    public partial class LinesExtractor : Form
    {
        String[] aFileNames;
        DataFileManager qc2NT;

        public LinesExtractor()
        {
            InitializeComponent();
            qc2NT = new DataFileManager(); 
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
            if (DialogResult.OK == setFileName(tbox_SrcFile))
            {
                // if single file selected
                if (aFileNames == null)
                {
                    tbox_DestFile.Text = qc2NT.OutputFileFromInputFile(tbox_SrcFile.Text);
                }
                else
                {
                    tbox_DestFile.Text = @"[input file directory]\Converted";// Path.GetDirectoryName(aFileNames[0]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setFileName(tbox_DestFile);
        }

        private void SetDateFormat()
        {
            //if (radioButtonMMDDYYYY.Checked)
            //    qc2NT.DateFormat = QC2NT.EDateFormat.mmddyyyy;
            //else
            //    qc2NT.DateFormat = QC2NT.EDateFormat.yyyymmdd;
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            qc2NT.line_start = long.Parse(tbox_LineStart.Text);

            qc2NT.line_end = long.Parse(tbox_LineEnd.Text);
            //SetDateFormat();
            //if (aFileNames == null)
            //{
            //    qc2NT.ConvertFile(textBox1.Text, textBox2.Text);
            //}
            //else
            //{
            //    this.toolStripProgressBar1.Maximum = aFileNames.Length;
            //    qc2NT.ConvertFiles(aFileNames, new QC2NT.OnFileConverted(OnFileConverted));
            //}
            String strOutputFileName = qc2NT.OutputFileFromInputFile(tbox_SrcFile.Text);
            tbox_DestFile.Text = strOutputFileName;
            tbox_DestFile.Refresh();
            //ShowMessage("DestFile=" + tbox_DestFile.Text);
            qc2NT.ExtractFile(tbox_SrcFile.Text, tbox_DestFile.Text, qc2NT.line_start, qc2NT.line_end);
            Cursor.Current = Cursors.Default;
        }

        private void ShowMessage(string message)
        {
            //string message = "You did not enter a server name. Cancel this operation?";
            string caption = "Message Box";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                // Closes the parent form.

                return;

            }
        }

        private void OnFileConverted(String strFileConverted, int count)
        {
            //toolStripProgressBar1.Value = count;
        }
    }
}
