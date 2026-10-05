using System;
using System.Collections.Generic;
using UnityEngine;
namespace Vadronia
{
    // Low-step gait from neutral art; both legs have independent, opposite phases.
    public sealed class CharacterView : IDisposable
    {
        readonly GameObject root;
        readonly SpriteRenderer still, torso, left, right, shadow;
        readonly Sprite[] idle=new Sprite[4], bodies=new Sprite[4], legsL=new Sprite[4], legsR=new Sprite[4];
        readonly float[] hip=new float[4], bodyBase=new float[4], legX=new float[4];
        readonly List<Sprite> owned=new List<Sprite>();
        readonly VisualLibrary visuals=new VisualLibrary();
        public readonly WalkCycle Cycle=new WalkCycle();
        public FootPoint Position {get;private set;}
        public Vector2 LeftFootOffset {get;private set;}
        public Vector2 RightFootOffset {get;private set;}
        public Transform Transform => root.transform;
        float blend,clock; int direction;
        public CharacterView(string name,FootPoint position,Texture2D walking,Texture2D original,bool conrad)
        {
            root=new GameObject(name); still=root.AddComponent<SpriteRenderer>();
            torso=Part("Corpo"); left=Part("Perna esquerda"); right=Part("Perna direita");
            shadow=visuals.Add(root.transform,"Sombra dos pés",visuals.SoftDisc,Vector2.zero,new Vector2(.9f,.32f),new Color(.08f,.09f,.07f,.7f),-16000);
            var atlas=Resources.Load<Texture2D>("Vadronia/characters-neutral");
            if(atlas==null)throw new InvalidOperationException("Atlas neutro ausente");
            for(int f=0;f<4;f++)
            {
                Rect r=NeutralAtlasLayout.Frames[(conrad?4:0)+f]; float ppu=r.height/(conrad?1.78f:1.65f);
                bool side=f==1||f==3; float cut=Mathf.Floor(r.height*(conrad?.255f:.39f));
                float upperBottom=cut-r.height*.035f; hip[f]=cut/ppu;bodyBase[f]=upperBottom/ppu;
                idle[f]=Slice(atlas,r,new Vector2(.5f,0),ppu);
                bodies[f]=Slice(atlas,new Rect(r.x,r.y+upperBottom,r.width,r.height-upperBottom),new Vector2(.5f,0),ppu);
                if(side)
                {
                    float x=r.x+r.width*(f==1?.14f:.20f),w=r.width*.68f;
                    var rect=new Rect(Mathf.Floor(x),r.y,Mathf.Floor(w),cut);
                    legsL[f]=SideLeg(atlas,rect,ppu,f==3);legsR[f]=SideLeg(atlas,rect,ppu,f==3);legX[f]=0;
                }
                else
                {
                    float w=Mathf.Floor(r.width*.35f);
                    legsL[f]=Slice(atlas,new Rect(r.x+r.width*.15f,r.y,w,cut),new Vector2(.5f,1),ppu);
                    legsR[f]=Slice(atlas,new Rect(r.x+r.width*.5f,r.y,w,cut),new Vector2(.5f,1),ppu);legX[f]=r.width*.175f/ppu;
                }
            }
            Position=position;Place(position);Animate(0,false,false);
        }
        SpriteRenderer Part(string name){var r=new GameObject(name).AddComponent<SpriteRenderer>();r.transform.SetParent(root.transform,false);return r;}
        Sprite Slice(Texture2D a,Rect r,Vector2 p,float ppu){var s=Sprite.Create(a,r,p,ppu,0,SpriteMeshType.FullRect);owned.Add(s);return s;}
        Sprite SideLeg(Texture2D atlas,Rect rect,float ppu,bool mirrored)
        {
            var sprite=Slice(atlas,rect,new Vector2(.5f,1),ppu);
            // Trim the occluded boot from this neutral side pose so each limb shows one foot.
            var shape=new[]{new Vector2(0,0),new Vector2(1,0),new Vector2(1,.20f),new Vector2(.76f,.34f),new Vector2(.72f,.60f),new Vector2(.88f,1),new Vector2(0,1)};
            for(int i=0;i<shape.Length;i++)shape[i]=new Vector2(((mirrored?1-shape[i].x:shape[i].x)-.5f)*rect.width/ppu,(shape[i].y-1)*rect.height/ppu);
            sprite.OverrideGeometry(shape,new ushort[]{0,1,2,0,2,3,0,3,4,0,4,5,0,5,6});
            return sprite;
        }
        public void Face(Vector2 d){if(d.sqrMagnitude>.001f)direction=Mathf.Abs(d.x)>Mathf.Abs(d.y)?(d.x>0?1:3):(d.y>0?2:0);}
        public void Place(FootPoint next)
        {
            float dx=next.X-Position.X,dy=next.Y-Position.Y;Cycle.Advance(dx,dy);if(Cycle.Moving)direction=Cycle.Facing;
            Position=next;root.transform.position=new Vector3(next.X,next.Y,0);
        }
        public void Animate(float dt,bool dodging=false,bool sprinting=false)
        {
            clock+=dt;blend=Mathf.MoveTowards(blend,Cycle.Moving?1:0,dt*12);bool active=blend>.001f;
            still.enabled=!active;torso.enabled=left.enabled=right.enabled=active;
            still.sprite=idle[direction];torso.sprite=bodies[direction];left.sprite=legsL[direction];right.sprite=legsR[direction];
            int order=-Mathf.RoundToInt(Position.Y*100)*10;still.sortingOrder=torso.sortingOrder=order+4;
            float swing=LowStepGait.Swing(Cycle.Phase)*blend;bool side=direction==1||direction==3;float sign=direction==3?-1:1;
            float angle=side?14*swing*sign:3*swing;
            float liftL=LowStepGait.LeftLift(Cycle.Phase)*blend,liftR=LowStepGait.RightLift(Cycle.Phase)*blend;
            LeftFootOffset=new Vector2(side?swing*.15f:0,liftL);RightFootOffset=new Vector2(side?-swing*.15f:0,liftR);
            left.transform.localPosition=new Vector3(-legX[direction],hip[direction]+liftL,0);right.transform.localPosition=new Vector3(legX[direction],hip[direction]+liftR,0);
            left.transform.localRotation=Quaternion.Euler(0,0,angle);right.transform.localRotation=Quaternion.Euler(0,0,-angle);
            left.sortingOrder=order+(swing>0?2:1);right.sortingOrder=order+(swing>0?1:2);
            left.color=side?new Color(.78f,.8f,.78f):Color.white;right.color=Color.white;
            float bob=active?Mathf.Abs(swing)*.009f:Mathf.Sin(clock*2.2f)*.006f;
            torso.transform.localPosition=new Vector3(0,bodyBase[direction]+bob,0);torso.transform.localRotation=Quaternion.Euler(0,0,side?swing*.7f:0);
            still.transform.localScale=new Vector3(1,1+Mathf.Sin(clock*2.2f)*.002f,1);
            root.transform.localRotation=Quaternion.Euler(0,0,dodging?-sign*8:0);shadow.transform.localRotation=Quaternion.Inverse(root.transform.localRotation);
        }
        public void Dispose(){UnityEngine.Object.Destroy(root);foreach(var s in owned)UnityEngine.Object.Destroy(s);visuals.Dispose();}
    }
}
