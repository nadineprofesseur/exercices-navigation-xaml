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
    }
}
