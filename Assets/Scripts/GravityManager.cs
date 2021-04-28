using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour
{
    private float _baseGravity = 9.81f;
    public static void ChangeGravity(float modifier)
    {
        Physics.gravity += new Vector3(0,-modifier,0);
    }
}
