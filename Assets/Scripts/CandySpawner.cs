using System.Collections;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    public GameObject[] Candies;

    [SerializeField] 
    private float maxX;
    
    [SerializeField]
    private float SpawnInterval;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SpawnCandy();
        StartSpawningCandies(); 
    }

    void SpawnCandy()
    {
        int rand = Random.Range(0, Candies.Length);

        float randomX = Random.Range(-maxX, maxX);

        Vector3 randomPos = new Vector3(randomX, transform.position.y, transform.position.z);

        Instantiate(Candies[rand], randomPos, transform.rotation);
    }

    IEnumerator SpawnCandies()
    {

        yield return new WaitForSeconds(2f);

        while (true)
        {
            SpawnCandy();
            yield return new WaitForSeconds(SpawnInterval);
        }
    }

    public void StartSpawningCandies()
    {
        StartCoroutine(SpawnCandies());
    }
    public void StopSpawningCandies()
    {
        StopCoroutine(SpawnCandies());
    }

}
