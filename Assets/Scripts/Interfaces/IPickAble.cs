using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IPickAble: MonoBehaviour
{
    public int ID;
    public string Name;

    public abstract void OnPickUp();

}
