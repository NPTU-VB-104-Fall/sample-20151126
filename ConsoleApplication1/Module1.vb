Module Module1

    Sub Main()

        Dim fte As ISalary = New FullTimeEmployee()
        Dim manager As ISalary = New Manager()
        Dim pte As ISalary = New PartTimeEmployee()

        'pte.Hours = 80

        Console.WriteLine("Full-Time: {0}", fte.GetSalary())
        Console.WriteLine("Manager: {0}", manager.GetSalary())
        Console.WriteLine("Part-Time: {0}", pte.GetSalary())

        'employee.Address = "Pingtung"
        'employee.Name = "Mary Chen"
        'employee.Phone = "0987654321"

        'Console.WriteLine("Name: {0}, Address: {1}, Phone: {2}",
        '                  employee.Name, employee.Address, employee.Phone)
        'Console.WriteLine("Salary: {0}", employee.GetSalary())
        'Console.WriteLine("Salary in 80 hours: {0}", employee.GetSalaryInHours(80))

        Console.Read()

    End Sub

End Module
