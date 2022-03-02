using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema_2 : MonoBehaviour
{
    public int[] myArray = new int[] {1,3,4,2,7,0};
    int target=10;
    for (int i = 0; i < myArray.Length; i += 1) {
        for (int j = 0; j < myArray.Length; j += 1) {
            // evitamos la comparación de un elemento consigo mismo
            if (i != j && (myArray[i] + myArray[j]) == target) {
                Debug.Log("Los numeros son: "+ j,i);
            }
        }
    }
}