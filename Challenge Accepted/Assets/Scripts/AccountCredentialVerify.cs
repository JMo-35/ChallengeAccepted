using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccountCredentialVerify
{
    public static bool NewAccountChecker(string u, string p1, string p2, string e)
    {
        if (u != "" && p1 != "" && p2 != "")
        {
            if (u.Length < 8)
            {
                Debug.LogWarning("UserName must be at least 8 characters.");
                return false;
            }

            if (p1.Length < 8)
            {
                Debug.LogWarning("Password must be at least 8 characters.");
                return false;
            }

            if (!p1.Equals(p2))
            {
                Debug.LogWarning("The entered passwords do not match.");
                return false;
            }

            if (e!= "" && !e.Contains("@"))
            {
                Debug.LogWarning("The email entered is invalid.");
                return false;
            }

            return true;
        }
        Debug.LogWarning("One or more of the field(s) must be filled out.");
        return false;
    }

    public static bool CreateAccount()
    {
        return true;
    }
}
