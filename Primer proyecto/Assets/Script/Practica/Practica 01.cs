using UnityEngine;
using System;

public class Practica01
{
    private string nombre;
    private string genero;
    private int edad;
    private double altura;
    public Practica01()
    {
    }
    public Practica01(string nombre, string genero, int edad, double altura)
    {
        this.nombre = nombre;
        this.genero = genero;
        this.edad = edad;
        this.altura = altura;
    }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Genero { get => genero; set => genero = value; }
    public int Edad { get => edad; set => edad = value; }
    public double Altura { get => altura; set => altura = value; }
}
