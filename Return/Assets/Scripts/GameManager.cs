using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject[] portraits;
    public HandleTextFile textFileHandler;
    // Start is called before the first frame update
    void Start()
    {
        //textFileHandler.readTextFile("Save");
        Debug.Log(Application.dataPath);
        getPotentialIndexFromFile();
        //test();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void getPotentialIndexFromFile()
    {
        string potentialIndex = textFileHandler.readTextFile(Application.dataPath + "/Resources/Save.txt");

        if (potentialIndex == null)
        {
            GetNewIndex();
        }
        else
        {
            activatePortrait(System.Convert.ToInt32(potentialIndex));
        }
    }

    void test()
    {
        int index = Random.Range(0, portraits.Length);
        activatePortrait(index);
    }

    void GetNewIndex()
    {
        int index = Random.Range(0, portraits.Length);
        textFileHandler.writeTextFile(Application.dataPath + "/Resources/Save.txt", index.ToString());
        activatePortrait(index);
    }

    void activatePortrait(int index)
    {
        GameObject portrait = portraits[index];
        portrait.SetActive(true);
    }
}
