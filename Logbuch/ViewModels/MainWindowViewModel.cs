using CommunityToolkit.Mvvm.ComponentModel;

namespace Logbuch.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private string _rufzeichen = "DK1CMB";

    [ObservableProperty] private string _name = "Caroline Claußen";

    [ObservableProperty] private string _band;
    
    //public string? Name = "Caroline Claußen";
    //private string? _band = "20 m";
    
    
    
   // public LogbuchEintrag Eintrag = new LogbuchEintrag();
    //private List<LogbuchEintrag> Logbuch = new List<LogbuchEintrag>();

    void TriggerNewEntry()
    {
        
    }

    public MainWindowViewModel()
    {
        
    }
    
}