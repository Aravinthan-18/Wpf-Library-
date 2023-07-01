using Library.Set;
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

namespace Library
{
    /// <summary>
    /// Interaction logic for Books.xaml
    /// </summary>
    public partial class Books : Window
    {
        public Books()
        {
            InitializeComponent();
            Set.Settings1 settings1= new Set.Settings1();
            lblname.Content = settings1.You;
            lblponni.Content = settings1.Ponni;
            lblpython.Content = settings1.Python;
            lblcpro.Content = settings1.cpro;
            lblcsharp.Content = settings1.csharp;
            lbljava.Content=settings1.java;
            lblche.Content=settings1.che;
            lblphy.Content=settings1.phy;
            lbltes.Content=settings1.tes;
        }
        Set.Settings1 settings1 = new Set.Settings1();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lblponni.Content = settings1.Ponni;
            settings1.Ponni -=1;
            settings1.Save();
            {
                lblponni.Content = settings1.Ponni;
                MessageBox.Show("Ponniyin Selvan","Library");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lblponni.Content = settings1.Ponni;
            settings1.Ponni += 1;
            settings1.Save();
            {
                lblponni.Content = settings1.Ponni;
                MessageBox.Show("Ponniyin Selvan", "Library");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lblpython.Content = settings1.Python;
            settings1.Python -= 1;
            settings1.Save();
            {
                lblpython.Content = settings1.Python;
                MessageBox.Show("Python", "Library");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            lblpython.Content = settings1.Python;
            settings1.Python += 1;
            settings1.Save();
            {
                lblpython.Content = settings1.Python;
                MessageBox.Show("Python", "Library");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            lblcpro.Content = settings1.cpro;
            settings1.cpro -= 1;
            settings1.Save();
            {
                lblcpro.Content = settings1.cpro  ;
                MessageBox.Show("Cprogram", "Library");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            lblcpro.Content = settings1.cpro;
            settings1.cpro += 1;
            settings1.Save();
            {
                lblcpro.Content = settings1.cpro;
                MessageBox.Show("Cprogram", "Library");
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            lblcsharp.Content = settings1.csharp;
            settings1.csharp -= 1;
            settings1.Save();
            {
                lblcsharp.Content = settings1.csharp;
                MessageBox.Show("Csharp", "Library");
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            lblcsharp.Content = settings1.csharp;
            settings1.csharp += 1;
            settings1.Save();
            {
                lblcsharp.Content = settings1.csharp;
                MessageBox.Show("Csharp", "Library");
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            lbljava.Content = settings1.java;
            settings1.java -= 1;
            settings1.Save();
            {
                lbljava.Content = settings1.java;
                MessageBox.Show("Java", "Library");
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            lbljava.Content = settings1.java;
            settings1.java += 1;
            settings1.Save();
            {
                lbljava.Content = settings1.java;
                MessageBox.Show("Java", "Library");
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            lblche.Content = settings1.java;
            settings1.che -= 1;
            settings1.Save();
            {
                lblche.Content = settings1.che;
                MessageBox.Show("Chemistry", "Library");
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            lblche.Content = settings1.che;
            settings1.che += 1;
            settings1.Save();
            {
                lblche.Content = settings1.che;
                MessageBox.Show("Chemistry", "Library");
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            lblphy.Content = settings1.phy;
            settings1.phy -= 1;
            settings1.Save();
            {
                lblphy.Content = settings1.phy;
                MessageBox.Show("Physics", "Library");
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            lblphy.Content = settings1.phy;
            settings1.phy += 1;
            settings1.Save();
            {
                lblphy.Content = settings1.phy;
                MessageBox.Show("Physics", "Library");
            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            lbltes.Content = settings1.tes;
            settings1.tes -= 1;
            settings1.Save();
            {
                lbltes.Content = settings1.tes;
                MessageBox.Show("Tesla", "Library");
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            lbltes.Content = settings1.tes;
            settings1.tes += 1;
            settings1.Save();
            {
                lbltes.Content = settings1.tes;
                MessageBox.Show("Tesla", "Library");
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Logout conformation","Information");
               Application.Current.Shutdown();
            
        }
    }
}
