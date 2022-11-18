using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace triquiapp
{
    public partial class MainPage : ContentPage
    {
        Int64 idtablero;
        int jugador;
        Models.Tablero tablero;
        public MainPage()
        {
            InitializeComponent();
        }
        public Boolean valido(Button btn)
        {
            int suma = tablero.camp1 + tablero.camp2 + tablero.camp3 + tablero.camp4 + tablero.camp5 + tablero.camp5 + tablero.camp7 + tablero.camp8 + tablero.camp9;
            if ((btn.Text == ""))
            {
                if (jugador==1 && suma % 2 ==0)
                    return true;
                if (jugador == 2 && suma % 2 == 1)
                    return true;

            }
            return false;
        }
        public async void EnviarJugada(int a)
        {
            int suma = tablero.camp1 + tablero.camp2 + tablero.camp3 + tablero.camp4 + tablero.camp5 + tablero.camp5 + tablero.camp7 + tablero.camp8 + tablero.camp9;
            int valor = 1 + 2 * (suma % 2);
            switch (a)
            {
                case 1: tablero.camp1 = valor;break;
                case 2: tablero.camp2 = valor;break;
                case 3: tablero.camp3 = valor;break;
                case 4: tablero.camp4 = valor;break;
                case 5: tablero.camp5 = valor;break;
                case 6: tablero.camp6 = valor;break;
                case 7: tablero.camp7 = valor;break;
                case 8: tablero.camp8 = valor;break;
                case 9: tablero.camp9 = valor;break;
            }
            WSClient client = new WSClient();
            var json = JsonConvert.SerializeObject(this.tablero); 
            await client.Get<Models.Tablero>("https://computador/api/servicio", json);
            MostrarTablero();
        }
        public void MostrarTablero()
        {
            switch (tablero.camp1)
            {
                case 0: this.camp1.Text = "";break;
                case 1: this.camp1.Text = "X";break;
                case 3: this.camp1.Text = "O";break;
            }
            switch (tablero.camp2)
            {
                case 0: this.camp2.Text = ""; break;
                case 1: this.camp2.Text = "X"; break;
                case 3: this.camp2.Text = "O"; break;
            }
            switch (tablero.camp3)
            {
                case 0: this.camp3.Text = ""; break;
                case 1: this.camp3.Text = "X"; break;
                case 3: this.camp3.Text = "O"; break;
            }
            switch (tablero.camp4)
            {
                case 0: this.camp4.Text = ""; break;
                case 1: this.camp4.Text = "X"; break;
                case 3: this.camp4.Text = "O"; break;
            }
            switch (tablero.camp5)
            {
                case 0: this.camp5.Text = ""; break;
                case 1: this.camp5.Text = "X"; break;
                case 3: this.camp5.Text = "O"; break;
            }
            switch (tablero.camp6)
            {
                case 0: this.camp6.Text = ""; break;
                case 1: this.camp6.Text = "X"; break;
                case 3: this.camp6.Text = "O"; break;
            }
            switch (tablero.camp7)
            {
                case 0: this.camp7.Text = ""; break;
                case 1: this.camp7.Text = "X"; break;
                case 3: this.camp7.Text = "O"; break;
            }
            switch (tablero.camp8)
            {
                case 0: this.camp8.Text = ""; break;
                case 1: this.camp8.Text = "X"; break;
                case 3: this.camp8.Text = "O"; break;
            }
            switch (tablero.camp9)
            {
                case 0: this.camp9.Text = ""; break;
                case 1: this.camp9.Text = "X"; break;
                case 3: this.camp9.Text = "O"; break;
            }
        }

        private async void camp1_Clicked(object sender, EventArgs e)
        {
            if (valido((Button)sender))
            {
                EnviarJugada(1);
            }
        }

        private void camp2_Clicked(object sender, EventArgs e)
        {

        }

        private void camp3_Clicked(object sender, EventArgs e)
        {

        }

        private void camp4_Clicked(object sender, EventArgs e)
        {

        }

        private void camp5_Clicked(object sender, EventArgs e)
        {

        }

        private void camp6_Clicked(object sender, EventArgs e)
        {

        }

        private void camp7_Clicked(object sender, EventArgs e)
        {

        }

        private void camp8_Clicked(object sender, EventArgs e)
        {

        }

        private void camp9_Clicked(object sender, EventArgs e)
        {

        }
    }
}
