using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Animator))]
public class StandardButton :
    MonoBehaviour,
    IPointerEnterHandler,
    IPointerExitHandler
{
    [SerializeField]
    private bool wobblePeriodically = false;

    [SerializeField]
    private TMP_Text textField = null;

    private Button button;
    private Animator animator;

    private void Awake()
    {
        button = GetComponent<Button>();
        animator = GetComponent<Animator>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        textField.color = Color.white;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        textField.color = Color.black;
    }

    private void OnEnable()
    {
        if (wobblePeriodically)
        {
            StartWobbling();
        }
        textField.color = Color.black;
    }

    private void OnDisable()
    {
        transform.localScale = Vector3.one;
    }

    private void StartWobbling()
    {
        StartCoroutine(Wobble());

        IEnumerator Wobble()
        {
            while (wobblePeriodically)
            {
                yield return new WaitForSeconds(Random.Range(2f, 5f));
                animator.SetTrigger("Wobble");
            }
        }
    }
}
