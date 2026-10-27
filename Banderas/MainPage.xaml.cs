namespace Banderas
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();




           this.listaPaises.ItemsSource = cargarPaises();

       }private List<Paises> cargarPaises()

        {

            return new List<Paises> {

        new Paises { nombre = "España", capital = "Madrid", bandera= "https://flagcdn.com/64x48/es.png" },

        new Paises { nombre = "Australia", capital = "Canberra", bandera = "https://flagcdn.com/64x48/au.png"},

        new Paises { nombre = "Inglaterra", capital = "Londres", bandera = "https://flagcdn.com/64x48/gb-eng.png"},

        new Paises { nombre = "Nueva Zelanda", capital = "Wellington", bandera = "https://flagcdn.com/64x48/nz.png"},

        new Paises { nombre = "Nepal", capital = "Kathmandu", bandera = "https://flagcdn.com/64x48/np.png" }

    };

        }   
        






        private void ComprobarCapital(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Paises pais = (Paises)listaPaises.SelectedItem;
            if (pais.capital == entryCapital.Text)
            {
                DisplayAlert("Correcto", "¡Has acertado!", "OK");
            }
            else
            {
                DisplayAlert("Incorrecto", "Inténtalo de nuevo.", "OK");
            }
        }
    }
}