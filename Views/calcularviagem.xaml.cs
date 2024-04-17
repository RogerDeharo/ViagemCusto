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

	}

    private void btn_sum_Clicked(object sender, EventArgs e)
    {

    }

    private void btn_newviagem_Clicked(object sender, EventArgs e)
    {

    }
}