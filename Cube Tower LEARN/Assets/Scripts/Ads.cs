using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class Ads : MonoBehaviour
{
    private string gameId = "3587398", type = "Banner_Android";

  /*  В type : nterstitial_Android или
Rewarded_Android или
Banner_Android*/

    private bool testMode = true, stop;
    private Coroutine ShowAd;

    private static int countLoses;

    private void Start()
    {
        Advertisement.Initialize(gameId, testMode);

        countLoses++;
        if (countLoses % 3 == 0)
            ShowAd = StartCoroutine(showAd());
    }

    private void Update()
    {
        if (stop)
        {
            stop = false;
            StopCoroutine(ShowAd);
        }
    }

    IEnumerator showAd()
    {
        while (true)
        {
            if (Advertisement.IsReady(type))
            {
                Advertisement.Show(type);
                stop = true;

            }

            yield return new WaitForSeconds(1f);

        }
    }
}