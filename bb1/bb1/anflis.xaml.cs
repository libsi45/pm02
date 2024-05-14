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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace bb1

{
   
    
    public partial class analizators : Window
    {
        private object data1;

        public analizators()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) => data1.IsReadOnly = false;

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            data1.IsReadOnly = false; 
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            using (var context = new Entities5())
            {
                foreach (var item in data1.Items)
                {
                    var analizator = item as Анализатор;
                    if (analizator != null)
                    {
                        var existingAnalizator = context.Анализатор.Find(analizator.Код_анализатора);
                        if (existingAnalizator != null)
                        {
                            context.Entry(existingAnalizator).CurrentValues.SetValues(analizator); 
                    }
                }

                context.SaveChanges();
                }

                data1.IsReadOnly = true;
            }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
          

                context.SaveChanges(); 
            }

            data1.IsReadOnly = true; 
        }
    }
}
