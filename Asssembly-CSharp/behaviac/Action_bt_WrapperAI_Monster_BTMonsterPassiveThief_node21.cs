using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Action_bt_WrapperAI_Monster_BTMonsterPassiveThief_node21 : Action
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((ObjAgent)pAgent).ShowHeadExclamationMark();
			return EBTStatus.BT_SUCCESS;
		}
	}
}