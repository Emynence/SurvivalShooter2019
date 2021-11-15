using System.Collections;
using UnityEngine;

public class timeManager : MonoBehaviour
{
    public float slowdownFactor = 0.05f;
    public float slowdownLength = 6f;

    private void Update()
    {
        Time.timeScale += (1f / slowdownLength)*Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }
    public void DoSlowmotion()
    {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }
    public IEnumerator DoFreeze()
    {
        float origTime = Time.timeScale;
        Time.timeScale = 0;
        float t = 0;
        float pauseDuration = 10f;
        while(t<pauseDuration)
        {
            yield return null;
            t += Time.unscaledDeltaTime;
        }
        Time.timeScale = origTime;
    }
}
