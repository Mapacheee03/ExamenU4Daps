using ExamenU4Daps.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ExamenU4Daps.ViewModel
{
    public class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES
        double _FrecCardiaca;
        double _HoraSueño;
        double _NivEstres;
        #endregion
        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            
        }
        #endregion
        #region OBJETOS
        public double FrecCardiaca
        {
            get { return _FrecCardiaca; }
            set { SetValue(ref _FrecCardiaca, value); }
        }
        public double HoraSueño
        {
            get { return _HoraSueño; }
            set { SetValue(ref _HoraSueño, value); }
        }
        public double NivEstres
        {
            get { return _NivEstres; }
            set { SetValue(ref _NivEstres, value); }
        }
        #endregion
        #region PROCESOS
        public async void CalcularNvlEstres()
        {
            NivEstres = (_FrecCardiaca / 100) + (0.2 * (8 - _HoraSueño));
        }
        public async void btnCalcular()
        {
            CalcularNvlEstres();
        }
        #endregion
        #region COMANDOS
        public ICommand CalcularCommand => new Command(btnCalcular);
        
        #endregion
    }
}
