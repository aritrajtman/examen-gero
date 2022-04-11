using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1 : MonoBehaviour
{
    public string moneda;

   public int D;
    public int R;
    public int E;
    public int pesos;

    // Start is called before the first frame update
    void Start()
    {
        D = pesos * 100;
        R = pesos * 50;
        E = pesos * 200;

        if (moneda != "d")
        {
            Debug.Log("No es una moneda valida");
        }
        else if (moneda != "e") 
        {
            Debug.Log("No es una moneda valida");
        } 
       
        else if (moneda != "r")
        {
            Debug.Log("No es una moneda valida");
        }
        else if (pesos < 1000) 
        {
            Debug.Log("El monto mínimo es $1000");
        }
        else if (moneda =="d")
        {
            Debug.Log(+pesos+  "equivalen a");
            Debug.Log("Dolares");
        }
        else if (moneda == "d")
        {
            Debug.Log(+pesos+ "pesos equivalen a");
            Debug.Log(+E+ "Euros");
        }
        else if (moneda == "r")
        {   
            Debug.Log(+pesos+ "pesos equivalen a");
            Debug.Log(+R+"Reales");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
