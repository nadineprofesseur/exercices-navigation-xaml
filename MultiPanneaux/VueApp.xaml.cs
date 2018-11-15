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

		protected VueStatistiques vueStatistiques = null;
		protected VueAdministration vueAdministration = null;
		protected VueAide vueAide = null;

		public VueApp()
		{
			InitializeComponent();

			this.vueStatistiques = new VueStatistiques(this.panneauStatistique);
			this.vueAide = new VueAide(this.panneauAide);
			this.vueAdministration = new VueAdministration(this.panneauAdministration);

			this.panneauPage.Children.Clear();
			this.panneauPage.Children.Add(this.vueStatistiques.getVisuel());
		}

		private void actionNaviguerStatistiques_Click(object sender, RoutedEventArgs e)
		{
			this.panneauPage.Children.Clear();
			this.panneauPage.Children.Add(this.vueStatistiques.getVisuel());
		}

		private void actionNaviguerAdministration_Click(object sender, RoutedEventArgs e)
		{
			this.panneauPage.Children.Clear();
			this.panneauPage.Children.Add(this.vueAdministration.getVisuel());
		}

		private void actionNaviguerAide_Click(object sender, RoutedEventArgs e)
		{
			this.panneauPage.Children.Clear();
			this.panneauPage.Children.Add(this.vueAide.getVisuel());
		}
	}
}
