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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;
using System.Net;
using Ubiety.Dns.Core;

namespace Приложение_для_еды
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        private void ent_Click(object sender, RoutedEventArgs e)
        {
            //string Triton = ("C:\\Users\\Дмитрий\\Desktop\\Проекты Visual studio\\Семестр 3\\Курсовая\\Все нужное.db");
            //SQLiteConnection m_dbConnection;
            //m_dbConnection = new SQLiteConnection("Data Source=" + Triton + ";Version=3;");
            //m_dbConnection.Open();
            //string command = "INSERT INTO DV (Number, Password) VALUES (" + num.Text + ",'" + pas.Text + "'); \n";
            //SQLiteCommand cmd = new SQLiteCommand(command, m_dbConnection);

            
            //cmd.ExecuteNonQuery();
            //m_dbConnection.Close();




            this.Hide();
            Window1 kl = new Window1();
            if (kl.ShowDialog() == true)
            {

            }

        }


        
        
    }
}
