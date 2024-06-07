using BankApp.Components.Pages;

namespace BankApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            Routing.RegisterRoute("Couter", typeof(Counter));
        }
    }
}
