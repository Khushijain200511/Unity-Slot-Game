using UnityEngine;
using System.Collections;

public class Reel : MonoBehaviour
{
    public Symbol[] symbols;

    public float spinTime = 2f;

    private Symbol currentSymbol;

    public IEnumerator Spin()
    {
        float timer = 0;

        while(timer < spinTime)
        {
            int randomIndex = Random.Range(0, symbols.Length);

            currentSymbol = symbols[randomIndex];

            // Update displayed symbol here

            timer += Time.deltaTime;

            yield return null;
        }
    }


    public string GetResult()
    {
        return currentSymbol.symbolName;
    }
}
