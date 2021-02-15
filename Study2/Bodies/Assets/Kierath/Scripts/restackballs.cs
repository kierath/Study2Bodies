using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restackballs : MonoBehaviour
{
    Rigidbody rb;
    private Vector3 startPos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPos = transform.position;
    }

    IEnumerator ballRefill()
    {
        yield return new WaitForSeconds(1);
    }

    IEnumerator unfreezePosition()
    {
        yield return new WaitForSeconds(2);
        rb.constraints = RigidbodyConstraints.None;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Floor")
        {
            StartCoroutine(ballRefill());
            transform.position = startPos;
            rb.constraints = RigidbodyConstraints.FreezePosition;
            StartCoroutine(unfreezePosition());
        }
    }
}
