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
    public class Pokemon
    {
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
    }

    public sealed partial class MisPokemonPage : Page
    {
        public MisPokemonPage()
        {
            this.InitializeComponent();
            List<Pokemon> pokemons = new List<Pokemon>
            {
                new Pokemon { ImagePath = "/Assets/Chandelure.png", ImageName = "/Assets/ChandelureTexto.png" },
                new Pokemon { ImagePath = "/Assets/Articuno.jpg", ImageName = "/Assets/ArticunoTexto.png"  },
                new Pokemon { ImagePath = "/Assets/Lucario.jpg", ImageName = "/Assets/LucarioTexto.png" }
            };
            GridViewMisPokemons.ItemsSource = pokemons;
        }

        private void MisPokemons_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
