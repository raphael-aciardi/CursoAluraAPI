using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos.Endereco
{
    public class ReadEnderecoDto
    {
        public int Id { get; set; }
<<<<<<< HEAD
        public string Logradouro { get; set; }
=======
        [Required]
        public string Logradouro { get; set; }
        [Required]
>>>>>>> 008b1041909fcacb2a601ad7d41c0d4e252b6a06
        public int Numero { get; set; }
    }
}
