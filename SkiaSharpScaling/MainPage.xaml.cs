namespace SkiaSharpScaling
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void CaptureAsync(object sender, EventArgs e)
        {
            var snap = await CaptureTarget.CaptureAsync();
            if (snap != null)
            {
                var s = await snap.OpenReadAsync();
                CaptureImageView.Source = ImageSource.FromStream(() => s);
            }
        }
    }

}
