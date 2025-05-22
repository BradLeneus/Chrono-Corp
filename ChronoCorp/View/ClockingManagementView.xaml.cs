using System.Windows.Controls;
using ChronoCorp.Data;
using ChronoCorp.Service;
using ChronoCorp.ViewModel;

namespace ChronoCorp.View
{
    public partial class ClockingManagementView : UserControl
    {
        public ClockingManagementView()
        {
            InitializeComponent();

            var dbContext = new ApplicationDbContext();
            var ceduleQuartService = new CeduleQuartService(dbContext);
            var fichePaieService = new FichePaieService(dbContext);

            DataContext = new ClockingManagementViewModel(ceduleQuartService, fichePaieService);
        }
    }
}
