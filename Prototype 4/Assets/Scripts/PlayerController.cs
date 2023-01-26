using System;
using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private GameObject focalPoint;
    private Rigidbody playerRb;
    private float powerupStrength = 15;
    private float powerupDuration = 7;
    public bool hasPowerup;
    public GameObject powerupIndicator;

    private void Start()
    {
        focalPoint = GameObject.Find("Focal Point");
        playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        powerupIndicator.gameObject.transform.position = transform.position + new Vector3(0, -0.5f, 0);

        playerRb.AddForce(focalPoint.transform.forward * (speed * verticalInput));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            powerupIndicator.gameObject.SetActive(true);
            StartCoroutine(PowerupCountdownRoutine());
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(powerupDuration);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();

            enemyRb.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }
}