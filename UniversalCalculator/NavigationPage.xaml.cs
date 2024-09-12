using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class NavigationPage : Page
	{
		public NavigationPage()
		{
			this.InitializeComponent();
		}

		private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
		{

		}
		// When clicking Maths Caclculator button, navigate to the math calculator page - RH
		private void btnMathsCalculator_Click(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(MainPage));
		}
		// When clicking Mortgage Caclculator button, navigate to the Mortgage calculator page - RH
		private void btnMortgageCalculator_Click(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(MortgageCalculator));
		}
		// When clicking Currency Caclculator button, navigate to the Currency calculator page - RH
		private void btnCurrencyConverter_Click(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(CurrencyConverter));
		}
		// When clicking Exit button, Close then App. - RH
		private void btnAppExit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Exit();
		}
	}
}
