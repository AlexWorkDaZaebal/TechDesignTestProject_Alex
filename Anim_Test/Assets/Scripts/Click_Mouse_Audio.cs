using UnityEngine;

public class Click_Mouse_Audio : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] AudioClip audioClip;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}
