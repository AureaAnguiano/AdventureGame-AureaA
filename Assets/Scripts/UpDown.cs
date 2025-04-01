using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] float distanceToStop = 5f;

    [SerializeField] bool isMovingUp = true;

    Vector3 startPosition;
    Vector3 endPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        endPosition = transform.position + Vector3.up * distanceToStop;
    }

    

    // Update is called once per frame
    void Update()
    {
        if (isMovingUp)
        {
            //move up
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, endPosition) < 0.1f)
            {
                isMovingUp = false;
            }
        }
        else
            //down
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, startPosition) < 0.1f)
        {
            isMovingUp = true;
        }
    }
}
