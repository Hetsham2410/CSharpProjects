using OOPHRSystem.Core.Entities;

namespace OOPHRSystem.Core.Services
{
    interface IPayslipGenerator
    {
        void Generate(Employee employee);
    }
}