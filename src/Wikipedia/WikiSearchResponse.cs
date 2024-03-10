using System.Text.Json.Serialization;

namespace Wikipedia;

public class WikiSearchResponse
{

    /// <summary>
    /// Indica si la respuesta de la b�squeda se ha completado por lotes.
    /// </summary>
    public bool BatchComplete { get; set; }


    /// <summary>
    /// Continuaci�n de la b�squeda, si est� disponible.
    /// </summary>
    public Continuation? Continue { get; set; }


    /// <summary>
    /// Resultado de la consulta de b�squeda.
    /// </summary>
    [JsonPropertyName("query")]
    public QueryResult? QueryResult { get; set; }


    /// <summary>
    /// Error en la respuesta, si se produce alguno.
    /// </summary>
    public Error? Error { get; set; }


    /// <summary>
    /// Errores del m�dulo en la respuesta.
    /// </summary>
    [JsonPropertyName("errors")]
    public IList<ModuleError>? ModuleErrors { get; set; }


    /// <summary>
    /// Servidor que sirvi� la respuesta.
    /// </summary>
    public string? ServedBy { get; set; }


    /// <summary>
    /// Identificador de la solicitud.
    /// </summary>
    public string? RequestId { get; set; }


    /// <summary>
    /// Idioma de los errores en la respuesta.
    /// </summary>
    [JsonPropertyName("errorlang")]
    public string? ErrorLanguage { get; set; }


    /// <summary>
    /// Idioma utilizado en la respuesta.
    /// </summary>
    [JsonPropertyName("uselang")]
    public string? Language { get; set; }


    /// <summary>
    /// Marca de tiempo actual.
    /// </summary>
    [JsonPropertyName("curtimestamp")]
    public DateTimeOffset CurrentTimestamp { get; set; }


}