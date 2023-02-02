using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace netpc_e1.Models;

public class User{
    [Key]
    public int UserId { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    public string UserPassword { get; set; }
}