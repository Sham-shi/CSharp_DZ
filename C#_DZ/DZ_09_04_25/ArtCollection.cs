
using C__DZ.DZ_09_04_25;

namespace CSharp_DZ.DZ_09_04_25;

public class ArtCollection
{
    private List<Artwork> _artworks;
    public int Count => _artworks.Count;

    public ArtCollection()
    {
        _artworks = new List<Artwork>();
    }

    public Artwork this[int index]
    {
        get
        {
            return _artworks[index];
        }
        set
        {
            _artworks[index] = value;
        }
    }

    public void AddArtwork(Artwork artwork)
    {
        _artworks.Add(artwork);
    }

    public void RemoveArtwork(string title, int year)
    {
        _artworks.RemoveAll(a => a.Title == title && a.Year == year);
    }

    public List<Artwork> FindArtworksByArtist(string artist)
    {
        return this.SearchBy(a => a.Artist == artist);
    }

    public List<Artwork> GetArtworksByStyle(string style)
    {
        return this.SearchBy(a => a.Style == style);
    }

    public override string ToString()
    {
        return string.Join("\n", _artworks);
    }
}
