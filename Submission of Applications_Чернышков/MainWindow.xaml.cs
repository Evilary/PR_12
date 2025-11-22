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
using Submission_of_Applications_Чернышков.Pages;

namespace Submission_of_Applications_Чернышков
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frame.Navigate(new Statement());
        }

        public void OpenPassport() => frame.Navigate(new Passport());
        public void OpenContacts() => frame.Navigate(new Contacts());
        public void OpenEducation() => frame.Navigate(new Education());
        public void OpenSpeciality() => frame.Navigate(new Speciality());
        public void OpenParents() => frame.Navigate(new Parents());
        public void OpenStatus() => frame.Navigate(new Status());
    }
}
