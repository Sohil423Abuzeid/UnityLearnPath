using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRig;
    private GameObject focalPoint;
    private bool hasPowerUp=false;
    private GameObject powerUpRing;
    // Start is called before the first frame update
    void Start()
    {
        playerRig = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("PlatformCenter");
        powerUpRing = transform.Find("powerUpRing").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        float forward = Input.GetAxis("Vertical");
        playerRig.AddForce(focalPoint.transform.forward*forward*1);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag(Tags.PowerUp.ToString()))
        {
            Destroy(other.gameObject);
            hasPowerUp = true;
            powerUpRing.SetActive(true);
            StartCoroutine(PowerupCountdownRoutine());
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (hasPowerUp && collision.gameObject.CompareTag(Tags.Enemy.ToString()))
        {
            Vector3 pushDiraction = (collision.gameObject.transform.position- transform.position).normalized;
            Rigidbody enemyRB = collision.gameObject.GetComponent<Rigidbody>();

            enemyRB.AddForce(pushDiraction*50f,ForceMode.Impulse);
        }

    }
    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        powerUpRing.SetActive(false);
        hasPowerUp = false;
    }
}
