using BMI.MVVM.ViewModels;

namespace BMI.MVVM.Views;

public partial class BmiView : ContentPage
{
	public BmiView()
	{
		InitializeComponent();
        BindingContext = new BmiViewModel();
    }
}