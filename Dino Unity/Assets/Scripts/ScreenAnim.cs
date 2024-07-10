using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ScreenAnim : MonoBehaviour
{
    [SerializeField] RectTransform rectTransform;
    [SerializeField] SceneLoader loader;
    [SerializeField] float duration;
    [SerializeField] GameObject obj;
    [SerializeField] Canvas animUI;
    public IEnumerator RightAnim()
   {
        obj.SetActive(true);
        obj.transform.SetParent(animUI.transform);
        Vector2 initialPosition = new Vector2(-4652.546f, 0);
        Vector2 targetPosition = new Vector2(760, initialPosition.y);
        float elapsedTime = 0;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.unscaledDeltaTime;
            rectTransform.anchoredPosition = Vector2.Lerp(initialPosition, targetPosition, elapsedTime / duration);
            yield return null;
        }
        rectTransform.anchoredPosition = targetPosition;
        loader.AfterAnim();
    }
    public IEnumerator LeftAnim()
    {
        obj.SetActive(true);
        obj.transform.SetParent(animUI.transform);
        Vector2 initialPosition = new Vector2(760, 0);
        Vector2 targetPosition = new Vector2(-4652.546f, initialPosition.y);
        float elapsedTime = 0;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.unscaledDeltaTime;
            rectTransform.anchoredPosition = Vector2.Lerp(initialPosition, targetPosition, elapsedTime / duration);
            yield return null;
        }
        rectTransform.anchoredPosition = targetPosition;
    }
}
