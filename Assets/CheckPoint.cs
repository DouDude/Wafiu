using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public static CheckPoint Instance { get; private set; }

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject currentCheckPoint;
    [SerializeField] private float deathHeight = -10f;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            currentCheckPoint = gameObject;
        }
    }

    public void RespawnPlayer()
    {
        if (currentCheckPoint != null)
        {
            player.transform.position = currentCheckPoint.transform.position;
        }
        else
        {
            player.transform.position = Vector3.zero;
        }
    }

    private void Update()
    {
        if (player.transform.position.y < deathHeight)
        {
            RespawnPlayer();
        }
    }
}