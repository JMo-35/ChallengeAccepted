using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temp_User : MonoBehaviour
{
    public Text level, currentChallenge;
    private int lvl = 3;
    public Loader load;

    private void Start()
    {
        level.text = lvl.ToString();
        currentChallenge.text = load.GetRandomChallenge(lvl);
    }
}
