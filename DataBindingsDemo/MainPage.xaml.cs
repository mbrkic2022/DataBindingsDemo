namespace DataBindingsDemo
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            SliderValueLbl.Text = DemoSld.Value.ToString("F2");
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
    }

}
