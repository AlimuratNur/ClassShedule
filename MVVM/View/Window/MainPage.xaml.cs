using ClassShedule.MVVM.ViewModels;

namespace ClassShedule.MVVM.View.Window
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }


    }
}
