namespace Ejercicio_4_Cuadrado_y_Cubo;

///<Summary>
///<Createddate> 2022/06/16 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2022/06/16 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el diseño y se configuró el código cs de la app
///</lastmodificationdescription>
///<lastmodifierautor> Carlos Mito </lastmodifierautor>
///</Summary>

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(Numero1.Text))
		{
			double numero, cuadrado, cubo;
			numero = Convert.ToDouble(Numero1.Text);
			cuadrado = numero * numero;
			cubo = numero * numero * numero;
			CuadradoFinal.Text = Convert.ToString(cuadrado);
			CuboFinal.Text = Convert.ToString(cubo);
        }
        else
        {
            DisplayAlert("Error", "Introduce el número ", "Ok");
        }
    }
}

