using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.IO;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using baza;
using GalaSoft.MvvmLight.CommandWpf;
using Global;
using Sa;

namespace Приложение_для_еды
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public  List<Vehicle> Vehicles { get; }
        public static ObservableCollection<Vehicle> ShoppingСarts { get; } = new ObservableCollection<Vehicle>();

        //public ObservableCollection<Vehicle> ShoppingСarts { get; } = new ObservableCollection<Vehicle>();
        public Window1()
        {
            InitializeComponent();
            DataContext = this;
            vehiclesList.SelectionChanged += OnSelectionChanged;
            Vehicles = new List<Vehicle>();
            ListBox.Items.Add(Vehicles);
        }

        private void AddVehicleToShipporingCarts(Vehicle newVehicle)
        {
            BF.Gj();
        }
        private RelayCommand<Vehicle> _deleteCommand;
        public RelayCommand<Vehicle> DeleteCommand => _deleteCommand
            ?? (_deleteCommand = new RelayCommand<Vehicle>(ItemUnchecked));

        private void ItemUnchecked(Vehicle parameter)
        {
            ShoppingСarts.Remove(parameter);
        }
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //Sou sound = new Sou();
            //sound.zvk();

            Vehicle selectedItem = (Vehicle)e.AddedItems[0];
            // Добавил на экран
            ShoppingСarts.Add(selectedItem);
            // Добавил в базу данных
            AddVehicleToShipporingCarts(selectedItem);
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //ListBox.Items.Clear();
            
        }
    }
}
