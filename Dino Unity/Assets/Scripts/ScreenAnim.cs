using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenAnim : MonoBehaviour
{
    [SerializeField] RectTransform rectTransform;
    [SerializeField] SceneLoader loader;
    [SerializeField] float duration;
    [SerializeField] GameObject obj;
    [SerializeField] Canvas deathUI;
    [SerializeField] Canvas pauseUI;

    public IEnumerator AnimatePanel()
    {
        obj.SetActive(true);
        if (deathUI.enabled)
            obj.transform.SetParent(deathUI.transform);
        else
            obj.transform.SetParent(pauseUI.transform);

        float elapsedTime = 0.0f;
        float startWidth = 0.0f;
        float endWidth = Screen.width;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.unscaledDeltaTime;
            float newWidth = Mathf.Lerp(startWidth, endWidth, elapsedTime / duration);
            rectTransform.sizeDelta = new Vector2(newWidth, rectTransform.sizeDelta.y);
            yield return null;
        }
        rectTransform.sizeDelta = new Vector2(endWidth, rectTransform.sizeDelta.y);
        GameObject.Find("Main Camera").transform.parent = null;
        GameObject.Find("Player").gameObject.SetActive(false);
        loader.AfterAnim();
    }
}
