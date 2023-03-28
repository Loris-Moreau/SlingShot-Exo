using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    ThirdPersonController TPC;

    public static Player Instance;

    public GameObject loseText;
    public GameObject winText;

    void Awake()
    {
        if (Instance) Destroy(this);
        else Instance = this;
    }

    private void Start()
    {
        TPC = GetComponent<ThirdPersonController>();
    }

    void Update()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Enemy"))
        {
           //Enemy hit
        }
    }
}

