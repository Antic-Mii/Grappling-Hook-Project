using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    [SerializeField] private Transform player;

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(3);
    }
    // next step, make the player when hits collider, reload/restart the scene
}
