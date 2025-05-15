namespace MauiBindingTutorial;
public partial class MainPage : ContentPage
{
    public List<int> Primes { get; } = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }
}
