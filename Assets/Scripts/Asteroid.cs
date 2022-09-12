using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed = 3f;
    
    public GameObject asteroid;

    private void Start()
    {
        speed = Random.Range(1f, 3f);
    }

    public void Update()
    {
        MoveDirection( );
        MoveRotation( );
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "deathzone" || other.tag == "Player")
            Destroy(gameObject);
    }

    public void RandomSpawn(Transform newPosition)
    {
        Vector2 randomObjectSpawn = new Vector2(10f, Random.Range(-2.5f, 4f));
        GameObject newAsteroid = Instantiate(asteroid, randomObjectSpawn, Quaternion.identity);
        newAsteroid.transform.parent = newPosition;
    }

    public void MoveDirection()
    {
        Vector2 randomObjectDirection = transform.position; //direction speed
        randomObjectDirection.x -= Time.deltaTime * speed;
        transform.position = randomObjectDirection;
    }
    
    public void MoveRotation()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * 30f);
    }

}
