using StarterAssets;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rewards rewards;
    //public Enemy enemy;
    ThirdPersonController TPC;

    public static Player Instance;

    [SerializeField] public static int enemyCounter = 0;

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
        if (enemyCounter >= 9)
        {
            rewards.Won();
        }
	}
}
