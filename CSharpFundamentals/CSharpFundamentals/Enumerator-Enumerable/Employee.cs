namespace EnumeratorEnumerable
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal  Salary { get; set; }
        public string Department { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Employee))
                return false;
            var emp = obj as Employee;
            return this.Id == emp.Id
                && this.Name == emp.Name
                && this.Salary == emp.Salary
                && this.Department == emp.Department;
        }
        public static bool operator ==(Employee e1, Employee e2) => e1.Equals(e2);
        public static bool operator !=(Employee e1, Employee e2) => !e1.Equals(e2);
    }
}
