# Wikipedia - Una implementación de la API de búsqueda de texto completo de Wikipedia

[![License](https://img.shields.io/github/license/Genbox/Wikipedia)](https://github.com/Genbox/Wikipedia/blob/master/LICENSE.txt)

### Caracteristicas

* Soporte para 283 idiomas de Wikipedia.
* Soprte para todos los parámetros de búsqueda a partir de MediaWiki v1.24

### Ejemplo

Esta es la forma más sencilla de obtener datos de Wikipedia:

```csharp
static async Task Main()
{
    using WikipediaClient client = new WikipediaClient();
    
    WikiSearchRequest req = new WikiSearchRequest("Albert Einstein");
    req.Limit = 5; // 5 Resultados.
    
    WikiSearchResponse resp = await client.SearchAsync(req);
    
    foreach (SearchResult s in resp.QueryResult.SearchResults)
    {
        Console.WriteLine($" - {s.Title}");
    }
}
```

Output:
```
 - Albert Einstein
 - Hans Albert Einstein
 - Einstein family
 - Albert Brooks
 - Albert Einstein College of Medicine
```