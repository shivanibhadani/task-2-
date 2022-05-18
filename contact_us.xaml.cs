using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.OleDb;
using System.Configuration;

namespace task_2_
{
    /// <summary>
    /// Interaction logic for contact_us.xaml
    /// </summary>
    public partial class contact_us : Window
    {
        public contact_us()
        {
            InitializeComponent();
            gridload();
        }
        private void gridload()
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["connection"].ToString();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select * from [table1]";
            cmd.Connection = con;
            OleDbDataReader db = cmd.ExecuteReader();
            grid1.ItemsSource = db;

        }
    }
}
