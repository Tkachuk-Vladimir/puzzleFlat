using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PlaeyrMovemetn : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;
    [SerializeField] KeyCode keyTwo;
    [SerializeField] Vector3 moveDirection;

    private void FixedUpdate()
    {
        if (Input.GetKey(keyOne))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
        if(Input.GetKey(keyTwo))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }
        if(Input.GetKey(KeyCode.R)) //if we press the key R, the level will reload
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
}
