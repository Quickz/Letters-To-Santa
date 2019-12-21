using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class BaseScreen : MonoBehaviour
{
    [SerializeField]
    private GameObject window = null;

    private static List<BaseScreen> screens = new List<BaseScreen>();

    protected virtual void Awake()
    {
        screens.Add(this);
    }

    public static void CloseAll()
    {
        foreach (BaseScreen screen in screens)
        {
            screen.Close();
        }
    }

    public virtual void OpenAlone()
    {
        CloseAll();
        Open();
    }

    public virtual void Open()
    {
        window.SetActive(true);
    }

    public virtual void Close()
    {
        window.SetActive(false);
    }

    protected virtual void OnDestroy()
    {
        screens.Remove(this);
    }
}
