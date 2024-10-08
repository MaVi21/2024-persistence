using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefsManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        PlayerInfo.Money = PlayerPrefs.GetInt("money");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
        PlayerPrefs.SetInt("money", PlayerInfo.Money);
        PlayerPrefs.Save();
    }
}
