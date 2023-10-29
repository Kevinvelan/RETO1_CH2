using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PANELES : MonoBehaviour
{


    public GameObject panelGanar;
    public GameObject panelPerder;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Enemigo"))
        { 
          
            panelPerder.SetActive(true);

        }

        if (collision.gameObject.CompareTag("Caliz"))
        {

            panelGanar.SetActive(true);

        }



    }


}
