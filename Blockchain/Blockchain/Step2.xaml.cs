using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Blockchain
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Step2 : ContentPage
	{
		public Step2 ()
		{
			InitializeComponent ();
            dPicker.MaximumDate = DateTime.Today;
            tPicker.Time = DateTime.Now.TimeOfDay;
		}
	}
}