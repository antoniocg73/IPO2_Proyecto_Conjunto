using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class PokedexPage : Page
    {
        public class Pokemon
        {
            public string Name { get; set; }
            public string Image { get; set; }
        }

        public class GroupInfoCollection<T> : ObservableCollection<T>
        {
            public char Key { get; set; }
            public GroupInfoCollection(IEnumerable<T> items) : base(items) { }

        }

        private List<Pokemon> pokemons = new List<Pokemon>
        {
            new Pokemon { Name = "Articuno", Image = "Assets/ArticunoPokedex.png" },
            new Pokemon { Name = "Butterfree", Image = "Assets/ButterFreePokedex.png" },
            new Pokemon { Name = "Chandelure", Image = "Assets/ChandelurePokedex.png" },
            new Pokemon { Name = "Charizard", Image = "Assets/CharizardPokedex.png" },
            new Pokemon { Name = "Garchomp", Image = "Assets/GarchompPokedex.png" },
            new Pokemon { Name = "Gengar", Image = "Assets/GengarPokedex.png" },
            new Pokemon { Name = "Grookey", Image = "Assets/GrookeyPokedex.png" },
            new Pokemon { Name = "Lapras", Image = "Assets/LaprasPokedex.png" },
            new Pokemon { Name = "Lucario", Image = "Assets/LucarioPokedex.png" },
            new Pokemon { Name = "Makuhita", Image = "Assets/MakuhitaPokedex.png" },
            new Pokemon { Name = "Scizor", Image = "Assets/ScizorPokedex.png" },
            new Pokemon { Name = "Snorlax", Image = "Assets/SnorlaxPokedex.png" },
        };

        public ObservableCollection<GroupInfoCollection<Pokemon>> PokemonsGrouped { get; set; }
        public PokedexPage()
        {
            this.InitializeComponent();
            GroupPokemons();
            DataContext = this;
        }

        private void GroupPokemons()
        {
            var grouped = from pokemon in pokemons
                        group pokemon by pokemon.Name[0] into grp
                        orderby grp.Key
                        select new GroupInfoCollection<Pokemon>(grp) { Key = grp.Key };
            PokemonsGrouped = new ObservableCollection<GroupInfoCollection<Pokemon>>(grouped);
        }

        private void InfoPokemon(object sender, ItemClickEventArgs e)
        {
            if (e.ClickedItem is Pokemon clickedPokemon)
            {
                // Pagina detalles del pokemon
            }
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = (sender as TextBox)?.Text.ToLower() ?? "";
            var filteredList = pokemons.Where(p => p.Name.ToLower().Contains(searchText)).ToList();
            var grouped = from pokemon in filteredList
                          group pokemon by pokemon.Name[0] into grp
                          orderby grp.Key
                          select new GroupInfoCollection<Pokemon>(grp) { Key = grp.Key };

            PokemonsGrouped.Clear();
            foreach (var group in grouped)
            {
                PokemonsGrouped.Add(group);
            }
        }

    }
}
