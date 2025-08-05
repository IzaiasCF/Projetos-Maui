namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = Views.ListaProduto();
        }


    }
}