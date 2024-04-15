using ViagemCusto.Models;

namespace ViagemCusto
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_createpedagio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.criarpedagio());
        }

        private void btn_listpedagio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.listarpedagio());
        }

        private async void btn_calcular_Clicked(object sender, EventArgs e)
        {
            if(txt_origem.Text == null)
            {
                await DisplayAlert("Erro", "Preencha o lugar de origem", "Ok");
                return;
            }
            if(txt_destino.Text == null)
            {
                await DisplayAlert("Erro", "Preencha o destino", "Ok");
                return;
            }
            if (txt_distancia.Text == null)
            {
                await DisplayAlert("Erro", "Preencha o valor da distancia", "Ok");
                return;
            }
            if (txt_rendimento.Text == null)
            {
                await DisplayAlert("Erro", "Preencha o valor do rendimento", "Ok");
                return;
            }
            if (txt_combustivel.Text == null)
            {
                await DisplayAlert("Erro", "Preencha o valor do combustivel", "Ok");
                return;
            }

            
            Navigation.PushAsync(new Views.calcularviagem());
        }
    }

}
