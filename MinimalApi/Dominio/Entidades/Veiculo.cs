﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MinimalApi.Dominio.Entidades;

public class Veiculo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [StringLength(150)]
    public string? Nome { get; set; }
    [Required]
    [StringLength(100)]
    public string? Marca { get; set; }
    [Required]
    public int Ano { get; set; }
}
