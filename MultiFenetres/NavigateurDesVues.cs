using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFenetres
{
    class NavigateurDesVues
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
	}
}
