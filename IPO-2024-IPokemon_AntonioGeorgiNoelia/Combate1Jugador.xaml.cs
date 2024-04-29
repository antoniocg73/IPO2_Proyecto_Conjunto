using Pokemon_Antonio_Campallo_Gomez;
using System;
using System.Collections.Generic;
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
    public sealed partial class Combate1Jugador : Page
    {
        ArticunoACG flipMiArticuno;
        ChandelureNDAA flipMiChandelure;
        MyUCLucario flipMiLucario;
        int turno;

        public Combate1Jugador()
        {
            this.InitializeComponent();
            articunoCombate1.verFondo(false); articunoCombate2.verFondo(false);
            articunoCombate1.verFilaVida(false); articunoCombate2.verFilaVida(false);
            articunoCombate1.verFilaEnergia(false); articunoCombate2.verFilaEnergia(false);
            articunoCombate1.verNombre(false); articunoCombate2.verNombre(false);

            chandelureCombate1.verFondo(false); chandelureCmbate2.verFondo(false);
            chandelureCombate1.verFilaVida(false); chandelureCmbate2.verFilaVida(false);
            chandelureCombate1.verFilaEnergia(false); chandelureCmbate2.verFilaEnergia(false);  
            chandelureCombate1.verNombre(false); chandelureCmbate2.verNombre(false);

            ((iPokemon)lucarioCombate1).verFondo(false); ((iPokemon)lucarioCombate2).verFondo(false);
            ((iPokemon)lucarioCombate1).verFilaVida(false); ((iPokemon)lucarioCombate2).verFilaVida(false);
            ((iPokemon)lucarioCombate1).verFilaEnergia(false); ((iPokemon)lucarioCombate2).verFilaEnergia(false);
            ((iPokemon)lucarioCombate1).verNombre(false); ((iPokemon)lucarioCombate2).verNombre(false);
            ((iPokemon)lucarioCombate1).verPocionEnergia(false); ((iPokemon)lucarioCombate2).verPocionEnergia(false);
            ((iPokemon)lucarioCombate1).verPocionVida(false); ((iPokemon)lucarioCombate2).verPocionVida(false);

        }

        private void clickJugador1(object sender, RoutedEventArgs e)
        {
            flipJugador1.IsEnabled = false;
            switch (flipJugador1.SelectedIndex)
            {
                case 0:
                    flipMiArticuno = flipJugador1.SelectedItem as ArticunoACG;
                    break;
                case 1:
                    flipMiChandelure = flipJugador1.SelectedItem as ChandelureNDAA;
                    break;
                case 2:
                    flipMiLucario = flipJugador1.SelectedItem as MyUCLucario;
                    break;
                default:
                    // Caso por defecto (si flipJugador1.SelectedIndex no coincide con ningún caso)
                    break;
            }
            btnElegirPokemon1.Visibility = Visibility.Collapsed;
            //controlesJugador1.Visibility = Visibility.Visible;
            if (flipJugador1.IsEnabled == false && flipMaquina.IsEnabled == false)
            {
                turno = azarTurno();
                if (turno == 1)
                {
                    maquinaNoJuega();
                }
                else
                {
                    maquinaSiJuega();
                }
            }
        }
        
        private void clickJugadorMaquina(object sender, RoutedEventArgs e)
        {
            flipMaquina.IsEnabled = false;
            switch (flipMaquina.SelectedIndex)
            {
                case 0:
                    flipMiArticuno = flipMaquina.SelectedItem as ArticunoACG;
                    break;
                case 1:
                    flipMiChandelure = flipMaquina.SelectedItem as ChandelureNDAA;
                    break;
                case 2:
                    flipMiLucario = flipMaquina.SelectedItem as MyUCLucario;
                    break;
                default:
                    // Caso por defecto (si flipJugador1.SelectedIndex no coincide con ningún caso)
                    break;
            }
            btnElegirPokemonMaquina.Visibility = Visibility.Collapsed;
            if (flipJugador1.IsEnabled == false && flipMaquina.IsEnabled == false)
            {
                turno = azarTurno();
                if (turno == 1)
                {
                    maquinaNoJuega();
                }
                else
                {
                    maquinaSiJuega();
                }
            }
        }

        public int azarTurno()
        {
            Random rnd = new Random();
            return rnd.Next(1, 2);
        }   

        public void maquinaNoJuega()
        {
            
        }

        public void maquinaSiJuega()
        {

        }

        private void opcionesDeAtaque(object sender, RoutedEventArgs e)
        {
            controlesJugador1.Visibility = Visibility.Collapsed;
            opcionesAtacar.Visibility = Visibility.Visible;
        }
    }
}
