//using OOPHRSystem.Core.Entities;
//using OOPHRSystem.Core.Repositories;
//using System;

//var deletablerepository = new DeletableRepository<Employee>();
//var employee = new SalariedEmployee();
//employee.SetName("Mohammed", "Sameeh");
//deletablerepository.Add(employee);
//Console.WriteLine($"Employee '{employee.FullName}' has been added with id #{employee.Id}");
//var addedEmployee = deletablerepository.GetById(employee.Id);
//Console.WriteLine(addedEmployee == null ? "Employee not found" : "Employee found");
//deletablerepository.Delete(employee);
//addedEmployee = deletablerepository.GetById(employee.Id);
//Console.WriteLine(addedEmployee == null ? "Employee not found" : "Employee found");

//var applicantRepository = new Repository<Applicant>();
//var applicant = new Applicant();
//applicant.SetName("Ahmed", "Hesham");
//applicantRepository.Add(applicant);
////applicantRepository.Delete(applicant); // APPLICANTS SHOULD NOT BE DELETED
//Console.ReadKey();
