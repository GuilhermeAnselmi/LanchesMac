using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models;

[Table("Lanches")]
public class Lanche
{
    [Key]
    public int LancheId { get; set; }
    [Required(ErrorMessage = "Erro no nome do lanche"), Display(Name = "Nome do lanche")]
    public string Nome { get; set; }
    public string DescricaoCurta { get; set; }
    public string DescricaoDetalhada { get; set; }
    public decimal Preco { get; set; }
    public string ImagemUrl { get; set; }
    public string ImagemThumbnailUrl { get; set; }
    public bool LanchePreferido { get; set; }
    public bool Estoque { get; set; }

    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }
}
