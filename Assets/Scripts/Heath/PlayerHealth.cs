using UnityEngine;

public class PlayerHealth : Health
{
    public static PlayerHealth Instance { get; private set; }

    private void Awake()
    {
        base.Awake();

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }
}