using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    public GameObject powerPanel;


    Throwable current;
    float flingPower;

    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance == this)
        {
            Destroy(gameObject);
        }
    }

    public void MakeCurrent(Throwable newCurrent)
    {
        current = newCurrent;
        powerPanel.SetActive(true);

        // Add a fling direction indicator
        
    }

    public void SetPower(float newPower)
    {
        flingPower = newPower;
    }


}
