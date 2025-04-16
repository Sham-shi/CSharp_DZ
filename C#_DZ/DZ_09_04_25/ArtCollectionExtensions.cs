
using CSharp_DZ.DZ_09_04_25;

namespace C__DZ.DZ_09_04_25;

public static class ArtCollectionExtensions
{
    public static Dictionary<int, List<Artwork>> GroupByYear(this ArtCollection collection)
    {
        var artworksByYear = new Dictionary<int, List<Artwork>>();

        for (int i = 0; i < collection.Count; i++)
        {
            var currentArtwork = collection[i];

            if (!artworksByYear.ContainsKey(currentArtwork.Year))
            {
                artworksByYear[currentArtwork.Year] = [];
            }

            artworksByYear[currentArtwork.Year].Add(currentArtwork);
        }

        return artworksByYear;
    }

    public static List<Artwork> GroupByYear(this ArtCollection collection, int year)
    {
        List<Artwork> artworksByYear = collection.GroupByYear()[year];

        return artworksByYear;
    }

    public static List<Artwork> SearchBy(this ArtCollection collection, Func<Artwork, bool> func)
    {
        var artworksByArtist = new List<Artwork>();

        for (int i = 0; i < collection.Count; i++)
        {
            if (func.Invoke(collection[i]))
            {
                artworksByArtist.Add(collection[i]);
            }
        }

        if (artworksByArtist.Count > 0)
        {
            return artworksByArtist;
        }

        throw new ArtworkNotFoundExeption();
    }
}
