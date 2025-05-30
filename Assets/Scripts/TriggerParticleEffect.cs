using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(requiredComponent:typeof(ParticleSystem), requiredComponent2: typeof(Collider))]

public class TriggerParticleEffect : MonoBehaviour
{
    private ParticleSystem particleSystem;

    public int firstEmissionAmount = 10;
    public int secondEmissionAmount = 20;
    public int thirdEmissionAmount = 30;
    public float delayBetweenEmissions = 0.5f;
    

    // Start is called before the first frame update
    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>(); 
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
        {
            StartCoroutine(routine: EmitParticlesCoroutine ());
        }
    }

    private IEnumerator EmitParticlesCoroutine()
    {
        particleSystem.Emit(firstEmissionAmount);
        yield return new WaitForSeconds(delayBetweenEmissions);

        particleSystem.Emit(secondEmissionAmount);
        yield return new WaitForSeconds(delayBetweenEmissions);

        particleSystem.Emit(thirdEmissionAmount);
    }
}
