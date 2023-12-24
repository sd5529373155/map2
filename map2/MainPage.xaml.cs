using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;


namespace map2;

    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var geolcoationRequest = new GeolocationRequest(GeolocationAccuracy.High, TimeSpan.FromSeconds(10));
        var location = await Geolocation.GetLocationAsync(geolcoationRequest);
        map.MoveToRegion(MapSpan.FromCenterAndRadius(location, Distance.FromKilometers(10)));

        var pin = new Pin
        {
            Address = "Address",
            Location = location,
            Type = PinType.Place,
            Label = "Home"
        };
        map.Pins.Add(pin);
    }
    private async void Pin_MarkerClicked(object sender, EventArgs e)
    {
        var pinInfo = (Pin)sender;
        await DisplayAlert("HI", pinInfo.Address, "OK");
    }
}


