using System;
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
		public enum ACTION_NAVIGUER { STATISTIQUES, ADMINISTRATION, AIDE };

		public void notifierActionNaviguer(ACTION_NAVIGUER action)
		{
			switch (action)
			{
				case ACTION_NAVIGUER.STATISTIQUES:
					//NavigateurDesVues.getInstance().naviguerVersStatistiques();
				break;
				case ACTION_NAVIGUER.ADMINISTRATION:
					NavigateurDesVues.getInstance().naviguerVersAdministration();
				break;
				case ACTION_NAVIGUER.AIDE:
					NavigateurDesVues.getInstance().naviguerVersAide();
				break;
			}
		}

    }
}
