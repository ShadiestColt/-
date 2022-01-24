using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Global;
using Приложение_для_еды;

namespace Global
{
    public class PUK
    {

       

        public static string Triton = "C:\\Users\\Дмитрий\\Desktop\\Проекты Visual studio\\Семестр 3\\Курсовая\\Приложение для еды\\Все нужное.db";
        public static string zvuki = "C:\\Users\\Admin\\Desktop\\Курсовая\\Приложение для еды\\click.wav";
        public static string link = "SELECT Pic FROM IDO";
        public static string link2 = "INSERT INTO LKJ (Zakaz) VALUES ('{0}')";
        public static string link3 = "SELECT GUID FROM IDO";

       

    }
    
     public class Vehicle
     {
       

        public string Name { get; set; }
        public string iconBytes { get; set; }
        public int ID { get; set; }
        public ImageSource ImageSource { get; set; }

        public Vehicle(int id, string name, ImageSource imageSource, string IconBytes)
        {
            ID = id; Name = name; ImageSource = imageSource; iconBytes = IconBytes;
        }
        public Vehicle()
        {

        }
     }


}
