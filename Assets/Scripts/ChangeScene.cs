using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChangeScene : MonoBehaviour
{
    public void ChangerScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}