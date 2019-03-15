using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class ColorAndDictationManipulation : MonoBehaviour, IDictationHandler
{

    public TextMesh dictationOutputText;
    private new Renderer renderer;
    public GameObject objToBeManipulated;
    private bool isRecording;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    public void OnVoiceCommand()
    {
        renderer = objToBeManipulated.GetComponent<Renderer>();
        renderer.material.color = Color.red;
        dictationOutputText.color = Color.red;
        ToggleRecording();
    }

    public void OnDictationHypothesis(DictationEventData eventData)
    {
        dictationOutputText.text = eventData.DictationResult;
    }

    public void OnDictationResult(DictationEventData eventData)
    {
        dictationOutputText.text = eventData.DictationResult;
    }

    public void OnDictationComplete(DictationEventData eventData)
    {
        dictationOutputText.text = eventData.DictationResult;
        renderer.material.color = Color.green;
        dictationOutputText.color = Color.green;
    }

    public void OnDictationError(DictationEventData eventData)
    {
        isRecording = false;
        dictationOutputText.color = Color.white;
        renderer.material.color = Color.white;
        StartCoroutine(DictationInputManager.StopRecording());

    }

    public void ToggleRecording()
    {
        if (isRecording)
        {
            isRecording = false;
            StartCoroutine(DictationInputManager.StopRecording());
            dictationOutputText.color = Color.red;
        } else
        {
            isRecording = true;
            StartCoroutine(DictationInputManager.StartRecording(null, 5f, 20f, 10));
            dictationOutputText.color = Color.red;
            renderer.material.color = Color.red;
        }
    }
}
