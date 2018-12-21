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
		public enum ACTION_NAVIGUER { STATISTIQUES, ADMINISTRATION, AIDE };

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
			if(this.vueAdministration == null) this.vueAdministration = new VueAdministration();
			this.vueAdministration.Show();
			this.vueCourante.Hide();
			//this.vueCourante = null; // pour detruire l'objet au lieu de le reutiliser
			this.vueCourante = this.vueAdministration;

			List<string> listeDesMeilleurs = new List<string>();
			listeDesMeilleurs.Add("Yohann");
			listeDesMeilleurs.Add("Nadine");
			this.vueAdministration.afficherListeSpecialistes(listeDesMeilleurs);
		}

		protected VueStatistiques vueStatistiques = null;
		public void naviguerVersStatistiques()
		{
			Console.WriteLine("naviguerVersStatistiques()");
			if(this.vueStatistiques == null) this.vueStatistiques = new VueStatistiques();
			this.vueStatistiques.Show();
			this.vueCourante.Hide();
			//this.vueCourante = null; // pour detruire l'objet au lieu de le reutiliser
			this.vueCourante = this.vueStatistiques;
		}

		protected VueAide vueAide = null;
		public void naviguerVersAide()
		{
			Console.WriteLine("naviguerVersAide()");
			if(this.vueAide == null) this.vueAide = new VueAide();
			this.vueAide.Show();
			this.vueCourante.Hide();
			//this.vueCourante = null; // pour detruire l'objet au lieu de le reutiliser
			this.vueCourante = this.vueAide;
			this.vueAide.afficherMessage("Lisez le manuel");
		}

	}
}
