using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soccer.ViewModels;

namespace Soccer.ViewModels
{
    public class MainViewModel
    {
        #region Properties

        public LoginViewModel Login { get; set; }
        #endregion

        #region Constructor

        public MainViewModel()
        {
            Login = new LoginViewModel();
        }
        #endregion
    }
}
