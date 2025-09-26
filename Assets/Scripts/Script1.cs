using Mono.Cecil.Cil;
using Unity.VisualScripting;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public string Cheese = "queso herreño ahumado"; 
    
    int numero = 1;

    //Variable de tipo entero
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Cheese, gameObject);
        Debug.Log(numero);
    }

    // Update is called once per frame
    void Update()
    {
        //This runs on every frame of the game.

        //Variable +1
        numero = numero + 1;

        //print to console
        Debug.Log(Cheese + "update" + numero);
    }
}
