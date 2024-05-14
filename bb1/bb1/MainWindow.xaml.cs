using System;
using System.Collections.Generic;
using System.Data;
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

namespace bb1
{
   
    public partial class MainWindow : Window
    {
        public object par { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void UpdateTime(int code)
        {
           
        }
        private void authorization_Click(object sender, RoutedEventArgs e)
        {
            if (Text != "" && Password != "")
            {
                using (var bd = new Entities5())
                {

                    var user = bd.Авторизация.FirstOrDefault(p => p.Логин == log.Text && p.Пароль == par.Password);
                    if (user != null)
                    {
                        if ((user.Время_блокировки != null) && (Convert.ToInt32((DateTime.Now - user.Время_блокировки).Value.TotalMinutes) <= 30))
                        {
                            MessageBox.Show($"Учетная запись  заблокированна. До блокировки {30 - ((DateTime.Now - user.Время_блокировки).Value.Minutes)} минут.");
                            return;
                        }

                        var role = from pol in bd.Пользователи


                    }
                }

                {
                    MessageBox.Show("Логин или пароль указаны не правильно");
                    return;
                }
            }

            MessageBox.Show("Заполните поля");
            return;
        }
    }
    }
}
