using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MultiPanneaux
{
	public class VueStatistiques
	{
		protected Panel panneau;
		public VueStatistiques(Panel panneau)
		{
			this.panneau = panneau;
		}

		public Panel getVisuel()
		{
			return this.panneau;
		}
	}
}
