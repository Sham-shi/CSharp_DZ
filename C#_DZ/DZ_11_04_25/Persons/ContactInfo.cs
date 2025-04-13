namespace C__DZ.DZ_11_04_25.Persons;

public struct ContactInfo
{
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public ContactInfo(string email, string phoneNumber)
    {
        Email = email;
        PhoneNumber = phoneNumber;
    }
    public override string ToString()
    {
        return $"Email: {Email}, Телефон: {PhoneNumber}";
    }
}
