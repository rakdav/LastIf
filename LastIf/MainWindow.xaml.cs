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

namespace LastIf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = double.Parse(X.Text);
                double y = double.Parse(Y.Text);
                double c;
                if (x - y == 0)
                {
                    c = Math.Sinh(x) * Math.Sinh(x) + y * y + Math.Sin(y);
                }
                else if(x-y>0)
                {
                    c = (Math.Sinh(x) - y) * (Math.Sinh(x) - y) + Math.Cos(y);
                }
                else
                {
                    c = (y - Math.Sinh(x)) * (y - Math.Sinh(x)) + Math.Tan(y);
                }
                Result.Text =String.Format("c={0:F2} x={1} y={2}",c,x,y);
            }
            catch(Exception ex)
            {

            }
        }
    }
}
