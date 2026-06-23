using UnityEngine;
using System.Collections;

public class SlotMachine : MonoBehaviour
{

    public Reel[] reels;

    public int payout = 100;


    public void StartSpin()
    {
        StartCoroutine(SpinReels());
    }


    IEnumerator SpinReels()
    {

        foreach(Reel reel in reels)
        {
            StartCoroutine(reel.Spin());

            yield return new WaitForSeconds(0.5f);
        }


        yield return new WaitForSeconds(2);


        CheckResult();

    }



    void CheckResult()
    {

        string first = reels[0].GetResult();


        bool win = true;


        foreach(Reel reel in reels)
        {
            if(reel.GetResult()!=first)
            {
                win=false;
            }
        }


        if(win)
        {
            Debug.Log("WIN! +" + payout);
        }
        else
        {
            Debug.Log("Try Again");
        }

    }

}
