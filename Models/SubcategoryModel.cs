using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netpc_e1.Models;

public class Subcategory {
    [Key]
    public int SubcategoryId { get; set; }

    [Required]
	public string SubcategoryName { get; set; }
	
    [Required]
    public int MainCategory { get; set; }

    [ForeignKey("MainCategory")]
    public Category CategoryObj { get; set; }
}