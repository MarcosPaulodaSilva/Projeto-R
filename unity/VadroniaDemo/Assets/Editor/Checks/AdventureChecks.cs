using System;
namespace Vadronia
{
    public static class AdventureChecks
    {
        public static int Run(Action<string> report)
        {
            int count=CoreChecks.Run(report);
            Action<bool,string> require=(ok,name)=>{if(!ok)throw new Exception(name);report("PASS: "+name);count++;};
            var state=new AdventureState();
            require(state.TryDodge()&&!state.TryDodge()&&state.Stamina==76,"Esquiva gasta fôlego uma vez e respeita recarga");
            for(int i=0;i<8;i++)state.Tick(.1f,false);
            require(state.TryDodge(),"Esquiva volta após recarga");
            for(int i=0;i<150;i++)state.Tick(.1f,true);
            require(state.Stamina>=0&&state.Stamina<=100,"Corrida não produz fôlego negativo");
            for(int i=0;i<100;i++)state.Tick(.1f,false);
            require(state.Stamina==100,"Fôlego regenera até o limite");
            require(!state.Gather(0)&&!state.ClaimReward(),"Missão não progride antes da conversa");
            state.AcceptQuest();require(state.Gather(0)&&!state.Gather(0)&&!state.Gather(-1),"Canteiro não pode ser coletado duas vezes");
            state.Gather(1);state.Gather(2);
            require(state.ClaimReward()&&!state.ClaimReward()&&state.Progress.coins==25,"Recompensa concedida exatamente uma vez");
            var restored=new AdventureState();restored.Restore(new AdventureProgress{quest=state.Progress.quest,herbs=state.Progress.herbs,coins=state.Progress.coins});
            require(restored.HerbCount==3&&restored.Progress.quest==2&&!restored.ClaimReward(),"Progresso restaurado não duplica recompensa");
            bool low=true,opposed=true;int left=0,right=0;
            for(int i=0;i<100;i++)
            {
                float phase=i/100f,l=LowStepGait.LeftLift(phase),r=LowStepGait.RightLift(phase);
                low&=l<=.03501f&&r<=.03501f;opposed&=!(l>.00001f&&r>.00001f);
                if(l>.01f)left++;if(r>.01f)right++;
            }
            require(low,"Pés não sobem além de 3,5 centímetros");
            require(opposed&&left>20&&right>20,"Ambas as pernas alternam apoio sem joelho alto");
            return count;
        }
    }
}
