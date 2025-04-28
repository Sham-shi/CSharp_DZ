
using System.Text.Json.Serialization;

namespace C__DZ.DZ_25_04_25.Task3;

public class Book
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("author")]
    public string Author { get; set; }

    [JsonPropertyName("publishedDate")]
    public DateTime PublishedDate { get; set; }

    public override string ToString()
    {
        return $"Название: {Title}, Автор: {Author}, Дата публикации: {PublishedDate}";
    }
}
