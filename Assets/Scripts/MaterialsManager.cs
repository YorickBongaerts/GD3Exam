using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MaterialsManager : MonoBehaviour
{
    public bool ShouldSwap;
    public Material SwapToMaterial;
    private int _pressedButton;
    public List<Material> _bulletMaterials = new List<Material>();
    private void Update()
    {
        SwapInput();
    }
    void SwapInput()
    {
        if (!ShouldSwap)
            return;

        Time.timeScale = 0;

        if (Keyboard.current.numpad1Key.wasPressedThisFrame)
            _pressedButton = 1;

        if (Keyboard.current.numpad2Key.wasPressedThisFrame)
            _pressedButton = 2;

        if (Keyboard.current.numpad3Key.wasPressedThisFrame)
            _pressedButton = 3;

        if (Keyboard.current.numpad4Key.wasPressedThisFrame)
            _pressedButton = 4;

        if (Keyboard.current.numpad5Key.wasPressedThisFrame)
            _pressedButton = 5;

        if (Keyboard.current.numpad6Key.wasPressedThisFrame)
            _pressedButton = 6;

        if (Keyboard.current.numpad7Key.wasPressedThisFrame)
            _pressedButton = 7;

        if (Keyboard.current.numpad8Key.wasPressedThisFrame)
            _pressedButton = 8;

        if (_pressedButton != 0)
        {
            ShouldSwap = false;
            SwapMaterial();
        }
    }
    void SwapMaterial()
    {
        _bulletMaterials[_pressedButton - 1] = SwapToMaterial;
        SwapToMaterial = null;
        _pressedButton = 0;
        Debug.Log("swapped");
        Time.timeScale = 1;
    }
}
