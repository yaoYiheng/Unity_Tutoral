﻿using UnityEngine;  
using System.Collections;  
using UnityEditor;  
  
public class AutoSetTextureUISprite :AssetPostprocessor   
{  
  
    void OnPreprocessTexture()  
    {  
  
        //自动设置类型;  
        TextureImporter textureImporter = (TextureImporter)assetImporter;  
        textureImporter.textureType=TextureImporterType.Sprite;  
  
        //自动设置打包tag;  
        string dirName = System.IO.Path.GetDirectoryName(assetPath);  
        Debug.Log("Import ---  "+dirName);  
        string folderStr = System.IO.Path.GetFileName(dirName);  
        Debug.Log("Set Packing Tag ---  "+folderStr);  
  
        textureImporter.spritePackingTag = folderStr;  
    }  
} 