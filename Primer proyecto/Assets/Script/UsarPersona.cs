using UnityEngine;
using System.Collections.Generic;
using PackagePersona;


public class NewMonoBehaviourScript : MonoBehaviour
{
    List<Estudiante> ListaE=new List <Estudiante>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        Estudiante e1 = new Estudiante("2001","Ing Multimedia", "Jose Jose", "JoseJose@uao.edu.co","Calle 1 # 2-3");
        Estudiante e2 = new Estudiante("2005", "Ing Mecatronica", "Juan Jose", "JuanJose@uao.edu.co", "Calle C 2# 2-3");

        ListaE.Add(e1);
        ListaE.Add(e2);

        for (int i = 0; i < ListaE.Count; i++)
        {
        /*
            Debug.Log("Nombre: " + ListaE[i].NameP);
            Debug.Log("Carrera: " + ListaE[i].Carrera);
            Debug.Log("Codigo: " + ListaE[i].Codigo);
            Debug.Log("Correo: " + ListaE[i].MailP);
            Debug.Log("Direccion: " + ListaE[i].DirP);
        */
            Debug.Log(ListaE[i].NameP + "\n" + 
                ListaE[i].Carrera + "\n" + 
                ListaE[i].Codigo + "\n" + 
                ListaE[i].MailP + "\n" +
                ListaE[i].DirP);
        }
    }

    // Update is called once per frame
    public void Update()
    {
    }
}
