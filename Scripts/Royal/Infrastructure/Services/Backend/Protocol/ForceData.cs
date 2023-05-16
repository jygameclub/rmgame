using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct ForceData : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int ForceLeagueScore { get; }
        public int ForceKingsCupScore { get; }
        public int ForceTeamBattleScore { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ForceData GetRootAsForceData(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.ForceData.GetRootAsForceData(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.ForceData() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ForceData GetRootAsForceData(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.ForceData obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.ForceData() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528447255824] = _i;
            mem[1152921528447255832] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ForceData __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528447376016] = _i;
            mem[1152921528447376024] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.ForceData() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_ForceLeagueScore()
        {
        
        }
        public int get_ForceKingsCupScore()
        {
        
        }
        public int get_ForceTeamBattleScore()
        {
            throw 36703060;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ForceData> CreateForceData(FlatBuffers.FlatBufferBuilder builder, int forceLeagueScore = 0, int forceKingsCupScore = 0, int forceTeamBattleScore = 0)
        {
            builder.StartObject(numfields:  3);
            Royal.Infrastructure.Services.Backend.Protocol.ForceData.AddForceTeamBattleScore(builder:  builder, forceTeamBattleScore:  forceTeamBattleScore);
            Royal.Infrastructure.Services.Backend.Protocol.ForceData.AddForceKingsCupScore(builder:  builder, forceKingsCupScore:  forceKingsCupScore);
            Royal.Infrastructure.Services.Backend.Protocol.ForceData.AddForceLeagueScore(builder:  builder, forceLeagueScore:  forceLeagueScore);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ForceData> val_1 = Royal.Infrastructure.Services.Backend.Protocol.ForceData.EndForceData(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ForceData>)val_1.Value;
        }
        public static void StartForceData(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  3);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddForceLeagueScore(FlatBuffers.FlatBufferBuilder builder, int forceLeagueScore)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  0, x:  forceLeagueScore, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddForceKingsCupScore(FlatBuffers.FlatBufferBuilder builder, int forceKingsCupScore)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  1, x:  forceKingsCupScore, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddForceTeamBattleScore(FlatBuffers.FlatBufferBuilder builder, int forceTeamBattleScore)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  forceTeamBattleScore, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ForceData> EndForceData(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
