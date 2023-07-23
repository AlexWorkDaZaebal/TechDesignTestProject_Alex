using UnityEngine;

public class UI_Anim_Buttons : MonoBehaviour
{
    [SerializeField] Animator Anim1;

    public void Anim_Buttons()
    {
        Anim1.SetTrigger("Shake");
    }

}
