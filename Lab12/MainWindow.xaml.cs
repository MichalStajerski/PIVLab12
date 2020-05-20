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
using System.Runtime.InteropServices;
using System.Security;

namespace Lab12
{
    
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public List<User> Users = new List<User>()
        {
            new User("JK","ha")
            

        };

        public MainWindow()
        {
            InitializeComponent();
            
        }
        
       


        String SecureStringToString(SecureString value)
        {
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(value);
                return Marshal.PtrToStringUni(valuePtr);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }

        public void Verification(string login,string password)
        {

            //var attempt = Users.Where(x => x.Login == login && x.Password == password);
            if (Users[0].Login == login && Users[0].Password == password)
            {
                MessageBox.Show("Udalo sie zalogowac");
               
            }
            else
            {
                MessageBox.Show("Nie udalo sie zalogowac");
             
            }
            

            

            



            

        }
        
        


        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            
            var a = SecureStringToString(MyPasswordBox.SecurePassword);
            string password = a;

            string login = MyTextBox.Text;
            

            Verification(login,password);


                       
         

        }

       
    }
}
