using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Problems : MonoBehaviour
{
    public static int Problem = 0;

    public Text haveNote;
    public GameObject Jiyeon;
    public GameObject[] WorkBook;
    public GameObject AnswerBlank;
    public InputField Answer;

    public static int Notes = 0;
    void Update()
    {
        haveNote.text = Notes.ToString();
        if(Problem != 0)
        {
            Jiyeon.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            AnswerBlank.SetActive(true);
            WorkBook[Problem - 1].SetActive(true);
        }
        else
        {
            Jiyeon.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.KeypadEnter) && Answer.text != null && Problem != 0)
        {
            if (Problem == 1)
            {
                if (Answer.text != "2")
                {
                    JiyeonMove.Phase++;
                }
            }
            else if(Problem == 2)
            {
                if(Answer.text != "1")
                {
                    JiyeonMove.Phase++;
                }
            }
            else if (Problem == 3)
            {
                if (Answer.text != "2")
                {
                    JiyeonMove.Phase++;
                }
            }
            else if (Problem == 4)
            {
                if (Answer.text != "3")
                {
                    JiyeonMove.Phase++;
                }
            }
            else if (Problem == 5)
            {
                if (Answer.text != "1")
                {
                    JiyeonMove.Phase++;
                }
            }
            Notes++;
            Answer.text = null;
            AnswerBlank.SetActive(false);
            WorkBook[Problem - 1].SetActive(false);
            Problem = 0;
            Cursor.lockState = CursorLockMode.Locked;           
        }
    }
}
