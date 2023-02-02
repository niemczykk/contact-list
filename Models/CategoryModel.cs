using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace netpc_e1.Models;

public class Category {
    [Key]
    public int CategoryId { get; set; }

    [Required]
	public string CategoryName { get; set; }
}