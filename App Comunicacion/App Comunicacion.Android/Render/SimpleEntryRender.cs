using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App_Comunicacion.Custom;
using App_Comunicacion.Droid.Render;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(SimpleEntry), typeof(SimpleEntryRender))]
namespace App_Comunicacion.Droid.Render
{
#pragma warning disable CS0618 // Type or member is obsolete
    public class SimpleEntryRender:ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            var Gradiente = new GradientDrawable();
            Gradiente.SetCornerRadius(30f);
            Gradiente.SetStroke(0, Android.Graphics.Color.White);
            Gradiente.SetColor(Android.Graphics.Color.White);
            Control.SetBackground(Gradiente);
            Control.SetPadding(25, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);

        }
    }
#pragma warning disable CS0618 // Type or member is obsolete
}