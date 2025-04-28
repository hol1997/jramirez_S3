using jramirez_S3.Views;

namespace jramirez_S3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
           
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new Views.Ingresar_contacto());
        }
    }
}