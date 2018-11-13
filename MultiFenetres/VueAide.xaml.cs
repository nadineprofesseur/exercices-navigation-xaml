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
using System.Windows.Shapes;

namespace MultiFenetres
{
    /// <summary>
    /// Logique d'interaction pour VueAide.xaml
    /// </summary>
    public partial class VueAide : Window
    {

		protected ControleurAide controleur;
        public VueAide()
        {
            InitializeComponent();
			this.controleur = new ControleurAide(this);
        }

		private void actionNaviguerStatistiques_Click(object sender, RoutedEventArgs e)
		{
			this.controleur.notifierActionNaviguer(NavigateurDesVues.ACTION_NAVIGUER.STATISTIQUES);
		}

		private void actionNaviguerAdministration_Click(object sender, RoutedEventArgs e)
		{
			this.controleur.notifierActionNaviguer(NavigateurDesVues.ACTION_NAVIGUER.ADMINISTRATION);
		}

		private void actionNaviguerAide_Click(object sender, RoutedEventArgs e)
		{
			this.controleur.notifierActionNaviguer(NavigateurDesVues.ACTION_NAVIGUER.AIDE);
		}
	}
}
