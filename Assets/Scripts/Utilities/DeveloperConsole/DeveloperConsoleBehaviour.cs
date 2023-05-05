using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;
using TMPro;

public class DeveloperConsoleBehaviour : MonoBehaviour
{
    [SerializeField]
    private ConsoleCommand[] commands = new ConsoleCommand[0];

    [Header("UI")]
    [SerializeField]
    private GameObject uiCanvas = null;

    [SerializeField]
    private TMP_InputField inputField = null;

    private float pausedTimeScale;

    private static DeveloperConsoleBehaviour instance;

    // Singlton for dev console
    private DeveloperConsole developerConsole;
    private DeveloperConsole DeveloperConsole
    {
        get
        {
            if (developerConsole != null)
                return developerConsole;
            return developerConsole = new DeveloperConsole(commands);
        }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        DontDestroyOnLoad(gameObject);
    }

    public void Toggle(CallbackContext context)
    {
        if (!context.action.triggered)
            return;

        if (uiCanvas.activeSelf)
        {
            Time.timeScale = pausedTimeScale;
            uiCanvas.SetActive(false);
        }
        else
        {
            pausedTimeScale = Time.timeScale;
            Time.timeScale = 0;
            uiCanvas.SetActive(true);
            inputField.ActivateInputField();
        }
    }

    public void ProcessCommand(string input)
    {
        DeveloperConsole.handleCommand(input);
        inputField.text = string.Empty;
    }
}
