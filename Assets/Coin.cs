using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 50f;
    [SerializeField] private float floatAmp = 0.2f;
    [SerializeField] private float floatSpeed = 2f;

    public GameManager gm;

    private Vector3 startPos; // starting position
    
    void Start()
    {
        startPos = transform.position;
    }

    
    void Update()
    {
        // Rotate the coin
        //transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);

        // Floating effect
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatAmp;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //GameManager.instance.AddScore(1); // Add to score
            gm.incrementScore();
            Destroy(gameObject); // Remove coin
        }
        
    }
}
