// foreach (var wizard in WizardCollection.Create())
// {
//     Console.WriteLine(wizard);
// }


var student = new Student {Id = 01, GivenName = "Monica", SurName = "Hardt", Status = Status.Dropout, 
        StartDate = new DateTime(2022,09, 16), EndDate = new DateTime(2022,09,18), 
        GraduationDate = new DateTime(2022,09,19) };

        Console.WriteLine(student.ToString());