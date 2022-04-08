//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float producto1;
    public float producto2;
    public float producto3;
    public float montodisponible1;
    void Start()
    {
        if (montodisponible1 < producto1 + producto2 + producto3)
        {
            Debug.Log("La suma de dinero supera al monto disponible");
        }

        else if (montodisponible1 > producto1 + producto2 + producto3)
        {
            Debug.Log("La suma de dinero no supera al monto disponible");
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
