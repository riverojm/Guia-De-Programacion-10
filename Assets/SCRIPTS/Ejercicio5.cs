using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    public int n1;
    public int n2;
    // Start is called before the first frame update
    void Start()
    {
        if (n2 == 0)
        {
            Debug.Log("error, no se puede dividir por cero");
        }
        else
        {
            int division = n1 / n2;
            Debug.Log(""+n1+" / "+n2+"= "+division+"");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
