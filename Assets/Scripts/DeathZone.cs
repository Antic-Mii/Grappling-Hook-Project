using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    [SerializeField] private Transform player;

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }
    // next step, make the player when hits collider, reload/restart the scene
}
