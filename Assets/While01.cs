using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While01 : MonoBehaviour
{
    public int counter;
    public int counterMax;

    // Start is called before the first frame update
    void Start()
    {
        if (counter != counterMax && counter > counterMax)
        {
            while (counter >= counterMax)
            {
                Debug.Log(counter);
                counter--;
            }

        }
        
        else
        {
            Debug.Log("NUMEROS INGRESADOS SON INCORRECTOS");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
