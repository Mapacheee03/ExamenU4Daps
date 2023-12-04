using ExamenU4Daps.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenU4Daps.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalcularEstres : ContentView
    {
        public CalcularEstres()
        {
            InitializeComponent();
            BindingContext = new VMmenuprincipal(Navigation);
        }
    }
}