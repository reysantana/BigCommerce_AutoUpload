using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace XlsxToPic
{
    public partial class PicConverter : Form
    {
        public PicConverter()
        {
            InitializeComponent();
        }
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        Excel.Range range;
        private void btn_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg_open = new OpenFileDialog();
            tbl_filelist.Rows.Clear();
            dlg_open.Filter = "Excel files (*.xlsx, *.xls)|*.xls;*.xlsx|All files (*.*)|*.*";
            dlg_open.RestoreDirectory = true;
            dlg_open.Multiselect = true;
            dlg_open.Title = "Please Select Excel File(s) to Convert";
            //dlg_open.Filter = " Files | *.xlsx;*.xls";
            if (dlg_open.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in dlg_open.FileNames)
                {
                    AddToList(file);
                }
            }
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            string output_path = "";
            if(tbl_filelist.Rows.Count == 0)
            {
                MessageBox.Show("There are no excel files to be decoded! First you have to ");
                return;
            }

            list_gen.Items.Clear();
            for (int i = 0; i < tbl_filelist.Rows.Count; i ++)
            {
                string fileName;
                fileName = tbl_filelist.Rows[i].Cells[1].Value.ToString();
                ReadExcel(fileName);
            }
        }

        private void AddToList(string sFile)
        {
            int n = tbl_filelist.Rows.Add();
            tbl_filelist.Rows[n].Cells[0].Value = n+1;
            tbl_filelist.Rows[n].Cells[1].Value = sFile;
        }

        private void ReadExcel(string sFile)
        {
            string xlsName = sFile.Split('\\').Last();
            list_gen.Items.Add("Loading " + xlsName + "...");
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(sFile);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            list_gen.Items.Add(xlsName + " loaded.");
            list_gen.Items.Add("Reading and Generating data from " + xlsName);
            list_gen.Items.Add("Please Wait for a few minutes.");
            range = xlWorkSheet.UsedRange;
            int rw = range.Rows.Count;
            int block = rw / 1000 ;
            for (int j = 0; j <= block; j ++)
            {
                int start = (j > 0 ? j * 1000 : 2);
                int end = ((j == block) ? rw :((j + 1) * 1000 - 1));
                if(j >= 1)
                    Thread.Sleep(20000);
                Parallel.For(start, end+1, x =>
                {
                    WebClient webClient = new WebClient();
                    int detailCnt = 0;

                    for (int i = 16; i <= 31; i++)
                    {
                        if ((range[x, i] as Excel.Range).Value == "")
                        {
                            detailCnt = i - 1;
                            break;
                        }
                    }
                    for (int i = 16; i <= detailCnt; i++)
                    {
                        //fileName = path + "\\detail_view" + Convert.ToString(i - 15) + "_exp.jpg";
                       // webClient.DownloadFile((range[x, i] as Excel.Range).Value, fileName);
                    }
                });
                list_gen.Items.Add("Block " + Convert.ToString(j + 1) + "( " + Convert.ToString(start) + "~" +Convert.ToString(end) +") : Generated" );
            }
            list_gen.Items.Add(xlsName + " has been decoded successfully");
            xlApp.Workbooks.Close();
        }
    }
}
