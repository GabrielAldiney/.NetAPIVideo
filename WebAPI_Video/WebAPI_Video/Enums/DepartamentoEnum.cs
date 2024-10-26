using System.Text.Json.Serialization;

namespace WebAPI_Video.Enums
{ 
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartamentoEnum
    {
        Rh,
        Financeiro,
        Compras,
        Atendimento,
        Zeladoria


    }
}
