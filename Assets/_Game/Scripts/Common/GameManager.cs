using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Sirenix.OdinInspector;
public enum GAME_STATE
{
    DEFAULT,
    START,
    RUNNING,
    END,
    REVIVE,
    PAUSE,
    INREVIEW
}
public enum END_STATE
{
    WIN,
    LOSE
}
public class GameManager : MonoSingleton<GameManager>
{
    [SerializeField] private GAME_STATE m_game_state = GAME_STATE.DEFAULT;

    public GAME_STATE GAME_STATE
    {
        get
        {
            return this.m_game_state;
        }
        set
        {
            this.m_game_state = value;
            switch (this.m_game_state)
            {
                case GAME_STATE.DEFAULT:
                    m_StateMachine.ChangeState(GM_DefaultState.Instance);
                    break;
                case GAME_STATE.START:
                    m_StateMachine.ChangeState(GM_StartState.Instance);
                    break;
                case GAME_STATE.RUNNING:
                    m_StateMachine.ChangeState(GM_RunningState.Instance);
                    break;
                case GAME_STATE.END:
                    m_StateMachine.ChangeState(GM_EndState.Instance);
                    break;
                case GAME_STATE.REVIVE:

                    break;
                case GAME_STATE.PAUSE:

                    break;
                case GAME_STATE.INREVIEW:

                    break;
                default:

                    break;
            }
        }
    }
    protected StateMachine<GameManager> m_StateMachine;
    protected override void Awake()
    {
        base.Awake();
        m_StateMachine = new StateMachine<GameManager>(this);
    }
    #region STATE MACHINE CALLBACK
    public virtual void OnDefaultEnter()
    {

    }
    public virtual void OnDefaultExecute()
    {

    }
    public virtual void OnDefaultExit()
    {
    }

    public virtual void OnStartEnter()
    {

    }
    public virtual void OnStartExecute()
    {

    }
    public virtual void OnStartExit()
    {
    }
    public virtual void OnRunningEnter()
    {

    }
    public virtual void OnRunningExecute()
    {

    }
    public virtual void OnRunningExit()
    {
    }
    public virtual void OnEndEnter()
    {

    }
    public virtual void OnEndExecute()
    {

    }
    public virtual void OnEndExit()
    {
    }
    #endregion
}
