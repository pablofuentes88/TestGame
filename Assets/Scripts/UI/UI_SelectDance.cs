using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_SelectDance : MonoBehaviour
{
    public Animator animator;

    private const float MACARENA = 0f;
    private const float HOUSE = 1f;
    private const float WAVE = 2f;

    private float newState = 0.0f;
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
        StateController.animationSelected = this.newState;
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
        //GameObject.Find("ely_k_atienza").GetComponent<AnimatorSelected>().ANIMATED_SELECTED = newState;
    }

    private void Trigger()
    {
        if (blendTransition < newState) blendTransition += Time.deltaTime * blendAcceleration;
        if (blendTransition > newState) blendTransition -= Time.deltaTime * blendAcceleration;
    }


}
