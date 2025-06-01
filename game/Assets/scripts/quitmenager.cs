using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class quitmenu : MonoBehaviour
{
    public GameObject quitbutton; 

    void Start()
    {
        quitbutton.SetActive(false);
        StartCoroutine(ActivateAfterSeconds(10f));
    }

    IEnumerator ActivateAfterSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (quitbutton != null)
        {
            quitbutton.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Nie przypisano obiektu do aktywacji!");
        }
    }

    public void quitgame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
