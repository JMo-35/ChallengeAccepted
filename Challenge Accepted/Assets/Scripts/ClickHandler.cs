using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ClickHandler : MonoBehaviour
{
    private Button thisButton;
    public GameObject nextScreen;
    void Start()
    {
        thisButton = GetComponent<Button>();
    }

    public void LoadNextScreen()
    {
        nextScreen.SetActive(true);
        transform.parent.gameObject.SetActive(false);
    }
}
