using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] SceneLoader loader;
    public IEnumerator Yep()
    {
        Time.timeScale = 0;
        obj.SetActive(true);
        yield return new WaitForSecondsRealtime(1f);
        obj.SetActive(false);
        Time.timeScale = 1;
        loader.RestartCurrentScene();
    }
}
