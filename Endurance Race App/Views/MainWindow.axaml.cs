using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaApplication1.Classes;

namespace AvaloniaApplication1.Views;

public partial class MainWindow : Window
{
    private APIinterface api;
    public MainWindow()
    {
        InitializeComponent();
        api = new APIinterface();
    }

    private void GetLapTime_OnClick(object? sender, RoutedEventArgs e)
    {
        string lapTime = api.GetLapTime().GetAwaiter().GetResult();

        if (lapTime != "")
        {
            LapTimeText.Text = lapTime;
        }
    }
}