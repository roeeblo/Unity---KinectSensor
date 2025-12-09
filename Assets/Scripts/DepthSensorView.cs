using UnityEngine;

public class DepthZonesView : MonoBehaviour
{
	public DepthSourceManager depthManager;

	private Texture2D _texture2d;
	private Renderer _render;

	void Start()
	{
		_texture2d = new Texture2D(512, 424, TextureFormat.RGBA32, false);
		_render = GetComponent<Renderer>();
	}

	void Update()
	{
		ushort[] _depthData = depthManager.GetData();
		if (_depthData == null) return;

		Color32[] pixels = new Color32[_depthData.Length];

		for (int i = 0; i < _depthData.Length; i++)
		{

			if (_depthData[i] >= 1000 && _depthData[i] <= 1500)
			{
				pixels[i] = new Color32(255, 0, 0, 255);
			}
			else if (_depthData[i] > 1500 && _depthData[i] <= 2000)
			{
				pixels[i] = new Color32(0, 255, 0, 255);
			}
			else
			{
				pixels[i] = new Color32(0, 0, 0, 255);
			}
		}

		_texture2d.SetPixels32(pixels);
		_texture2d.Apply();
		_render.material.mainTexture = _texture2d;
	}

}
