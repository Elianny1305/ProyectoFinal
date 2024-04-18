
public class Datos
{
    public string Id {get; set;} = String.Empty;
    public DateTime Fecha {get; set;} = DateTime.Now;
    public string Descripcion {get; set;} = String.Empty;
    public int Costo {get; set;} = 0;
    public int? Muertos {get; set;}
    public int? Heridos {get; set;}
    public int Vehiculos {get; set;} = 0;

}
public class Accidente
{
    public string Id {get; set;} = String.Empty;
    public string UserName {get; set;} = String.Empty;
    public string Password {get; set;} = String.Empty;
}
