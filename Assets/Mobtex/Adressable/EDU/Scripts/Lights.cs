using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{

    [SerializeField]
    private GameObject lights;


    //Liga e Desliga a luz selecionada.
    public void EnabledAndDisableLights()
    {
        lights.SetActive(!lights.activeSelf);
    }
}
