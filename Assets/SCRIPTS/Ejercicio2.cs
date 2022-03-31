using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    //Realizá un programa que, siendo num1 y num2 variables enteras con valores 4 y 5,  respectivamente, realice la operación correspondiente y muestre el resultado en pantalla: 
    //a.Suma
    //b.Producto
    
    // Start is called before the first frame update
        void Start()
    {
        int n1 = 4;
        int n2 = 5;
        int suma;
        int mult;
        suma = n1 + n2;
        mult = n1 * n2;
        Debug.Log("la suma de las variables= "+suma+"");
        Debug.Log("la multiplicacion de las variables= " + mult + "");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
