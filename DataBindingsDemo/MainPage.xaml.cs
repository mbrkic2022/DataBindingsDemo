namespace DataBindingsDemo
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }



        private void GreetMeBtn_Clicked(object sender, EventArgs e)
        {
            string greeting = "Hello, " + NameEntry.Text;
            GreetingLbl.Text = greeting;
        }
    }

}
