using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    public int n1;
    // Start is called before the first frame update
    void Start()
    {
        if (n1 > 0)
        {
            int resto;
            resto = n1 % 2;
            if (resto == 0)
            {
                Debug.Log("el numero es par");
            }
            else
            {
                Debug.Log("el numero es impar");
            }
        }
        else
        {
            Debug.Log("error, el numero debe ser mayor que 0");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
