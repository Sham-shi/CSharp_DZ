namespace C__DZ.DZ_11_04_25.Persons;

public class Trainer : Person
{
    public string TrainerID { get; set; }
    public List<string> Specializations { get; set; }

    private static int trainersCounter = 0;

    public Trainer(string firstName, string lastName, List<string> specializations) : base(firstName, lastName)
    {
        TrainerID = $"T-{LastName[0]}{FirstName[0]}-{++trainersCounter}";
        Specializations = specializations;
        Role = RoleType.Trainer;
    }

    public Trainer(string firstName, string lastName, ContactInfo contact, List<string> specializations) : base(firstName, lastName, contact)
    {
        TrainerID = $"T-{LastName[0]}{FirstName[0]}-{++trainersCounter}";
        Specializations = specializations;
        Role = RoleType.Trainer;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine(GetRole());
        Console.WriteLine($"ID: {TrainerID}");
        Console.WriteLine($"Имя: {LastName} {FirstName}");
        Console.WriteLine("Специализации:");

        for (int i = 0; i < Specializations.Count; i++)
        {
            Console.WriteLine(Specializations[i]);
        }

        Console.WriteLine($"Контактная информация:\n{Contact}\n");
    }
}
