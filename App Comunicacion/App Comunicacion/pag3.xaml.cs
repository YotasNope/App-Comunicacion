using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace App_Comunicacion
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class pag3 : ContentPage
{
    public pag3()
    {
        InitializeComponent();

            MyMap.MoveToRegion(
                    MapSpan.FromCenterAndRadius(
                    new Position(4.751419, -74.029902),
                    Distance.FromKilometers(30)
                    )
                );
    }
}
}