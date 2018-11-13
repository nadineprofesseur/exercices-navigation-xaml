using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MultiFenetres
{
    public class NavigateurDesVues
    {

		private Window premiereVue = null; 
		protected Window vueCourante = null;

		// DESIGN PATTERN SINGLETON - debut
		private NavigateurDesVues()
		{
			
		}
		private static NavigateurDesVues navigateur = null;
		public static NavigateurDesVues getInstance()
		{
			if (null == navigateur) navigateur = new NavigateurDesVues();
			return navigateur;
		}
		// DESIGN PATTERN SINGLETON - fin

		public void enregistrerPremiereVue(Window vue)
		{
			this.premiereVue = vue;
			this.vueCourante = this.premiereVue;
		}

		protected VueAdministration vueAdministration = null;
		public void naviguerVersAdministration()
		{
			Console.WriteLine("naviguerVersAdministration()");
			this.vueAdministration = new VueAdministration();
			this.vueAdministration.Show();
			this.vueCourante.Close();
			this.vueCourante = null; // pour detruire l'objet au lieu de le reutiliser
			this.vueCourante = this.vueAdministration;
		}

		protected VueStatistiques vueStatistiques = null;
		public void naviguerVersStatistiques()
		{
			Console.WriteLine("naviguerVersStatistiques()");
			this.vueStatistiques = new VueStatistiques();
			this.vueStatistiques.Show();
			this.vueCourante.Close();
			this.vueCourante = null; // pour detruire l'objet au lieu de le reutiliser
			this.vueCourante = this.vueStatistiques;
		}

		protected VueAide vueAide = null;
		public void naviguerVersAide()
		{
			Console.WriteLine("naviguerVersAide()");
			this.vueAide = new VueAide();
			this.vueAide.Show();
			this.vueCourante.Close();
			this.vueCourante = null; // pour detruire l'objet au lieu de le reutiliser
			this.vueCourante = this.vueAide;
		}

	}
}
