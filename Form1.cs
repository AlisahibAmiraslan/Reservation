using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        string checkIn, checkOut;
        int den;

        private void roomcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
         
        List<string> daysData = new List<string>();
        List<string> countCheckOut = new List<string>();

        private void findRoomNum()
        {
            Con.Open();
            string query = "select * from ReservationTbl where RoomNum="+ roomcbx.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query,Con); 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

         

            foreach (DataRow dr in dt.Rows)
                {
                den = Convert.ToInt32(dr["RoomNum"].ToString());
                checkIn = dr["ResDate"].ToString();
                checkOut = dr["ChOutDate"].ToString();
                

                // gelecekte check out veya check ın hesaplama için 
                //for (DateTime counter = DateTime.Parse(checkIn); counter <= DateTime.Parse(checkOut); counter = counter.AddDays(1))
                //{
                //    countCheckOut.Add(counter.ToString("dd/MM/yyyy 00:00:00"));
                //}


                /* giriş tarihleri bir-birine qarışmaması için check ın time'a elave "AddDays(1)" yeni bir gün elave ettim
                  Meselen yeni rezervasyon yaparken diger yeni odanın check out tarixi ile köhne rezervasyon tarixleri üst üsde düşürdü
                ve buna görede eski rezervasyon check out'una bir gün elave ederek sorunu aradan kaldırdım
                */


                for (DateTime counter = DateTime.Parse(checkIn).AddDays(1); counter <= DateTime.Parse(checkOut); counter = counter.AddDays(1))
                {
                    daysData.Add(counter.ToString("dd/MM/yyyy 00:00:00"));
                }

            }

            Con.Close();
          
        }


        private void roomcbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            findRoomNum();
        }
        private void reset()
        {
            roomcbx.SelectedIndex = -1;
            availibilitycbx.SelectedIndex = -1;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (daysData != null && checkIn != null && checkOut != null)
            {
                //******
                //List<string> databaseDays = new List<string>();


                //for (DateTime counter = DateTime.Parse(checkIn); counter <= DateTime.Parse(checkOut); counter = counter.AddDays(1))
                //{
                //    databaseDays.Add(counter.ToString("dd/MM/yyyy 00:00:00"));
                //}

                //foreach (string item in daysData)
                //{
                //    MessageBox.Show(item);
                //}

                //foreach (var item in databaseDays)
                //{
                //    MessageBox.Show("that is databaseDays" + " --- " + item);
                //}
                //******
                //******
                var startDate = resDatePc.Value;
                var endDate = chOutPc.Value;

                List<string> workingDays = new List<string>();


                for (DateTime counter = startDate; counter <= endDate; counter = counter.AddDays(1))
                {
                    workingDays.Add(counter.ToString("dd/MM/yyyy 00:00:00"));
                }

                //foreach (var item in workingDays)
                //{
                //    MessageBox.Show("that is workingdays" + " --- " + item);
                //}

                //MessageBox.Show("That is check in" + " --- " + checkIn);

                //*****


                //bool existsCheckIn = workingDays.Any(s => s.Contains(checkIn));

                //bool existsCheckOut = workingDays.Any(s => s.Contains(checkOut));

                bool existsDatas = workingDays.Intersect(daysData).Any();



                if (existsDatas)
                {
                    MessageBox.Show("These Dates are full!");
                    reset();
                    //daysdata'nı sil
                    daysData.Clear();
                }
                else
                {
                    //****************
                    //en son bura yoruma alındı

                    var date1 = resDatePc.Value.ToString("MM/dd/yyyy");
                    var date2 = chOutPc.Value.ToString("MM/dd/yyyy");

                    Con.Open();
                    string query = "insert into ReservationTbl values('" + roomcbx.SelectedValue.ToString() + "','" + date1 + "','" + date2 + "','" + availibilitycbx.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Room successfull added !");
                    ListAll();
                    reset();
                    //daysdata'nı sil
                    daysData.Clear();
                    //en son bura yoruma alındı
                    //****************

                    //if (roomcbx.SelectedIndex == -1 && availibilitycbx.SelectedIndex == -1)
                    //{
                    //    MessageBox.Show("Please fill all boxes !!!");
                }
        }
            else
            {
                //en son bura yoruma alındı
                //****************

                var date1 = resDatePc.Value.ToString("MM/dd/yyyy");
                var date2 = chOutPc.Value.ToString("MM/dd/yyyy");
                Con.Open();
                string query = "insert into ReservationTbl values('" + roomcbx.SelectedValue.ToString() + "','" + date1 + "','" + date2 + "','" + availibilitycbx.SelectedItem.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Room successfull added !");
                ListAll();
                reset();
                //daysdata'nı sil
                daysData.Clear();

                //en son bura yoruma alındı
                //****************
            }
            //if (roomcbx.SelectedIndex == -1 && availibilitycbx.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Please fill all boxes !!!");
            //}
        }


        //gelecekte check out veya check ın hesaplama için
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
          foreach (var item in countCheckOut)
            {
                MessageBox.Show(item);
            }
            countCheckOut.Clear();
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
            //MessageBox.Show(total);

            //*****

            var startDate = dateTimePicker1.Value;
            var endDate = dateTimePicker3.Value;

            List<DateTime> workingDays = new List<DateTime>();

            for (DateTime counter = startDate; counter <= endDate.AddDays(1); counter = counter.AddDays(1))
            {
                //if (counter.DayOfWeek != DayOfWeek.Saturday && counter.DayOfWeek != DayOfWeek.Sunday)
                workingDays.Add(counter);
            }

            //MessageBox.Show(workingDays[workingDays.Count - 1].ToString());

            if (workingDays.Contains(workingDays[workingDays.Count - 1]) && workingDays.Contains(startDate))
            {
                for (DateTime counter = workingDays[0]; counter <= workingDays[workingDays.Count - 1]; counter = counter.AddDays(1))
                {

                    MessageBox.Show(counter.ToString());
                }
            }
            else
            {
                MessageBox.Show("not Match");
            }
            //*****



        }
    }
}
