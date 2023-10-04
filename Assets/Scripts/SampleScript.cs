using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GoogleAdmobController.s_Instance.ShowAdBannerAd();
        GoogleAdmobController.s_Instance.ShowAdInterstitial();
        GoogleAdmobController.s_Instance.ShowAdRewardedAd(OnRewarded);
    }

    private void OnRewarded()
    {
        // Reward User with some thing
    }
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
