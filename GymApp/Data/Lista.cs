using System.ComponentModel.DataAnnotations;

namespace GymApp.Data;

internal sealed class Lista
{

    //ID DEL CLIENTE
    [Key]
    public int Id { get; set; }


    //NOMBRE DEL CLIENTE
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }


    //APELLIDO DEL CLIENTE
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }


}



