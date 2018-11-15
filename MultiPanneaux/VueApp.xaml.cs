using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MultiPanneaux
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class VueApp : Window
	{

		protected Panel vueStatistiques;
		protected Panel vueAdministration;
		protected Panel vueAide;

		public VueApp()
		{
			InitializeComponent();
			this.vueStatistiques = this.panneauStatistique;
			this.vueAdministration = this.panneauAdministration;
			this.vueAide = this.panneauAide;
			this.panneauPage.Children.Clear();
			this.panneauPage.Children.Add(this.vueStatistiques);
		}

		private void actionNaviguerStatistiques_Click(object sender, RoutedEventArgs e)
		{
			this.panneauPage.Children.Clear();
			this.panneauPage.Children.Add(this.vueStatistiques);
		}

		private void actionNaviguerAdministration_Click(object sender, RoutedEventArgs e)
		{
			this.panneauPage.Children.Clear();
			this.panneauPage.Children.Add(this.vueAdministration);
		}

		private void actionNaviguerAide_Click(object sender, RoutedEventArgs e)
		{
			this.panneauPage.Children.Clear();
			this.panneauPage.Children.Add(this.vueAide);
		}
	}
}
