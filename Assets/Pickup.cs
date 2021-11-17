using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    GameObject playerObject;
    CharacterController playerScript;

    private void OnTriggerEnter(Collider other)
    {

        playerScript.AddGem(1);
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");
        playerScript = playerObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
