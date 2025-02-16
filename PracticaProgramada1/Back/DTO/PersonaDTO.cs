﻿namespace Back.DTO
{
    public class PersonaDTO
    {
        public int Id { get; set; }

        public string Identificación { get; set; } = null!;

        public string Nombre { get; set; } = null!;

        public string PrimerApellido { get; set; } = null!;

        public string SegundoApellido { get; set; } = null!;
    }
}
