using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class MaterialsManager : MonoBehaviour
{
    [SerializeField] private PlayerMove player;
    [SerializeField] private GameCanvas gameCanvas;
    public bool ShouldSwap;
    public Material SwapToMaterial;
    public GameObject SwapToObject;
    private int _pressedButton;
    public List<Material> _bulletMaterials = new List<Material>();
    public GameObject[] _collectedPowers = new GameObject[8];
    public int BrownUses = 0;
    public int MaxBlueTime = 2;
    public bool CanUseBlue;
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
        if (_collectedPowers[_pressedButton - 1] != null)
        {
            var powerUp = _collectedPowers[_pressedButton - 1];
            powerUp.SetActive(true);
            UnequipPower(powerUp);
        }
        _collectedPowers[_pressedButton - 1] = SwapToObject;
        _bulletMaterials[_pressedButton - 1] = SwapToMaterial;
        gameCanvas.PowerUpUICollection[_pressedButton - 1].GetComponent<Image>().color = SwapToMaterial.color;
        SwapToMaterial = null;
        SwapToObject = null;
        _pressedButton = 0;
        Debug.Log("swapped");
        Time.timeScale = 1;
    }

    private void UnequipPower(GameObject powerToDelete)
    {
        switch (powerToDelete.GetComponent<MeshRenderer>().sharedMaterial.name)
        {
            case "MAT_Red (Instance)":
                powerToDelete.GetComponent<RedPowerupScript>().UnApplyExtraPower();
                Debug.Log("Deleted Red");
                break;
            case "MAT_Blue (Instance)":
                powerToDelete.GetComponent<BluePowerupScript>().UnApplyExtraPower();
                Debug.Log("Deleted Blue");
                break;
            case "MAT_White (Instance)":
                powerToDelete.GetComponent<WhitePowerupScript>().UnApplyExtraPower();
                Debug.Log("Deleted White");
                break;
            case "MAT_Brown (Instance)":
                powerToDelete.GetComponent<BrownPowerupScript>().UnApplyExtraPower();
                Debug.Log("Deleted Brown");
                break;
            case "Lit (Instance)":
                Destroy(powerToDelete.gameObject);
                Debug.Log("ez?");
                break;
        }
    }

    public IEnumerator BlueTimer()
    {
        if (CanUseBlue)
        {
            yield return new WaitForSeconds(MaxBlueTime);
            CanUseBlue = false;
            player._protectionSphere.SetActive(false);
            yield return null;
        }
        if (!CanUseBlue)
        {
            yield return new WaitForSeconds(5);
            CanUseBlue = true;
            yield return null;
        }
        yield return null;
    }
}
