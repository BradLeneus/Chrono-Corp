using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChronoCorp.Interface
{
    public interface IMainViewModel
    {
        ICommand SaveCommand { get; }
    }
}
