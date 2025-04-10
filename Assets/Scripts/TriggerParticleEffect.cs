using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(requiredComponent:typeof(ParticleSystem), requiredComponent2: typeof(Collider))]

public class TriggerParticleEffect : MonoBehaviour
{
    private ParticleSystem particleSystem; //particle system reference
    public int particleAmount = 10; //Exposed variable for particle amount

    // Start is called before the first frame update
    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>(); 
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>()) //checks if player triggers event
        {
            particleSystem.Emit(particleAmount);
        }
    }
}
