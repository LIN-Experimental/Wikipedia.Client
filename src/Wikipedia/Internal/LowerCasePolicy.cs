namespace Wikipedia.Internal;


internal class LowerCasePolicy : JsonNamingPolicy
{

    /// <summary>
    /// Instancia estática de la política de minúsculas.
    /// </summary>
    public static readonly JsonNamingPolicy Instance = new LowerCasePolicy();



    /// <summary>
    /// Constructor privado para evitar instancias externas.
    /// </summary>
    private LowerCasePolicy()
    {
    }


    /// <summary>
    /// Método para convertir el nombre a minúsculas.
    /// </summary>
    /// <param name="name">Nombre.</param>
    public override string ConvertName(string name) => name.ToLowerInvariant();
   

}