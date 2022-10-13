using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1_LayoutXF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        // Método do evento Clicked do Botão 
        private void GoPaginaStack(object sender, EventArgs args)
        {
            // Abrir Página
            Navigation.PushAsync(new Layouts.Stack.StackPage());
        }


        // Método do evento Clicked do Botão 
        private void GoPaginaGrid(object sender, EventArgs args)
        {
            // Abrir Página
            Navigation.PushAsync(new Layouts.Grid.GridPage());
        }

        // Método do evento Clicked do Botão 
        private void GoPaginaAbsolute(object sender, EventArgs args)
        {
            // Abrir Página
            Navigation.PushAsync(new Layouts.Absolute.AbsolutePage());
        }

        // Método do evento Clicked do Botão 
        private void GoPaginaRelative(object sender, EventArgs args)
        {
            // Abrir Página
            Navigation.PushAsync(new Layouts.Relative.RelativePage());
        }

        // Método do evento Clicked do Botão 
        private void GoPaginaScrool(object sender, EventArgs args)
        {
            // Abrir Página
            Navigation.PushAsync(new Layouts.Scrool.ScroolPage());
        }





    }
}
