using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroySingleton : MonoBehaviour
{
    private static DontDestroySingleton instance;

    void Awake()
    {
        if (instance == null)
        {

            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
