using GameFramework;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace GameFrameworkExample
{
    public class ProcedureLogin : ProcedureBase
    {
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            string welcomeMessage = Utility.Text.Format("弹出登录界面.", Version.GameFrameworkVersion);
            Log.Debug(welcomeMessage);
            base.OnEnter(procedureOwner);

        }

    }
}
