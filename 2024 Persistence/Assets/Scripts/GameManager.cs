using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject cube;
    
    // Start is called before the first frame update
    void Start()
    {
        LoadCube();
        GameObject.Find("SaveButton").GetComponent<Button>().onClick.AddListener(() => OnSaveButtonClicked());
    }

    private void LoadCube()
    {
        CubeInfo cubeInfo = SaveManager.LoadCube();

        if (cubeInfo != null)
        {            
            Vector3 cubePosition = new Vector3();
            cubePosition.x = cubeInfo.position[0];
            cubePosition.y = cubeInfo.position[1];
            cubePosition.z = cubeInfo.position[2];
            GameObject.Find("Cube").transform.position = cubePosition;
        }        
    }

    public void OnSaveButtonClicked()
    {
        Debug.Log("Saving...");
        SaveManager.SaveCube(cube);
    }
}
