using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;

namespace EverydayClipping {
    public partial class Form1 : Form {
        private static readonly string ConnStr = ConfigurationManager.ConnectionStrings["itcastCater"].ConnectionString;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            var cn = new SQLiteConnection(ConnStr);
            cn.Open();
            var cmd = cn.CreateCommand();
            /*
            cmd.CommandText = "SELECT count(rowid) FROM clippings";
            var sr = cmd.ExecuteReader();
            sr.Read();
            linkLabel1.Text = sr.GetInt32(0).ToString();
            sr.Close();
            */
            cmd.CommandText = "SELECT * FROM clippings ORDER BY random() LIMIT 1";
            var sr = cmd.ExecuteReader();
            sr.Read();
            linkLabel1.Text = sr.GetString(1);
            linkLabel4.Text = @"—— " + sr.GetString(3) + @", 《" + sr.GetString(2) +@"》";
            sr.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            
        }

        private void linkLabel5_LocationChanged(object sender, EventArgs e) {

        }

        private void linkLabel5_MouseClick(object sender, MouseEventArgs e) {
            var cn = new SQLiteConnection(ConnStr);
            cn.Open();
            var cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT * FROM clippings ORDER BY random() LIMIT 1";
            var sr = cmd.ExecuteReader();
            sr.Read();
            linkLabel1.Text = sr.GetString(1);
            linkLabel4.Text = @"—— " + sr.GetString(3) + @", 《" + sr.GetString(2) +@"》";
            sr.Close();
        }
    }
}
