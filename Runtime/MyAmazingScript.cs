using TMPro;
using UnityEngine;

namespace HunterGoodin.CentralAudio
{
	public class MyAmazingScript : MonoBehaviour
	{
		[SerializeField] private TextMeshProUGUI numTMP;
		[SerializeField] private int num = 0;

		public void ChangeNum(int passed)
		{
			num += passed;
			numTMP.text = $"{num}";
			Debug.Log($"Num chanegd to {num}");
		}

		public void QuitGame()
		{
			Application.Quit();
		}
	}
}