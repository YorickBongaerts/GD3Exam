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
    private float DistanceToClosestPoint = 100;
    private GameObject ClosestPoint;
    public void OnInput(InputAction.CallbackContext context)
    {
        Debug.Log(context.ReadValue<Vector2>());
    }
    void SwapInput()
    {
        if (!ShouldSwap)
            return;

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
    public void OnRightStickInput(InputAction.CallbackContext context)
    {
        if (!ShouldSwap)
            return;

        Vector2 input = context.ReadValue<Vector2>();
        //Debug.Log(input + "raw");
        input = input.normalized;
        //Debug.Log(input + "normalized");
        if (input.x == 0 && input.y == 0)
            return;
        _pressedButton = gameCanvas.PowerUpUICollection.IndexOf(CheckClosestPoint(input)) + 1;
        SwapInput();
    }

    private GameObject CheckClosestPoint(Vector2 input)
    {
        DistanceToClosestPoint = 100;
        ClosestPoint = null;
        //Debug.Log(input);
        foreach (GameObject point in gameCanvas.PowerUpUICollection)
        {
            Vector2 normalizedLocalPointPosition = point.transform.GetComponent<RectTransform>().localPosition.normalized;
            float distance = new Vector2(normalizedLocalPointPosition.x - input.x, normalizedLocalPointPosition.y - input.y).magnitude;
            if (distance < DistanceToClosestPoint)
            {
                DistanceToClosestPoint = distance;
                ClosestPoint = point;
            }
        }
        return ClosestPoint;
    }
}
