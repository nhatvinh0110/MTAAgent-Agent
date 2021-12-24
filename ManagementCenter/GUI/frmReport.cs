using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.DTO;
using Common;

namespace ManagementCenter.GUI
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        public bool Like(string toSearch, string toFind)
        {
            return new Regex(@"\A" + new Regex(@"\.|\$|\^|\{|\[|\(|\||\)|\*|\+|\?|\\").Replace(toFind, ch => @"\" + ch).Replace('_', '.').Replace("%", ".*") + @"\z", RegexOptions.Singleline).IsMatch(toSearch);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            Print(txtReport.Text);
        }

        void Printv2()
        {
            //PrintDocument p = new PrintDocument();

            //var font = new Font("Times New Roman", 14);
            //var margins = p.DefaultPageSettings.Margins;
            //var layoutArea = new RectangleF(
            //	margins.Left,
            //	margins.Top,
            //	p.DefaultPageSettings.PrintableArea.Width - (margins.Left + margins.Right),
            //	p.DefaultPageSettings.PrintableArea.Height - (margins.Top + margins.Bottom));
            //var layoutSize = layoutArea.Size;
            //layoutSize.Height = layoutSize.Height - font.GetHeight() * 2; // keep lastline visible
            //var brush = new SolidBrush(Color.Black);

            //// what still needs to be printed
            //var remainingText = txtReport.Text;

            //p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            //{
            //	int charsFitted, linesFilled;

            //	// measure how many characters will fit of the remaining text
            //	var realsize = e1.Graphics.MeasureString(
            //		remainingText,
            //		font,
            //		layoutSize,
            //		StringFormat.GenericDefault,
            //		out charsFitted,  // this will return what we need
            //		out linesFilled);

            //	// take from the remainingText what we're going to print on this page
            //	var fitsOnPage = remainingText.Substring(0, charsFitted);
            //	// keep what is not printed on this page 
            //	remainingText = remainingText.Substring(charsFitted);

            //	// print what fits on the page
            //	e1.Graphics.DrawString(
            //		fitsOnPage,
            //		font,
            //		brush,
            //		layoutArea);

            //	// if there is still text left, tell the PrintDocument it needs to call 
            //	// PrintPage again.
            //	e1.HasMorePages = remainingText.Length > 0;
            //};

            //         p.Print();
        }

        private void Print(string thetext)
        {
            try
            {

                PrintDocument p = new PrintDocument();

                var font = new Font("Times New Roman", 12);
                var brush = new SolidBrush(Color.Black);

                // what still needs to be printed
                var remainingText = thetext;

                p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
                {
                    int charsFitted, linesFilled;

                    // measure how many characters will fit of the remaining text

                    var realsize = e1.Graphics.MeasureString(
                            remainingText,
                            font,
                            e1.MarginBounds.Size,
                            StringFormat.GenericDefault,
                            out charsFitted,  // this will return what we need
                            out linesFilled);

                    // take from the remainingText what we're going to print on this page
                    var fitsOnPage = remainingText.Substring(0, charsFitted);
                    // keep what is not printed on this page 
                    remainingText = remainingText.Substring(charsFitted);

                    // print what fits on the page
                    e1.Graphics.DrawString(
                            fitsOnPage,
                            font,
                            brush,
                            e1.MarginBounds);

                    // if there is still text left, tell the PrintDocument it needs to call 
                    // PrintPage again.
                    e1.HasMorePages = remainingText.Length > 0;
                };

                PrintDialog pd = new PrintDialog();
                pd.Document = p;
                DialogResult result = pd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    p.Print();
                }


            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message, "Unable to print", MessageBoxButtons.OK);
            }

        }

        public void LoadData()
        {
            try
            {
                List<Room> rooms = DAL_Rooms.get_Rooms_Include_ComputerCount().Where(x => x.Status == true).ToList();

                List<Computer> computers = DAL_Computer.get_ComputersAsList_Include_RoomName(frmMain.dataProvider).ToList();

                txtReport.Text = "\t\tKẾT QUẢ KIỂM TRA QUY TẮC ĐẶT TÊN MÁY" + Environment.NewLine + Environment.NewLine;

                for (int i = 0; i < rooms.Count; i++)
                {

                    List<Computer> CurrRoom = computers.Where(x => x.RoomID == rooms[i].RoomID && x.SecondsDiff < 8).ToList();

                    txtReport.AppendText("+ Phòng: " + rooms[i].RoomName + Environment.NewLine);
                    txtReport.AppendText("\t- Tổng số lượng máy: " + rooms[i].ComputerCount + Environment.NewLine);
                    txtReport.AppendText("\t- Số lượng máy đang online: " + CurrRoom.Count + Environment.NewLine);

                    if (rooms[i].ComputerCount <= 0 || CurrRoom.Count <= 0)
                    {
                        continue;
                    }

                    List<string> lscomputersERROR = CurrRoom.Where(x => Like(x.ComputerName, rooms[i].ComputerNameTemplate) == false).Select(x => x.ComputerName).ToList();

                    int[] arr = CurrRoom.Where(x => Like(x.ComputerName, rooms[i].ComputerNameTemplate)).OrderBy(x => x.RoomName).Select(x => Convert.ToInt32(x.ComputerName.Replace(rooms[i].ComputerNameTemplate.Replace("_", ""), "").ToString())).ToArray();

                    string computersMISS = "";

                    if (arr.Length > 0)
                    {
                        int last = arr.Max();

                        int n = arr.Length;
                        int k = last - n;

                        computersMISS = printKMissing(arr, n, k);
                    }


                    string computersERROR = string.Join(", ", lscomputersERROR);

                    txtReport.AppendText("\t- Số thứ tự đang còn thiếu: " + (string.IsNullOrEmpty(computersMISS) ? "Không phát hiện số thứ tự đang thiếu" : computersMISS) + Environment.NewLine);

                    txtReport.AppendText("\t- Các máy đặt sai quy tắc: " + (string.IsNullOrEmpty(computersERROR) ? "Không phát hiện máy vi phạm quy tắc" : computersERROR) + Environment.NewLine);

                }

                List<Computer> Room_NA = computers.Where(x => string.IsNullOrEmpty(x.RoomName) || x.RoomName == Constant.NotAvailable).OrderBy(x => x.ComputerName).ToList();

                txtReport.AppendText("+ Các máy chưa xếp phòng:" + Environment.NewLine);
                txtReport.AppendText("\t- Số lượng máy: " + Room_NA.Count + Environment.NewLine);
                if (Room_NA.Count > 0)
                {
                    txtReport.AppendText("\t- Tên các máy chưa xếp phòng: " + string.Join(", ", Room_NA.Select(x => x.ComputerName)));
                }

            }
            catch (Exception io)
            {
                txtReport.Text = io.Message;
            }
        }


        string printKMissing(int[] arr, int n, int k)
        {
            string result = "";
            Array.Sort(arr);

            // Find first positive number 
            int i = 0;
            while (i < n && arr[i] <= 0)
                i++;

            // Now find missing numbers 
            // between array elements 
            int count = 0, curr = 1;
            while (count < k && i < n)
            {
                if (arr[i] != curr)
                {
                    result = result + (curr + ", ");
                    count++;
                }
                else
                    i++;
                curr++;
            }

            // Find missing numbers  
            // after maximum. 
            while (count < k)
            {
                result = result + (curr + ", ");
                curr++;
                count++;
            }

            if (string.IsNullOrEmpty(result))
            {
                return "";
            }

            return result.Remove(result.Length - 2);
        }
    }
}
