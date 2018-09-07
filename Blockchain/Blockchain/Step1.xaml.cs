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
	public partial class Step1 : ContentPage
	{
		public Step1 ()
		{
			InitializeComponent ();
		}

        public void Capitalize(object sender, EventArgs e)
        {
            Entry ent = (Entry)sender;
            char[] typedText = ent.Text.ToCharArray();
            string result = "";
            for (int i = 0; i < typedText.Length; i++)
            {
                if (i == 0)
                {
                    result += typedText[i].ToString().ToUpper();
                }
                else if (typedText[i - 1] == ' ')
                {
                    result += typedText[i].ToString().ToUpper();
                }
                else
                {
                    result += typedText[i];
                }
            }
            ent.Text = result;
        }
    }
}