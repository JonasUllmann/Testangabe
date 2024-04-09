using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SEW3Test_buchliste
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        private bool state;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();


            timer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            if (state)
            {
                btnadd.Background = Brushes.Gray;
            }
            else
            {
                btnadd.Background= Brushes.Red;
            }

            state = !state;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Buch b1 = new Buch(tbxname.Text, (DateTime)dtp.SelectedDate);
            b1.randomgen();
            lbxlist.Items.Add(b1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lbxlist.Items.Clear();
            tbxname.Clear();

        }
    }

    public class Buch
    {

        private string name;
        private DateTime date;
        private int bookid;

        Random rndm = new Random();

        public Buch(string name, DateTime date)
        {
            this.name = name;
            this.date = date;
        }

        public void randomgen()
        {
            bookid = rndm.Next(100000, 999999);
        }

        public override string ToString()
        {
            return $"{bookid} {name} {date.ToShortDateString()}";
        }

    }
}