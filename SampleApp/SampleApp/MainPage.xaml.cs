namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ChoseFileBtn_Clicked(object sender, EventArgs e)
        {
            var result = await FilePicker.Default.PickAsync();
        }
    }

}
