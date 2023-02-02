using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netpc_e1.Models;

public class Contact {
    [Key]
    public int ContactId { get; set; }

	[Required]
	public string FirstName { get; set; }

	[Required]
	public string LastName { get; set; }

	[Required]
	public string Email { get; set; }

	[Required]
	public DateTime BirthDate { get; set; }

	[Required]
	public string PhoneNumber { get; set; }

	[Required]
	public int SecondCategory { get; set; }

	[ForeignKey("SecondCategory")]
	public virtual Subcategory SubcategoryObj { get; set; }
}