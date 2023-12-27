using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListAll();
            ListAllRoom();
            GetFreeRooms();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Deneme;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        public void ListAll()
        {
            Con.Open();
            string query = "select * from ReservationTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query,Con);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        public void ListAllRoom()
        {
            Con.Open();
            string query = "select * from RoomsTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            adapter.Fill(ds);
            roomdgw.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void GetFreeRooms()
        {
            string free = "free";
            Con.Open();
            SqlCommand cmd = new SqlCommand("select RoomNumber from RoomsTbl",Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomNumber",typeof(string));
            dt.Load(rdr);
            roomcbx.ValueMember = "RoomNumber";
            roomcbx.DataSource = dt;
            Con.Close();
        }

        public void UpdateRoomAva()
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

            string searchdate = dateTimePicker2.Value.ToString("MM/dd/yyyy");
            
            string filter = filtercb.SelectedItem.ToString();
           
            Con.Open();
            string query = "select * from ReservTbl where Availibility='" + filter + "' and chOutDate='" + searchdate + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListAll();
        }

        private void filtercb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //******
                var startDate = dateTimePicker1.Value;
                var endDate = dateTimePicker3.Value;
                List<DateTime> workingDays = new List<DateTime>();

                for (DateTime counter = startDate; counter <= endDate; counter = counter.AddDays(1))
                {
                    if (counter.DayOfWeek != DayOfWeek.Saturday && counter.DayOfWeek != DayOfWeek.Sunday)
                        workingDays.Add(counter);
                }

                //*****

               

                var date1 = resDatePc.Value.ToString("MM/dd/yyyy");
                var date2 = chOutPc.Value.ToString("MM/dd/yyyy");

                Con.Open();
                string query = "insert into ReservationTbl values('" + roomcbx.SelectedValue.ToString() + "','" + date1 + "','" + date2 + "','" + availibilitycbx.SelectedItem.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Room successfull added !");
                ListAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // iki datetime aralık gün sayısını bulma
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startTime = dateTimePicker1.Value;
            DateTime endTime = dateTimePicker3.Value;
            TimeSpan duration = new TimeSpan(endTime.Ticks - startTime.Ticks);
            // MessageBox.Show(duration.ToString());
            string name = dateTimePicker1.Value.ToString();
            string name3 = dateTimePicker3.Value.ToString();
            string total = name3 + ",,,,,,, " + name;
            MessageBox.Show(total);

            //*****



            var startDate = dateTimePicker1.Value;
            var endDate = dateTimePicker3.Value;
            List<DateTime> workingDays = new List<DateTime>();

            for (DateTime counter = startDate; counter <= endDate; counter = counter.AddDays(1))
            {
                if (counter.DayOfWeek != DayOfWeek.Saturday && counter.DayOfWeek != DayOfWeek.Sunday)
                    workingDays.Add(counter);
                //MessageBox.Show(counter.ToString());
            }


            //*****



        }
    }
}
