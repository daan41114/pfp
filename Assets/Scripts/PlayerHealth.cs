using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : HealthConponment
{
    [SerializeField] private PlayerHealthUI _playerHealthUI;

    private void Start()
    {
        _playerHealthUI.UpdateUI(CurrentHealth);
    }
    protected override void HandleTakeDamage()
    {
        base.HandleTakeDamage();
        _playerHealthUI.UpdateUI(CurrentHealth);
    }

    protected override void Death()
    {
        base.Death();
        print("Laad levels in, of game mune");
    }
}
