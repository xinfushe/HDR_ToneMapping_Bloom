﻿using UnityEngine;
using System;

[ExecuteInEditMode, ImageEffectAllowedInSceneView]
public class BloomEffect : MonoBehaviour {

	void OnRenderImage (RenderTexture source, RenderTexture destination) {
		Graphics.Blit(source, destination);
	}
}