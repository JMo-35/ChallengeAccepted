using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

public class Loader : MonoBehaviour
{

    XDocument xmlDoc;
    IEnumerable<XElement> items; 
    List <XMLData> data = new List <XMLData>();
    private int rank;
    private string challenge;

    void Start()
    {
        DontDestroyOnLoad(gameObject); 
        LoadXML();
        StartCoroutine("AssignData");
    }

    void LoadXML()
    {
        xmlDoc = XDocument.Load("Assets/XML_Data/challenge_accepted_data.xml");
        items = xmlDoc.Descendants("record").Elements();
    }

    IEnumerator AssignData()
    {
        foreach (var item in items)
        {
            rank = int.Parse(item.Parent.Element("rank").Value);
            challenge = item.Parent.Element("challenge").Value.Trim();
            data.Add(new XMLData(rank, challenge));
        }
        yield return null;
    }

    //temporary function
    public string GetRandomChallenge(int level)
    {
        if (level < 1 || level > 10)
        {
            return null;
        }
        List<string> tasks = new List<string>();
        foreach (var task in data)
        {
            if (task.rankNum == level)
            {
                tasks.Add(task.challengeText);
            }
        }
        string choice = tasks[Random.Range(0, tasks.Count)];
        return choice;
    }
}

public class XMLData
{
    public int rankNum;
    public string challengeText;

    public XMLData (int rank, string challenge)
    {
        rankNum = rank;
        challengeText = challenge;
    }
}