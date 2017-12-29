using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PasswordGenerator
{
        class NewPasswordGenerator:INotifyPropertyChanged
        {
                public event PropertyChangedEventHandler PropertyChanged;

                protected const string symbols = "ABCDEFGHIGKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

                Random rand_number = new Random();

                                      
                
                        

                public string GeneratePassword(string password_length)
                {
                        bool _check_convert;

                        int _length;

                        _check_convert = Int32.TryParse(password_length,out _length);

                        if (_check_convert == false)
                                return "";

                        if (_length < 0)
                                _length = 1;

                        string _new_password = "";

                        char [] _symbols = symbols.ToCharArray();

                        while (_new_password.Length != _length)
                        {
                                _new_password += _symbols[rand_number.Next(0, _symbols.Length - 1)]; 
                        }

                       return _new_password;

                }

                public void OnPropertyChanged(string property)
                {
                        if (PropertyChanged != null)
                                PropertyChanged(this, new PropertyChangedEventArgs(property));
                }

                
        }
}
