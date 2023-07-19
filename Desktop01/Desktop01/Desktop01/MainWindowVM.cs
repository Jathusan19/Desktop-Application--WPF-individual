using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop01.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Desktop01
{
    public  partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        public  ObservableCollection<User> users;
        [ObservableProperty]
        public User selectedUser=null;



        public void CloseMainWindow()
        {
            Application.Current.MainWindow.Close();
        }




        [RelayCommand]
        public void messeag()
        {

            MessageBox.Show($"{selectedUser.FirstName} GPA value must be between 0 and 4.", "Error");
        }

        [RelayCommand]
        public void AddStudent()
        {
            var vm = new AddUserVM();
            vm.title = "ADD USER";
            AddUserWindow window = new AddUserWindow(vm);
            window.ShowDialog();

            if (vm.Student.FirstName != null)
            {
                users.Add(vm.Student);
            }
        }

        [RelayCommand]
        public void Delete()
        {
            if (selectedUser != null)
            {
                string name = selectedUser.FirstName;
                users.Remove(selectedUser);
                MessageBox.Show($"{name} is Deleted successfuly.", "DELETED \a ");
                
            }
            else
            {
                MessageBox.Show("Plese Select Student before Delete.", "Error");


            }
        }
        [RelayCommand]
        public void ExecuteEditStudentCommand()
        {
            if (selectedUser != null)
            {
                var vm = new AddUserVM(selectedUser);
                vm.title = "EDIT USER";
                var window = new AddUserWindow(vm);

                window.ShowDialog();


                int index = users.IndexOf(selectedUser);
                users.RemoveAt(index);
                users.Insert(index, vm.Student);



            }
            else
            {
                MessageBox.Show("Please Select the student", "Warning!");
            }
        }

        public  MainWindowVM()
        {
            users = new ObservableCollection<User>();
            BitmapImage image1 = new BitmapImage(new Uri("/Model/Images/4.png", UriKind.Relative));
            users.Add(new User(12, "Steve", "Jobs", "12/10/2002",image1));
            BitmapImage image2 = new BitmapImage(new Uri("/Model/Images/3.png", UriKind.Relative));
            users.Add(new User(12, "Manth", "Hatton", "1/7/2004",image2));
            BitmapImage image3 = new BitmapImage(new Uri("/Model/Images/2.png", UriKind.Relative));
            users.Add(new User(12, "Alvin", "Lewis", "9/3/2003",image3));
            BitmapImage image4= new BitmapImage(new Uri("/Model/Images/1.png", UriKind.Relative));
            users.Add(new User(12, "Knight", "Rider", "20/2/2006", image4));
            BitmapImage image5 = new BitmapImage(new Uri("/Model/Images/5.png", UriKind.Relative));
            users.Add(new User(12, "Mass", "miden", "20/2/2005", image5));
            BitmapImage image6 = new BitmapImage(new Uri("/Model/Images/6.png", UriKind.Relative));
            users.Add(new User(12, "Mahot", "Mann", "20/2/2003", image6));
            BitmapImage image7 = new BitmapImage(new Uri("/Model/Images/7.png", UriKind.Relative));
            users.Add(new User(12, "Shilbert", "Shut", "20/2/2006", image7));
            BitmapImage image8 = new BitmapImage(new Uri("/Model/Images/8.png", UriKind.Relative));
            users.Add(new User(12, "Koweski", "Riden", "20/2/2002", image8));
            BitmapImage image9 = new BitmapImage(new Uri("/Model/Images/9.png", UriKind.Relative));
            users.Add(new User(12, "Towinski", "Kawasaki", "20/2/2001", image9));

        }
    }
}
