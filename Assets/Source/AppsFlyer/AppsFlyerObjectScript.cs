using AppsFlyerSDK;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AppsFlyer
{
    public class AppsFlyerObjectScript : MonoBehaviour, IAppsFlyerConversionData
    {
        [SerializeField] private TMP_Text _conversionData;
        [SerializeField] private Image _mainImage;
        
        private void Start()
        {
            AppsFlyerSDK.AppsFlyer.initSDK("ZLigGqGzDdxGMT7QBPjsMG", "com.testtask.flappybird", this);
            AppsFlyerSDK.AppsFlyer.startSDK();
        }

        public void onConversionDataSuccess(string conversionData)
        {
            AppsFlyerSDK.AppsFlyer.AFLog("onConversionDataSuccess", conversionData);
            var conversionDataDictionary = AppsFlyerSDK.AppsFlyer.CallbackStringToDictionary(conversionData);

            _conversionData.text = conversionDataDictionary.ToString();
            _mainImage.gameObject.SetActive(true);
        }

        public void onConversionDataFail(string error)
        {

        }

        public void onAppOpenAttribution(string attributionData)
        {

        }

        public void onAppOpenAttributionFailure(string error)
        {

        }
    }
}