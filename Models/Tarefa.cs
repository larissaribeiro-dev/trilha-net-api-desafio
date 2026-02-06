using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrilhaApiDesafio.Models
{
    [Table("TAREFAS")]
    public class Tarefa
    {
        [Key]
        [Column("ID")] // Força o nome da coluna como ID
        public int Id { get; set; }

        [Column("TITULO")]
        public string Titulo { get; set; }

        [Column("DESCRICAO")]
        public string Descricao { get; set; }

        [Column("DATA")]
        public DateTime Data { get; set; }

        [Column("STATUS")]
        public EnumStatusTarefa Status { get; set; }
    }
}