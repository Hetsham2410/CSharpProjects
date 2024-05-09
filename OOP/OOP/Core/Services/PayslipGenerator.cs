using OOPHRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Services
{
    class PayslipGenerator : IPayslipGenerator
    {
        private readonly INotifier notifier;

        public PayslipGenerator(INotifier notifier)
        {
            this.notifier = notifier;
        }
        public void Generate(Employee employee)
        {
            var payItems = employee.GetPayItems();
            var message = new StringBuilder();
            message.AppendLine($"Dear {employee.FullName},");
            message.AppendLine($"Please find below your payslip details:");
            int maxLength = 0;
            foreach (var payItem in payItems)
            {
                maxLength = Math.Max(maxLength, payItem.Name.Length);
            }
            foreach (var payItem in payItems)
            {
                message.AppendLine($"{payItem.Name.PadRight(maxLength)}: {payItem.Value:N2}");
            }
            notifier.Notify(employee.Email, "Payslip Generated !", message.ToString());
        }
    }
}
