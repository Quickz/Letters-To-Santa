using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transition : MonoBehaviour
{
    public bool IsFading { get; private set; }

    [SerializeField]
    private Image target = null;

    [SerializeField]
    private float speed = 1f;

    [SerializeField]
    private bool fadedOutByDefault = false;

    private Coroutine fadeCoroutine;
    private float defaultOpacity;

    protected virtual void Awake()
    {
        defaultOpacity = target.color.a;

        if (!fadedOutByDefault)
        {
            SetOpacity(target, 0f);
            target.gameObject.SetActive(false);
        }
    }

    /// <summary>
    ///  Fades out, runs the method
    ///  and fades back in.
    /// </summary>
    public void RunWithFade(Action CallBack)
    {
        StopFade();
        StartCoroutine(FadeOutAndIn(CallBack));
    }

    public Coroutine FadeIn()
    {
        StopFade();
        fadeCoroutine = StartCoroutine(FadeInAndDeactivate());
        return fadeCoroutine;


        IEnumerator FadeInAndDeactivate()
        {
            yield return StartCoroutine(Fade(0f));
            target.gameObject.SetActive(false);
        }
    }

    public Coroutine FadeOut()
    {
        StopFade();
        target.gameObject.SetActive(true);
        fadeCoroutine = StartCoroutine(Fade(defaultOpacity));
        return fadeCoroutine;
    }

    private void StopFade()
    {
        if (fadeCoroutine != null)
        {
            StopCoroutine(fadeCoroutine);
        }
    }

    private IEnumerator FadeOutAndIn(Action Callback = null)
    {
        yield return FadeOut();
        Callback?.Invoke();
        yield return new WaitForSeconds(0.05f);
        yield return FadeIn();
    }

    private IEnumerator Fade(float targetAlpha)
    {
        IsFading = true;
        float alpha = target.color.a;
        while (alpha != targetAlpha)
        {
            alpha = Mathf.MoveTowards(
                alpha,
                targetAlpha,
                Time.unscaledDeltaTime * speed);

            SetOpacity(target, alpha);

            yield return null;
        }
        IsFading = false;
    }

    private void SetOpacity(Image target, float alpha)
    {
        target.color = new Color(
            target.color.r,
            target.color.g,
            target.color.b,
            alpha);
    }
}
