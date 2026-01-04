using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rive.Demo.ViewModels;

namespace Rive.Demo.Pages;

public partial class UpdatePropertiesPage : ContentPage
{
    public UpdatePropertiesPage()
    {
        InitializeComponent();

        BindingContext = new UpdatePropertiesViewModel();
    }
}