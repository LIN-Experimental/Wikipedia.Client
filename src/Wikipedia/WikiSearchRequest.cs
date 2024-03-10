namespace Wikipedia;


/// <summary>
/// Nuevo.
/// </summary>
/// <param name="query">Consulta.</param>
public class WikiSearchRequest(string query) : WikiMediaRequest
{

    /// <summary>
    /// Busca títulos de página o contenido que coincida con este valor. Puede utilizar la cadena de búsqueda para invocar características especiales de búsqueda, dependiendo de lo que implemente el backend de búsqueda de la wiki.
    /// </summary>
    public string Query { get; set; } = query;


    /// <summary>
    /// Los espacios de nombres a enumerar. Por defecto: <see cref="WikiNamespace.Main" />.
    /// </summary>
    public WikiNamespace NamespacesToInclude { get; set; }


    /// <summary>
    /// Cuántas páginas totales devolver. Por defecto: 10, Máx .: 500
    /// </summary>
    public int Limit { get; set; }


    /// <summary>
    /// Cuando haya más resultados disponibles, use esto para continuar. Por defecto: 0
    /// </summary>
    public int Offset { get; set; }


    /// <summary>
    /// Perfil independiente de la consulta a utilizar (afecta al algoritmo de clasificación). 
    /// Por defecto: <see cref="WikiQueryProfile.AutoSelect" />
    /// </summary>
    public WikiQueryProfile QueryIndependentProfile { get; set; }


    /// <summary>
    /// Qué tipo de búsqueda realizar.
    /// </summary>
    public WikiSearchMethod WikiSearchMethod { get; set; }


    /// <summary>
    /// Qué metadatos incluir. Por defecto: TotalHits, Suggestion
    /// </summary>
    public WikiInfo InfoToInclude { get; set; }


    /// <summary>
    /// Qué propiedad incluir en los resultados. Por defecto: una combinación de fragmento, tamaño, recuento de palabras y marca de tiempo
    /// </summary>
    public WikiProperty PropertiesToInclude { get; set; }


    /// <summary>
    /// Incluir resultados InterWiki en la búsqueda, si están disponibles.
    /// </summary>
    public bool IncludeInterWikiResults { get; set; }


    /// <summary>
    /// Habilitar la reescritura interna de la consulta.
    /// Algunos backends de búsqueda pueden reescribir la consulta en otra que se considere que proporciona mejores resultados, por ejemplo, corrigiendo errores ortográficos.
    /// </summary>
    public bool EnableRewrites { get; set; }


    /// <summary>
    /// Establecer el orden de clasificación de los resultados devueltos. Por defecto: Relevance.
    /// </summary>
    public WikiSortOrder SortOrder { get; set; }


    /// <summary>
    /// Qué idioma utilizar. Por defecto: Inglés (en)
    /// </summary>
    public WikiLanguage Language { get; set; }



    /// <summary>
    /// Validar.
    /// </summary>
    public bool TryValidate(out string? message)
    {
        if (Limit > 500)
        {
            message = nameof(Limit) + " debe estar entre 1 y 500";
            return false;
        }

        if (string.IsNullOrEmpty(Query))
        {
            message = nameof(Query) + " debe establecerse en un valor";
            return false;
        }

        if (Language == WikiLanguage.NotSet)
        {
            message = nameof(Language) + " debe establecerse en un valor válido";
            return false;
        }

        message = null;
        return true;
    }


}