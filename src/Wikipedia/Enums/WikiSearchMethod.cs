namespace Wikipedia.Enums;


public enum WikiSearchMethod
{

    /// <summary>
    /// No establecido.
    /// </summary>
    NotSet = 0,


    /// <summary>
    /// Buscar en los títulos de las páginas (predeterminado) (si el motor de búsqueda no admite búsquedas por título,
    /// como Lucene que se utiliza en Wikipedia, entonces se utiliza el texto)
    /// </summary>
    [StringValue("title")]
    Title,


    /// <summary>
    /// Buscar en el texto de la página
    /// </summary>
    [StringValue("text")]
    Text,


    /// <summary>
    /// Buscar títulos que coincidan exactamente. Ejemplo: 'Microsoft' devuelve 'Microsoft', donde 'Microsof' devuelve
    /// 'sin resultados'
    /// </summary>
    [StringValue("nearmatch")]
    NearMatch
}
