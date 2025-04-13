namespace C__DZ.DZ_11_04_25.Persons;

public class Client : Person
{
    public string ClientID { get; set; }
    public MembershipType MembershipType { get; set; }

    private static int clientsCounter = 0;

    public Client(string firstName, string lastName, MembershipType membershipType) : base(firstName, lastName)
    {
        ClientID = $"K-{LastName[0]}{FirstName[0]}-{++clientsCounter}";
        MembershipType = membershipType;
        Role = RoleType.Client;
    }

    public Client(string firstName, string lastName, ContactInfo contact, MembershipType membershipType) : base(firstName, lastName, contact)
    {
        ClientID = $"K-{LastName[0]}{FirstName[0]}-{++clientsCounter}";
        MembershipType = membershipType;
        Role = RoleType.Client;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine(GetRole());
        Console.WriteLine($"ID: {ClientID}");
        Console.WriteLine($"Имя: {LastName} {FirstName}");
        Console.Write("Абонемент: ");

        if (MembershipType == MembershipType.DropIn)
        {
            Console.WriteLine("разовое посещение");
        }
        else if(MembershipType == MembershipType.Monthly)
        {
            Console.WriteLine("месячный");
        }
        else
        {
            Console.WriteLine("годовой");
        }

        Console.WriteLine($"Контактная информация:\n{Contact}\n");
    }
}
