using packagePersona;
using UnityEngine;
using System;   

namespace PackageEstudiante
{
    public class Estudiante : Persona
    {
        private string codigo;
        private string carrera;
        
        public Estudiante()
        {
        }
        public Estudiante(string carrera, string codigo, string nameP, string mailP, string dirP)
           : base(nameP, mailP, dirP)
        {
            this.carrera = carrera;
            this.codigo = codigo;
        }   

        public string Carrera { get => carrera; set => carrera = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }

}