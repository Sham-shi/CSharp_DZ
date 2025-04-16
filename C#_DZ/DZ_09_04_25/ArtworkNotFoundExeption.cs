namespace C__DZ.DZ_09_04_25;

public class ArtworkNotFoundExeption : Exception
{
    public ArtworkNotFoundExeption(string value) : base($"Не удалось обнаружить произведений по {value}") { }

    public ArtworkNotFoundExeption() : base("Произведения не обнаружены") { }
}
