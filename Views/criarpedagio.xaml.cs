using ViagemCusto.Models;

namespace ViagemCusto.Views;

public partial class criarpedagio : ContentPage
{
	public criarpedagio()
	{
		InitializeComponent();
	}

    private async void btn_enviar_Clicked(object sender, EventArgs e)
    {
		try { 
				pedagio p = new pedagio();
				p.local = txt_local.Text;
				p.valor = Convert.ToDouble(txt_valor.Text);

				await App.Db.Insert(p);
				await DisplayAlert("Sucesso!", "Pedagio foi adicionado", "Ok");
		} catch (Exception ex) {
				await DisplayAlert("Erro", ex.Message, "Ok");
		}
    }
}