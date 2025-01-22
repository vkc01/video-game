using UnityEngine;

public class BossHP : MonoBehaviour
{
    bool isBlinded;
    bool isPoisoned;
    int countdown;
    //int PoisonedDMG;
    void Start()
    {
        //PoisonedDMG = 0;
        isPoisoned = false;
        isBlinded = false;
    }
    public void Poisoned()
    {
        countdown = 4;
        isPoisoned = true;
    }
    public void Blinded()
    {
        isBlinded = true;
    }
    public void EndOfTurn()
    {
        if (isPoisoned)
        {
            countdown--;
            //PoisonedDMG = 1;
        }
        if (countdown == 0)
        {
            isPoisoned = false;
        }
        if (isBlinded)
        {
            int randomIndex = Random.Range(1, 3);
            if (randomIndex == 1)
            {
                Debug.Log("Boss missed his attack");
            }
            isBlinded = false;
        }
    }
}
