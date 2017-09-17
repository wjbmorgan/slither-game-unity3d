using UnityEngine;
using UnityEngine.Advertisements;

public class OpenAds : MonoBehaviour
{
	public void ShowAd()
	{
		if (Advertisement.IsReady())
		{
			Advertisement.Show();
		}
	}
}

