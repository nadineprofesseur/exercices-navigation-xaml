using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFenetres
{
    public class NavigateurDesVues
    {

		//private Window premiereVue = null; 

		// DESIGN PATTERN SINGLETON - debut
		private NavigateurDesVues()
		{
			;

		}
		private static NavigateurDesVues navigateur = null;
		public static NavigateurDesVues getInstance()
		{
			if (null == navigateur) navigateur = new NavigateurDesVues();
			return navigateur;
		}
		// DESIGN PATTERN SINGLETON - fin

		protected VueAdministration vueAdministration = null;
		public void naviguerVersAdministration()
		{
			Console.WriteLine("naviguerVersAdministration()");
			this.vueAdministration = new VueAdministration();
			this.vueAdministration.Show();
		}

		protected VueStatistiques vueStatistiques = null;
		public void naviguerVersStatistiques()
		{
			Console.WriteLine("naviguerVersStatistiques()");
			this.vueStatistiques = new VueStatistiques();
			this.vueStatistiques.Show();
		}

		protected VueAide vueAide = null;
		public void naviguerVersAide()
		{
			Console.WriteLine("naviguerVersAide()");
			this.vueAide = new VueAide();
			this.vueAide.Show();
		}

	}
}
