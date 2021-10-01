using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : HealthConponment
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(5);
        }
    }
}
