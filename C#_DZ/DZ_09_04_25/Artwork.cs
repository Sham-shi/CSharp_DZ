
namespace CSharp_DZ.DZ_09_04_25;

public class Artwork
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Style { get; set; }
    public int Year { get; set; }

    public Artwork(string title, string artist, string style, int year)
    {
        if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(artist) || string.IsNullOrWhiteSpace(style) || year <= 0)
        {
            throw new ArgumentNullException("Поля не должны быть пустыми!");
        }

        Title = title;
        Artist = artist;
        Style = style;
        Year = year;
    }

    public override string ToString()
    {
        return $"Название: {Title}\nХудожник: {Artist}\nСтиль: {Style}\nГод создания: {Year}\n";
    }

    public static bool operator ==(Artwork artwork1, Artwork artwork2)
    {
        return artwork1.Title == artwork2.Title && artwork1.Year == artwork2.Year;
    }

    public static bool operator !=(Artwork artwork1, Artwork artwork2)
    {
        return artwork1.Title != artwork2.Title || artwork1.Year != artwork2.Year;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || obj is not Artwork)
        {
            return false;
        }

        Artwork currentArtwork = (Artwork)obj;

        return this == currentArtwork;
    }
}
