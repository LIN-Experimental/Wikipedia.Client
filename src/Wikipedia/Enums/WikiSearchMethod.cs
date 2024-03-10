namespace Wikipedia.Enums;


public enum WikiSearchMethod
{

    /// <summary>
    /// No establecido.
    /// </summary>
    NotSet = 0,


    /// <summary>
    /// Buscar en los t�tulos de las p�ginas (predeterminado) (si el motor de b�squeda no admite b�squedas por t�tulo,
    /// como Lucene que se utiliza en Wikipedia, entonces se utiliza el texto)
    /// </summary>
    [StringValue("title")]
    Title,


    /// <summary>
    /// Buscar en el texto de la p�gina
    /// </summary>
    [StringValue("text")]
    Text,


    /// <summary>
    /// Buscar t�tulos que coincidan exactamente. Ejemplo: 'Microsoft' devuelve 'Microsoft', donde 'Microsof' devuelve
    /// 'sin resultados'
    /// </summary>
    [StringValue("nearmatch")]
    NearMatch
}
