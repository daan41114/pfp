using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField]
    private bool _isbuildable;
    public bool GetIsBuildable()
    {
        return _isbuildable;
    }
}
