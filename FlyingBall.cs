using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBall : MonoBehaviour
{
    public GameObject cannonball;
    public float cannonballSpeed = 20;
    public  GameObject pof;
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Start script");
        Shoot();
    }
    public void Shoot()
    {
        Debug.Log("Shoot");
        GameObject ball = Instantiate(cannonball, pof.transform.position, Quaternion.identity);

        Rigidbody rb = ball.AddComponent<Rigidbody>();

        rb.velocity = cannonballSpeed * pof.transform.forward;

        StartCoroutine(RemoveCannonball(ball));
    }

    IEnumerator RemoveCannonball(GameObject ball)
    {

        yield return new WaitForSeconds(2f);
        Destroy(ball);

        Debug.Log("Remove cannonball");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
