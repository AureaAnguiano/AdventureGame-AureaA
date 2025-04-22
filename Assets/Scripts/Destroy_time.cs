using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Util/Destroction Util")]
public class Destroy_time : MonoBehaviour
{
    public void Destroyer(GameObject gameObject)
    {
        Object.Destroy(gameObject, 0.8f);
    }


}