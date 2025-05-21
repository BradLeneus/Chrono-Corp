using System;
using System.Threading.Tasks;
using ChronoCorp.Interface;
using ChronoCorp.Model;
using ChronoCorp.ViewModel;
using Moq;
using Xunit;

namespace ChronoCorpTest
{
    public class ScheduleManagementViewModelTests
    {
        [Fact]
        public async Task CreateAndAssignShift_Should_Call_AddCeduleQuartAsync_With_Correct_Parameters()
        {
            // Arrange
            var mockCeduleQuartService = new Mock<ICeduleQuartService>();
            var mockEmployeeService = new Mock<IEmployeeService>();

            var viewModel = new ScheduleManagementViewModel(mockCeduleQuartService.Object, mockEmployeeService.Object);

            var employee = new Employee
            {
                Id = 1,
                Prenom = "Awakea",
                Nom = "Doe",
                Courriel = "Awakea.doe@gmail.nz",
                Telephone = "444-444-444",
                Departement = "IT",
                Poste = "Développeur .NET"
            };

            viewModel.SelectedEmployee = employee;
            viewModel.SelectedDate = new DateTime(2024, 6, 1);
            viewModel.SelectedTime = new TimeSpan(8, 0, 0);
            viewModel.EndTime = new TimeSpan(16, 0, 0);
            viewModel.TypeQuart = 2;
            viewModel.IsPausePayee = true;

            // Act
            await viewModel.CreateAndAssignShift(employee, DateTime.MinValue, DateTime.MinValue, 2, true);

            // Assert
            mockCeduleQuartService.Verify(s => s.AddCeduleQuartAsync(It.Is<CeduleQuart>(q =>
                q.IdEmployee == employee.Id &&
                q.HeureDebut == new DateTime(2024, 6, 1, 8, 0, 0) &&
                q.HeureFin == new DateTime(2024, 6, 1, 16, 0, 0) &&
                q.TypeQuart == 2 &&
                q.IsPausePayee == true &&
                q.IsPointageApprouve == false
            )), Times.Once);
        }
    }
}
