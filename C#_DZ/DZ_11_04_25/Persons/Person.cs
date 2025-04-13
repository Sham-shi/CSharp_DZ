namespace C__DZ.DZ_11_04_25.Persons;

public class Person : IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ContactInfo Contact { get; set; }

    protected RoleType Role { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public Person(string firstName, string lastName, ContactInfo contact)
    {
        FirstName = firstName;
        LastName = lastName;
        Contact = contact;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine(GetRole());
        Console.WriteLine($"Имя: {LastName} {FirstName}");
        Console.WriteLine($"Контактная информация:\n{Contact}");
    }

    public string GetRole()
    {
        if(Role == RoleType.Client)
        {
            return "Клиент";
        }
        else if (Role == RoleType.Trainer)
        {
            return "Тренер";
        }

        throw new Exception();
    }
}
