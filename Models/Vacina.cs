using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    [Table("Vacina")]
    public class Vacina
    {
        [Key]
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("NomeVacina")]
        [StringLength(120)]
        [Display(Name = "Nome da Vacina")]
        [Required(ErrorMessage = "O campo Nome da Vacina é de preenchimento obrigatório.")]
        public string NomeVacina { get; set; }

        [Column("Valor")]
        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "O campo Valor é de preenchimento obrigatório.")]
        public decimal Valor { get; set; }

        [Column("DataVacina")]
        [Display(Name = "Data da Vacina")]
        [Required(ErrorMessage = "O campo Data da Vacina é de preenchimento obrigatório.")]
        public DateTime DataVacina { get; set; }

        [Column("PessoaId")]
        [Display(Name = "Nome do Cliente")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "O campo Nome do Cliente é de preenchimento obrigatório.")]
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
