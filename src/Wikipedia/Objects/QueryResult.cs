using System.Text.Json.Serialization;

namespace Wikipedia.Objects;

public class QueryResult
{

    public QueryResult()
    {
        SearchResults = [];
    }

    [JsonPropertyName("search")] 
    public List<SearchResult> SearchResults { get; set; }


    public SearchInfo? SearchInfo { get; set; }


}