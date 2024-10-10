using UnityEngine;

public class Game : MonoBehaviour
{
    float timePlaying;
    int eventNumber;
    [SerializeField] GameObject player;

    void Update()
    {
        timePlaying += Time.deltaTime;
        if (timePlaying > 2 && eventNumber == 0)
        {
            eventNumber++;
            player.GetComponent<Lipsync>().Play(0);
        }
        if (timePlaying > 12 && eventNumber == 1)
        {
            eventNumber++;
            player.GetComponent<Lipsync>().Play(1);
        }
    }
}
