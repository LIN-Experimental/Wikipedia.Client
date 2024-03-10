namespace Wikipedia;


public class WikipediaClient : IDisposable
{

    /// <summary>
    /// Cliente HTTP.
    /// </summary>
    private readonly HttpClient? _httpClient;


    /// <summary>
    /// Opciones de serialización.
    /// </summary>
    private readonly JsonSerializerOptions _options;


    /// <summary>
    /// Cliente.
    /// </summary>
    private readonly HttpClient? _userClient;



    /// <summary>
    /// Nuevo Cliente.
    /// </summary>
    /// <param name="client">cliente defecto.</param>
    public WikipediaClient(HttpClient? client = null)
    {
        _userClient = client;

        if (_userClient == null)
            _httpClient = new HttpClient();

        _options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = LowerCasePolicy.Instance
        };
    }



    /// <summary>
    /// Activar HTTPS.
    /// </summary>
    public bool UseTls { get; set; } = true;


    /// <summary>
    /// Lenguaje por defecto.
    /// </summary>
    public WikiLanguage DefaultLanguage { get; set; } = WikiLanguage.English;



    /// <summary>
    /// Buscar.
    /// </summary>
    /// <param name="query">Consulta.</param>
    /// <param name="token">Token de cancelación.</param>
    public async Task<WikiSearchResponse> SearchAsync(string query, CancellationToken token = default)
    {
        return await SearchAsync(new WikiSearchRequest(query), token);
    }



    /// <summary>
    /// Buscar.
    /// </summary>
    /// <param name="request">Request.</param>
    /// <param name="token">Token de cancelación.</param>
    public async Task<WikiSearchResponse> SearchAsync(WikiSearchRequest request, CancellationToken token = default)
    {

        // Establecer idioma por defecto.
        if (request.Language == WikiLanguage.NotSet)
            request.Language = DefaultLanguage;

        // Cliente http.
        HttpClient? client = (_userClient ?? _httpClient)
                             ?? throw new InvalidOperationException("Cliente HTTP es null");

        // Crear el request.
        using HttpRequestMessage httpReq = CreateHttpRequest(request);

        // Respuesta de la API.
        using HttpResponseMessage httpResp = await client.SendAsync(httpReq, token);

        // Stream.
        using System.IO.Stream contentStream = await httpResp.Content.ReadAsStreamAsync();

        // Obtener el objeto.
        var searchResp = await JsonSerializer.DeserializeAsync<WikiSearchResponse>(contentStream, _options, token)
            ?? throw new InvalidOperationException("Unable to read query response");


        // Resultado de la query.
        QueryResult query = searchResp.QueryResult ?? new();

        // Usar https.
        var prefix = UseTls ? "https://" : "http://";

        // Formatos.
        foreach (var search in query.SearchResults)
        {
            // Generar la URL.
            search.Url = new Uri(prefix + request.Language.GetStringValue() + ".wikipedia.org/wiki/" +
                                 search.Title);

            // Limpiar el texto.
            search.Snippet = StringExtensions.CleanText(search.Snippet ?? "");

        }

        // Return.
        return searchResp;
    }



    /// <summary>
    /// Crear HTTP request.
    /// </summary>
    private HttpRequestMessage CreateHttpRequest(WikiSearchRequest searchRequest)
    {
        if (!searchRequest.TryValidate(out var message))
            throw new ArgumentException(message, nameof(searchRequest));

        //Required
        var queryParams = new Dictionary<string, string>
        {
            { "action", "query" },
            { "list", "search" }, //See https://www.mediawiki.org/w/api.php?action=help&modules=query%2Bsearch
            { "srsearch", searchRequest.Query },
            { "format", "json" },
            { "formatversion", "2" } //See https://www.mediawiki.org/wiki/API:JSON_version_2
        };

        MapWikiMediaRequest(searchRequest, queryParams);

        //Optional
        if (searchRequest.NamespacesToInclude != WikiNamespace.NotSet)
            queryParams.Add("srnamespace", searchRequest.NamespacesToInclude.GetConcatValues());

        if (searchRequest.Limit != 0)
            queryParams.Add("srlimit", searchRequest.Limit.ToString());

        if (searchRequest.Offset != 0)
            queryParams.Add("sroffset", searchRequest.Offset.ToString());

        if (searchRequest.QueryIndependentProfile != WikiQueryProfile.NotSet)
            queryParams.Add("srqiprofile", searchRequest.QueryIndependentProfile.GetStringValue());

        if (searchRequest.WikiSearchMethod != WikiSearchMethod.NotSet)
            queryParams.Add("srwhat", searchRequest.WikiSearchMethod.GetStringValue());

        if (searchRequest.InfoToInclude != WikiInfo.NotSet)
            queryParams.Add("srinfo", searchRequest.InfoToInclude.GetConcatValues());

        if (searchRequest.PropertiesToInclude != WikiProperty.NotSet)
            queryParams.Add("srprop", searchRequest.PropertiesToInclude.GetConcatValues());

        if (searchRequest.IncludeInterWikiResults)
            queryParams.Add("srinterwiki", "true");

        if (searchRequest.EnableRewrites)
            queryParams.Add("srenablerewrites", "true");

        if (searchRequest.SortOrder != WikiSortOrder.NotSet)
            queryParams.Add("srsort", searchRequest.SortOrder.GetStringValue());

        //API example: http://en.wikipedia.org/w/api.php?action=query&list=search&srsearch=wikipedia&srprop=timestamp
        var baseUrl = new Uri(string.Format(UseTls ? "https://{0}.wikipedia.org/w/" : "http://{0}.wikipedia.org/w/",
            searchRequest.Language.GetStringValue()));

        return new HttpRequestMessage(HttpMethod.Get,
            new Uri(baseUrl, "api.php?" + UrlHelper.CreateQueryString(queryParams)));
    }



    private void MapWikiMediaRequest(WikiMediaRequest request, Dictionary<string, string> queryParams)
    {
        if (request.Assert != null)
            queryParams.Add("assert", request.Assert);

        if (request.AssertUser != null)
            queryParams.Add("assertuser", request.AssertUser);

        if (request.ErrorFormat != WikiErrorFormat.NotSet)
            queryParams.Add("errorformat", request.ErrorFormat.GetStringValue());

        if (request.ErrorLanguageToUse != null)
            queryParams.Add("errorlang", request.ErrorLanguageToUse);

        if (request.ErrorUseLocalLanguage)
            queryParams.Add("errorsuselocal", "true");

        if (request.IncludeCurrentTimestamp)
            queryParams.Add("curtimestamp", "true");

        if (request.IncludeLanguageUsed)
            queryParams.Add("responselanginfo", "true");

        if (request.IncludeServedBy)
            queryParams.Add("servedby", "true");

        if (request.LanguageToUse != null)
            queryParams.Add("uselang", request.LanguageToUse);

        if (request.LanguageVariant != null)
            queryParams.Add("variant", request.LanguageVariant);

        if (request.RequestId != null)
            queryParams.Add("requestid", request.RequestId);
    }



    /// <summary>
    /// Liberar recursos.
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }


    /// <summary>
    /// Liberar recursos.
    /// </summary>
    /// <param name="disposing"></param>
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
            _httpClient?.Dispose();
    }


}