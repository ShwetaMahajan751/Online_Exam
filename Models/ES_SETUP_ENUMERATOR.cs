
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class ES_SETUP_ENUMERATOR 
{
    
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required(ErrorMessage = "Enumerator Id is required")]
    public long Enumerator_Id { get; set; }

    [MaxLength(100)]
    [StringLength(100)]
    public string Enum_Group { get; set; }

    [MaxLength(100)]
    [StringLength(100)]
    public string Enum_Name { get; set; }

    [MaxLength(100)]
    [StringLength(100)]
    public string Enum_Display_Text { get; set; }

    [MaxLength(100)]
    [StringLength(100)]
    public string Enum_Value { get; set; }

    public int? Sequence_Number { get; set; }

    public bool? Is_Default { get; set; }

    public bool? Is_Visible { get; set; }

    public bool? Status_Enum { get; set; }

    public long? Created_By { get; set; }

    public DateTime? Created_Datetime { get; set; }

    public long? Modified_By { get; set; }

    public DateTime? Modified_Datetime { get; set; }

    public int? Lock_Id { get; set; }

	
	public long Id {get; set;}
}