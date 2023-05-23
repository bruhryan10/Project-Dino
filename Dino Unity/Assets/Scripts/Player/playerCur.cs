using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCur : MonoBehaviour
{
    public int curNum = 10;

    void Awake()
    {
        curNum = PlayerPrefs.GetInt("cur");
    }
    public void OnDestroy()
    {
        PlayerPrefs.SetInt("cur", curNum);
    }
}
