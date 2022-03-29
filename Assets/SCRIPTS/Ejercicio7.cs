using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
    public int n1;
    public int n2;
    public int n3;
    // Start is called before the first frame update
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
