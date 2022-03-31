using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
    public int n1;
    public int n2;
    public int n3;
    // Start is called before the first frame update
    // Realizá un programa que al ingresar por Inspector tres números enteros num1, num2 y  num3, muestre el valor del mayor de todos. 
    //En caso de igualdad entre los tres imprimir "Los números son iguales".  Test1: num1 = 12, num2 = 4, num3= 7. Resultado esperado: El mayor número es num1  Test2: num1 = 2, num2 = 65, num3= 8. Resultado esperado: El mayor número es num2 
    //Test3: num1 = 3, num2 = 10, num3= 28. Resultado esperado: El mayor número es num3  Test4: num1 = 5, num2 = 5, num3= 5. Resultado esperado: Los números son iguales 


    void Start()
    {
        if (n1 == n2 && n2 == n3)
        {
            Debug.Log("los numeros son iguales");
        }
        if (n1 > n2 && n1 > n3) 
        {
            Debug.Log("el numero mas grande es= "+n1+"");
        }
        if (n2 > n1 && n2 > n3)
        {
            Debug.Log("el numero mas grande es= " + n2 + "");
        }
        if (n3 > n2 && n3 > n1)
        {
            Debug.Log("el numero mas grande es= " + n3 + "");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
