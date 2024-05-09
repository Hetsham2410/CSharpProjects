using OOPHRSystem.Core.Services;
using OOPHRSystem.Core.Entities;
using OOPHRSystem.Core.Repositories;
using System;


var salriedemployee = new SalariedEmployee();
salriedemployee.SetName("Ahmed", "Hesham");
salriedemployee.Email = "ahmedhesham@eskyit.com";
salriedemployee.BasicSalary = 2000;
salriedemployee.Housing = 1000;
salriedemployee.Transportation = 500;
ISalariedEmployeeSalaryCalculator salriedemployeecalculator = SalariedEmployeeSalaryCalculatorFactory.Create(salriedemployee);
Console.WriteLine($"Salary of salaried (Without TAX) employee = {salriedemployeecalculator.GetSalary():0.00} ");
Console.WriteLine($"Salary of salaried employee (With TAX) = {salriedemployeecalculator.GetSalary(10):0.00} ");
Console.WriteLine($"Salary of salaried employee (With TAX and BONOUS) = {salriedemployeecalculator.GetSalary(10, 1000):0.00} ");

var hourlyemployee = new HourlyEmployee();
hourlyemployee.SetName("Mohamed", "Ali");
hourlyemployee.Email = "mohamedali@eskyit.com";
hourlyemployee.HourRate = 100;
hourlyemployee.TotalWorkingHours = 60;
IHourlyEmployeeSalaryCalculator hourlyemployeecalculator = HourlyEmployeeSalaryCalculatorFactory.Create(hourlyemployee);
Console.WriteLine($"Salary of hourly employee = {hourlyemployeecalculator.GetSalary():0.00} ");

var internemployee = new InternEmployee();
internemployee.SetName("Saad", "Fadel");
internemployee.Email = "saadfadel@eskyit.com";
IInternEmployeeSalaryCalculator internemployeecalculator = InternEmployeeSalaryCalculatorFactory.Create();
Console.WriteLine($"Salary of hourly employee = {internemployeecalculator.GetSalary():0.00} ");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("=========================");

var sender = new Sender();
sender.smtpServer = "mail@example.com";
sender.port = 25;
sender.senderAddress = "ahmed@example.com";
sender.senderPassword = "P@ssw0rd2410";
INotifier notifier = NotifierFactory.Create(sender);
IPayslipGenerator payslipGenerator = PayslipGeneratorFactory.Create(notifier);
payslipGenerator.Generate(salriedemployee);
payslipGenerator.Generate(hourlyemployee);
payslipGenerator.Generate(internemployee);
Console.WriteLine("=========================");
DissmissableEmployee employee = new SalariedEmployee();
employee.SetName("Mohammed", "Tarek");
DismissEmployee.Dismiss(employee);
employee = new HourlyEmployee();
employee.SetName("Islam", "Ashraf");
DismissEmployee.Dismiss(employee);
employee = new InternEmployee();
employee.SetName("Mahmoud", "Abdelrazek");
DismissEmployee.Dismiss(employee);

//employee = new CEO();
Console.ReadKey();


