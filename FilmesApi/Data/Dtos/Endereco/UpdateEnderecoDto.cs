﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos.Endereco
{
    public class UpdateEnderecoDto
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
    }
}
