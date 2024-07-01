using Cards.Services;


namespace Cards
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        private readonly Cards.Services.Servicio _servicio;



        public MainPage(Servicio servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            loading.IsVisible = true;


            var data = await _servicio.GetCartas();

            Cartas.ItemsSource = data;


            loading.IsVisible = false;


        }
    }

}
