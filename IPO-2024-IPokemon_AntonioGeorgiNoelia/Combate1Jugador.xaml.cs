﻿using Pokemon_Antonio_Campallo_Gomez;
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
using Windows.UI.Xaml.Navigation;
using Windows.UI.Notifications;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Devices.PointOfService;
using Microsoft.Toolkit.Uwp.Notifications;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace IPO_2024_IPokemon_AntonioGeorgiNoelia
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Combate1Jugador : Page
    {
        ArticunoACG flipMiArticunoJugador1;
        ChandelureNDAA flipMiChandelureJugador1;
        MyUCLucario flipMiLucarioJugador1;
        ArticunoACG flipMiArticunoMaquina;
        ChandelureNDAA flipMiChandelureMaquina;
        MyUCLucario flipMiLucarioMaquina;

        int turno;

        public Combate1Jugador()
        {
            this.InitializeComponent();
            articunoCombate1.verFondo(false); articunoCombate2.verFondo(false);
            articunoCombate1.verFilaVida(false); articunoCombate2.verFilaVida(false);
            articunoCombate1.verFilaEnergia(false); articunoCombate2.verFilaEnergia(false);
            articunoCombate1.verNombre(false); articunoCombate2.verNombre(false);
            articunoCombate1.Vida = 100; articunoCombate2.Vida = 100;
            articunoCombate1.Energia = 100; articunoCombate2.Energia = 100;

            chandelureCombate1.verFondo(false); chandelureCombate2.verFondo(false);
            chandelureCombate1.verFilaVida(false); chandelureCombate2.verFilaVida(false);
            chandelureCombate1.verFilaEnergia(false); chandelureCombate2.verFilaEnergia(false);  
            chandelureCombate1.verNombre(false); chandelureCombate2.verNombre(false);
            chandelureCombate1.Vida = 100; chandelureCombate2.Vida = 100;
            chandelureCombate1.Energia = 100; chandelureCombate2.Energia = 100;

            ((iPokemon)lucarioCombate1).verFondo(false); ((iPokemon)lucarioCombate2).verFondo(false);
            ((iPokemon)lucarioCombate1).verFilaVida(false); ((iPokemon)lucarioCombate2).verFilaVida(false);
            ((iPokemon)lucarioCombate1).verFilaEnergia(false); ((iPokemon)lucarioCombate2).verFilaEnergia(false);
            ((iPokemon)lucarioCombate1).verNombre(false); ((iPokemon)lucarioCombate2).verNombre(false);
            ((iPokemon)lucarioCombate1).verPocionEnergia(false); ((iPokemon)lucarioCombate2).verPocionEnergia(false);
            ((iPokemon)lucarioCombate1).verPocionVida(false); ((iPokemon)lucarioCombate2).verPocionVida(false);
            ((iPokemon)lucarioCombate1).Vida = 100; ((iPokemon)lucarioCombate2).Vida = 100;
            ((iPokemon)lucarioCombate1).Energia = 100; ((iPokemon)lucarioCombate2).Energia = 100;

            butterfreeCombate1.verFondo(false); butterfreeCombate2.verFondo(false);
            butterfreeCombate1.verFilaVida(false); butterfreeCombate2.verFilaVida(false);
            butterfreeCombate1.verFilaEnergia(false); butterfreeCombate2.verFilaEnergia(false);
            butterfreeCombate1.verNombre(false); butterfreeCombate2.verNombre(false);
            butterfreeCombate1.Vida = 100; butterfreeCombate2.Vida = 100;
            butterfreeCombate1.Energia = 100; butterfreeCombate2.Energia = 100;
            butterfreeCombate1.verPocionEnergia(false); butterfreeCombate2.verPocionEnergia(false);
            butterfreeCombate1.verPocionVida(false); butterfreeCombate2.verPocionVida(false);

            gengarCombate1.verFondo(false); gengarCombate2.verFondo(false);
            gengarCombate1.verFilaVida(false); gengarCombate2.verFilaVida(false);
            gengarCombate1.verFilaEnergia(false); gengarCombate2.verFilaEnergia(false);
            gengarCombate1.verNombre(false); gengarCombate2.verNombre(false);
            gengarCombate1.Vida = 100; gengarCombate2.Vida = 100;
            gengarCombate1.Energia = 100; gengarCombate2.Energia = 100;
            gengarCombate1.verPocionEnergia(false); gengarCombate2.verPocionEnergia(false);
            gengarCombate1.verPocionVida(false); gengarCombate2.verPocionVida(false);

            laprasCombate1.verFondo(false); laprasCombate2.verFondo(false);
            laprasCombate1.verFilaVida(false); laprasCombate2.verFilaVida(false);
            laprasCombate1.verFilaEnergia(false); laprasCombate2.verFilaEnergia(false);
            laprasCombate1.verNombre(false); laprasCombate2.verNombre(false);
            laprasCombate1.Vida = 100; laprasCombate2.Vida = 100;
            laprasCombate1.Energia = 100; laprasCombate2.Energia = 100;

            makuhitaCombate1.verFondo(false); makuhitaCombate2.verFondo(false);
            makuhitaCombate1.verFilaVida(false); makuhitaCombate2.verFilaVida(false);
            makuhitaCombate1.verFilaEnergia(false); makuhitaCombate2.verFilaEnergia(false);
            makuhitaCombate1.verNombre(false); makuhitaCombate2.verNombre(false);
            makuhitaCombate1.Vida = 100; makuhitaCombate2.Vida = 100;
            makuhitaCombate1.Energia = 100; makuhitaCombate2.Energia = 100;
            makuhitaCombate1.verPocionEnergia(false); makuhitaCombate2.verPocionEnergia(false);
            makuhitaCombate1.verPocionVida(false); makuhitaCombate2.verPocionVida(false);

            scizorCombate1.verFondo(false); scizorCombate2.verFondo(false);
            scizorCombate1.verFilaVida(false); scizorCombate2.verFilaVida(false);
            scizorCombate1.verFilaEnergia(false); scizorCombate2.verFilaEnergia(false);
            scizorCombate1.verNombre(false); scizorCombate2.verNombre(false);
            scizorCombate1.Vida = 100; scizorCombate2.Vida = 100;
            scizorCombate1.Energia = 100; scizorCombate2.Energia = 100;
            scizorCombate1.verPocionEnergia(false); scizorCombate2.verPocionEnergia(false);
            scizorCombate1.verPocionVida(false); scizorCombate2.verPocionVida(false);

            snorlaxCombate1.verFondo(false); snorlaxCombate2.verFondo(false);
            snorlaxCombate1.verFilaVida(false); snorlaxCombate2.verFilaVida(false);
            snorlaxCombate1.verFilaEnergia(false); snorlaxCombate2.verFilaEnergia(false);
            snorlaxCombate1.verNombre(false); snorlaxCombate2.verNombre(false);
            snorlaxCombate1.Vida = 100; snorlaxCombate2.Vida = 100;
            snorlaxCombate1.Energia = 100; snorlaxCombate2.Energia = 100;
            snorlaxCombate1.verPocionEnergia(false); snorlaxCombate2.verPocionEnergia(false);
            snorlaxCombate1.verPocionVida(false); snorlaxCombate2.verPocionVida(false);

            toxicroackCombate1.verFondo(false); toxicroackCombate2.verFondo(false);
            toxicroackCombate1.verFilaVida(false); toxicroackCombate2.verFilaVida(false);
            toxicroackCombate1.verFilaEnergia(false); toxicroackCombate2.verFilaEnergia(false);
            toxicroackCombate1.verNombre(false); toxicroackCombate2.verNombre(false);
            toxicroackCombate1.Vida = 100; toxicroackCombate2.Vida = 100;
            toxicroackCombate1.Energia = 100; toxicroackCombate2.Energia = 100;
            toxicroackCombate1.verPocionEnergia(false); toxicroackCombate2.verPocionEnergia(false);
            toxicroackCombate1.verPocionVida(false); toxicroackCombate2.verPocionVida(false);

            charizardCombate1.verFondo(false); charizardCombate2.verFondo(false);
            charizardCombate1.verFilaVida(false); charizardCombate2.verFilaVida(false);
            charizardCombate1.verFilaEnergia(false); charizardCombate2.verFilaEnergia(false);
            charizardCombate1.verNombre(false); charizardCombate2.verNombre(false);
            charizardCombate1.Vida = 100; charizardCombate2.Vida = 100;
            charizardCombate1.Energia = 100; charizardCombate2.Energia = 100;
            charizardCombate1.verPocionEnergia(false); charizardCombate2.verPocionEnergia(false);
            charizardCombate1.verPocionVida(false); charizardCombate2.verPocionVida(false);

            garchompCombate1.verFondo(false); garchompCombate2.verFondo(false);
            garchompCombate1.verFilaVida(false); garchompCombate2.verFilaVida(false);
            garchompCombate1.verFilaEnergia(false); garchompCombate2.verFilaEnergia(false);
            garchompCombate1.verNombre(false); garchompCombate2.verNombre(false);
            garchompCombate1.Vida = 100; garchompCombate2.Vida = 100;
            garchompCombate1.Energia = 100; garchompCombate2.Energia = 100;
        }

        /*private void flipMaquina_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (flipMaquina.SelectedIndex)
            {
                case 0:
                    pokemonSeleccionadoMaquina = flipMaquina.SelectedItem as ArticunoACG;
                    break;
                case 1:
                    pokemonSeleccionadoMaquina = flipMaquina.SelectedItem as ChandelureNDAA;
                    break;
                case 2:
                    pokemonSeleccionadoMaquina = flipMaquina.SelectedItem as MyUCLucario;
                    break;
                default:
                    // Caso por defecto (si flipMaquina.SelectedIndex no coincide con ningún caso)
                    break;
            }
        } */  
        private async void clickJugador1(object sender, RoutedEventArgs e)
        {
            flipJugador1.IsEnabled = false;
            btnElegirPokemon1.Visibility = Visibility.Collapsed;
            //controlesJugador1.Visibility = Visibility.Visible;
            iPokemon pokemonSeleccionado = flipJugador1.SelectedItem as iPokemon;
            pokemonSeleccionado.verFilaEnergia(true);
            pokemonSeleccionado.verFilaVida(true);
            pokemonSeleccionado.verPocionEnergia(false);
            pokemonSeleccionado.verPocionVida(false);
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
                    turno_maquina_random();
                    await Task.Delay(3000); // Espera 3 segundos
                }
            }
        }
        
        private async void clickJugadorMaquina(object sender, RoutedEventArgs e)
        {
            flipMaquina.IsEnabled = false;
            btnElegirPokemonMaquina.Visibility = Visibility.Collapsed;
            iPokemon pokemonSeleccionado = flipMaquina.SelectedItem as iPokemon;    
            pokemonSeleccionado.verFilaEnergia(true);
            pokemonSeleccionado.verFilaVida(true);
            pokemonSeleccionado.verPocionEnergia(false);
            pokemonSeleccionado.verPocionVida(false);
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
                    turno_maquina_random();
                    await Task.Delay(3000); // Espera 3 segundos
                }
            }
        }

        public int azarTurno()
        {
            Random rnd = new Random();
            return rnd.Next(0, 2);
        }   

        public void maquinaNoJuega()
        {
            textEsperarMaquina.Text = "Es el turno del jugador 1.";
            textEsperarMaquina.Visibility = Visibility.Visible;
            textEsperar1.Visibility = Visibility.Collapsed;
            controlesJugador1.Visibility = Visibility.Visible;
        }

        public void maquinaSiJuega()
        {
            controlesJugador1.Visibility = Visibility.Collapsed;
            textEsperar1.Text = "Es el turno de la máquina.";
            textEsperar1.Visibility = Visibility.Visible;
            textEsperarMaquina.Visibility = Visibility.Collapsed;
        }

        public void turno_maquina_random()
        {
            if (flipMaquina.SelectedItem is iPokemon pokemonSeleccionado)
            {
                if (pokemonSeleccionado.Vida > 30 && pokemonSeleccionado.Energia > 30)
                {
                    ataqueMaquina();
                }
                else if (pokemonSeleccionado.Vida <= 30 && pokemonSeleccionado.Energia > 30)
                {
                    curarMaquina();
                }
                else if (pokemonSeleccionado.Vida > 30 && pokemonSeleccionado.Energia <=30)
                {
                    subirEnergiaMaquina();
                }
                else
                {
                    curarMaquina();
                }
            }
        }
        private async void ataqueMaquina()
        {
            if (flipMaquina.SelectedItem is iPokemon atacante && flipJugador1.SelectedItem is iPokemon defensor)
            {   
                double vidaActual = defensor.Vida;
                double energiaActual = atacante.Energia;
                if (atacante.Energia > 60)
                {
                    atacante.animacionAtaqueFuerte();
                    defensor.Vida -= calcular_daño_fuerte();
                }
                else
                {
                    atacante.animacionAtaqueFlojo();
                    defensor.Vida -= calcular_daño_flojo();
                }
                if (atacante.Energia > 50)
                {
                    atacante.Energia -= 25;
                }
                else
                {
                    atacante.Energia -= 15;
                }
                textEsperarMaquina.Text = "La máquina ha decidido atacar.";
                textEsperarMaquina.Visibility = Visibility.Visible;
                await Task.Delay(10000); // Espera 10 segundos

                if (atacante.Energia <= 30 && energiaActual > 30)
                {
                    atacante.animacionCansado();
                    await Task.Delay(5000); // Espera 5 segundos
                }   

                if (defensor.Vida <= 0)
                {
                    defensor.animacionDerrota();
                    textEsperar1.Text = "Pokemon debilitado.";
                    await Task.Delay(5000); // Espera 5 segundos
                    BitmapImage derrota = new BitmapImage(new Uri("ms-appx:///Assets/derrota.jpg"));
                    imageFinalCombate.Source = derrota;
                    imageFinalCombate.Visibility = Visibility.Visible;
                    txtMensajeVictoria.Text = "¡Ha ganado la máquina!";
                    txtMensajeVictoria.Visibility = Visibility.Visible;
                    //Notificación
                    new ToastContentBuilder().AddArgument("action", "victoriaJugador2").AddArgument("ConversationId", 9813).AddText("¡El jugador 2 ha ganado el combate!").AddAppLogoOverride(new Uri("ms-appx:///Assets/derrota.jpg"), ToastGenericAppLogoCrop.Circle).Show();

                }
                else if (defensor.Vida > 0 && defensor.Vida <= 30 && vidaActual > 30)
                {
                    defensor.animacionHerido();
                    await Task.Delay(5000); // Espera 5 segundos
                    maquinaNoJuega();
                    await Task.Delay(10000); // Espera 10 segundos
                }
                else
                {
                    maquinaNoJuega();
                    await Task.Delay(10000); // Espera 10 segundos
                }
            }
        }
        public async void curarMaquina()
        {
            if (flipMaquina.SelectedItem is iPokemon curable)
            {
                double vidaActual = curable.Vida;
                curable.Vida += 10;
                curable.animacionDescasar();
                textEsperarMaquina.Text = "La máquina ha decidido curarse.";
                textEsperarMaquina.Visibility = Visibility.Visible;
                await Task.Delay(10000); // Espera 10 segundos
                if (curable.Vida > 30 && vidaActual <= 30)
                {
                    curable.animacionNoHerido();
                    await Task.Delay(5000); // Espera 5 segundos
                }
                maquinaNoJuega();
            }
        }

        public async void subirEnergiaMaquina()
        {
            if (flipMaquina.SelectedItem is iPokemon pokemonEnergia)
            {
                double energiaActual = pokemonEnergia.Energia;
                if (pokemonEnergia.Energia > 75)
                {
                    pokemonEnergia.Energia = 100;
                }
                else
                {
                    pokemonEnergia.Energia += 10;
                }
                pokemonEnergia.animacionDefensa();
                textEsperarMaquina.Text = "La máquina ha decidido subir su energía.";
                textEsperarMaquina.Visibility = Visibility.Visible;
                await Task.Delay(10000); // Espera 10 segundos
                if (pokemonEnergia.Energia > 30 && energiaActual <= 30)
                {
                    pokemonEnergia.animacionNoCansado();
                    await Task.Delay(5000); // Espera 5 segundos
                }
                maquinaNoJuega();
            }
        }

        public int calcular_daño_fuerte()
        {
            int dañoTotal = 0;
            Random r = new Random();
            int random = r.Next(1, 100);
            if (random < 60)
            {
                dañoTotal = 20;
            }
            else if (random <= 90)
            {
                dañoTotal = (int)Math.Round((double)random / 3);
            }
            else
            {
                dañoTotal = 40;
            }
            return dañoTotal;
        }
        
        public int calcular_daño_flojo()
        {
            return 15;
        }

        private async void btnAtacar1_Click(object sender, RoutedEventArgs e)
        {
            if (flipJugador1.SelectedItem is iPokemon atacante && flipMaquina.SelectedItem is iPokemon defensor)
            {
                double vidaActual = defensor.Vida;
                double energiaActual = atacante.Energia;
                if (atacante.Energia > 60)
                {
                    atacante.animacionAtaqueFuerte();
                    defensor.Vida -= calcular_daño_fuerte();
                }
                else
                {
                    atacante.animacionAtaqueFlojo();
                    defensor.Vida -= calcular_daño_flojo();
                }

                if (atacante.Energia > 50)
                {
                    atacante.Energia -= 25;
                }
                else
                {
                    atacante.Energia -= 15;
                }
                controlesJugador1.Visibility = Visibility.Collapsed;
                textEsperar1.Text = "El jugador 1 ha decidido atacar.";
                textEsperar1.Visibility = Visibility.Visible;
                await Task.Delay(10000); // Espera 10 segundos

                if (atacante.Energia <= 30 && energiaActual > 30)
                {
                    atacante.animacionCansado();
                    await Task.Delay(5000); // Espera 5 segundos
                }

                if (defensor.Vida <= 0)
                {
                    defensor.animacionDerrota();
                    textEsperarMaquina.Text = "Pokemon debilitado.";
                    await Task.Delay(5000); // Espera 5 segundos
                    imageFinalCombate.Visibility = Visibility.Visible;
                    txtMensajeVictoria.Text = "¡Ha ganado el jugador 1!";
                    txtMensajeVictoria.Visibility = Visibility.Visible;
                    //Notificación
                    new ToastContentBuilder().AddArgument("action", "victoriaJugador2").AddArgument("ConversationId", 9813).AddText("¡El jugador 2 ha ganado el combate!").AddAppLogoOverride(new Uri("ms-appx:///Assets/victoria.jpg"), ToastGenericAppLogoCrop.Circle).Show();
                }
                else if (defensor.Vida > 0 && defensor.Vida <= 30 && vidaActual >30)
                {
                    defensor.animacionHerido();
                    await Task.Delay(5000); // Espera 5 segundos
                    maquinaSiJuega();
                    turno_maquina_random();
                    await Task.Delay(10000); // Espera 10 segundos
                }
                else
                {
                    maquinaSiJuega();
                    turno_maquina_random();
                    await Task.Delay(10000); // Espera 10 segundos
                }

                
            }
        }

        private async void btnRendirse1_Click(object sender, RoutedEventArgs e)
        {
            controlesJugador1.Visibility = Visibility.Collapsed;
            BitmapImage derrota = new BitmapImage(new Uri("ms-appx:///Assets/derrota.jpg"));
            imageFinalCombate.Source = derrota;
            iPokemon miPokemon = flipJugador1.SelectedItem as iPokemon;
            miPokemon.animacionDerrota();
            textEsperar1.Text = "El jugador 1 ha decidido rendirse.";
            textEsperar1.Visibility = Visibility.Visible;
            await Task.Delay(5000); // Espera 5 segundos
            imageFinalCombate.Visibility = Visibility.Visible;
            txtMensajeVictoria.Text = "¡Ha ganado la máquina!";
            txtMensajeVictoria.Visibility = Visibility.Visible;
            //Notificación
            new ToastContentBuilder().AddArgument("action", "victoriaJugador2").AddArgument("ConversationId", 9813).AddText("¡El jugador 2 ha ganado el combate!").AddAppLogoOverride(new Uri("ms-appx:///Assets/derrota.jpg"), ToastGenericAppLogoCrop.Circle).Show();
        }

        private async void btnCurarse1_Click(object sender, RoutedEventArgs e)
        {
            controlesJugador1.Visibility = Visibility.Collapsed;
            iPokemon pokemonSeleccionado = flipJugador1.SelectedItem as iPokemon;
            double vidaActual = pokemonSeleccionado.Vida;
            if (pokemonSeleccionado.Vida > 75)
            {
                pokemonSeleccionado.Vida = 100;
            }
            else
            {
                pokemonSeleccionado.Vida += 20;
            }

            pokemonSeleccionado.animacionDescasar();
            textEsperar1.Text = "El jugador 1 ha decidido curarse.";
            textEsperar1.Visibility = Visibility.Visible;
            await Task.Delay(5000); // Espera 5 segundos
            if (pokemonSeleccionado.Vida > 30 && vidaActual <=30)
            {
                pokemonSeleccionado.animacionNoHerido();
                await Task.Delay(5000); // Espera 5 segundos
            }
            maquinaSiJuega();
            turno_maquina_random();
            await Task.Delay(10000); // Espera 10 segundos
        }

        private async void btnEnergia1_Click(object sender, RoutedEventArgs e)
        {
            controlesJugador1.Visibility = Visibility.Collapsed;
            iPokemon pokemonEnergia = flipJugador1.SelectedItem as iPokemon;
            double energiaActual = pokemonEnergia.Energia;
            if (pokemonEnergia.Energia > 75)
            {
                pokemonEnergia.Energia = 100;
            }
            else
            {
                pokemonEnergia.Energia += 20;
            }
            pokemonEnergia.animacionDefensa();
            textEsperar1.Text = "El jugador 1 ha decidido subir su energía.";
            textEsperar1.Visibility = Visibility.Visible;
            await Task.Delay(8000); // Espera 8 segundos
            if (pokemonEnergia.Energia > 30 && energiaActual <= 30)
            {
                pokemonEnergia.animacionNoCansado();
                await Task.Delay(5000); // Espera 5 segundos
            }
            maquinaSiJuega();
            turno_maquina_random();
            await Task.Delay(10000); // Espera 10 segundos
        }
    }
}
