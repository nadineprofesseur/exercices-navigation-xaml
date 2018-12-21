using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MultiPanneaux
{
	public class VueStatistiques : Panel
	{
		public VueStatistiques(Panel panneau)
		{
			for(int position = 0; position < panneau.Children.Count; position++)
			//foreach (UIElement objetGraphique in panneau.Children)
			{
				UIElement objetGraphique = panneau.Children[position];
				panneau.Children.RemoveAt(position);
				//panneau.Children.Remove(objetGraphique);
				this.Children.Add(objetGraphique);
			}

		}

		public Panel getVisuel()
		{
			return this;
		}
	}
}
