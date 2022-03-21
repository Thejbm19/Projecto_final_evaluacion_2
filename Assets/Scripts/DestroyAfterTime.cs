using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
   
   
    void Update()
    {
        Destroy(gameObject, 3);  //Destruye la bal despues de 3 segundos
    }
}
