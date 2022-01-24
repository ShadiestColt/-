using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.IO;
using System.Windows.Media.Imaging;
using Global;

namespace baza
{
    public class BF
    {
        public static List<Vehicle> Vehicles {get;} = new List<Vehicle>();
        //public static List<Vehicle> Vehicles { get;} = new List<Vehicle>();
        //public static ObservableCollection<Vehicle> ShoppingСarts { get; } = new ObservableCollection<Vehicle>();
        public static void BD()
        {
           

            byte[] iconBytes = null;
            SQLiteConnection con;
            con = new SQLiteConnection("Data Source=" + PUK.Triton + ";Version=3;");
            con.Open();
            SQLiteCommand command = new SQLiteCommand(PUK.link, con);
            SQLiteDataReader reader = command.ExecuteReader();
            SQLiteCommand command1 = new SQLiteCommand(PUK.link3, con);
            SQLiteDataReader reader1 = command1.ExecuteReader();

            while (reader.Read())
            {
                if (reader["Pic"] != null && !Convert.IsDBNull(reader["Pic"]))
                {
                    //Вот тут происходит магия перевоплощения картинки в байты
                    iconBytes = (byte[])reader["Pic"];
                    //А вот тут происходит обратный процесс предыдущему 
                    Vehicles.Add(new Vehicle { Name = "Pic", ImageSource = ConvertByteArrayToBitmapImage(iconBytes), iconBytes = reader["Pic"].ToString() });
                }
            }
            while (reader1.Read())
            {
                Vehicles.Add(new Vehicle { ID = int.Parse(reader1["GUID"].ToString()) });
            }

            con.Close();
            BitmapImage ConvertByteArrayToBitmapImage(byte[] bytes)
            {
                var stream = new MemoryStream(bytes);
                stream.Seek(0, SeekOrigin.Begin);
                var image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = stream;
                image.EndInit();
                return image;
            }

        }
        public static void Gj()
        {
            Vehicle newVehicle = new Vehicle();
            string sqlExpression = string.Format(PUK.link2, newVehicle.ID);
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + PUK.Triton + ";Version=3;"))
            {
                connection.Open();
                //добавление
                SQLiteCommand command = new SQLiteCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                connection.Close();
            }
        }

    }

}
