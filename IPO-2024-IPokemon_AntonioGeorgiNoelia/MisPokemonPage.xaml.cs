using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace IPO_2024_IPokemon_AntonioGeorgiNoelia
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MisPokemonPage : Page
    {
        public MisPokemonPage()
        {
            this.InitializeComponent();

            tbNombre.Text = "Nombre: " + miArticuno.Nombre;
            tbCategoria.Text = "Categoría: " + miArticuno.Categoría;
            tbDescripcion.Text = "Descripción: " + miArticuno.Descripcion;
            miArticuno.verFilaVida(false);
            miArticuno.verFilaEnergia(false);
            miArticuno.verFondo(false);
            miArticuno.verNombre(false);

            ApplicationView.GetForCurrentView().VisibleBoundsChanged += UcRatingText_VisibleBoundsChanged;

        }

        private void UcRatingText_VisibleBoundsChanged(ApplicationView sender, object args)
        {
            var Width = ApplicationView.GetForCurrentView().VisibleBounds.Width;

            if (Width >= 1200)
            {
                RelativePanel.SetBelow(tbNombre, null);
                RelativePanel.SetRightOf(tbNombre, miArticuno);
                RelativePanel.SetRightOf(tbCategoria, miArticuno);
                RelativePanel.SetRightOf(tbDescripcion, miArticuno);
                RelativePanel.SetBelow(tbCategoria, tbNombre);
                RelativePanel.SetBelow(tbDescripcion, tbCategoria);
            }
            else
            {
                RelativePanel.SetRightOf(tbNombre, null);
                RelativePanel.SetRightOf(tbCategoria, null);
                RelativePanel.SetRightOf(tbDescripcion, null);
                RelativePanel.SetBelow(tbNombre, miArticuno);
                RelativePanel.SetBelow(tbCategoria, tbNombre);
                RelativePanel.SetBelow(tbDescripcion, tbCategoria);
            }
        }

    }
}
