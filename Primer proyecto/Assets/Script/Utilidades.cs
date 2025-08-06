using System.IO;
using UnityEngine;
using System.Collections.Generic;
using PackageEstudiante;
//using packagePersona;
using TMPro;
using packagePunto2D;

public class NewMonoBehaviourScript : MonoBehaviour
{
    string rutaE => Path.Combine(Application.persistentDataPath, "estudiantes.json");
    //string rutaP => Path.Combine(Application.persistentDataPath, "personas.json");

    UsaPersona listas;

    public TMP_InputField txtNombre;
    public TMP_InputField txtCodigo;
    public TMP_InputField txtCarrera;
    public TMP_InputField txtCorreo;
    public TMP_InputField txtDireccion;

    void Start()
    {
        listas = new UsaPersona
        {
            estudiantes = new List<Estudiante>
            {
                new Estudiante("Ing Multimedia", "2001", "Jose Jose", "JoseJose@uao.edu.co", "Calle 1 # 2-3"),
                new Estudiante("Ing Mecatronica", "2005", "Romeo Santos", "RomeoSantos@uao.edu.co", "Calle C 2# 2-3")
            }
            ,
            puntos2D = new List<Punto2D>()
        };

        /*
        for(int i = 0; i < listas.estudiantes.Count; i++)
            Debug.Log($"Estudiante: {i.NameP}, Correo: {i.MailP}, " +
                      $"Dirección: {i.DirP}, Carrera: {i.Carrera}, Código: {i.Codigo}");
        */
        foreach (var i in listas.estudiantes)
        {
            Debug.Log($"Estudiante: {i.NameP}, Correo: {i.MailP}, " +
                      $"Dirección: {i.DirP}, Carrera: {i.Carrera}, Código: {i.Codigo}");
        }


    }
    public void save()
    {
        string json = JsonUtility.ToJson(listas, true);
        File.WriteAllText(rutaE, json);
        Debug.Log("Archivo guardado en: " + rutaE);
    }   

    public void read()
    {
        string jsonLeido = File.ReadAllText(rutaE);
        UsaPersona cargados = JsonUtility.FromJson<UsaPersona>(jsonLeido);

        foreach (var e in cargados.estudiantes)
        {
            Debug.Log($"Estudiante: {e.NameP}, Correo: {e.MailP}," +
                $" Direccion: {e.DirP}, Carrera: {e.Carrera}, Codigo: {e.Codigo}");
        }
    }

    public void add()
    {
        string nombre = txtNombre.text;
        string codigo = txtCodigo.text;
        string carrera = txtCarrera.text;
        string correo = txtCorreo.text;
        string direccion = txtDireccion.text;

        Estudiante elEstudiante = new Estudiante(carrera, codigo, nombre, correo, direccion);

        listas.estudiantes.Add(elEstudiante);

        foreach (var e in listas.estudiantes)
        {
            Debug.Log($"Estudiante: {e.NameP}, Correo: {e.MailP}," +
                $" Direccion: {e.DirP}, Carrera: {e.Carrera}, Codigo: {e.Codigo}");
        }
    }
    void Update()
    {

    }
}
