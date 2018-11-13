using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFenetres
{
    public class NavigateurDesVues
    {


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

		public void naviguerVersAdministration()
		{
			Console.WriteLine("naviguerVersAdministration()");

		}

		public void naviguerVersStatistiques()
		{
			Console.WriteLine("naviguerVersStatistiques()");

		}

		public void naviguerVersAide()
		{
			Console.WriteLine("naviguerVersAide()");

		}

	}
}
