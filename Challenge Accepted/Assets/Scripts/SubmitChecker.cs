using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmitChecker : MonoBehaviour
{
    private GameObject holder;

    private void Start()
    {
        holder = transform.parent.gameObject;
    }
    public void CheckForValidity()
    {
        string un = holder.transform.GetChild(1).GetComponentInChildren<InputField>().text;
        string p1 = holder.transform.GetChild(2).GetComponentInChildren<InputField>().text;
        string p2 = holder.transform.GetChild(3).GetComponentInChildren<InputField>().text;
        string em = holder.transform.GetChild(4).GetComponentInChildren<InputField>().text;
        Debug.Log(un + ", " + p1 + ", " + p2 + ", " + em);
        if (AccountCredentialVerify.NewAccountChecker(un, p1, p2, em) == true)
        {
            Debug.Log("Account created");
            GetComponent<ClickHandler>().LoadNextScreen();
        }
    }

    public void CheckForExistingUser()
    {
        string un = holder.transform.GetChild(1).GetComponentInChildren<InputField>().text;
        string pw = holder.transform.GetChild(2).GetComponentInChildren<InputField>().text;

        // Temporary code for admin access
        if (un.Equals("adm") && pw.Equals("adm"))
        {
            GetComponent<ClickHandler>().LoadNextScreen();
        }
    }
}
