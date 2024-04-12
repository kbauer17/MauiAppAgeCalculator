using System.Reflection;

namespace MauiAppAgeCalculator.Views
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                ?.InformationalVersion;
            VersionLabel.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
        }

        private void CurrentAgeEntered(object sender, EventArgs e)
        {
            int currentAge = Convert.ToInt32(current_age.Text);
            int yearsToWait = 21 - currentAge;
            TwentyOne.Text = $"You must wait {yearsToWait} years";
        }
    }
}