using System.Windows.Input;
using System.Windows;
using System.Windows.Shapes;
namespace Board2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //  board.MouseLeftButtonDown += Board_MouseLeftButtonDown;
            board.MouseLeftButtonDown += Board_MouseLeftButtonDown;
        }
        private void Board_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(board);
            X.Content = $"X: {point.X}";
            Y.Content = $"Y: {point.Y}";
        }
    }
}