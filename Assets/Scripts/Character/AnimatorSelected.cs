using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorSelected : MonoBehaviour
{
    public static float ANIMATED_SELECTED = 1;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().SetFloat("Blend", ANIMATED_SELECTED);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
