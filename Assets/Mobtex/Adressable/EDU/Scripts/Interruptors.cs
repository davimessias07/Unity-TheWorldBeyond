using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interruptors : MonoBehaviour
{
    [SerializeField]
    private Animator _Animation;

    private bool isOff = false;

    public void AnimationInterruptor()
    {
        if(isOff == false)
        {
            OnInterruptor();
        }
        else
        {
            OffInterruptor();
        }
    }

    public void OnInterruptor()
    {
        {
         _Animation.SetTrigger("ON");
        }
        isOff = true; 
    } 

    private void OffInterruptor()
    {
        {
          _Animation.SetTrigger("OFF");
        }  
        isOff = false; 
         
    }
}
