using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : Singleton<Sound>
{
	#region 常量
	#endregion

	#region 事件
	#endregion

	#region 字段
	public string RescousePath = "";
	AudioSource m_BgSource;
	AudioSource m_EffectSource;

    #endregion

   
    #region 属性
	public float BackgoundVolume
	{
		set{m_BgSource.volume = value;}
		get{return m_BgSource.volume;}
	}
	public float EffectVolume
	{
		set{m_EffectSource.volume = value;}
		get{return m_EffectSource.volume;}
	}
    #endregion

    #region 方法
	public void PlayBgMusic(string audioTitle)
	{
		//之前播放的音效名称
		string oldTitle;
		//如果播放的音效为空, 则
		if(m_BgSource.clip == null)
		{
			oldTitle = "";
		}
		else
		{
			oldTitle = m_BgSource.clip.name;
		}

		//如果当前正在播放的鱼传入的不一样. 则播放传入的
		if(oldTitle != audioTitle)
		{
			//拼接文件路径
			string path;;
			if(string.IsNullOrEmpty(RescousePath))
			{
				path = "";
			}
			else
			{
				path = RescousePath + "/" + audioTitle;
			}

			//加载文件
			AudioClip clip = Resources.Load<AudioClip>(path);

			//播放文件
			 if (clip != null)
			 {
				 m_BgSource.clip = clip;
				 m_BgSource.Play();
			 }

		}
	}

	public void PauseBgMusic()
	{
		m_BgSource.Stop();
		m_BgSource.clip = null;
	}
	
	public void PlayEffecSound(string audioName)
	{
		// 拼接文件的路径
		 string path;

		 if (string.IsNullOrEmpty(RescousePath))
		 {
			 path = audioName;
		 }
		 else
		 {	
			 path = RescousePath + "/" + audioName;
		 }

		AudioClip clip = Resources.Load<AudioClip>(path);
		 m_EffectSource.PlayOneShot(clip);
	}
    #endregion

    #region Unity回调
	protected override void Awake()
	{
		base.Awake();

		//动态添加
		m_BgSource = this.gameObject.AddComponent<AudioSource>();
		m_BgSource.playOnAwake = false;
		m_BgSource.loop = true;

		m_EffectSource = this.gameObject.AddComponent<AudioSource>();

	}
    #endregion

    #region 事件回调
    #endregion

    #region 帮助方法
    #endregion
}
