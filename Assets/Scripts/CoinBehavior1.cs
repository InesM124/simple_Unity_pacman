// using UnityEngine;
// using System.Collections;

// public class Coin : MonoBehaviour
// {
//     public float inactiveDuration = 2f;
//     public float reactivateDuration = 5f;
//     public float rotationSpeed = 50f; // Adjust as needed

//     void Start()
//     {
//         // Randomize initial rotation to add variation
//         transform.rotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
//     }

//     void OnTriggerStay(Collider other)
//     {
//         if (other.CompareTag("Player"))
//         {
//             // Deactivate the coin
//             gameObject.SetActive(false);
//             // Start coroutine to reactivate the coin after inactiveDuration
//             StartCoroutine(ReactivateAfterDelay());
//         }
//     }

//     IEnumerator ReactivateAfterDelay()
//     {
//         // Wait for inactiveDuration
//         yield return new WaitForSeconds(inactiveDuration);
//         // Reactivate the coin
//         gameObject.SetActive(true);
//         // Wait for reactivateDuration
//         yield return new WaitForSeconds(reactivateDuration);
//     }

//     void Update()
//     {
//         // Rotate the coin horizontally (around y-axis)
//         transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
//     }
// }
using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour
{
    public float inactiveDuration = 2f;
    public float reactivateDuration = 5f;
    public float rotationSpeed = 50f; // Adjust as needed
    public string targetTag = "Player"; // Tag of the object you want to detect collisions with

    void Start()
    {
        // Randomize initial rotation to add variation
        transform.rotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            // Deactivate the coin
            gameObject.SetActive(false);
            // Start coroutine to reactivate the coin after inactiveDuration
            StartCoroutine(ReactivateAfterDelay());
        }
    }

    IEnumerator ReactivateAfterDelay()
    {
        // Wait for inactiveDuration
        yield return new WaitForSeconds(inactiveDuration);
        // Reactivate the coin
        gameObject.SetActive(true);
        // Wait for reactivateDuration
        yield return new WaitForSeconds(reactivateDuration);
    }

    void Update()
    {
        // Rotate the coin horizontally (around y-axis)
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
