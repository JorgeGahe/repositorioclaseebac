using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{

    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;
    int limiteInferior = -5;
    int limiteSuperiro = 5;
    enum SeleccionColor
    {
        rojo,
        verde,
        azul,
        blanco,
        gris,
    }

    // A B C    OR   AND   ((A or B) and C) =       ((A or B) or C) =
    // 1 1 1     1    1         1       1      1          1      1       1 
    // 1 1 0     1    0         1       0      0          1      0       1  
    // 1 0 1     1    0         1       1      1          1      1       1  
    // 1 0 0     1    0         1       0      0          1      0       1 
    // 0 1 1     1    0         1       1      1          1      1       1  
    // 0 1 0     1    0         1       0      0          1      0       1   
    // 0 0 1     1    0         0       1      0          0      1       1   
    // 0 0 0     0    0         0       0      0          0      0       0   


    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;
        variable3 = false;

        if ((variable1 || variable2) && variable3)
        {
            Debug.Log("La operacion 1 es verdadero");
            
        }
        if ((variable1 || variable2) || variable3)
        {
            if (variable1)
            {
                Debug.Log("La variable 1 es verdadero");
            }
            Debug.Log("La operacion 2 es verdadero");
        }
        if ((variable3 && variable2) || variable1)
        {
            Debug.Log("La operacion 3 es verdadero");
        }

        valor1 = Random.Range(limiteInferior, limiteSuperiro);
        Debug.Log(valor1);
        //if (valor1 >= 0)
        //{
        //    Debug.Log("el valor es positivo");
        //}
        //else
        //{
        //    Debug.Log("el valor es negativo");
        //}

        string resultado = (valor1 >= 0) ? "el valor es positivo" : "el valor es negatrivo";
        Debug.Log(resultado);
        //switch (valor1)
        //{
        //    case (int)SeleccionColor.rojo:
        //        Debug.Log("el color seleccionado es rojo");
        //        break;
        //    case (int)SeleccionColor.verde:
        //        Debug.Log("el color seleccionado es verde");
        //        break;
        //    case (int)SeleccionColor.azul:
        //        Debug.Log("el color seleccionado es azul");
        //        break;
        //    case (int)SeleccionColor.blanco:
        //        Debug.Log("el color seleccionado es blanco");
        //        break;
        //    case (int)SeleccionColor.gris:
        //        Debug.Log("el color seleccionado es gris");
        //        break;
        //    default:
        //        Debug.Log("ese no es un color valido");
        //        break;
        //}


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
