using C__DZ.DZ_09_04_25;
using CSharp_DZ.DZ_09_04_25;

//var artwork = new Artwork("", "", "", 0);
var artwork1 = new Artwork("Мона Лиза", "Леонардо да Винчи", "Высокое Возрождение", 1506);
var artwork2 = new Artwork("Герника", "Пабло Пикассо", "Кубизм", 1937);
var artwork3 = new Artwork("Крик", "Эдвард Мунк", "Экспрессионизм", 1893);
var artwork4 = new Artwork("Постоянство памяти", "Сальвадор Дали", "Сюрреализм", 1931);
var artwork5 = new Artwork("Музыкант", "Пабло Пикассо", "Кубизм", 1972);
var artwork6 = new Artwork("Сон", "Сальвадор Дали", "Аллегорическая сцена", 1937);

var gallery = new ArtCollection();

gallery.AddArtwork(artwork1);
gallery.AddArtwork(artwork2);
gallery.AddArtwork(artwork3);
gallery.AddArtwork(artwork3);
gallery.AddArtwork(artwork4);
gallery.AddArtwork(artwork5);
gallery.AddArtwork(artwork6);

Console.WriteLine(gallery);

gallery.RemoveArtwork("Крик", 1893);

Console.WriteLine(gallery);

var artworksByArtistList = gallery.FindArtworksByArtist("Пабло Пикассо");

Console.WriteLine("Произведения Пабло Пикассо:");
foreach (var artwork in artworksByArtistList)
{
    Console.WriteLine(artwork);
}

var artworksByStyle = gallery.GetArtworksByStyle("Кубизм");

Console.WriteLine("Произведения в стиле кубизм:");
foreach (var artwork in artworksByStyle)
{
    Console.WriteLine(artwork);
}

var artworksGroupedByYear = gallery.GroupByYear(1937);

Console.WriteLine("Произведения, написанные в 1937:");
foreach (var artwork in artworksGroupedByYear)
{
    Console.WriteLine(artwork);
}

Dictionary<string, List<Artwork>> artworksByArtist = new Dictionary<string, List<Artwork>>();

for (int i = 0; i < gallery.Count; i++)
{
    if (!artworksByArtist.ContainsKey(gallery[i].Artist))
    {
        artworksByArtist[gallery[i].Artist] = [];
    }

    artworksByArtist[gallery[i].Artist].Add(gallery[i]);
}

HashSet<string> artworksTitles = new HashSet<string>();

for (int i = 0; i < gallery.Count; i++)
{
    artworksTitles.Add(gallery[i].Title);
}