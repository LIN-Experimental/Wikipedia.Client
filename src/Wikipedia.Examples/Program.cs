using System.Threading.Tasks;
using System;
using Wikipedia;
using Wikipedia.Enums;
using Wikipedia.Objects;

namespace Wikipedia.Examples;

internal static class Program
{
    private static async Task Main()
    {

        //Default language is English
        using WikipediaClient client = new ();


        WikiSearchRequest req = new("Albert Einstein")
        {
            Limit = 5,
            WikiSearchMethod = WikiSearchMethod.Text,
            Language = WikiLanguage.Spanish,
            SortOrder = WikiSortOrder.JustMatch
        };


        WikiSearchResponse resp = await client.SearchAsync(req);


        Console.WriteLine($"Searching for {req.Query}");
        Console.WriteLine();
        Console.WriteLine($"Found {resp.QueryResult.SearchResults.Count} English results:");

        foreach (SearchResult s in resp.QueryResult.SearchResults)
        {
            Console.WriteLine($" - {s.Title}");
            Console.WriteLine($"{s.Snippet}");
        }

        Console.WriteLine();
        Console.WriteLine();

        //We change the language to Spanish
        req.Language = WikiLanguage.Spanish;

        resp = await client.SearchAsync(req).ConfigureAwait(false);

        Console.WriteLine($"Found {resp.QueryResult.SearchResults.Count} Spanish results:");

        foreach (SearchResult s in resp.QueryResult.SearchResults)
        {
            Console.WriteLine($" - {s.Title}");
            Console.WriteLine($"{s.Snippet}");
        }

    }
}