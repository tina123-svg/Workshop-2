DateTime birthDate = new DateTime(2005, 6, 15);

DateTime currentDate = DateTime.Now;

TimeSpan age = currentDate - birthDate;
int ageYear = (int)(age.TotalDays / 362.25);

Console.WriteLine($"Birth Date: {birthDate.ToShortDateString()}");
Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
Console.WriteLine($"Age in years: {ageYear}");

DateTime newBirthDate = birthDate.AddDays(10);
Console.WriteLine($"New BirthDate is: {newBirthDate.ToShortDateString()}");