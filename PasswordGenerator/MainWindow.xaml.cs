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
using System.ComponentModel;

namespace PasswordGenerator
{
        /// <summary>
        /// Логика взаимодействия для MainWindow.xaml
        /// </summary>
        public partial class MainWindow:INotifyPropertyChanged
        {
                public event PropertyChangedEventHandler PropertyChanged;

                

                protected string password_length;

                protected string password;

                public string Password
                {
                        get { return password; }
                        set
                        {
                                if (password != value)
                                {
                                        password = value;
                                        OnPropertyChanged("Password");

                                }
                                        


                        }
                }
                public string PasswordLength
                {
                        get { return password_length; }

                        set
                        {
                                if (password_length != value)
                                {
                                        password_length = value;
                                        OnPropertyChanged("PasswordLength");
                                }
                                
                        }
                }

                public MainWindow()
                {
                        InitializeComponent();
                        DataContext = this;
                        
                }

                public void OnPropertyChanged(string property)
                {
                        if (PropertyChanged != null)
                                PropertyChanged(this, new PropertyChangedEventArgs(property));
                }

                public void OnGenerateButtonClick(object sender, RoutedEventArgs e)
                {
                        NewPasswordGenerator passwordgenerator = new NewPasswordGenerator();
                        Password = passwordgenerator.GeneratePassword(PasswordLength);

                }

        }
}
