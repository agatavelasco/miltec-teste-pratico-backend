using MiltecApi.Enum;

namespace MiltecApi.Entities
{
    public class Anuncio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataPublicacao { get; set; }
        public decimal Valor { get; set; }
        public string Cidade { get; set; }
        public string Tipo { get; set; } 
        public Categoria? Categoria { get; set; }
        public string? Modelo { get; set; } 
        public string? Condicao { get; set; } 
        public int? Quantidade { get; set; } 
    }

}
