using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CuentaBancarias.Models
{
    [Table("t_cuentaban")]
    public class Cuenta
    {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? NombreTitular { get; set; }
    public string? TipoCuenta { get; set; }
    public decimal SaldoInicial { get; set; }
    public string? Email { get; set; }
    }
}