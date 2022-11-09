
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;
[Table("ITEMS")]
public class Item{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID")]
    public int ItemId{ get; set; }
    [Column("NAME")]
    public string Name{ get; set; }
    [Column("IS_DONE")]
    public bool IsDone{ get; set; }
}