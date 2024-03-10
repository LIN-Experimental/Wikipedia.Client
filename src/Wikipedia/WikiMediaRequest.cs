namespace Wikipedia;


public abstract class WikiMediaRequest
{

    /// <summary>
    /// Verifica si el usuario está conectado si se establece en "user", no está conectado si se establece en "anon", o tiene
    /// el derecho de usuario de bot si es "bot".
    /// </summary>
    public string? Assert { get; set; }


    /// <summary>
    /// Verifica que el usuario actual sea el usuario nombrado.
    /// </summary>
    public string? AssertUser { get; set; }


    /// <summary>
    /// Incluye el nombre de host que sirvió la solicitud en los resultados.
    /// </summary>
    public bool IncludeServedBy { get; set; }


    /// <summary>
    /// Incluye la marca de tiempo actual en el resultado.
    /// </summary>
    public bool IncludeCurrentTimestamp { get; set; }


    /// <summary>
    /// Incluye los idiomas utilizados para uselang y errorlang en el resultado.
    /// </summary>
    public bool IncludeLanguageUsed { get; set; }


    /// <summary>
    /// Cualquier valor dado aquí se incluirá en la respuesta. Puede usarse para distinguir las solicitudes.
    /// </summary>
    public string? RequestId { get; set; }


    /// <summary>
    /// Idioma a utilizar para las traducciones de mensajes. action=query&meta=siteinfo con siprop=languages devuelve una
    /// lista de códigos de idioma, o especifica "user" para usar la preferencia de idioma del usuario actual, o especifica
    /// "content" para usar el idioma de contenido de esta wiki.
    /// </summary>
    public string? LanguageToUse { get; set; }


    /// <summary>
    /// Variante del idioma. Solo funciona si el idioma base admite la conversión de variantes.
    /// </summary>
    public string? LanguageVariant { get; set; }


    /// <summary>
    /// Formato a utilizar para la salida de texto de advertencia y error.
    /// </summary>
    public WikiErrorFormat ErrorFormat { get; set; }


    /// <summary>
    /// Idioma a utilizar para advertencias y errores. action=query&meta=siteinfo con siprop=languages devuelve una lista de
    /// códigos de idioma, o especifica "content" para usar el idioma de contenido de esta wiki, o especifica "uselang" para
    /// usar el mismo valor que el parámetro uselang.
    /// </summary>
    public string? ErrorLanguageToUse { get; set; }


    /// <summary>
    /// Si se proporciona, los textos de error utilizarán mensajes personalizados localmente del espacio de nombres MediaWiki.
    /// </summary>
    public bool ErrorUseLocalLanguage { get; set; }
}
