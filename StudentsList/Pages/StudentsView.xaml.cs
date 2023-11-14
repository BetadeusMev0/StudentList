using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace StudentsList.Pages
{
    /// <summary>
    /// Логика взаимодействия для StudentsView.xaml
    /// </summary>
    public partial class StudentsView : Page
    {
        public StudentsView(MV mv)
        {
            this.mv= mv;
            InitializeComponent();
            View.ItemsSource= this.mv.students;
        }

        private MV mv = new MV();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((Student)(((Button)sender).DataContext)).Name); // ОЧЕНЬ ВАЖНО





            //((MainWindow)Tag).mainFrame.Navigate(Student.GetStudentsExample()[0].ImgPath);
        }
    }
}
