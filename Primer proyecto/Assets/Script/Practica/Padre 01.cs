using UnityEngine;
using System;

namespace PackagePersona 
{ 
    public class Padre01 : Practica01
    {
        private string rol;
        private string barrio;

        public Padre01()
        {
        }

        public Padre01(string rol, string barrio, string nombre, string genero, int edad, double altura)
            : base(nombre, genero, edad, altura)
        {
            this.rol = rol;
            this.barrio = barrio;
        }

        public string Rol { get => rol; set => rol = value; }
        public string Barrio { get => barrio; set => barrio = value; }
    }

}
