namespace jramirez_S3.Views;

public partial class Ver_Contacto : ContentPage
{
    private Contacto _contacto;

    public string TipoIdentificacion => _contacto.TipoIdentificacion;
    public string NumeroIdentificacion => _contacto.NumeroIdentificacion;
    public string Nombres => _contacto.Nombres;
    public string Apellidos => _contacto.Apellidos;
    public DateTime FechaNacimiento => _contacto.FechaNacimiento;
    public string Correo => _contacto.Correo;
    public double Salario => _contacto.Salario;
    public double AporteIESS => _contacto.CalcularAporteIESS();
    public Ver_Contacto(Contacto contacto)
	{
		InitializeComponent();
        _contacto = contacto;
        BindingContext = this;
    }

    private async  void Button_Clicked(object sender, EventArgs e)
    {
        string contenido = $"Identificación: {_contacto.TipoIdentificacion}\n" +
                          $"Número: {_contacto.NumeroIdentificacion}\n" +
                          $"Nombres: {_contacto.Nombres}\n" +
                          $"Apellidos: {_contacto.Apellidos}\n" +
                          $"Fecha de Nacimiento: {_contacto.FechaNacimiento:dd/MM/yyyy}\n" +
                          $"Correo: {_contacto.Correo}\n" +
                          $"Salario: ${_contacto.Salario:F2}\n" +
                          $"Aporte IESS: ${_contacto.CalcularAporteIESS():F2}";

        string fileName = Path.Combine(FileSystem.AppDataDirectory, "Contacto.txt");
        File.WriteAllText(fileName, contenido);

        await DisplayAlert("Exportado", $"Archivo guardado en:\n{fileName}", "OK");
    }
}