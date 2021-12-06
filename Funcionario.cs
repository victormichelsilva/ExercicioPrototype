﻿namespace ExercicioPrototype
{
    public abstract class Funcionario
    {
        public abstract Funcionario Clone();

        public string Nome { get; set; }
        public string Cargo { get; set; }
    }
}
