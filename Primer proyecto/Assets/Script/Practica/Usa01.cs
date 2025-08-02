using UnityEngine;
using System.Collections.Generic;
using PackagePersona;
public class Usa01 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List<Padre01> ListaPadre01 = new List<Padre01>();

        Padre01 p1 = new Padre01("Padre", "El Poblado", "Carlos", "Masculino", 45, 1.75);

        ListaPadre01.Add(p1);

        for(int i = 0; i < ListaPadre01.Count; i++)
        {
            Debug.Log("Nombre: " + ListaPadre01[i].Nombre);
            Debug.Log("Genero: " + ListaPadre01[i].Genero);
            Debug.Log("Edad: " + ListaPadre01[i].Edad);
            Debug.Log("Altura: " + ListaPadre01[i].Altura);
            Debug.Log("Rol: " + ListaPadre01[i].Rol);
            Debug.Log("Barrio: " + ListaPadre01[i].Barrio);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
