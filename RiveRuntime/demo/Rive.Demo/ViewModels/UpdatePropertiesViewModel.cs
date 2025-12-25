using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Rive.Demo.ViewModels;

public partial class UpdatePropertiesViewModel : ObservableObject
{
    [ObservableProperty] private string? _artboardName = "Emoji_package";

    [RelayCommand]
    private void UpdateProperty(string property)
    {
        ArtboardName = property switch
        {
            "artboard" => ArtboardName == "Emoji_package" ? "Onfire" : "Emoji_package",
            _ => ArtboardName
        };
    }
}