namespace jramirez_S3.Views;

public partial class Ingresar_contacto : ContentPage
{
	public Ingresar_contacto()
	{
		InitializeComponent();
   
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(nombresEntry.Text) ||
            string.IsNullOrWhiteSpace(apellidosEntry.Text) ||
            identificacionPicker.SelectedIndex == -1 ||
            string.IsNullOrWhiteSpace(numeroEntry.Text) ||
            string.IsNullOrWhiteSpace(correoEntry.Text) ||
            string.IsNullOrWhiteSpace(salarioEntry.Text))
        {
            await DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
            return;
        }

        var contacto = new Contacto
        {
            TipoIdentificacion = identificacionPicker.SelectedItem.ToString(),
            NumeroIdentificacion = numeroEntry.Text,
            Nombres = nombresEntry.Text,
            Apellidos = apellidosEntry.Text,
            FechaNacimiento = fechaDatePicker.Date,
            Correo = correoEntry.Text,
            Salario = double.Parse(salarioEntry.Text)
        };

        await Navigation.PushAsync(new Ver_Contacto(contacto));
    }
}