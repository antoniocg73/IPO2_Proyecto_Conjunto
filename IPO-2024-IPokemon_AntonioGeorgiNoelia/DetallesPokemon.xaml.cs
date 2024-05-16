using Pokemon_Antonio_Campallo_Gomez;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace IPO_2024_IPokemon_AntonioGeorgiNoelia
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class DetallesPokemon : Page
    {
        private iPokemon currentPokemon;

        public DetallesPokemon()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            PokemonPokedex id = e.Parameter as PokemonPokedex;

            switch (id.Name)
            {
                case "Articuno":
                    articuno.Visibility = Visibility.Visible;
                    articuno.verFilaEnergia(false);
                    articuno.verFilaVida(false);
                    currentPokemon = articuno;
                    break;
                case "Butterfree":
                    butterfree.Visibility = Visibility.Visible;
                    currentPokemon = butterfree;
                    break;
                case "Chandelure":
                    chandelure.Visibility = Visibility.Visible;
                    chandelure.verFilaEnergia(false);
                    chandelure.verFilaVida(false);
                    currentPokemon = chandelure;
                    break;
                case "Charizard":
                    charizard.Visibility = Visibility.Visible;
                    currentPokemon = charizard;
                    break;
                case "Garchomp":
                    garchomp.Visibility = Visibility.Visible;
                    currentPokemon = garchomp;
                    break;
                case "Gengar":
                    gengar.Visibility = Visibility.Visible;
                    currentPokemon = gengar;
                    break;
                case "Lapras":
                    lapras.Visibility = Visibility.Visible;
                    currentPokemon = lapras;
                    break;
                case "Lucario":
                    lucario.Visibility = Visibility.Visible;
                    currentPokemon = lucario;
                    ((iPokemon)lucario).verFilaEnergia(false);
                    ((iPokemon)lucario).verFilaVida(false);
                    ((iPokemon)lucario).verPocionEnergia(false);
                    ((iPokemon)lucario).verPocionVida(false);
                    break;
                case "Makuhita":
                    makuhita.Visibility = Visibility.Visible;
                    currentPokemon = makuhita;
                    break;
                case "Scizor":
                    scizor.Visibility = Visibility.Visible;
                    currentPokemon = scizor;
                    break;
                case "Snorlax":
                    snorlax.Visibility = Visibility.Visible;
                    currentPokemon = snorlax;
                    break;
                case "Toxicroak":
                    toxicroak.Visibility = Visibility.Visible;
                    currentPokemon = toxicroak;
                    break;
                default:
                    currentPokemon = articuno;
                    break;

            }

            tbNombrePokedex.Text = "Nombre: " + currentPokemon.Nombre;
            tbCategoriaPokedex.Text = "Categoría: " + currentPokemon.Categoría;
            tbDescripcionPokedex.Text = "Descripción: " + currentPokemon.Descripcion;
            tbAlturaPokedex.Text = "Altura (m): " + currentPokemon.Altura;
            tbPesoPokedex.Text = "Peso (kg): " + currentPokemon.Peso;
            tbEvolucionPokedex.Text = "Evolución: " + currentPokemon.Evolucion;
            tbTipoPokedex.ItemsSource = id.Types;
            pokemonImagenPokedex.Source = new BitmapImage(new Uri("ms-appx://" + id.Image));
        }

        private void btnAtaqueFuerte_Click(object sender, RoutedEventArgs e)
        {
            currentPokemon.animacionAtaqueFuerte();
        }

        private void btnAtaqueDebil_Click(object sender, RoutedEventArgs e)
        {
            currentPokemon.animacionAtaqueFlojo();
        }

        private async void btnHerido_Click(object sender, RoutedEventArgs e)
        {
            currentPokemon.animacionHerido();
            await Task.Delay(5000);
            currentPokemon.animacionNoHerido();
        }

        private async void btnCansado_Click(object sender, RoutedEventArgs e)
        {
            currentPokemon.animacionCansado();
            await Task.Delay(5000);
            currentPokemon.animacionNoCansado();
        }

        private void btnDefensa_Click(object sender, RoutedEventArgs e)
        {
            currentPokemon.animacionDefensa();
        }



        private void btnDescansar_Click(object sender, RoutedEventArgs e)
        {
            currentPokemon.animacionDescasar();
        }




    }
}
