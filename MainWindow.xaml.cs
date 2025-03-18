using System.Diagnostics;
using System.Windows;
using System.Windows.Media;
using System.Threading;

namespace positionCheck;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    Positions PositionIndicator = new Positions();

    public MainWindow() {
        if( Process.GetProcessesByName("ShellShockLive").Length > 0 ) {
            InitializeComponent();
        } else {
            MessageBox.Show("ShellShock Live not found... The application will now exit.", "ShellShock Live not found.", MessageBoxButton.OK, MessageBoxImage.Error);
            Environment.Exit(1);
        }
    }

    private void ExitButton_MouseOn( object sender, RoutedEventArgs e ) {
        ExitButton.Foreground = Brushes.White;
    }

    private void ShowAlignmentsButton_MouseOn( object sender, RoutedEventArgs e ) {
        ShowAlignmentsButton.Foreground = Brushes.White;
    }

    private void ShowAlignmentsButton_MouseOff( object sender, RoutedEventArgs e ) {
        ShowAlignmentsButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 18, 43, 15));
    }

    private void ExitButton_MouseOff( object sender, RoutedEventArgs e ) {
        ExitButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 76, 20, 20));
    }

    private void ExitButton_Click( object sender, RoutedEventArgs e ) {
        Environment.Exit(1);
    }

    private void ShowAlignmentsButton_Click( object sender, RoutedEventArgs e ) {
        if (PositionIndicator.Visibility == Visibility.Visible) {
            PositionIndicator.Visibility = Visibility.Hidden;
        } else {
            PositionIndicator.Visibility = Visibility.Visible;
        }        
    }
}