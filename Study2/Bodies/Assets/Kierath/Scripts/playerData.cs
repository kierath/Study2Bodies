using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerData : MonoBehaviour
{
    public static playerData dat; //class static so enter without getcomponent from other scripts
    public Vector3 playerPosition;
    void Awake()
    {
        if (dat == null)
        {
            DontDestroyOnLoad(gameObject);// game object will not be destroyed on scene reload 
            dat = this;
        }
        else if (dat != this)
        {
            Destroy(gameObject);
        }
    }
}