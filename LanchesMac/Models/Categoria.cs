using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models;

[Table("Categorias")]
public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }
    [Required(ErrorMessage = "Nome da categoria é exigida")]
    [StringLength(100, ErrorMessage = "Tamanho maximo é 100")]
    [Display(Name = "Nome")]
    public string Nome { get; set; }
    [StringLength(200, ErrorMessage = "Tamanho maximo é 200")]
    [Required(ErrorMessage = "Descrição da categoria é exigida")]
    public string Descricao { get; set; }

    public List<Lanche> Lanches { get; set; }
}
