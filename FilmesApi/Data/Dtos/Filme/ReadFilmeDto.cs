﻿using FilmesApi.Data.Dtos.Sessao;
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos.Filme
{
    public class ReadFilmeDto
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Duracao { get; set; }
        public DateTime HoraDaConsulta { get; set; } = DateTime.Now;

        public ICollection<ReadSessaoDto> Sessoes { get; set; }
    }
}
