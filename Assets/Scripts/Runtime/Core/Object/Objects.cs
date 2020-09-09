﻿using UnityEngine;
using UnityEngine.Video;

namespace Model
{
    public class Objects
    {
        private static GameObject _gui;
        private static Manager _manager;
        private static AudioSource _audioSource;
        private static VideoPlayer _videoPlayer;
        public static GameObject gui
        {
            get
            {
                if (_gui == null)
                {
                    _gui = GameUtil.GetGameObjectConvertedToTag("GUI");
                }
                return _gui;
            }
        }
        public static Manager manager
        {
            get
            {
                if (_manager == null)
                {
                    GameObject manager = GameUtil.GetGameObjectConvertedToTag("ModelManager");
                    if (manager == null) return null;
                    _manager = GameUtil.GetComponent<Manager>(manager);
                }
                return _manager;
            }
        }
        public static AudioSource audioSource
        {
            get
            {
                if (_audioSource == null)
                {
                    GameObject audiosource = GameUtil.GetGameObjectConvertedToTag("AudioSource");
                    if (audiosource == null) return null;
                    _audioSource = GameUtil.GetComponent<AudioSource>(audiosource);
                }
                return _audioSource;
            }
        }
        public static VideoPlayer videoPlayer
        {
            get
            {
                if (_videoPlayer == null)
                {
                    GameObject videoplayer = GameUtil.GetGameObjectConvertedToTag("AudioSource");
                    if (videoplayer == null) return null;
                    _videoPlayer = GameUtil.GetComponent<VideoPlayer>(videoplayer);
                }
                return _videoPlayer;
            }
        }
    }
}