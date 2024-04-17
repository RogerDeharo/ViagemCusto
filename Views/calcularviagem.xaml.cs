using ViagemCusto.Models;

namespace ViagemCusto.Views;

public partial class calcularviagem : ContentPage
{
    double total = 0;
    double valor_pedagio = 0;
	public calcularviagem()
	{
		InitializeComponent();

        lbl_local.Text = "Origem:" + MainPage.vg.origem;
        lbl_destino.Text = "Destino:" + MainPage.vg.destino;
        lbl_valor.IsVisible = false;

	}

    private async void btn_sum_Clicked(object sender, EventArgs e)
    {
        double consumo_carro = ((MainPage.vg.distancia / MainPage.vg.rendimento) * MainPage.vg.valor_gas);

        List<pedagio> pedagios = await App.Db.GetAll();
        foreach(pedagio p in pedagios)
        {
            valor_pedagio += p.valor;
        }

        total = consumo_carro + valor_pedagio;
        await DisplayAlert("Soma total:", $"Pedagio: {valor_pedagio.ToString("C")}\nConsumo: {consumo_carro.ToString("C")}\n---------\nTotal: {total.ToString("C")}", "Ok");
    }

    private void btn_newviagem_Clicked(object sender, EventArgs e)
    {
        viagem empty_viagem = new viagem {
            valor_gas = 1.0,
            rendimento = 1.0,
            destino = "",
            distancia = 1.0,
            origem = "",
        };
        MainPage.vg = empty_viagem;
        Navigation.PushAsync(new MainPage());       
    }
}