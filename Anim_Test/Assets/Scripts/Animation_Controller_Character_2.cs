using UnityEngine;

public class Animation_Controller_Character_2 : MonoBehaviour
{
    [SerializeField] string NamePos = "";
    [SerializeField] bool ExitAnim = false;
    [SerializeField] GameObject Button;

    private Animator Anim;

    private void Start()
    {
        Anim = GetComponent<Animator>();

        if (ExitAnim)
        {
            Anim.SetBool("Exit", true);
        }
    }

    private void OnMouseDown()
    {
        Anim.SetTrigger(NamePos);
        Button.SetActive(true);
    }

}
