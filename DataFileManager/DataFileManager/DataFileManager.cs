using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFileManager
{
    class DataFileManager
    {
        /// <summary>
        /// Input file format sample
        /// Date       Time     Last     Volume
        /// 08/27/2012	23:11:01	1398.00	2	98	1397.75	1398.00	130471	0	0
        /// 08/27/2012	23:23:28	1398.50	6	104	1398.00	1398.50	130800	0	0
        /// 08/27/2012	23:29:39	1398.50	1	105	1398.00	1398.50	130983	0	0
        /// 
        /// Output file format 
        /// yyyyMMdd HHmmss;price;volume
        /// 20120827 231101;1398;2
        /// 20120827 232328;1398.50;6
        /// 20120827 232939;1398.50;1
        /// </summary>
        public enum EDateFormat
        {
            yyyymmdd,
            mmddyyyy
        }
        public EDateFormat DateFormat { get; set; }

        public long line_start, line_end;

        public String Convert(String strQCRecord)
        {
            if (String.IsNullOrEmpty(strQCRecord))
                return String.Empty;
            else return strQCRecord;

            String[] fields = strQCRecord.Split('\t');
            String[] dateComponents = fields[0].Split('/', '-');
            String[] timeComponents = fields[1].Split(':');
            String[] timeSecondsComponents = timeComponents[2].Split('.');

            String strNTDate;
            if (DateFormat == EDateFormat.mmddyyyy)
                strNTDate = String.Format("{0}{1}{2}", dateComponents[2], dateComponents[0], dateComponents[1]);
            else
                strNTDate = String.Format("{0}{1}{2}", dateComponents[0], dateComponents[1], dateComponents[2]);
            String strNTTime = String.Format("{0}{1}{2}", timeComponents[0], timeComponents[1], timeSecondsComponents[0]);
            String strNTRecord = String.Format("{0} {1};{2};{3}", strNTDate, strNTTime, fields[2], fields[3]);

            return strNTRecord;
        }

        public String OutputFileFromInputFile(String strPathInput)
        {
            String strNinjaFileName = NinjaImportFileNameRules(Path.GetFileName(strPathInput));
            String strExtension = Path.GetExtension(strPathInput);
            String strFileName = strNinjaFileName + ".Last" + strExtension;
            return Path.GetDirectoryName(strPathInput) + "\\" + line_start + "_" + line_end + "\\" + strFileName;
        }

        /// <summary>
        /// must be InstrumentName.Last.txt
        /// Assume futures
        /// Use the hyphen '-' character to find the expiry as in
        /// ES 09-14
        /// </summary>
        /// <param name="strFileName"></param>
        /// <returns></returns>
        protected String NinjaImportFileNameRules(String strFileName)
        {
            int indexOfHyphen = strFileName.IndexOf('-');
            if (indexOfHyphen == -1)
                return strFileName.Substring(0, strFileName.Length-4); //remove the "txt" file extension
            String part1 = strFileName.Substring(indexOfHyphen - 5, indexOfHyphen + 3);
            return part1;
        }

        public void ConvertFiles(String[] strQCInputFiles,
           OnFileConverted fileConversionListener)
        {
            int count = 0;
            foreach (String strInputFile in strQCInputFiles)
            {
                String strOutputFileName = OutputFileFromInputFile(strInputFile);
                ConvertFile(strInputFile, strOutputFileName);
                if (fileConversionListener != null)
                {
                    fileConversionListener(strOutputFileName, ++count);
                }
            }
        }

        public delegate void OnFileConverted(String strFileConverted, int count);

        public void ConvertFile(String strQCInputFilePath, String strNTOutputFilePath)
        {
            long cur_line = 0;

            Directory.CreateDirectory(Path.GetDirectoryName(strNTOutputFilePath));
            using (StreamReader sr = new StreamReader(File.OpenRead(strQCInputFilePath)))
            {
                using (StreamWriter sw = new StreamWriter(File.OpenWrite(strNTOutputFilePath)))
                {
                    while (!sr.EndOfStream)
                    {
                        String strQCRecord = sr.ReadLine();
                        cur_line++;
                        if(cur_line>= line_start && cur_line<=line_end)
                            sw.WriteLine(Convert(strQCRecord));
                    }
                }
            }
        }

        public void ExtractFile(String strQCInputFilePath, String strNTOutputFilePath, long lineStart, long lineEnd)
        {
            long cur_line = 0;

            Directory.CreateDirectory(Path.GetDirectoryName(strNTOutputFilePath));
            using (StreamReader sr = new StreamReader(File.OpenRead(strQCInputFilePath)))
            {
                using (StreamWriter sw = new StreamWriter(File.OpenWrite(strNTOutputFilePath)))
                {
                    while (!sr.EndOfStream)
                    {
                        String strQCRecord = sr.ReadLine();
                        cur_line++;
                        if (cur_line > line_end) return;
                        else if (cur_line >= lineStart)
                            sw.WriteLine(Convert(strQCRecord));                        
                    }
                }
            }
        }
    }
}