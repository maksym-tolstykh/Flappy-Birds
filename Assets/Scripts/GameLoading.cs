using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameLoading : MonoBehaviour
{
	public int idScene;
	public Image image;
	public Text loatTxt;

	private void Start()
	{
		StartCoroutine(LoadScen());//начать выполнение комнати Лоад сцен
	}

	IEnumerator LoadScen()
	{
		AsyncOperation operation = SceneManager.LoadSceneAsync(idScene);//загрузка сцени
		while (!operation.isDone)//пока сцена не загрузилась
		{
			float progress = operation.progress / 0.9f;
			//image.fillAmount = progress;
			loatTxt.text = string.Format("{0:0}%", progress * 100);
			yield return null;
		}
	}
}