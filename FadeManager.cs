using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeManager : MonoBehaviour { // ここでゲームオーバー処理とクリア処理

	// ---------------------------

	/// <summary>
	/// 基本的にenableFadeをtrueにしたあと、したいフェードのboolをtrueに変える
	/// </summary>
	public bool enableFade = false;
	public bool enableFastFade;
	public bool enableEndFade = false;
	public bool enableDeathEnd = false;
	public bool enableFadeOn = false;

	public float speed = 0.02f;

	public Image FadeImage;

	private float count = 1f;

	private bool enableAlphaTop = false;

	// ---------------------------

	void Start () {
		enableFade = true;
		enableFastFade = true;
		setAlpha (FadeImage, count);
	}

	void Update () {

		if (enableFadeOn) {
			FadeInAndOut (FadeImage);
		}
		
		if (enableFastFade) {
			FadeIn (FadeImage);
		}

		if (enableEndFade) {
			FadeOut (FadeImage);
		}
	}

	void setAlpha(Image image,float alpha) {
		image.color = new Color (image.color.r, image.color.g, image.color.b, alpha);
	}

	public void FadeOut(Image image) {
		if (enableFade) {
			count += speed;
			setAlpha (image, count);
			if (image.color.a >= 1f) {
				enableFade = false;
				if (enableEndFade) {
					SceneManager.LoadScene (1);
				} 
			}
		}
	}

	void FadeIn(Image image) {
		if (enableFade) {
			count -= speed;
			setAlpha (image, count);
			if (image.color.a <= 0f) {
				enableFade = false;
				enableFastFade = false;
			}
		}
	}

	void FadeInAndOut(Image image) {

		if (enableFade) {
			if (!enableAlphaTop) {
				count += speed;
			} else {
				count -= speed;
				if (image.color.a <= 0f) {
					enableFade = false;
					enableFadeOn = false;
					enableAlphaTop = false;
				}
			}
			setAlpha (image, count);
			if (image.color.a >= 1f) {
				enableAlphaTop = true;
			}
		}
	}
}
