using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Button))]
public class LevelButton : MonoBehaviour
{
    [Tooltip("Name of the scene to load")]
    [SerializeField]
    private string scene = string.Empty;

    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(LoadLevelWithFade);
    }

    private void LoadLevelWithFade()
    {
        SceneTransition.Instance.RunWithFade(LoadLevel);
    }

    private void LoadLevel()
    {
        SceneManager.LoadScene(scene);
    }
}
