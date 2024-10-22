using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeReference] Animator Door;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            print("Open door!");
            Door.SetBool("IsOpen", true);
        }
    }
        private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player")){
            print("Close door!");
            Door.SetBool("IsOpen", false);
        }
    }
}
