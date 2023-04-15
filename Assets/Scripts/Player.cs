using StarterAssets;
using UnityEngine;

public class Player : MonoBehaviour
{
    ThirdPersonController TPC;

    public static Player Instance;

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
}

