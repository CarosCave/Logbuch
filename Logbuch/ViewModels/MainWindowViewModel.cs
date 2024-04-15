using System;
using System.Collections.Generic;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using Logbuch.Models;
namespace Logbuch.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private string _rufzeichen = "DK1CMB";

    [ObservableProperty] private string _name = "Caroline Claußen";

    //[ObservableProperty] private string _band;
    
    //public string? Name = "Caroline Claußen";
    //private string? _band = "20 m";
    private string _band = "20 m";
    
    public string Band 
    {
        get => _band;
        set
        {
            OnPropertyChanged(nameof(Band));
        }
    }
    public List<string> Bands { get; }
    
    public LogbuchEintrag Eintrag = new LogbuchEintrag();
    private List<LogbuchEintrag> Logbuch = new List<LogbuchEintrag>();

    public void TriggerNewEntry()
    {
        

        Eintrag.CallSign = Rufzeichen;
        Eintrag.OperatorName = Name;
        Eintrag.Band = Band;
        
        Logbuch.Add(Eintrag);
        Eintrag = new LogbuchEintrag();
    }

    public void TriggerConsoleEntry()
    {
        foreach (var entry in Logbuch)
        {
            Console.WriteLine(entry.CallSign);
            Console.WriteLine(entry.OperatorName);
            Console.WriteLine(entry.Band);
            Console.WriteLine();
        }
    }
    
    public MainWindowViewModel()
    {
        Bands = new List<string> { "80 m", "40 m", "20 m", "2 m", "70 cm"};
    }
    
}