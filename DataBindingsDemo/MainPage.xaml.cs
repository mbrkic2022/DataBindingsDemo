namespace DataBindingsDemo
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            SliderValueLbl.Text = DemoSld.Value.ToString("F2");
            Person person = new Person() { Age = "25", Name = "Anna" };
            ObjectLbl.BindingContext = person;
            ObjectLbl.SetBinding(Label.TextProperty, "Name");
        }



        private void GreetMeBtn_Clicked(object sender, EventArgs e)
        {
            string greeting = "Hello, " + NameEntry.Text;
            GreetingLbl.Text = greeting;
            NameEntry.Text = "";
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            SliderValueLbl.Text = e.NewValue.ToString("F2");
        }

        private async void NavigateBtn_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Navigation", "You will be redirected to another page", "Ok");
            await Shell.Current.GoToAsync("//GridDemoPage");
        }
    }

}
