using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEvent;
    private void OnTriggerEnter(Collider other)
    {
        //trigger the even and test with a debug message
        if (other.gameObject.tag == "Player")
        {
            triggerEvent.Invoke();
        }
        
        
        

    }
    
}
