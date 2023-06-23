using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    private readonly int platformCount = 20;
    private Platform lastPlatform;

    [SerializeField] private Platform firstPlatform;
    [SerializeField] private float maxHeight = 2;
    [SerializeField] private float maxWeight = 3.5f;
    [SerializeField] private float minHeight = 4;
    [SerializeField] private Platform[] platformShapes;

    private void Start()
    {
        lastPlatform = firstPlatform;
        GeneratePlatforms();
    }

    private void GeneratePlatforms()
    {
        for (int i = 0; i < platformCount; i++)
        {
            var position = GetNextPosition();

            int platformShape = Random.Range(0, platformShapes.Length);
            Platform newPlatform = platformShapes[platformShape];
            lastPlatform = Instantiate(newPlatform, position, Quaternion.identity);
            lastPlatform.SetOriginPosition(position);
        }
    }

    private Vector3 GetNextPosition()
    {
        var xPosition = Random.Range(-maxWeight, maxWeight);
        var yPosition = Random.Range(minHeight, maxHeight);
        return new Vector3(xPosition, lastPlatform.transform.position.y + yPosition, 0);
    }

    private void MovePlatform(Platform platform)
    {
        platform.transform.position = GetNextPosition();
        lastPlatform = platform;
        platform.SetOriginPosition(platform.transform.position);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            MovePlatform(collision.gameObject.GetComponent<Platform>());
        }
    }
}