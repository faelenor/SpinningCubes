using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureSequence : MonoBehaviour {

    public Texture2D[] textures;
    public Material material;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int numTextures = textures.Length;

        if (numTextures == 0)
            return;
        
        material.mainTexture = textures[(int)Mathf.Abs(Time.time * 10) % numTextures];
    }
}
