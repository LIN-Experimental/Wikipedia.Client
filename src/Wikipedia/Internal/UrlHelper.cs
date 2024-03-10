namespace Wikipedia.Internal;


internal static class UrlHelper
{

    /// <summary>
    /// Caracteres de URL válidos según RFC3986:
    /// Fuente: https://tools.ietf.org/html/rfc3986#section-2.3
    /// </summary>
    private const string CaracteresUrlValidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._~";


    /// <summary>
    /// HashSet.
    /// </summary>
    private static readonly HashSet<byte> CaracteresUrlValidosLookup = BuildLookup(CaracteresUrlValidos);



    /// <summary>
    /// Construye un conjunto de bytes para buscar caracteres válidos en una URL.
    /// Esto se utiliza para determinar qué caracteres necesitan ser escapados al codificar una URL.
    /// </summary>
    /// <param name="listaCaracteres">La lista de caracteres válidos en una URL.</param>
    /// <returns>Un conjunto de bytes que representan los caracteres válidos en una URL.</returns>
    private static HashSet<byte> BuildLookup(string listaCaracteres)
    {
        var lookup = new HashSet<byte>();
        foreach (var c in listaCaracteres)
        {
            var escapado = Uri.EscapeUriString(c.ToString(CultureInfo.InvariantCulture));
            if (escapado.Length == 1 && escapado[0] == c)
                lookup.Add((byte)c);
        }
        return lookup;
    }



    /// <summary>
    /// Codifica una cadena para que sea segura en una ruta de URL.
    /// </summary>
    /// <param name="input">Entrada.</param>
    public static string UrlPathEncode(string input)
    {
        string[] segmentosRuta = input.Split('/');
        return string.Join("/", segmentosRuta.Select(CodeUrl));
    }



    /// <summary>
    /// Codifica una cadena para que sea segura en una URL.
    /// </summary>
    public static string CodeUrl(string data)
    {
        var datosCodificados = new StringBuilder();
        foreach (var symbol in Encoding.UTF8.GetBytes(data))
        {
            if (CaracteresUrlValidosLookup.Contains(symbol))
                datosCodificados.Append((char)symbol);
            else
                datosCodificados.Append('%').AppendFormat(CultureInfo.InvariantCulture, "{0:X2}", symbol);
        }
        return datosCodificados.ToString();
    }



    /// <summary>
    /// Crea una cadena de consulta a partir de una colección de pares clave-valor.
    /// </summary>
    public static string CreateQueryString(IEnumerable<KeyValuePair<string, string>> parametros, bool codificar = true,
        bool mostrarIgualEnVacio = false)
    {
        var constructorCadenaConsulta = new StringBuilder();
        foreach (var elemento in parametros)
        {
            if (constructorCadenaConsulta.Length > 0)
                constructorCadenaConsulta.Append('&');

            var claveCodificada = codificar ? CodeUrl(elemento.Key) : elemento.Key;

            if (string.IsNullOrEmpty(elemento.Value))
            {
                constructorCadenaConsulta.Append(claveCodificada);

                if (mostrarIgualEnVacio)
                    constructorCadenaConsulta.Append('=');
            }
            else
            {
                constructorCadenaConsulta.Append(claveCodificada).Append('=').Append(codificar ? CodeUrl(elemento.Value) : elemento.Value);
            }
        }

        return constructorCadenaConsulta.ToString();
    }


}