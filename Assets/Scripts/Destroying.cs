using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Util/Destroction Util")]
public class Destroying : MonoBehaviour
{
    public void Destroyer(GameObject gameObject)
    {
        Object.Destroy(gameObject);
    }


}

