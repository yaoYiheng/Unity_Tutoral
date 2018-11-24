using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : Singleton<Sound>
{

    public string ResoursePath = "";

    public float BgVolume
    {
        get { return BgVolume; }
        set { BgVolume = value; }
    }

    public float EffectVolume
    {
        get { return EffectVolume; }
        set { EffectVolume = value; }
    }

    private AudioSource BgAudioSource;
    private AudioSource EffectSource;


    protected override void Awake()
    {
        base.Awake();

        //动态为 脚本将要附着的组件 添加音频组件

        BgAudioSource = this.gameObject.AddComponent<AudioSource>();
        BgAudioSource.playOnAwake = false;
        BgAudioSource.loop = true;

        EffectSource = this.gameObject.AddComponent<AudioSource>();

    }

    //播放音乐
    public void PlayBgSound(string sound)
    {

        //获取当前正在播放的音乐文件
        string currentSound;
        if (BgAudioSource.clip == null)
            currentSound = "";
        else
            currentSound = BgAudioSource.clip.name;

        //如果当前播放音乐不等于传入进来的音乐.则播放新的音乐
        if(currentSound != sound)
        {
            //获取路径
            string path = "";
            if (string.IsNullOrEmpty(sound))
            {
                path = "";
            }
            else
            {
                path = ResoursePath + "/" + sound;
            }

            AudioClip clip = Resources.Load<AudioClip>(path);

            BgAudioSource.clip = clip;
            BgAudioSource.Play();
        }



    }
    //停止播放
    public void StopSound()
    {
        BgAudioSource.Stop();
        BgAudioSource.clip = null;
    }

    //播放音效
    public void PlayEffectSound(string sound)
    {
        //获取路径
        string path = "";
        if (string.IsNullOrEmpty(sound))
        {
            path = "";
        }
        else
        {
            path = ResoursePath + "/" + sound;
        }

        //获取clip
        AudioClip clip = Resources.Load<AudioClip>(path);

        //播放
        EffectSource.PlayOneShot(clip);
        //EffectSource.clip = clip;
        //EffectSource.Play();

    }
}