using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveManager
{
    private static string path = Application.persistentDataPath + "/cube.dat";

    public static void SaveCube(GameObject cube)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Create);
        CubeInfo cubeInfo = new CubeInfo(cube);
        formatter.Serialize(stream, cubeInfo);
        stream.Close();
        Debug.Log("Saved to " + path);
    }

    public static CubeInfo LoadCube()
    {
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            CubeInfo cubeInfo = formatter.Deserialize(stream) as CubeInfo;
            stream.Close();
            return cubeInfo;
        }
        else
        {
            Debug.LogWarning("File " + path + " does not exist");
            return null;
        }
    }

}
