using System.Collections.ObjectModel;
using ViagemCusto.Models;

namespace ViagemCusto.Views;

public partial class listarpedagio : ContentPage
{
	ObservableCollection<pedagio> lista_pedagios = new ObservableCollection<pedagio>();
	public listarpedagio()
	{
		InitializeComponent();
		lst_pedagios.ItemsSource = lista_pedagios;
	}

	protected async override void OnAppearing()
	{
		if(lista_pedagios.Count == 0)
		{
			List<pedagio> tmp = await App.Db.GetAll();
			foreach (pedagio p in tmp)
			{
				lista_pedagios.Add(p);
			}
		}
	}
}