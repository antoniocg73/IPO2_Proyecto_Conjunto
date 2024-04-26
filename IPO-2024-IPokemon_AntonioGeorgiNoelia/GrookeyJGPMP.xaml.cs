﻿using Pokemon_Antonio_Campallo_Gomez;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace Pokemon_Antonio_Campallo_Gomez
{
    public sealed partial class GrookeyJGPMP : UserControl, iPokemon
    {
        DispatcherTimer dtTime;
        MediaPlayer mpSonidos = new MediaPlayer();
        String NCategoria = "Chimpance";
        String NTipo = "Planta";
        Double NAltura = 0.3;
        Double NPeso = 5.0;
        String NEvolucion = "Thwackey";
        String NDescripcion = "Grookey (サルノリ Sarunori en japonés) es un Pokémon de tipo planta introducido en la octava generación. Es uno de los tres Pokémon iniciales que pueden elegir los entrenadores que empiezan su aventura en la región de Galar, junto a Scorbunny y Sobble.";


        public double Vida { get { return this.pbVida.Value; } set { this.pbVida.Value = value; } }
        public double Energia { get { return this.pbEscudo.Value; } set { this.pbEscudo.Value = value; } }
        public string Nombre { get { return this.txtNombre.Text; } set { this.txtNombre.Text = value; } }
        public string Categoría { get { return this.NCategoria; } set { this.NCategoria = value; } }
        public string Tipo { get { return this.NTipo; } set { this.NTipo = value; } }
        public double Altura { get { return NAltura; } set { this.NAltura = value; } }
        public double Peso { get { return this.NPeso; } set { this.NPeso = value; } }
        public string Evolucion { get { return this.NEvolucion; } set { this.NEvolucion = value; } }
        public string Descripcion { get { return this.NDescripcion; } set { this.NDescripcion = value; } }

        public GrookeyJGPMP()
        {
            this.InitializeComponent();
            this.IsTabStop = true;

            // Suscribir al evento de teclado
           //this.KeyDown += ControlTeclas;
        }

        private void imgPocionVida_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            dtTime = new DispatcherTimer();
            dtTime.Interval = TimeSpan.FromMilliseconds(100);
            dtTime.Tick += increaseHealth;
            dtTime.Start();
            this.imgPocionVida.Opacity = 0.5;
        }
        private void increaseHealth(object sender, object e)
        {
            this.pbVida.Value += 0.2;
            if (pbVida.Value >= 100)
            {
                this.dtTime.Stop();
                this.imgPocionVida.Opacity = 1;
            }
        }

       /* 
        private void ControlTeclas(object sender, KeyRoutedEventArgs e)
        {
            Storyboard sbaux;
            switch (e.Key)
            {
                //ATAQUE DÉBIL
                case Windows.System.VirtualKey.Number1:
                    sbaux = (Storyboard)this.Resources["ataqueDebil"];
                    sbaux.Begin();
                    mpSonidos.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/AtaqueDebil.mp3"));
                    mpSonidos.Play();
                    break;

                //ATAQUE FUERTE
                case Windows.System.VirtualKey.Number2:
                    sbaux = (Storyboard)this.Resources["ataqueFuerte"];
                    sbaux.Begin();
                    mpSonidos.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/AtaqueFuerte.mp3"));
                    mpSonidos.Play();
                    break;

                //ACCIÓN DEFENSIVA (ESCUDO)
                case Windows.System.VirtualKey.Number3:
                    sbaux = (Storyboard)this.Resources["Defensa"];
                    sbaux.Begin();
                    mpSonidos.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/Escudo.mp4"));
                    mpSonidos.Play();
                    break;


                //ATAQUE DE DESCANSO (RECUPERAR ENERGÍA Y VIDA)
                case Windows.System.VirtualKey.Number4:
                    sbaux = (Storyboard)this.Resources["animacionDescanso"];
                    sbaux.Begin();
                    mpSonidos.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/Descanso.mp3"));
                    mpSonidos.Play();
                    break;

                case Windows.System.VirtualKey.Number5:
                    sbaux = (Storyboard)this.Resources["animacionNoDescanso"];
                    sbaux.Begin();
                    mpSonidos.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/Descanso.mp3"));
                    mpSonidos.Play();
                    break;

                //ESTADO HERIDO Y AL CONTRARIO
                case Windows.System.VirtualKey.Number6:
                    sbaux = (Storyboard)this.Resources["sbNormal_Herido"];
                    sbaux.Begin();
                    break;

                case Windows.System.VirtualKey.Number7:
                    sbaux = (Storyboard)this.Resources["sbHerido_Normal"];
                    sbaux.Begin();
                    break;

                //ESTADO CANSADO Y AL CONTRARIO
                case Windows.System.VirtualKey.Number8:
                    sbaux = (Storyboard)this.Resources["estadoCansado"];
                    sbaux.Begin();
                    break;

                case Windows.System.VirtualKey.Number9:
                    sbaux = (Storyboard)this.Resources["estadoNoCansado"];
                    sbaux.Begin();
                    break;

                //ESTADO DERROTADO Y AL CONTRARIO
                case Windows.System.VirtualKey.Q:
                    sbaux = (Storyboard)this.Resources["estadoDerrotado"];
                    sbaux.Begin();
                    mpSonidos.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/Derrotado.mp3"));
                    mpSonidos.Play();
                    break;

                case Windows.System.VirtualKey.A:
                    sbaux = (Storyboard)this.Resources["estadoNoDerrotado"];
                    sbaux.Begin();
                    mpSonidos.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/Derrotado.mp3"));
                    mpSonidos.Play();
                    break;

                //ESTADO CON ESCUDO Y AL CONTRARIO
                case Windows.System.VirtualKey.W:
                    sbaux = (Storyboard)this.Resources["estadoEscudo"];
                    sbaux.Begin();
                    break;

                case Windows.System.VirtualKey.S:
                    sbaux = (Storyboard)this.Resources["estadoNoEscudo"];
                    sbaux.Begin();
                    break;
            }
        }
       */
        
        
        public void verFondo(bool ver)
        {
            throw new NotImplementedException();
        }

        public void verFilaVida(bool ver)
        {
            if (!ver) { this.pbVida.Opacity = 0; }
            else
            {
                this.pbVida.Opacity = 100;
            }
        }

        public void verFilaEnergia(bool ver)
        {
            if (!ver) { this.pbEscudo.Opacity = 0; }
            else
            {
                this.pbEscudo.Opacity = 100;
            }
        }

        public void verPocionVida(bool ver)
        {
            if (!ver) { this.imgPocionVida.Opacity = 0; }
            else
            {
                this.imgPocionVida.Opacity = 100;
            }
        }

        public void verPocionEnergia(bool ver)
        {
            if (!ver) { this.imgPocionEnergia.Opacity = 0; }
            else
            {
                this.imgPocionEnergia.Opacity = 100;
            }
        }

        public void verNombre(bool ver)
        {
            if (!ver) { this.txtNombre.Opacity = 0; }
            else
            {
                this.txtNombre.Opacity = 100;
            }
        }

        public void activarAniIdle(bool activar)
        {
            throw new NotImplementedException();
        }

        Storyboard sbaux; //Para usar los storyBoard

        public void animacionAtaqueFlojo()
        {
            sbaux = (Storyboard)this.Resources["ataqueDebil"];
            sbaux.Begin();
            mpSonidos.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///AssetsGrookeyJGPMP/AtaqueDebil.mp3"));
            mpSonidos.Play();
        }

        public void animacionAtaqueFuerte()
        {
            sbaux = (Storyboard)this.Resources["ataqueFuerte"];
            sbaux.Begin();
            mpSonidos.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///AssetsGrookeyJGPMP/AtaqueFuerte.mp3"));
            mpSonidos.Play();
        }

        public void animacionDefensa()
        {
            sbaux = (Storyboard)this.Resources["Defensa"];
            sbaux.Begin();
            mpSonidos.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///AssetsGrookeyJGPMP/Escudo.mp4"));
            mpSonidos.Play();
        }

        public void animacionDescasar()
        {
            sbaux = (Storyboard)this.Resources["animacionDescanso"];
            sbaux.Begin();
            mpSonidos.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///AssetsGrookeyJGPMP/Descanso.mp3"));
            mpSonidos.Play();

            //Animacion para volver al estado normal
           /* sbaux = (Storyboard)this.Resources["animacionNoDescanso"];
            sbaux.Begin();
            mpSonidos.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/Descanso.mp3"));
            mpSonidos.Play();*/
        }

        public void animacionCansado()
        {
           
            sbaux = (Storyboard)this.Resources["estadoCansado"];
            sbaux.Begin();
         
        }

        public void animacionNoCansado()
        {
            sbaux = (Storyboard)this.Resources["estadoNoCansado"];
            sbaux.Begin();
        }

        public void animacionHerido()
        {
         
            sbaux = (Storyboard)this.Resources["sbNormal_Herido"];
            sbaux.Begin();

        }

        public void animacionNoHerido()
        {
            sbaux = (Storyboard)this.Resources["sbHerido_Normal"];
            sbaux.Begin();
        }

        public void animacionDerrota()
        {
             
            sbaux = (Storyboard)this.Resources["estadoDerrotado"];
            sbaux.Begin();
            mpSonidos.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///AssetsGrookeyJGPMP/Derrotado.mp3"));
            mpSonidos.Play();
              
            //Animacion para volver al estado normal
            /*sbaux = (Storyboard)this.Resources["estadoNoDerrotado"];
            sbaux.Begin();
            mpSonidos.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/Derrotado.mp3"));
            mpSonidos.Play();*/
            
        }
        
    }
}
