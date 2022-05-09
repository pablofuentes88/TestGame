using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorSelected : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().SetFloat("Blend", StateController.animationSelected);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
