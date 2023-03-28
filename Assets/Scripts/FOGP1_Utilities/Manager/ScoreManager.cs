using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FOGP1_Utilities.Manager
{
    public class ScoreManager : MonoBehaviour
    {
        public static ScoreManager instance;
        public UpdateScoreEvent updateScore;
        public int score { get; set private; }
        public int multiplier { get; set private; }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            score = 0;
            Destroy(this);
            return;
        }

        score = 0;
        multiplier = 1;
        
        if (UpdateScore == null)
        {
        UpdateScore = new UpdateScoreEvent();
        }
}

}

    public class ScoreInfo
    {
        public int score;
        public int delta;
        public Vector3? location;

        public ScoreInfo(int _score, int _delta, Vector3? _location)
        {
            socre = _score;
            delta = _delta;
            location = _location;


        }
    }

    [System.Serializable]
    public class UpdateScoreEvent : UnityEngine.Events.UnityEvent<ScoreInfo> {}
}