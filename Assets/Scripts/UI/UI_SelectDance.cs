using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_SelectDance : MonoBehaviour
{
    public Animator animator;

    private const float MACARENA = 0f;
    private const float HOUSE = 1f;
    private const float WAVE = 2f;

    private float newState;
    private float blendTransition = 0.0f;
    private float blendAcceleration = 0.3f;
    bool activeTrigger = false;

    public void Update()
    {
        if (activeTrigger)
            Trigger();

        animator.SetFloat("Blend", blendTransition);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MacarenaAnim()
    {
        ChangeAnimationState(MACARENA);
    }

    public void HouseAnim()
    {
        ChangeAnimationState(HOUSE);
    }

    public void WaveHipHopAnim()
    {
        ChangeAnimationState(WAVE);
    }

    public void ChangeAnimationState(float newState)
    {
        if (blendTransition == newState) return;
        this.newState = newState;
        activeTrigger = true;
    }

    private void Trigger()
    {
        if (blendTransition < newState) blendTransition += Time.deltaTime * blendAcceleration;
        if (blendTransition > newState) blendTransition -= Time.deltaTime * blendAcceleration;
    }


}
