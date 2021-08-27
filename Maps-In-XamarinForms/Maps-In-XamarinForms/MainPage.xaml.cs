using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace Maps_In_XamarinForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Pin pinShoopping = new Pin()
            {
                Type = PinType.Place,
                Label = "Shopping",
                Address = "Av. Historiador Rubens de Mendonça - Jardim Aclimacao, Cuiabá - MT, 78050-970",
                Position = new Position(-15.575414855108773, -56.07242016714789),
                Tag = "id_shopping",
            };

            map.Pins.Add(pinShoopping);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(pinShoopping.Position, Distance.FromMeters(1000)));

        }

    }
}
