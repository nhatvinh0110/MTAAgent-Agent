using Common;
using Common.CONFIG;
using Common.DATA;
using Common.DTO;
using Common.REGISTRY;
using ManagementCenter.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementCenter.GUI
{
    public partial class fm_LogInfo : Form
    {
        public fm_LogInfo()
        {
            InitializeComponent();
        }

        private void btnDeviceEventFilter_Click(object sender, EventArgs e)
        {
            List<Info_Contestant> log_if = new List<Info_Contestant>();
            if (!string.IsNullOrEmpty(ComboxSubject.Text) && !string.IsNullOrEmpty(comboBoxName.Text) && !string.IsNullOrEmpty(comboBoxMaTS.Text))
            {
                log_if = DAL_InfoContestant.get_Info_Contestant_All(comboBoxMaTS.Text, comboBoxName.Text, ComboxSubject.Text);
            }
            else if (!string.IsNullOrEmpty(ComboxSubject.Text) && !string.IsNullOrEmpty(comboBoxName.Text) && string.IsNullOrEmpty(comboBoxMaTS.Text))
            {
                log_if = DAL_InfoContestant.get_Info_Contestant_SubjectAndName(ComboxSubject.Text, comboBoxName.Text);
            }
            else if (!string.IsNullOrEmpty(ComboxSubject.Text) && string.IsNullOrEmpty(comboBoxName.Text) && !string.IsNullOrEmpty(comboBoxMaTS.Text))
            {
                log_if = DAL_InfoContestant.get_Info_Contestant_SubjectAndContesttanCode(ComboxSubject.Text, comboBoxMaTS.Text);
            }
            else if (!string.IsNullOrEmpty(ComboxSubject.Text) && string.IsNullOrEmpty(comboBoxName.Text) && string.IsNullOrEmpty(comboBoxMaTS.Text))
            {
                log_if = DAL_InfoContestant.get_Info_Contestant(ComboxSubject.Text);
            }
            else if (string.IsNullOrEmpty(ComboxSubject.Text) && !string.IsNullOrEmpty(comboBoxName.Text) && string.IsNullOrEmpty(comboBoxMaTS.Text))
            {
                log_if = DAL_InfoContestant.get_Info_Contestant(comboBoxName.Text);
            }
            else if (string.IsNullOrEmpty(ComboxSubject.Text) && string.IsNullOrEmpty(comboBoxName.Text) && !string.IsNullOrEmpty(comboBoxMaTS.Text))
            {
                log_if = DAL_InfoContestant.get_Info_Contestant(comboBoxMaTS.Text);
            }
            else if (string.IsNullOrEmpty(ComboxSubject.Text) && !string.IsNullOrEmpty(comboBoxName.Text) && !string.IsNullOrEmpty(comboBoxMaTS.Text))
            {
                log_if = DAL_InfoContestant.get_Info_Contestant_ContestantCodeAndName(comboBoxMaTS.Text, comboBoxName.Text);
            }
            else
            {
                log_if = DAL_InfoContestant.get_Info_Contestant();
            }

            DataBinding(log_if);
        }


        private void DataBinding(List<Info_Contestant> data)
        {
            dataGridViewX1.DataSource = data;
        }
        private void GetForComBoxName()
        {
            this.comboBoxName.Items.Clear();
            DataTable dt = DAL_InfoContestant.GetName();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxName.Items.Add(dt.Rows[i][0]);
            }
            object[] distinctItems = (from object o in comboBoxName.Items select o).Distinct().ToArray();
            comboBoxName.Items.Clear();
            comboBoxName.Items.AddRange(distinctItems);
        }
        private void GetForComBoxSubject()
        {
            this.ComboxSubject.Items.Clear();
            DataTable dt = DAL_InfoContestant.GetSubject();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ComboxSubject.Items.Add(dt.Rows[i][0]);
            }
            object[] distinctItems = (from object o in ComboxSubject.Items select o).Distinct().ToArray();
            ComboxSubject.Items.Clear();
            ComboxSubject.Items.AddRange(distinctItems);

        }
        private void GetForComBoxMaTS()
        {
            this.comboBoxMaTS.Items.Clear();
            DataTable dt = DAL_InfoContestant.GetMaTS();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxMaTS.Items.Add(dt.Rows[i][0]);
            }
            object[] distinctItems = (from object o in comboBoxMaTS.Items select o).Distinct().ToArray();
            comboBoxMaTS.Items.Clear();
            comboBoxMaTS.Items.AddRange(distinctItems);

        }
        private void fm_LogInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mTAAgentDataSet.Info_Contestant' table. You can move, or remove it, as needed.
            this.info_ContestantTableAdapter.Fill(this.mTAAgentDataSet.Info_Contestant);
            // TODO: This line of code loads data into the 'mTAAgentDataSet.Info_Contestant' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'mTAAgentDataSet.Info_Contestant' table. You can move, or remove it, as needed.

            /*List<Info_Contestant> events = DAL_InfoContestant.get_Info_Contestant();
            DataBinding(events);*/
            try
            {
                GetForComBoxSubject();
                GetForComBoxName();
                GetForComBoxMaTS();
            }
            catch (Exception io)
            {
                MessageBox.Show(io.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }
        public static int max = 100000;
        private void Form1_Load(object sender, EventArgs e)
        {
            frm_Report.Del_Data();
        }

        /*public void SaveSql()
        {
            var lastLine = File.ReadAllLines(fileName).Length;
            try
            {
                con.Open();
                for(int i = 1; i < lastLine; i++)
                {
                    string query = "INSERT INTO DETAIL_LOG(ID,time,eventType,description,ID_ContestantLog) VALUES('"+(i)+"','"+time[i]+ "',N'" + status[i] + "',N'" + description[i] + "','LOG0001')";
                    SqlCommand sqlDa = new SqlCommand(query, con);
                    sqlDa.ExecuteNonQuery();
                }
                con.Close();
 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
        public void SaveDetail_log(string[] arr,string ID_Log)
        {
            string con = frmMain.con;
            DataProvider dataProvider = new DataProvider();
            dataProvider.cnn = new System.Data.SqlClient.SqlConnection(con);

            try
            {

                for (int i = 1; i < arr.Length; i++)
                {
                    Report_Contestant cs = new Report_Contestant();
                    //cs.time = "$.time"; cs.eventType = "$.eventType"; cs.description = "$.description";
                    string query = "INSERT INTO DETAIL_LOG(ID, time, eventType, description,ID_ContestantLog) VALUES ('" + (i) + "','" + time[i] + "',N'" + status[i] + "',N'" + description[i] + "','" + ID_Log + "' )";
                    //string query = "INSERT INTO DETAIL_LOG(ID, time, eventType, description,ID_ContestantLog) VALUES ('" + (i) + "','11',N' 1111',N'1111','" + 27 + "' )";

                    dataProvider.ExecuteNonQuery(query);
                }

            }
            catch (Exception io)
            {
                Log_Helper.Error(io.Message, io);
            }
        }
        public void DeleteDetail_log()
        {
            string con = frmMain.con;
            DataProvider dataProvider = new DataProvider();
            dataProvider.cnn = new System.Data.SqlClient.SqlConnection(con);

            try
            {
                string query = "Delete  from DETAIL_LOG";
                //string query = "INSERT INTO DETAIL_LOG(ID, time, eventType, description,ID_ContestantLog) VALUES ('" + (i) + "','11',N' 1111',N'1111','" + 27 + "' )";

                dataProvider.ExecuteNonQuery(query);
            }
            catch (Exception io)
            {
                Log_Helper.Error(io.Message, io);
            }
        }
        string[] time = new string[max];
        string[] status = new string[max];
        string[] description = new string[max];
        public void splitString(string[] arr)
        {
            var count = 1;
            char[] split = { ':' };
            //string line = reader.ReadLine();
            try
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    time[count] = arr[i - 1].ToString().Substring(0, 19);
                    string temp = arr[i - 1].ToString().Substring(20);
                    string[] arrTemp = temp.Split(split);
                    status[count] = arrTemp[0];
                    string temp2 = temp.Replace(arrTemp[0], string.Empty);
                    description[count] = temp2.Substring(2);
                    count++;
                }
            }
            catch(Exception io)
            {
                Log_Helper.Error(io.Message, io);
            }
        }
        /*public void splitString(string[] arr)
        {
            var count = 1;
            char[] split = { ':' };
            //string line = reader.ReadLine();
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Length >= 19)
                    {
                        time[count] = arr[i - 1].ToString().Substring(0, 19);
                        string temp = arr[i - 1].ToString().Substring(20);
                        string[] arrTemp = temp.Split(split);
                        status[count] = arrTemp[0];
                        string temp2 = temp.Replace(arrTemp[0], string.Empty);
                        description[count] = temp2.Substring(2);
                        count++;
                    }
                    else
                    {
                        time[count] = arr[i];

                        status[count] = "";

                        description[count] = "";
                        count++;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Sai định dạng file");
            }
        }*/
        public void Show_Report(string ID_Log)
        {
            string con = frmMain.con;
            DataProvider dataProvider = new DataProvider();
            dataProvider.cnn = new System.Data.SqlClient.SqlConnection(con);
            string[] FolderName = ReadTextFile.GetFileName();

            DataTable da = new DataTable();
            da = Report_Contestant.GetConTestant(dataProvider, ID_Log);
            string[] strArr = new string[max];
            strArr = da.Rows[0][2].ToString().Split('\n');
            /*MessageBox.Show(strArr[0].ToString());*/
            /*string[] str = new string[max]; ;
            str[1] = strArr[1].Substring(0, 19);
            MessageBox.Show(str[1]);*/
            var count = 1;
            char[] split = { ':' };
            //string line = reader.ReadLine();
            /*for (int i = 1; i < strArr.Length; i++)
            {
                time[count] = strArr[i-1].ToString().Substring(0,19);
                string temp = strArr[i-1].ToString().Substring(20);
                string[] arrTemp = temp.Split(split);
                status[count] = arrTemp[0];
                string temp2 = temp.Replace(arrTemp[0], string.Empty);
                description[count] = temp2.Substring(2);
                count++;
            }*/
            splitString(strArr);
            SaveDetail_log(strArr,ID_Log);
            
            frmLogReport frmLR = new frmLogReport();
            frmLR.ShowDialog();
            DeleteDetail_log();
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridViewX1.CurrentCell.RowIndex;
            Show_Report(dataGridViewX1.Rows[selectedrowindex].Cells[6].Value.ToString());

        }

        private void labelX1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Info_Contestant> log_if = new List<Info_Contestant>();
            if (!string.IsNullOrEmpty(ComboxSubject.Text) && !string.IsNullOrEmpty(comboBoxName.Text) && !string.IsNullOrEmpty(comboBoxMaTS.Text))
            {
                log_if = DAL_InfoContestant.get_Info_Contestant_All(comboBoxMaTS.Text,comboBoxName.Text,ComboxSubject.Text );
            }
            else if (!string.IsNullOrEmpty(ComboxSubject.Text) && !string.IsNullOrEmpty(comboBoxName.Text) && string.IsNullOrEmpty(comboBoxMaTS.Text))
            {
                log_if = DAL_InfoContestant.get_Info_Contestant_SubjectAndName(ComboxSubject.Text,comboBoxName.Text);
            }
            else if (!string.IsNullOrEmpty(ComboxSubject.Text) && string.IsNullOrEmpty(comboBoxName.Text) && !string.IsNullOrEmpty(comboBoxMaTS.Text))
            {
                log_if = DAL_InfoContestant.get_Info_Contestant_SubjectAndContesttanCode(ComboxSubject.Text,comboBoxMaTS.Text);
            }
            else if (!string.IsNullOrEmpty(ComboxSubject.Text) && string.IsNullOrEmpty(comboBoxName.Text) && string.IsNullOrEmpty(comboBoxMaTS.Text))
            {
                log_if = DAL_InfoContestant.get_Info_Contestant(ComboxSubject.Text);
            }
            else if (string.IsNullOrEmpty(ComboxSubject.Text) && !string.IsNullOrEmpty(comboBoxName.Text) && string.IsNullOrEmpty(comboBoxMaTS.Text))
            {
                log_if = DAL_InfoContestant.get_Info_Contestant(comboBoxName.Text);
            }
            else if (string.IsNullOrEmpty(ComboxSubject.Text) && string.IsNullOrEmpty(comboBoxName.Text) && !string.IsNullOrEmpty(comboBoxMaTS.Text))
            {
                log_if = DAL_InfoContestant.get_Info_Contestant(comboBoxMaTS.Text);
            }
            else if (string.IsNullOrEmpty(ComboxSubject.Text) && !string.IsNullOrEmpty(comboBoxName.Text) && !string.IsNullOrEmpty(comboBoxMaTS.Text))
            {
                log_if = DAL_InfoContestant.get_Info_Contestant_ContestantCodeAndName(comboBoxMaTS.Text,comboBoxName.Text);
            }
            else
            {
                log_if = DAL_InfoContestant.get_Info_Contestant();
            }

            DataBinding(log_if);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxName.Text = "";
            ComboxSubject.Text = "";
            comboBoxMaTS.Text = "";
        }
        public static string sbdThisinh;
        public static string ID_InfoContestant;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridViewX1.CurrentCell.RowIndex;
                ID_InfoContestant = dataGridViewX1.Rows[selectedrowindex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                Show_Report(dataGridViewX1.Rows[selectedrowindex].Cells[8].Value.ToString());

            }
            catch
            {

            }
        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* int selectedrowindex = dataGridViewX1.CurrentCell.RowIndex;
            comboBoxName.Text = dataGridViewX1.Rows[selectedrowindex].Cells[1].Value.ToString();
            ComboxSubject.Text = dataGridViewX1.Rows[selectedrowindex].Cells[4].Value.ToString();
            comboBoxMaTS.Text = dataGridViewX1.Rows[selectedrowindex].Cells[0].Value.ToString();*/
        }

        private void dataGridViewX1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int selectedrowindex = dataGridViewX1.CurrentCell.RowIndex;
            comboBoxName.Text = dataGridViewX1.Rows[selectedrowindex].Cells[1].Value.ToString();
            ComboxSubject.Text = dataGridViewX1.Rows[selectedrowindex].Cells[4].Value.ToString();
            comboBoxMaTS.Text = dataGridViewX1.Rows[selectedrowindex].Cells[0].Value.ToString();*/
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridViewX1.CurrentCell.RowIndex;
            comboBoxName.Text = dataGridViewX1.Rows[selectedrowindex].Cells[2].Value.ToString();
            ComboxSubject.Text = dataGridViewX1.Rows[selectedrowindex].Cells[5].Value.ToString();
            comboBoxMaTS.Text = dataGridViewX1.Rows[selectedrowindex].Cells[1].Value.ToString();
        }
    }
}
