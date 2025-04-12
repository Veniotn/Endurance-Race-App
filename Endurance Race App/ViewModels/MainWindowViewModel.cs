using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaApplication1.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";
    
    [ObservableProperty] private string _LapTimesText = "Lap times: ";
    [ObservableProperty] private string _CurrentLapTimeText = "Current lap time: ";
    [ObservableProperty] private string _BestLapText = "Best lap: ";
    
    //Session Info
    [ObservableProperty] private string _TimeRemainingText = "Time remaining: ";
    [ObservableProperty] private string _LapsRemainingText = "Laps remaining: ";
    [ObservableProperty] private string _LapHistoryText = "Lap history: ";
    
}