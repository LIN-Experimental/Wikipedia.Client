using System;
using System.Threading.Tasks;
using Wikipedia.Enums;
using Wikipedia.Objects;

namespace Wikipedia.Examples;

internal static class Program
{
    private static async Task Main()
    {

        // Cliente
        WikipediaClient client = new();

        // Solicitud.
        WikiSearchRequest request = new("SILF.Core")
        {
            Limit = 5,
            WikiSearchMethod = WikiSearchMethod.Text,
            Language = WikiLanguage.Spanish
        };

        // Respuesta.
        WikiSearchResponse response = await client.SearchAsync(request);

        // Mostrar.
        Console.WriteLine($"Buscando: '{request.Query}'");
        Console.WriteLine();
        Console.WriteLine($"Se encontraron {response.QueryResult.SearchResults.Count} resultados");

        // Recorrer los resultados.
        foreach(SearchResult searchResult in response.QueryResult.SearchResults)
        {
            Console.WriteLine($" - {searchResult.Title}");
            Console.WriteLine($"{searchResult.Snippet}");
            Console.WriteLine();
        }

    }
}