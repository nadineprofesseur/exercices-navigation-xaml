using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFenetres
{
    public class ControleurAdministration
    {
		protected VueAdministration vue = null;

		public ControleurAdministration(VueAdministration vue)
		{
			this.vue = vue;			
		}
    }
}
