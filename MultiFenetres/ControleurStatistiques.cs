﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFenetres
{
    public class ControleurStatistiques
    {
		protected VueStatistiques vue = null;

		public ControleurStatistiques(VueStatistiques vue)
		{
			this.vue = vue;
		}

		public void notifierActionNaviguer(NavigateurDesVues.ACTION_NAVIGUER action)
		{
			switch (action)
			{
				case NavigateurDesVues.ACTION_NAVIGUER.STATISTIQUES:
					//NavigateurDesVues.getInstance().naviguerVersStatistiques();
				break;
				case NavigateurDesVues.ACTION_NAVIGUER.ADMINISTRATION:
					NavigateurDesVues.getInstance().naviguerVersAdministration();
				break;
				case NavigateurDesVues.ACTION_NAVIGUER.AIDE:
					NavigateurDesVues.getInstance().naviguerVersAide();
				break;
			}
		}

    }
}
