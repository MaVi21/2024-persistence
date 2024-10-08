using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CubeInfo
{
    public float[] position;

    public CubeInfo(GameObject cube)
    {
        position = new float[3];
        position[0] = cube.transform.position.x;
        position[1] = cube.transform.position.y;
        position[2] = cube.transform.position.z;
    }

}
