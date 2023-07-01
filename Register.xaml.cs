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
using System.IO;
using System.Configuration;

namespace Library
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        string Rootpath;
        public Register()
        {
            InitializeComponent();
            Rootpath = "C:\\Users\\welcome\\Documents\\";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                Set. Settings1 settings = new Set.Settings1();
                settings.You = txtname.Text;
                settings.Save();
            {

                if (txtname.Text != "" && txtcpass.Text != "" && txtmail.Text != "" && txtusname.Text != "")
                {
                    string Newfoldername = System.IO.Path.Combine(Rootpath, txtname.Text);
                    Directory.CreateDirectory(Newfoldername);
                    string Content = $"{txtname.Text}|{txtmail.Text}|{txtpass.Text}";
                    MessageBoxResult result=MessageBox.Show("Register sucessful");
                    string Create=System.IO.Path.Combine(Newfoldername,"Profile");
                    File.WriteAllText(Create,Content);
                     if (result == MessageBoxResult.OK)

                    {
                        Register register = new Register();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Fill all Details");
                    }
                }
               
                }
                }

      

        private void txtusname_MouseEnter(object sender, MouseEventArgs e)
        {
            txtusname.Clear();
        }

        private void txtname_MouseEnter(object sender, MouseEventArgs e)
        {
            txtname.Clear();
        }

        private void txtmail_MouseEnter(object sender, MouseEventArgs e)
        {
            txtmail.Clear();    
        }

        private void txtpass_MouseEnter(object sender, MouseEventArgs e)
        {
            txtpass.Clear();
        }

        private void txtcpass_MouseEnter(object sender, MouseEventArgs e)
        {
            txtcpass.Clear();
        }
    }
        }
    

