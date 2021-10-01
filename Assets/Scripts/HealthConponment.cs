using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthConponment : MonoBehaviour
{
    [SerializeField] private float _startHelth;
    private float _currentHelth;
    public float CurrentHealth
    
    {
        get { return _currentHelth; }
    }
    private void Awake()
    {
        _currentHelth = _startHelth;
    }

    
    public void TakeDamage(float amount)
    {
        _currentHelth -= amount;

        HandleTakeDamage();
        if (_currentHelth <= 0)
        {
            Death();
        }

    }
    protected virtual void HandleTakeDamage()
    {
        print("i take damage");
    }
    private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                TakeDamage(1);
            }
        }
    protected virtual void Death()
    {
        print("ded");
        Destroy(this.gameObject);
    }
}
