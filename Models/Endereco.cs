using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    [Table("Endereco")]
    public class Endereco
    {
        [Key]
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Rua")]
        [StringLength(70)]
        [Display(Name = "Rua")]
        [Required(ErrorMessage = "O campo Rua é de preenchimento obrigatório.")]
        public string Rua { get; set; }

        [Column("Numero")]
        [StringLength(10)]
        [Display(Name = "Número")]
        [Required(ErrorMessage = "O campo Numero é de preenchimento obrigatório.")]
        public string Numero { get; set; }

        [Column("Complemento")]
        [StringLength(80)]
        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        [Column("Bairro")]
        [StringLength(80)]
        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "O campo Bairro é de preenchimento obrigatório.")]
        public string Bairro { get; set; }

        [Column("UF")]
        [StringLength(2)]
        [Display(Name = "UF (Unidade da Federação)")]
        [Required(ErrorMessage = "O campo UF é de preenchimento obrigatório.")]
        public string UF { get; set; }

        [Column("PessoaId")]
        [Display(Name = "Nome do Cliente")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "O campo Nome do Cliente é de preenchimento obrigatório.")]
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
