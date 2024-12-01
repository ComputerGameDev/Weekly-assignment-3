using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DestroyOnTrigger : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 3;
    [SerializeField] string triggeringTag;
    [SerializeField] GameObject Bullets;
    [SerializeField] float sceneTransitionDelay = 2f;
    private TextMeshPro tmp;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Triggered by: {other.name}, Tag: {other.tag}");
        if (other.tag == triggeringTag && enabled)
        {
            Debug.Log("Triggering tag matched. Reducing hit points.");
            maxHitPoints--;
            if (tmp != null)
            {
                tmp.text = maxHitPoints.ToString(); // Update the health display
            }
            else
            {
                Debug.LogError("TextMeshPro reference (tmp) is null!");
            }

            Destroy(other.gameObject); // Destroy the bullet

            if (maxHitPoints <= 0)
            {
                Debug.Log($"{this.name} has lost all hit points. Disabling player.");
                gameObject.SetActive(false); // Make the player disappear
                StartCoroutine(HandleGameOver()); // Handle game-over logic
            }
        }
        else
        {
            Debug.LogError($"Triggering tag mismatch: Expected '{triggeringTag}', got '{other.tag}'.");
        }
    }


    private IEnumerator HandleGameOver()
    {
        yield return new WaitForSeconds(sceneTransitionDelay);
        Debug.Log("Game Over. Transitioning to Game Over Scene.");
        SceneManager.LoadScene("GameOverScene"); // Load the Game Over scene
    }


    // Start is called before the first frame update
    void Start()
    {    
        Transform Health = transform.Find("Health");
        if (Health != null){
            tmp = Health.GetComponent<TextMeshPro>();
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}

