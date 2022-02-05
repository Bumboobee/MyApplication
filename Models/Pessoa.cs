using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Key]
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("NomeCompleto")]
        [StringLength(120)]
        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O campo Nome Completo é de preenchimento obrigatório.")]
        public string NomeCompleto { get; set; }

        [Column("DataNascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "O campo Data de Nascimento é de preenchimento obrigatório.")]
        public DateTime DataNascimento { get; set; }

        [Column("Sexo")]
        [StringLength(1)]
        [Display(Name = "Sexo: M-(asculino) F-(eminino)")]
        [Required(ErrorMessage = "O campo Sexo é de preenchimento obrigatório.")]
        public string Sexo { get; set; }

        public virtual ICollection<Vacina> Vacina { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
