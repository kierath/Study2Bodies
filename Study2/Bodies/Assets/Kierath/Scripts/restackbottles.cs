using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restackbottles : MonoBehaviour
{
    // Start is called before the first frame update
    public int bottleCount = 0;
    void Start()
    {
        transform.position = new Vector3(transform.position.x, playerData.dat.playerPosition.y, transform.position.z);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bottle")
        {
            bottleCount += 1;
        }
    }

    void Update()
    {
        if(bottleCount == 9)
        {
            Application.LoadLevel(Application.loadedLevel);
            playerData.dat.playerPosition = transform.position;
            Debug.Log(bottleCount);
        }
    }
}
