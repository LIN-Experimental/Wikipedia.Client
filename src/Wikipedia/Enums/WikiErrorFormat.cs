namespace Wikipedia.Enums;

public enum WikiErrorFormat
{
    NotSet = 0,

    /// <summary>
    /// Formato utilizado antes de MediaWiki 1.29. <see cref="WikiMediaRequest.ErrorLanguageToUse" /> y
    ///     <see cref="WikiMediaRequest.ErrorUseLocalLanguage" /> son ignorados.
    /// </summary>
    [StringValue("bc")] Bc,

    /// <summary>
    ///     HTML.
    /// </summary>
    [StringValue("html")] Html,

    /// <summary>
    ///     Sin salida de texto, solo los códigos de error.
    /// </summary>
    [StringValue("none")] None,

    /// <summary>
    ///     Wikitexto con etiquetas HTML eliminadas y entidades reemplazadas.
    /// </summary>
    [StringValue("plaintext")] Plaintext,

    /// <summary>
    ///     Clave del mensaje y parámetros.
    /// </summary>
    [StringValue("raw")] Raw,

    /// <summary>
    ///     Wikitexto sin analizar.
    /// </summary>
    [StringValue("wikitext")] WikiText
}