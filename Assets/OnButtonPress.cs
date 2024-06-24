using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class OnButtonPress : MonoBehaviour
{
    [SerializeField]
    InputAction action = null;
    [Space()]

    [SerializeField]
    UnityEvent onPress;

    [SerializeField]
    UnityEvent onRelease;

    void SetActive2()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
    private void Awake()
    {
        action.started += Pressed;
        action.canceled += Released;
    }

    private void OnDestroy()
    {
        action.started -= Pressed;
        action.canceled -= Released;
    }

    private void OnEnable()
    {
        action.Enable();
    }

    private void OnDisable()
    {
        action.Disable();
    }

    void Pressed(InputAction.CallbackContext context)
    {
        Debug.Log("Press");
        onPress.Invoke();
    }


    void Released(InputAction.CallbackContext context)
    {
        onRelease.Invoke();
    }

}