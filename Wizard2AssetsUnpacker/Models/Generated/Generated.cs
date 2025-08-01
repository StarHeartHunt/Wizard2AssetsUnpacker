using MasterMemory;
using MessagePack;

namespace Wizard2AssetsUnpacker.Models.Generated
{

    [MessagePackObject(false)]
    [MemoryTable("AchievementMaster")]
    public class AchievementMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [Key(1)]
        public int RewardType { get; set; }
        [Key(2)]
        public int RewardDetailId { get; set; }
        [Key(3)]
        public int RewardNumber { get; set; }
        [Key(4)]
        public string PlatformAchieve { get; set; }
    }

    [MemoryTable("AdviceFaceMaster")]
    [MessagePackObject(false)]
    public class AdviceFaceMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public string TextId { get; set; }
        [Key(1)]
        public int[] FaceIndexes { get; set; }
    }

    [MemoryTable("AjitoGrade")]
    [MessagePackObject(false)]
    public class AjitoGrade
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Grade { get; set; }
        [Key(1)]
        public int CutsceneId { get; set; }
    }

    [MemoryTable("AjitoTheme")]
    [MessagePackObject(false)]
    public class AjitoTheme
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int ThemeId { get; set; }
        [Key(1)]
        public int SortId { get; set; }
        [Key(2)]
        public string[] ProbeCubemapIds { get; set; }
        [Key(3)]
        public int TableObjectId { get; set; }
        [Key(4)]
        public int ChairObjectId { get; set; }
    }

    [MemoryTable("ArrangeLayoutDetail")]
    [MessagePackObject(false)]
    public class ArrangeLayoutDetail
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int DetailId { get; set; }
        [Key(1)]
        [SecondaryKey(5, 0)]
        [NonUnique]
        public int ArrangeLayoutId { get; set; }
        [Key(2)]
        public int ObjectId { get; set; }
        [Key(3)]
        public int ChildObjectId { get; set; }
        [Key(4)]
        public Single PositionX { get; set; }
        [Key(5)]
        public Single PositionY { get; set; }
        [Key(6)]
        public Single PositionZ { get; set; }
        [Key(7)]
        public Single RotationX { get; set; }
        [Key(8)]
        public Single RotationY { get; set; }
        [Key(9)]
        public Single RotationZ { get; set; }
        [Key(10)]
        public Single ScaleX { get; set; }
        [Key(11)]
        public Single ScaleY { get; set; }
        [Key(12)]
        public Single ScaleZ { get; set; }
    }
    public enum AttractionCategory : uint { Soccer = 0, Hockey = 1, Volley = 2, ExtraTableTop = 3, }

    [MemoryTable("AttractionAreaMaster")]
    [MessagePackObject(false)]
    public class AttractionAreaMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int AttractionId { get; set; }
        [Key(1)]
        [SecondaryKey(0, 0)]
        public int FloorObjectId { get; set; }
        [Key(2)]
        public int ArrangeLayoutId { get; set; }
        [Key(3)]
        public AttractionCategory AttractionCategory { get; set; }
        [Key(4)]
        public string AttractionName { get; set; }
    }
    public enum AvatarAutoAnimationType : uint { Idle = 1, Run = 2, Jump = 3, Tackle = 4, }


    public class MasterTextId
    {

    }
    public enum AvatarEditTabType : uint { Head = 0, Eye = 1, Eyebrow = 2, Mouth = 4, Glasses = 5, Tops = 6, Bottoms = 7, Socks = 8, Shoes = 9, Smartphone = 10, Mustache = 11, Costume = 12, BodyShape = 100, BodyColor = 101, AvatarVoice = 150, CustomEmote = 200, StandIdle = 300, Run = 400, Jump = 500, Tackle = 600, AvatarStamp = 700, }
    public enum AvatarEditTabCategory : uint { BodyShape = 0, Face = 1, Costume = 2, Motion = 3, AvatarStamp = 4, }

    [MessagePackObject(false)]
    [MemoryTable("AvatarEditTabMaster")]
    public class AvatarEditTabMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public AvatarEditTabType TabType { get; set; }
        [Key(2)]
        public AvatarEditTabCategory TabCategory { get; set; }
    }

    [MemoryTable("AvatarAutoAnimMaster")]
    [MessagePackObject(false)]
    public class AvatarAutoAnimMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int AnimationId { get; set; }
        [Key(1)]
        public AvatarAutoAnimationType AnimationType { get; set; }
        [Key(2)]
        public string AnimationFileName { get; set; }
        [Key(3)]
        public string _LocalizedName { get; set; }
        [IgnoreMember]
        public MasterTextId LocalizedName { get; set; }
        [Key(4)]
        public int EditTabId { get; set; }
        [Key(5)]
        public Single OptionAnimationSpeedRate { get; set; }
        [IgnoreMember]
        public AvatarEditTabMaster EditTabIdRef { get; set; }
    }

    [MemoryTable("AvatarBodyMaster")]
    [MessagePackObject(false)]
    public class AvatarBodyMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int AvatarBodyId { get; set; }
        [Key(1)]
        public string _LocalizedName { get; set; }
        [IgnoreMember]
        public MasterTextId LocalizedName { get; set; }
        [Key(2)]
        public int[] Size { get; set; }
        [Key(3)]
        public int[] ColorIds { get; set; }
        [Key(4)]
        public int EditTabId { get; set; }
    }
    public enum AvatarPartsType : uint { Head = 0, Eye = 1, Eyebrow = 2, Body = 3, Mouth = 4, Glasses = 5, Tops = 6, Bottoms = 7, Socks = 8, Shoes = 9, Smartphone = 10, Face = 11, Mustache = 12, Costume = 13, }

    [MemoryTable("AvatarCategoryMaster")]
    [MessagePackObject(false)]
    public class AvatarCategoryMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int CategoryId { get; set; }
        [NonUnique]
        [Key(1)]
        [SecondaryKey(5, 0)]
        public AvatarPartsType PartsType { get; set; }
        [Key(2)]
        public string Name { get; set; }
        [Key(3)]
        public int[] CombinationNgCategoryIds { get; set; }
        [Key(4)]
        public int EditTabId { get; set; }
        [IgnoreMember]
        public AvatarEditTabMaster EditTabIdRef { get; set; }
    }

    [MemoryTable("AvatarColorCodeMaster")]
    [MessagePackObject(false)]
    public class AvatarColorCodeMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int ColorCodeId { get; set; }
        [Key(1)]
        public string ColorCode { get; set; }
        [Key(2)]
        public string Name { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("AvatarColorMaster")]
    public class AvatarColorMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int ColorId { get; set; }
        [Key(1)]
        public int MaskRColorCodeId { get; set; }
        [Key(2)]
        public int MaskGColorCodeId { get; set; }
        [Key(3)]
        public int MaskGColorOpacity { get; set; }
        [Key(4)]
        public int MaskBColorCodeId { get; set; }
        [Key(5)]
        public int MaskBColorOpacity { get; set; }
        [Key(6)]
        public int MaskAColorCodeId { get; set; }
        [Key(7)]
        public int MaskAColorOpacity { get; set; }
        [Key(8)]
        public int ImageColorCodeId { get; set; }
        [Key(9)]
        public int OverrideAvatarTextureId { get; set; }
        [Key(10)]
        public string Name { get; set; }
        [IgnoreMember]
        public AvatarColorCodeMaster MaskRColorCodeIdRef { get; set; }
        [IgnoreMember]
        public AvatarColorCodeMaster MaskGColorCodeIdRef { get; set; }
        [IgnoreMember]
        public AvatarColorCodeMaster MaskBColorCodeIdRef { get; set; }
        [IgnoreMember]
        public AvatarColorCodeMaster MaskAColorCodeIdRef { get; set; }
        [IgnoreMember]
        public AvatarColorCodeMaster ImageColorCodeIdRef { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("AvatarEmoteMaster")]
    public class AvatarEmoteMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int EmoteId { get; set; }
        [Key(1)]
        public int Type { get; set; }
        [Key(2)]
        public string EmoteFileName { get; set; }
        [Key(3)]
        public string _LocalizedName { get; set; }
        [IgnoreMember]
        public MasterTextId LocalizedName { get; set; }
        [Key(4)]
        public int EditTabId { get; set; }
        [Key(5)]
        public string CySpringOverwriteKey { get; set; }
        [Key(6)]
        public int Rarity { get; set; }
        [IgnoreMember]
        public AvatarEditTabMaster EditTabIdRef { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("AvatarPartsBottoms")]
    public class AvatarPartsBottoms
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int AvatarId { get; set; }
        [Key(1)]
        public string AvatarFileName { get; set; }
        [Key(2)]
        public int DefaultIconColorId { get; set; }
        [Key(3)]
        public int[] ColorIds { get; set; }
        [Key(4)]
        public int[] SoundCategoryIds { get; set; }
        [Key(5)]
        public int AvatarTextureId { get; set; }
        [Key(6)]
        public int SortPriority { get; set; }
    }

    [MemoryTable("AvatarPartsColorRewardMaster")]
    [MessagePackObject(false)]
    public class AvatarPartsColorRewardMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public int AvatarId { get; set; }
        [Key(2)]
        public int ColorId { get; set; }
    }

    [MemoryTable("AvatarPartsMaster")]
    [MessagePackObject(false)]
    public class AvatarPartsMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int AvatarId { get; set; }
        [Key(1)]
        public int CategoryId { get; set; }
        [Key(2)]
        public string _LocalizedName { get; set; }
        [IgnoreMember]
        public MasterTextId LocalizedName { get; set; }
        [Key(3)]
        public int Rarity { get; set; }
        [Key(4)]
        public bool IsNormallyUnavailable { get; set; }
        [IgnoreMember]
        public AvatarCategoryMaster CategoryIdRef { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("AvatarSizeMaster")]
    public class AvatarSizeMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int SizeId { get; set; }
        [Key(1)]
        public Single Value { get; set; }
        [Key(2)]
        public string Name { get; set; }
    }

    [MemoryTable("AvatarPartsCostume")]
    [MessagePackObject(false)]
    public class AvatarPartsCostume
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int AvatarId { get; set; }
        [Key(1)]
        public string AvatarFileName { get; set; }
        [Key(2)]
        public int DefaultIconAvatarTextureId { get; set; }
        [Key(3)]
        public int[] AvatarTextureIds { get; set; }
        [Key(4)]
        public int[] SoundCategoryIds { get; set; }
        [Key(5)]
        public int DedicatedEmoteId { get; set; }
        [Key(6)]
        public int AvatarBodyId { get; set; }
        [Key(7)]
        public int Size { get; set; }
        [Key(8)]
        public int SortPriority { get; set; }
        [IgnoreMember]
        public AvatarPartsMaster AvatarIdRef { get; set; }
        [IgnoreMember]
        public AvatarEmoteMaster DedicatedEmoteIdRef { get; set; }
        [IgnoreMember]
        public AvatarSizeMaster SizeRef { get; set; }
        [IgnoreMember]
        public int[] ColorIds { get; set; }
    }
    public enum AvatarBlinkType : uint { Normal = 0, None = 1, }

    [MemoryTable("AvatarPartsEye")]
    [MessagePackObject(false)]
    public class AvatarPartsEye
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int AvatarId { get; set; }
        [Key(1)]
        public string AvatarFileName { get; set; }
        [Key(2)]
        public int[] ColorIds { get; set; }
        [Key(3)]
        public int[] MakeupColorIds { get; set; }
        [Key(4)]
        public AvatarBlinkType BlinkType { get; set; }
        [Key(5)]
        public int AvatarTextureId { get; set; }
        [Key(6)]
        public int SortPriority { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("AvatarPartsEyebrow")]
    public class AvatarPartsEyebrow
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int AvatarId { get; set; }
        [Key(1)]
        public string AvatarFileName { get; set; }
        [Key(2)]
        public int[] ColorIds { get; set; }
        [Key(3)]
        public int[] PatternIds { get; set; }
        [Key(4)]
        public int SortPriority { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("AvatarPartsGlasses")]
    public class AvatarPartsGlasses
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int AvatarId { get; set; }
        [Key(1)]
        public string AvatarFileName { get; set; }
        [Key(2)]
        public int DefaultIconColorId { get; set; }
        [Key(3)]
        public int[] ColorIds { get; set; }
        [Key(4)]
        public int[] SoundCategoryIds { get; set; }
        [Key(5)]
        public int AvatarTextureId { get; set; }
        [Key(6)]
        public int SortPriority { get; set; }
    }

    [MemoryTable("AvatarPartsHead")]
    [MessagePackObject(false)]
    public class AvatarPartsHead
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int AvatarId { get; set; }
        [Key(1)]
        public string AvatarFileName { get; set; }
        [Key(2)]
        public int[] ColorIds { get; set; }
        [Key(3)]
        public int[] PatternIds { get; set; }
        [Key(4)]
        public int SortPriority { get; set; }
    }

    [MemoryTable("AvatarPartsMouth")]
    [MessagePackObject(false)]
    public class AvatarPartsMouth
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int AvatarId { get; set; }
        [Key(1)]
        public string AvatarFileName { get; set; }
        [Key(2)]
        public int[] ColorIds { get; set; }
        [Key(3)]
        public int AvatarTextureId { get; set; }
        [Key(4)]
        public int SortPriority { get; set; }
    }

    [MemoryTable("AvatarPartsMustache")]
    [MessagePackObject(false)]
    public class AvatarPartsMustache
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int AvatarId { get; set; }
        [Key(1)]
        public string AvatarFileName { get; set; }
        [Key(2)]
        public int[] ColorIds { get; set; }
        [Key(3)]
        public int SortPriority { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("AvatarPartsShoes")]
    public class AvatarPartsShoes
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int AvatarId { get; set; }
        [Key(1)]
        public string AvatarFileName { get; set; }
        [Key(2)]
        public int DefaultIconColorId { get; set; }
        [Key(3)]
        public int[] ColorIds { get; set; }
        [Key(4)]
        public int[] SoundCategoryIds { get; set; }
        [Key(5)]
        public int AvatarTextureId { get; set; }
        [Key(6)]
        public int SortPriority { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("AvatarPartsSmartphone")]
    public class AvatarPartsSmartphone
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int AvatarId { get; set; }
        [Key(1)]
        public string AvatarFileName { get; set; }
        [Key(2)]
        public int DefaultIconColorId { get; set; }
        [Key(3)]
        public int[] ColorIds { get; set; }
        [Key(4)]
        public int[] SoundCategoryIds { get; set; }
        [Key(5)]
        public int AvatarTextureId { get; set; }
        [Key(6)]
        public int SortPriority { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("AvatarPartsSocks")]
    public class AvatarPartsSocks
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int AvatarId { get; set; }
        [Key(1)]
        public string AvatarFileName { get; set; }
        [Key(2)]
        public int DefaultIconColorId { get; set; }
        [Key(3)]
        public int[] ColorIds { get; set; }
        [Key(4)]
        public int[] SoundCategoryIds { get; set; }
        [Key(5)]
        public int AvatarTextureId { get; set; }
        [Key(6)]
        public int SortPriority { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("AvatarPartsTops")]
    public class AvatarPartsTops
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int AvatarId { get; set; }
        [Key(1)]
        public string AvatarFileName { get; set; }
        [Key(2)]
        public int DefaultIconColorId { get; set; }
        [Key(3)]
        public int[] ColorIds { get; set; }
        [Key(4)]
        public int[] SoundCategoryIds { get; set; }
        [Key(5)]
        public int AvatarTextureId { get; set; }
        [Key(6)]
        public int SortPriority { get; set; }
    }

    [MemoryTable("AvatarSoundCategory")]
    [MessagePackObject(false)]
    public class AvatarSoundCategory
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int SoundCategoryId { get; set; }
        [Key(1)]
        public int Priority { get; set; }
        [Key(2)]
        public string Material { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("AvatarVoiceTypeMaster")]
    public class AvatarVoiceTypeMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int AvatarVoiceTypeId { get; set; }
        [Key(1)]
        public string _LocalizedName { get; set; }
        [IgnoreMember]
        public MasterTextId LocalizedName { get; set; }
        [Key(2)]
        public string _LocalizedDescription { get; set; }
        [IgnoreMember]
        public MasterTextId LocalizedDescription { get; set; }
    }

    [MemoryTable("BaseCardMaster")]
    [MessagePackObject(false)]
    public class BaseCardMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int BaseCardId { get; set; }
        [Key(1)]
        public int Type { get; set; }
        [Key(2)]
        public int Class { get; set; }
        [Key(3)]
        public int[] Tribes { get; set; }
        [Key(4)]
        public int Cost { get; set; }
        [Key(5)]
        public int Atk { get; set; }
        [Key(6)]
        public int Life { get; set; }
        [Key(7)]
        public int ChantCount { get; set; }
        [Key(8)]
        public int Rarity { get; set; }
        [Key(9)]
        public int[] RelatedBaseCardIds { get; set; }
        [Key(10)]
        public int[] SpecificEffectCardIds { get; set; }
    }

    [MemoryTable("BasePuzzleMaster")]
    [MessagePackObject(false)]
    public class BasePuzzleMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public string QuestName { get; set; }
        [Key(2)]
        public int CharaId { get; set; }
        [Key(3)]
        public string Description { get; set; }
        [Key(4)]
        public int StageId { get; set; }
        [Key(5)]
        public int PuzzleBattleMasterId { get; set; }
    }

    [MemoryTable("BattleAchievementType")]
    [MessagePackObject(false)]
    public class BattleAchievementType
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public string Name { get; set; }
        [Key(2)]
        public string TextId { get; set; }
        [Key(3)]
        public int OrderNum { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("BattleCountSetting")]
    public class BattleCountSetting
    {
        [Key(0)]
        [PrimaryKey(0)]
        public string Name { get; set; }
        [Key(1)]
        public int Count { get; set; }
    }

    [MemoryTable("BattleFieldMaster")]
    [MessagePackObject(false)]
    public class BattleFieldMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [Key(1)]
        public string StartDate { get; set; }
        [Key(2)]
        public string EndDate { get; set; }
        [Key(3)]
        public int SceneId { get; set; }
        [Key(4)]
        public string BgmId { get; set; }
    }

    [MemoryTable("BattleLogInfoMaster")]
    [MessagePackObject(false)]
    public class BattleLogInfoMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public string _Text { get; set; }
        [IgnoreMember]
        public MasterTextId Text { get; set; }
        [Key(2)]
        public int Priority { get; set; }
        [Key(3)]
        public int DisplayZero { get; set; }
        [Key(4)]
        public int[] Classes { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("BattleResultMessage")]
    public class BattleResultMessage
    {
        [PrimaryKey(0)]
        [Key(0)]
        public string TextId { get; set; }
        [Key(1)]
        public int FaceIndex { get; set; }
        [SecondaryKey(4, 0)]
        [NonUnique]
        [Key(2)]
        public bool IsWin { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("BattleTimeSetting")]
    public class BattleTimeSetting
    {
        [Key(0)]
        [PrimaryKey(0)]
        public string Name { get; set; }
        [Key(1)]
        public int Milliseconds { get; set; }
    }
    public enum BattleTutorialSkipType : uint { None = 0, Skip = 1, SkipShowClear = 2, }

    [MessagePackObject(false)]
    [MemoryTable("BattleTutorial")]
    public class BattleTutorial
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [Key(1)]
        public int CommandGroup { get; set; }
        [Key(2)]
        public int StageId { get; set; }
        [Key(3)]
        public string SoundBankName { get; set; }
        [Key(4)]
        public string ReplayPath { get; set; }
        [Key(5)]
        public bool IsFirstSideAlly { get; set; }
        [Key(6)]
        public int StartTurn { get; set; }
        [Key(7)]
        public bool IsStartTurnAlly { get; set; }
        [Key(8)]
        public int StartStep { get; set; }
        [Key(9)]
        public bool IsFreeBattle { get; set; }
        [Key(10)]
        public bool IsUserInfo { get; set; }
        [Key(11)]
        public string AllyNameTextId { get; set; }
        [Key(12)]
        public string OppoNameTextId { get; set; }
        [Key(13)]
        public int AllyClass { get; set; }
        [Key(14)]
        public int OppoClass { get; set; }
        [Key(15)]
        public int AllyLeaderSkinId { get; set; }
        [Key(16)]
        public int OppoLeaderSkinId { get; set; }
        [Key(17)]
        public int AllyEmblem { get; set; }
        [Key(18)]
        public int OppoEmblem { get; set; }
        [Key(19)]
        public string AllyLeaderVoice { get; set; }
        [Key(20)]
        public string OppoLeaderVoice { get; set; }
        [Key(21)]
        public BattleTutorialSkipType SkipType { get; set; }
        [Key(22)]
        public bool IsUseBattleLog { get; set; }
        [Key(23)]
        public bool IsUseBattleMenu { get; set; }
        [Key(24)]
        public bool IsUseStartCutin { get; set; }
    }
    public enum BattleTutorialCommandType : uint { Null = 0, CardPlay = 1, WaitTime = 2, WaitTurnStartDrawEnd = 3, DialogTips = 4, TurnEnd = 5, Attack = 6, Activation = 7, Evolve = 8, FocusHand = 9, MaskHand = 10, MaskTurnEnd = 11, MaskPP = 12, MaskLeader = 13, MaskFieldStatus = 14, WaitMulliganStart = 15, MulliganChange = 16, MulliganEnd = 17, MaskAllyFieldAndOppoField = 18, MaskMulliganEnd = 19, ExtraPP = 20, MaskField = 21, CursorHand = 22, CursorField = 23, FocusHandLock = 24, MaskEvolve = 25, CursorMulligan = 26, MaskSpellBoostButton = 27, SelectCard = 28, CloseCardDetail = 29, OpenCloseCardDetailLock = 30, OpenCardDetail = 31, OpenFusion = 32, SelectFusionCard = 33, DecideFusion = 34, SelectMode = 35, SelectChoice = 36, MulliganBG = 37, PushSpellBoostButton = 38, MaskHandCost = 39, MaskExtraPP = 40, MaskHandAndPP = 41, MaskCemeteryUI = 42, NoUse011 = 43, NoUse012 = 44, NoUse013 = 45, NoUse014 = 46, NoUse015 = 47, CursorEvolveOrb = 48, WaitDirectBattleStart = 49, WaitTurnStartEnd = 50, PassAndWait = 51, Result = 52, Emote = 53, CharaMessage = 54, MaskLeaderLife = 55, MaskMulligan = 56, BG = 57, NoUse20 = 58, NoUse21 = 59, NoUse22 = 60, PlayFinishMulligan = 61, MaskMode = 62, MaskCardDetail = 63, MaskActivationButton = 64, MaskFusionButton = 65, MaskFusionDecideButton = 66, MaskCrest = 67, WaitVfxAndTime = 68, MaskMulliganCard = 69, MaskCardCounter = 70, Introduction = 71, MaskPuzzle = 72, MaskReset = 73, }

    [MessagePackObject(false)]
    [MemoryTable("BattleTutorialCommand")]
    public class BattleTutorialCommand
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        [NonUnique]
        [SecondaryKey(5, 0)]
        public int CommandGroup { get; set; }
        [Key(2)]
        public BattleTutorialCommandType CommandType { get; set; }
        [Key(3)]
        public string Param1 { get; set; }
        [Key(4)]
        public string Param2 { get; set; }
        [Key(5)]
        public string Param3 { get; set; }
        [Key(6)]
        public string Param4 { get; set; }
        [Key(7)]
        public string Param5 { get; set; }
        [Key(8)]
        public string Param6 { get; set; }
        [Key(9)]
        public string Param7 { get; set; }
    }

    [MemoryTable("BattleTutorialMenuList")]
    [MessagePackObject(false)]
    public class BattleTutorialMenuList
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int TutorialId { get; set; }
        [Key(1)]
        public int OrderNumber { get; set; }
        [Key(2)]
        public int ParentId { get; set; }
        [Key(3)]
        public bool IsBasicTutorial { get; set; }
        [Key(4)]
        public int NextTutorialId { get; set; }
        [Key(5)]
        public int Difficulty { get; set; }
        [Key(6)]
        public string BannerPath { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("BingoMissionLineMaster")]
    public class BingoMissionLineMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Line { get; set; }
        [Key(1)]
        public string RewardNameTextId { get; set; }
        [Key(2)]
        public string ImagePath { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("BingoMissionMaster")]
    public class BingoMissionMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [SecondaryKey(0, 0)]
        [Key(1)]
        public int Position { get; set; }
        [SecondaryKey(1, 0)]
        [Key(2)]
        public int AchieveCondition { get; set; }
        [Key(3)]
        public int AchieveConditionDetailId { get; set; }
        [Key(4)]
        public int RequireCount { get; set; }
        [Key(5)]
        public int MessageId { get; set; }
        [Key(6)]
        public string MissionNameTextId { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("BoxGrade")]
    public class BoxGrade
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [SecondaryKey(0, 0)]
        [Key(1)]
        public int Round { get; set; }
        [SecondaryKey(0, 0)]
        [Key(2)]
        public int Tier { get; set; }
        [Key(3)]
        [SecondaryKey(0, 0)]
        public int WinCount { get; set; }
        [Key(4)]
        public int GradeId { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("CardFilterKeywordMaster")]
    public class CardFilterKeywordMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public string _Keyword { get; set; }
        [IgnoreMember]
        public MasterTextId Keyword { get; set; }
        [Key(2)]
        public string _Category { get; set; }
        [IgnoreMember]
        public MasterTextId Category { get; set; }
    }
    public enum BattleSummonContinueEffectStopTiming : uint { None = 0, All = 4294967295, RemoveField = 1, TurnEnd = 2, }

    [MessagePackObject(false)]
    [MemoryTable("CardResourceMaster")]
    public class CardResourceMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int CardResourceId { get; set; }
        [Key(1)]
        public int TextureName { get; set; }
        [Key(2)]
        public int HeaderTextureName { get; set; }
        [Key(3)]
        public string SummonEffectPath { get; set; }
        [Key(4)]
        public string SummonMoveType { get; set; }
        [Key(5)]
        public Single SummonTime { get; set; }
        [Key(6)]
        public string SummonFx { get; set; }
        [Key(7)]
        public string SummonContinueEffectPath { get; set; }
        [Key(8)]
        public BattleSummonContinueEffectStopTiming SummonContinueEffectStopTiming { get; set; }
        [Key(9)]
        public Single SummonContinueEffectSkillStartTime { get; set; }
        [Key(10)]
        public string SummonContinueFx { get; set; }
        [Key(11)]
        public string SummonPraiseEffectPath { get; set; }
        [Key(12)]
        public string SummonPraiseMoveType { get; set; }
        [Key(13)]
        public Single SummonPraiseTime { get; set; }
        [Key(14)]
        public string SummonPraiseFx { get; set; }
        [Key(15)]
        public string AtkEffectPath { get; set; }
        [Key(16)]
        public string AtkMoveType { get; set; }
        [Key(17)]
        public Single AtkTime { get; set; }
        [Key(18)]
        public string AtkFx { get; set; }
        [Key(19)]
        public string SubAtkParam { get; set; }
        [Key(20)]
        public string EvoAtkEffectPath { get; set; }
        [Key(21)]
        public string EvoAtkMoveType { get; set; }
        [Key(22)]
        public Single EvoAtkTime { get; set; }
        [Key(23)]
        public string EvoAtkFx { get; set; }
        [Key(24)]
        public string EvoSubAtkParam { get; set; }
        [Key(25)]
        public int HeavyParam { get; set; }
        [Key(26)]
        public Single TillingNormalX { get; set; }
        [Key(27)]
        public Single TillingNormalY { get; set; }
        [Key(28)]
        public Single OffsetNormalX { get; set; }
        [Key(29)]
        public Single OffsetNormalY { get; set; }
        [Key(30)]
        public Single TillingEvolX { get; set; }
        [Key(31)]
        public Single TillingEvolY { get; set; }
        [Key(32)]
        public Single OffsetEvolX { get; set; }
        [Key(33)]
        public Single OffsetEvolY { get; set; }
        [Key(34)]
        public Single TillingSuperEvolX { get; set; }
        [Key(35)]
        public Single TillingSuperEvolY { get; set; }
        [Key(36)]
        public Single OffsetSuperEvolX { get; set; }
        [Key(37)]
        public Single OffsetSuperEvolY { get; set; }
        [Key(38)]
        public string VoiceBankName { get; set; }
        [Key(39)]
        public string PlayVoice { get; set; }
        [Key(40)]
        public string AttackVoice { get; set; }
        [Key(41)]
        public string EvoAttackVoice { get; set; }
        [Key(42)]
        public string EvolveVoice { get; set; }
        [Key(43)]
        public string DestroyVoice { get; set; }
        [Key(44)]
        public string EvoDestroyVoice { get; set; }
        [Key(45)]
        public string SkillVoice { get; set; }
        [Key(46)]
        public string EvoSkillVoice { get; set; }
        [Key(47)]
        public string ActVoice { get; set; }
        [Key(48)]
        public Single SuperEvolveBlowTime { get; set; }
        [Key(49)]
        public string DestroyEffectPath { get; set; }
        [Key(50)]
        public string DestroyEffectFx { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("CardMaster")]
    public class CardMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int CardId { get; set; }
        [Key(1)]
        [NonUnique]
        [SecondaryKey(6, 0)]
        public int BaseCardId { get; set; }
        [Key(2)]
        public int CardResourceId { get; set; }
        [Key(3)]
        public int CardSetId { get; set; }
        [Key(4)]
        public int CardTextId { get; set; }
        [Key(5)]
        public int FoilType { get; set; }
        [Key(6)]
        public int NormalCardId { get; set; }
        [Key(7)]
        public int FoilCardId { get; set; }
        [Key(8)]
        public int HighRankFoilCardId { get; set; }
        [Key(9)]
        public int PreConvertId { get; set; }
        [Key(10)]
        public int LeaderAreaOwnerId { get; set; }
        [Key(11)]
        [SecondaryKey(0, 0)]
        public string HashId { get; set; }
        [IgnoreMember]
        public CardResourceMaster CardResourceIdRef { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("CardStyleResource")]
    public class CardStyleResource
    {
        [PrimaryKey(0)]
        [Key(0)]
        [SecondaryKey(0, 0)]
        public int StyleId { get; set; }
        [Key(1)]
        [SecondaryKey(0, 0)]
        public int CardId { get; set; }
        [Key(2)]
        public int CardResourceId { get; set; }
        [Key(3)]
        public int CardTextId { get; set; }
        [Key(4)]
        public int FrameId { get; set; }
        [Key(5)]
        public int StyleEffectId { get; set; }
    }

    [MemoryTable("CardText")]
    [MessagePackObject(false)]
    public class CardText
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int CardTextId { get; set; }
        [Key(1)]
        public string _Name { get; set; }
        [IgnoreMember]
        public MasterTextId Name { get; set; }
        [Key(2)]
        public string _SkillDesc { get; set; }
        [IgnoreMember]
        public MasterTextId SkillDesc { get; set; }
        [Key(3)]
        public string _Flavour { get; set; }
        [IgnoreMember]
        public MasterTextId Flavour { get; set; }
        [Key(4)]
        public string _EvoFlavour { get; set; }
        [IgnoreMember]
        public MasterTextId EvoFlavour { get; set; }
        [Key(5)]
        public string _CardCv { get; set; }
    }
    public enum CardTextPhraseDisplay : uint { Always = 1, OnlyBattle = 2, OnlyHand = 3, OnlyField = 4, }

    [MessagePackObject(false)]
    [MemoryTable("CardTextPhrase")]
    public class CardTextPhrase
    {
        [PrimaryKey(0)]
        [Key(0)]
        public string Identifier { get; set; }
        [Key(1)]
        public CardTextPhraseDisplay Display { get; set; }
        [Key(2)]
        public string _Text { get; set; }
        [IgnoreMember]
        public MasterTextId Text { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("CardVoiceIgnoreMaster")]
    public class CardVoiceIgnoreMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public string VoiceId { get; set; }
    }

    [MemoryTable("CollectionNoBlankStyle")]
    [MessagePackObject(false)]
    public class CollectionNoBlankStyle
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int StyleId { get; set; }
        [Key(1)]
        public string Name { get; set; }
    }

    [MemoryTable("CutsceneMaster")]
    [MessagePackObject(false)]
    public class CutsceneMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [SecondaryKey(5, 0)]
        [NonUnique]
        [Key(1)]
        public int WatchType { get; set; }
        [Key(2)]
        public string StartDate { get; set; }
        [Key(3)]
        public string EndDate { get; set; }
        [Key(4)]
        public string MovieFile { get; set; }
        [Key(5)]
        public string SoundFile { get; set; }
        [Key(6)]
        public string CutsceneName { get; set; }
    }
    public enum DecorativeItemCategory : uint { Medal = 0, Trophy = 1, }

    [MemoryTable("DecorativeItem")]
    [MessagePackObject(false)]
    public class DecorativeItem
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int DecorativeItemId { get; set; }
        [Key(1)]
        public int SortId { get; set; }
        [Key(2)]
        public DecorativeItemCategory Category { get; set; }
        [Key(3)]
        public string _NameId { get; set; }
        [IgnoreMember]
        public MasterTextId NameId { get; set; }
        [Key(4)]
        public string _DescriptionId { get; set; }
        [IgnoreMember]
        public MasterTextId DescriptionId { get; set; }
        [Key(5)]
        public string ModelId { get; set; }
        [Key(6)]
        public string IconName { get; set; }
        [Key(7)]
        public string ThumbnailId { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("DefaultloadingMaster")]
    public class DefaultloadingMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public string _TitleName { get; set; }
        [IgnoreMember]
        public MasterTextId TitleName { get; set; }
        [Key(2)]
        public string _DetailName { get; set; }
        [IgnoreMember]
        public MasterTextId DetailName { get; set; }
        [Key(3)]
        public int LoadType { get; set; }
        [Key(4)]
        public int ImageId { get; set; }
        [Key(5)]
        public string StartDate { get; set; }
        [Key(6)]
        public string EndDate { get; set; }
    }

    [MemoryTable("DegreeCategotyMaster")]
    [MessagePackObject(false)]
    public class DegreeCategotyMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int CategoryId { get; set; }
        [Key(1)]
        public string CategoryName { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("DegreeMaster")]
    public class DegreeMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [Key(1)]
        public int OrderNumber { get; set; }
        [Key(2)]
        public int IsSpecial { get; set; }
        [Key(3)]
        public string Name { get; set; }
        [Key(4)]
        public string Path { get; set; }
        [Key(5)]
        public string DegreeAchievementId { get; set; }
        [Key(6)]
        public int CategoryId { get; set; }
        [Key(7)]
        public int IsPremium { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("EmblemCategotyMaster")]
    public class EmblemCategotyMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int CategoryId { get; set; }
        [Key(1)]
        public string CategoryName { get; set; }
    }

    [MemoryTable("EmblemMaster")]
    [MessagePackObject(false)]
    public class EmblemMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public int IsSpecial { get; set; }
        [Key(2)]
        public string Name { get; set; }
        [Key(3)]
        public string Path { get; set; }
        [Key(4)]
        public int CategoryId { get; set; }
        [Key(5)]
        public int BaseId { get; set; }
        [Key(6)]
        public int PremiumId { get; set; }
        [Key(7)]
        public int IsPremium { get; set; }
        [Key(8)]
        public int SeriesId { get; set; }
    }

    [MemoryTable("EmoteColorChange")]
    [MessagePackObject(false)]
    public class EmoteColorChange
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int EmoteId { get; set; }
        [Key(1)]
        public string MaterialName { get; set; }
        [Key(2)]
        public string[] Color { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("ExchangeTicketRewardMaster")]
    public class ExchangeTicketRewardMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [NonUnique]
        [Key(1)]
        [SecondaryKey(5, 0)]
        public int ItemId { get; set; }
        [Key(2)]
        public int GroupId { get; set; }
        [Key(3)]
        public int RewardType { get; set; }
        [Key(4)]
        public int RewardDetailId { get; set; }
        [Key(5)]
        public int MessageId { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("ExticketResourceMaster")]
    public class ExticketResourceMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int ItemId { get; set; }
        [Key(1)]
        public int CardResourceId { get; set; }
        [Key(2)]
        public int FrameId { get; set; }
        [Key(3)]
        public Single TillingNormalX { get; set; }
        [Key(4)]
        public Single TillingNormalY { get; set; }
        [Key(5)]
        public Single OffsetNormalX { get; set; }
        [Key(6)]
        public Single OffsetNormalY { get; set; }
    }
    public enum FirstTipsType : uint { Image = 0, TextOnly = 1, Cut = 2, }

    [MemoryTable("FirstTipsMaster")]
    [MessagePackObject(false)]
    public class FirstTipsMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        [NonUnique]
        [SecondaryKey(4, 0)]
        public int Group { get; set; }
        [Key(2)]
        public string Comment { get; set; }
        [Key(3)]
        public FirstTipsType Type { get; set; }
        [Key(4)]
        public string TextId { get; set; }
        [Key(5)]
        public string ImageName { get; set; }
    }

    [MemoryTable("FurnitureObjectMaster")]
    [MessagePackObject(false)]
    public class FurnitureObjectMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int MetaverseObjectId { get; set; }
        [Key(1)]
        public int[] PlaceableSeriesIds { get; set; }
        [Key(2)]
        public int FurnitureType { get; set; }
    }

    [MemoryTable("GuildAchievementMaster")]
    [MessagePackObject(false)]
    public class GuildAchievementMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int AchievementId { get; set; }
        [Key(1)]
        public int Category { get; set; }
        [Key(2)]
        public string _DescriptionText { get; set; }
        [IgnoreMember]
        public MasterTextId DescriptionText { get; set; }
    }

    [MemoryTable("GuildAchievementReward")]
    [MessagePackObject(false)]
    public class GuildAchievementReward
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [SecondaryKey(0, 0)]
        [Key(1)]
        public int RewardType { get; set; }
        [Key(2)]
        [SecondaryKey(0, 0)]
        public int RewardDetailId { get; set; }
        [Key(3)]
        public int AchievementId { get; set; }
    }

    [MemoryTable("GuildFrameMaster")]
    [MessagePackObject(false)]
    public class GuildFrameMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public string _Name { get; set; }
        [IgnoreMember]
        public MasterTextId Name { get; set; }
        [Key(2)]
        public string ImageBaseName { get; set; }
        [Key(3)]
        public string ThumbnailPath { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("GuildLevelMaster")]
    public class GuildLevelMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Level { get; set; }
        [Key(1)]
        public int NecessaryPoint { get; set; }
        [Key(2)]
        public int AccumulatePoint { get; set; }
        [Key(3)]
        public string _UnlockText { get; set; }
        [IgnoreMember]
        public MasterTextId UnlockText { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("GuildMissionName")]
    public class GuildMissionName
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int MissionId { get; set; }
        [Key(1)]
        public string _MissionName { get; set; }
        [IgnoreMember]
        public MasterTextId MissionName { get; set; }
    }
    public enum GuildTagLookType : uint { Normal = 0, Bronze = 1, Silver = 2, Gold = 3, }

    [MemoryTable("GuildTagMaster")]
    [MessagePackObject(false)]
    public class GuildTagMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int TagId { get; set; }
        [Key(1)]
        public GuildTagLookType LookType { get; set; }
        [Key(2)]
        public string _NameTextId { get; set; }
        [IgnoreMember]
        public MasterTextId NameTextId { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("HighPremiumCard")]
    public class HighPremiumCard
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int CardId { get; set; }
        [Key(1)]
        public string Name { get; set; }
        [Key(2)]
        public Single ScaleX { get; set; }
        [Key(3)]
        public Single ScaleY { get; set; }
        [Key(4)]
        public Single OffsetX { get; set; }
        [Key(5)]
        public Single OffsetY { get; set; }
        [Key(6)]
        public Single EvolvedScaleX { get; set; }
        [Key(7)]
        public Single EvolvedScaleY { get; set; }
        [Key(8)]
        public Single EvolvedOffsetX { get; set; }
        [Key(9)]
        public Single EvolvedOffsetY { get; set; }
    }

    [MemoryTable("HomeIllustrationMaster")]
    [MessagePackObject(false)]
    public class HomeIllustrationMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [Key(1)]
        public int TextArrowDirection { get; set; }
        [Key(2)]
        public Single TextPosX { get; set; }
        [Key(3)]
        public Single TextPosY { get; set; }
    }
    public enum ParkVenue : uint { Lobby = 0, GuildLounge = 1, Space = 2, }

    [MemoryTable("HomeParkButtonAd")]
    [MessagePackObject(false)]
    public class HomeParkButtonAd
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int HomeParkButtonAdId { get; set; }
        [Key(1)]
        public int CampaignType { get; set; }
        [Key(2)]
        public ParkVenue DialogTarget { get; set; }
        [Key(3)]
        public int Sort { get; set; }
        [Key(4)]
        public string _AdText { get; set; }
        [IgnoreMember]
        public MasterTextId AdText { get; set; }
        [Key(5)]
        public string _FooterBalloonText { get; set; }
    }

    [MemoryTable("HouseActivityObjMaster")]
    [MessagePackObject(false)]
    public class HouseActivityObjMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        [SecondaryKey(0, 0)]
        public int HouseActivityObjId { get; set; }
        [NonUnique]
        [Key(1)]
        [SecondaryKey(5, 0)]
        [SecondaryKey(0, 0)]
        public int HouseSetId { get; set; }
        [Key(2)]
        public int DefaultObjectId { get; set; }
        [Key(3)]
        public Single PositionX { get; set; }
        [Key(4)]
        public Single PositionY { get; set; }
        [Key(5)]
        public Single PositionZ { get; set; }
        [Key(6)]
        public Single RotationX { get; set; }
        [Key(7)]
        public Single RotationY { get; set; }
        [Key(8)]
        public Single RotationZ { get; set; }
        [Key(9)]
        public Single ScaleX { get; set; }
        [Key(10)]
        public Single ScaleY { get; set; }
        [Key(11)]
        public Single ScaleZ { get; set; }
        [Key(12)]
        public int ChildObjectId { get; set; }
        [Key(13)]
        public int PlayDetailId { get; set; }
    }

    [MemoryTable("HouseCameraPosMaster")]
    [MessagePackObject(false)]
    public class HouseCameraPosMaster
    {
        [Key(0)]
        [SecondaryKey(0, 0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [NonUnique]
        [Key(1)]
        [SecondaryKey(0, 0)]
        [SecondaryKey(5, 0)]
        public int HouseSetId { get; set; }
        [Key(2)]
        public Single PositionX { get; set; }
        [Key(3)]
        public Single PositionY { get; set; }
        [Key(4)]
        public Single PositionZ { get; set; }
        [Key(5)]
        public Single RotationX { get; set; }
        [Key(6)]
        public Single RotationY { get; set; }
        [Key(7)]
        public Single RotationZ { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("HouseEditableObjMaster")]
    public class HouseEditableObjMaster
    {
        [SecondaryKey(0, 0)]
        [Key(0)]
        [PrimaryKey(0)]
        public int HouseEditableObjId { get; set; }
        [NonUnique]
        [Key(1)]
        [SecondaryKey(5, 0)]
        [SecondaryKey(0, 0)]
        public int HouseSetId { get; set; }
        [Key(2)]
        public int DefaultObjectId { get; set; }
        [Key(3)]
        public Single PositionX { get; set; }
        [Key(4)]
        public Single PositionY { get; set; }
        [Key(5)]
        public Single PositionZ { get; set; }
        [Key(6)]
        public Single RotationX { get; set; }
        [Key(7)]
        public Single RotationY { get; set; }
        [Key(8)]
        public Single RotationZ { get; set; }
        [Key(9)]
        public Single ScaleX { get; set; }
        [Key(10)]
        public Single ScaleY { get; set; }
        [Key(11)]
        public Single ScaleZ { get; set; }
        [Key(12)]
        public int ChildObjectId { get; set; }
        [Key(13)]
        public int EssentialIdType { get; set; }
        [Key(14)]
        public int EssentialDetailId { get; set; }
        [Key(15)]
        public int EssentialExtraId { get; set; }
    }

    [MemoryTable("HouseSetMaster")]
    [MessagePackObject(false)]
    public class HouseSetMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int HouseSetId { get; set; }
        [Key(1)]
        public int SeriesId { get; set; }
        [Key(2)]
        public string HouseSetModelId { get; set; }
    }

    [MemoryTable("Item")]
    [MessagePackObject(false)]
    public class Item
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int ItemId { get; set; }
        [Key(1)]
        public int ItemType { get; set; }
        [Key(2)]
        public string Name { get; set; }
        [Key(3)]
        public int LimitNum { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("ItemMaster")]
    public class ItemMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int ItemId { get; set; }
        [Key(1)]
        public int ItemType { get; set; }
        [Key(2)]
        public string ThumbnailPath { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("LeaderSkinMaster")]
    public class LeaderSkinMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int LeaderSkinId { get; set; }
        [Key(1)]
        public string LeaderSkinName { get; set; }
        [SecondaryKey(5, 0)]
        [NonUnique]
        [Key(2)]
        public int ClassId { get; set; }
        [Key(3)]
        public int EmoteId { get; set; }
        [Key(4)]
        public int AvailableTermId { get; set; }
        [Key(5)]
        public int IsHighRank { get; set; }
        [Key(6)]
        public int StartCutinId { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("LobbyEventSchedule")]
    public class LobbyEventSchedule
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int EventId { get; set; }
        [Key(1)]
        public int EventType { get; set; }
        [Key(2)]
        public int ConditionValue { get; set; }
        [Key(3)]
        public string OpenDate { get; set; }
        [Key(4)]
        public string StartDate { get; set; }
        [Key(5)]
        public string EndDate { get; set; }
        [Key(6)]
        public string CloseDate { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("LobbyTournament")]
    public class LobbyTournament
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [Key(1)]
        public string Name { get; set; }
        [Key(2)]
        public string HomeDescription { get; set; }
        [Key(3)]
        public string TournamentName { get; set; }
        [Key(4)]
        public string FormatName { get; set; }
        [Key(5)]
        public string FormatDescription { get; set; }
        [Key(6)]
        public string EntryCondition { get; set; }
        [Key(7)]
        public int EntryNum { get; set; }
        [Key(8)]
        public int TotalRound { get; set; }
        [Key(9)]
        public int BattleRule { get; set; }
        [Key(10)]
        public string EntryPageLogoLayoutPrefab { get; set; }
        [Key(11)]
        public int EntryPageDecorationId { get; set; }
        [Key(12)]
        public string EntryPageCollaboImagePath { get; set; }
        [Key(13)]
        public string EntryPageBalloonText { get; set; }
        [Key(14)]
        public string EntryPageEntryConfirmText { get; set; }
        [Key(15)]
        public int MinRankId { get; set; }
        [Key(16)]
        public string BannerImg { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("LobbyTreasureBoxQuestMaster")]
    public class LobbyTreasureBoxQuestMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [SecondaryKey(5, 0)]
        [NonUnique]
        [Key(1)]
        public int ScheduleId { get; set; }
        [Key(2)]
        public string Name { get; set; }
        [Key(3)]
        public int AchieveCondition { get; set; }
        [Key(4)]
        public int AchieveConditionDetailId { get; set; }
        [Key(5)]
        public int RequireCount { get; set; }
        [Key(6)]
        public int LimitType { get; set; }
        [Key(7)]
        public int RewardPoint { get; set; }
        [Key(8)]
        public int RewardType { get; set; }
        [Key(9)]
        public int RewardDetailId { get; set; }
        [Key(10)]
        public int RewardNumber { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("LobbyTreasureBoxQuestWeeklyPointReward")]
    public class LobbyTreasureBoxQuestWeeklyPointReward
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [Key(1)]
        [SecondaryKey(5, 0)]
        [NonUnique]
        public int ScheduleId { get; set; }
        [Key(2)]
        public int Point { get; set; }
        [Key(3)]
        public int RewardType { get; set; }
        [Key(4)]
        public int RewardDetailId { get; set; }
        [Key(5)]
        public int RewardNumber { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("MasterTextLabel")]
    public class MasterTextLabel
    {
        [Key(0)]
        [PrimaryKey(0)]
        public string Id { get; set; }
        [Key(1)]
        public string Text { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("MetaverseBgmMaster")]
    public class MetaverseBgmMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int BgmId { get; set; }
        [Key(1)]
        public string BgmEventName { get; set; }
        [Key(2)]
        public string BgmTitle { get; set; }
        [Key(3)]
        public int BgmDuration { get; set; }
    }
    public enum ConciergeTextUsageType : uint { TalkStart = 0, TalkEnd = 1, TalkGuest = 2, StartRebuild = 3, Cutscene_1 = 4, Cutscene_1_Leader = 5, Cutscene_2 = 6, Cutscene_3 = 7, Cutscene_4 = 8, }

    [MemoryTable("MetaverseConcierge")]
    [MessagePackObject(false)]
    public class MetaverseConcierge
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [SecondaryKey(0, 0)]
        [Key(1)]
        public int NpcId { get; set; }
        [SecondaryKey(0, 0)]
        [Key(2)]
        public ConciergeTextUsageType UsageType { get; set; }
        [Key(3)]
        [SecondaryKey(0, 0)]
        public int Index { get; set; }
        [Key(4)]
        public string _MessageText { get; set; }
        [IgnoreMember]
        public MasterTextId MessageText { get; set; }
    }
    public enum MetaverseGatePointType : uint { Start = 1, Middle = 2, End = 3, LeaveCameraPos = 4, LeaveStart = 5, LeaveMiddle = 6, LeaveEnd = 7, }

    [MessagePackObject(false)]
    [MemoryTable("MetaverseGateMaster")]
    public class MetaverseGateMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        [SecondaryKey(4, 0)]
        [NonUnique]
        public int MetaverseObjectId { get; set; }
        [Key(2)]
        public MetaverseGatePointType PointType { get; set; }
        [Key(3)]
        public Single PositionX { get; set; }
        [Key(4)]
        public Single PositionY { get; set; }
        [Key(5)]
        public Single PositionZ { get; set; }
        [Key(6)]
        public Single CameraH { get; set; }
        [Key(7)]
        public Single CameraV { get; set; }
    }
    public enum LobbyCardEssentialIdType : uint { Card = 1, Illustration = 2, }

    [MemoryTable("MetaverseLobbyCard")]
    [MessagePackObject(false)]
    public class MetaverseLobbyCard
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [SecondaryKey(4, 0)]
        [NonUnique]
        [Key(1)]
        public int GroupId { get; set; }
        [Key(2)]
        public LobbyCardEssentialIdType ContentType { get; set; }
        [Key(3)]
        public int DetailId { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("MetaverseMap")]
    public class MetaverseMap
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int MapId { get; set; }
        [Key(1)]
        public string Name { get; set; }
        [Key(2)]
        public int MaxUserCount { get; set; }
        [Key(3)]
        public string SceneName { get; set; }
        [Key(4)]
        public string DefaultBgm { get; set; }
        [Key(5)]
        public string WwiseSceneState { get; set; }
        [Key(6)]
        public Single JoinPositionX { get; set; }
        [Key(7)]
        public Single JoinPositionY { get; set; }
        [Key(8)]
        public Single JoinPositionZ { get; set; }
        [Key(9)]
        public Single CameraH { get; set; }
        [Key(10)]
        public Single CameraV { get; set; }
        [Key(11)]
        public int IntroCutTipsId { get; set; }
        [Key(12)]
        public int NpcPlacementId { get; set; }
    }

    [MemoryTable("MetaverseMapSpot")]
    [MessagePackObject(false)]
    public class MetaverseMapSpot
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int SpotId { get; set; }
        [NonUnique]
        [Key(1)]
        [SecondaryKey(4, 0)]
        public int MapId { get; set; }
        [Key(2)]
        public string Name { get; set; }
        [Key(3)]
        public Single PositionX { get; set; }
        [Key(4)]
        public Single PositionY { get; set; }
        [Key(5)]
        public Single PositionZ { get; set; }
        [Key(6)]
        public Single CameraH { get; set; }
        [Key(7)]
        public Single CameraV { get; set; }
        [Key(8)]
        public bool HideOnMapFlag { get; set; }
        [Key(9)]
        public Single OffsetX { get; set; }
        [Key(10)]
        public Single OffsetY { get; set; }
    }

    [MemoryTable("MetaverseMonitorContent")]
    [MessagePackObject(false)]
    public class MetaverseMonitorContent
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [Key(1)]
        public int ContentType { get; set; }
        [Key(2)]
        public int MonitorType { get; set; }
        [Key(3)]
        public string ContentFileName { get; set; }
        [Key(4)]
        public string SoundName { get; set; }
        [Key(5)]
        public int Length { get; set; }
        [Key(6)]
        public int FadeOutType { get; set; }
        [Key(7)]
        public string AccessUrl { get; set; }
    }

    [MemoryTable("MetaverseMonitorSchedule")]
    [MessagePackObject(false)]
    public class MetaverseMonitorSchedule
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [SecondaryKey(5, 0)]
        [Key(1)]
        [NonUnique]
        public int DetailId { get; set; }
        [Key(2)]
        public int[] MonitorContentIds { get; set; }
        [Key(3)]
        public string StartDate { get; set; }
        [Key(4)]
        public string EndDate { get; set; }
    }
    public enum MetaverseNpcType : uint { None = 0, Tutorial = 1, AreaWarp = 2, Achievement = 3, Conversation = 4, Shop = 5, GuildConcierge = 6, }

    [MessagePackObject(false)]
    [MemoryTable("MetaverseNpc")]
    public class MetaverseNpc
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public string _Name { get; set; }
        [IgnoreMember]
        public MasterTextId Name { get; set; }
        [Key(2)]
        public string _PositionName { get; set; }
        [IgnoreMember]
        public MasterTextId PositionName { get; set; }
        [Key(3)]
        public MetaverseNpcType NpcType { get; set; }
        [Key(4)]
        public string _InteractiveLabelText { get; set; }
        [IgnoreMember]
        public MasterTextId InteractiveLabelText { get; set; }
        [Key(5)]
        public string _MessageText0 { get; set; }
        [IgnoreMember]
        public MasterTextId MessageText0 { get; set; }
        [Key(6)]
        public string _MessageText1 { get; set; }
        [Key(7)]
        public string _MessageText2 { get; set; }
        [Key(8)]
        public string _MessageText3 { get; set; }
        [Key(9)]
        public int ReactionEmoteId { get; set; }
        [Key(10)]
        public string AvatarModelName { get; set; }
        [Key(11)]
        public int[] AvatarPartsIds { get; set; }
        [Key(12)]
        public int[] AvatarPartsColorIds { get; set; }
    }

    [MemoryTable("MetaverseNpcPlacement")]
    [MessagePackObject(false)]
    public class MetaverseNpcPlacement
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public string PrefabName { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("MetaverseObjectMaster")]
    public class MetaverseObjectMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int MetaverseObjectId { get; set; }
        [Key(1)]
        public string Name { get; set; }
        [Key(2)]
        public int OperationType { get; set; }
        [Key(3)]
        public int ObjectType { get; set; }
        [Key(4)]
        public string MetaverseObjectModelId { get; set; }
        [Key(5)]
        public int ObjectCategory { get; set; }
        [Key(6)]
        public int[] ColorIds { get; set; }
        [Key(7)]
        public string ColorFormatPath { get; set; }
        [Key(8)]
        public int UseMemberLimit { get; set; }
        [Key(9)]
        public int[] ChildObjectTypes { get; set; }
        [Key(10)]
        public int DefaultChildId { get; set; }
        [Key(11)]
        public int Talk3dBgObjCollectType { get; set; }
    }

    [MemoryTable("MetaverseTempleteMessage")]
    [MessagePackObject(false)]
    public class MetaverseTempleteMessage
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [Key(1)]
        public string TextId { get; set; }
        [Key(2)]
        public string FilePath { get; set; }
        [Key(3)]
        public int AvatarVoiceId { get; set; }
    }
    public enum MetaverseTutorialStepType : uint { None = 0, PlayFirstMovie = 1, CreateAvatar = 2, UseTreasureBoxKey = 3, TutorialComplete = 4, OpenTreasureBoxResult = 5, }

    [MessagePackObject(false)]
    [MemoryTable("MetaverseTutorial")]
    public class MetaverseTutorial
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public int SeasonId { get; set; }
        [Key(2)]
        public int Step { get; set; }
        [SecondaryKey(0, 0)]
        [Key(3)]
        public MetaverseTutorialStepType StepType { get; set; }
    }

    [MemoryTable("ModeSkillText")]
    [MessagePackObject(false)]
    public class ModeSkillText
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int CardId { get; set; }
        [PrimaryKey(0)]
        [Key(1)]
        public int TimingIndex { get; set; }
        [Key(2)]
        [PrimaryKey(0)]
        public int ModeIndex { get; set; }
        [Key(3)]
        public string _ModeDesc { get; set; }
        [IgnoreMember]
        public MasterTextId ModeDesc { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("MtvJumpGimmickMaster")]
    public class MtvJumpGimmickMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int MetaverseObjectId { get; set; }
        [Key(1)]
        public int JumpUpValue { get; set; }
        [Key(2)]
        public int MoveVelocityScaleUpValue { get; set; }
    }

    [MemoryTable("MtvObjectDeployMaster")]
    [MessagePackObject(false)]
    public class MtvObjectDeployMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int MetaverseObjectDeployId { get; set; }
        [SecondaryKey(5, 0)]
        [NonUnique]
        [Key(1)]
        public int MapId { get; set; }
        [NonUnique]
        [SecondaryKey(6, 0)]
        [Key(2)]
        public int MetaverseObjectId { get; set; }
        [Key(3)]
        public Single PositionX { get; set; }
        [Key(4)]
        public Single PositionY { get; set; }
        [Key(5)]
        public Single PositionZ { get; set; }
        [Key(6)]
        public Single RotationX { get; set; }
        [Key(7)]
        public Single RotationY { get; set; }
        [Key(8)]
        public Single RotationZ { get; set; }
        [Key(9)]
        public Single ScaleX { get; set; }
        [Key(10)]
        public Single ScaleY { get; set; }
        [Key(11)]
        public Single ScaleZ { get; set; }
        [Key(12)]
        public int ColorId { get; set; }
        [Key(13)]
        public int ChildObjectId { get; set; }
        [Key(14)]
        public int ChildColorId { get; set; }
        [Key(15)]
        public int DetailId { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("NpcAchievConditionMaster")]
    public class NpcAchievConditionMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public int ConditionType { get; set; }
        [Key(2)]
        public string Description { get; set; }
        [Key(3)]
        public int TargetId { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("NpcAchievMaster")]
    public class NpcAchievMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public int UnlockNpcId { get; set; }
        [Key(2)]
        public int UnlockConditionId { get; set; }
        [Key(3)]
        public string _UnlockLabelText { get; set; }
        [IgnoreMember]
        public MasterTextId UnlockLabelText { get; set; }
        [Key(4)]
        public string _UnlockMessageText { get; set; }
        [IgnoreMember]
        public MasterTextId UnlockMessageText { get; set; }
        [Key(5)]
        public int CompletionNpcId { get; set; }
        [Key(6)]
        public int CompletionConditionId { get; set; }
        [Key(7)]
        public string _CompletionLabelText { get; set; }
        [IgnoreMember]
        public MasterTextId CompletionLabelText { get; set; }
        [Key(8)]
        public string _CompletionMessageText { get; set; }
        [IgnoreMember]
        public MasterTextId CompletionMessageText { get; set; }
        [Key(9)]
        public int RewardType { get; set; }
        [Key(10)]
        public int RewardDetailId { get; set; }
        [Key(11)]
        public int RewardNumber { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("PuzzleBattleMaster")]
    public class PuzzleBattleMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [Key(1)]
        public string WinConditionTextId { get; set; }
        [Key(2)]
        public string[] HintTextId { get; set; }
        [Key(3)]
        public int TutorialCommandGroup { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("PuzzleMaster")]
    public class PuzzleMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [Key(1)]
        public int SortType { get; set; }
        [Key(2)]
        public int BannerId { get; set; }
        [Key(3)]
        public int CharaId { get; set; }
        [Key(4)]
        public string BasicTitleTextId { get; set; }
        [Key(5)]
        public string BasicCommentTextId { get; set; }
        [Key(6)]
        public string BasicPuzzleStartDate { get; set; }
        [Key(7)]
        public int MissionId { get; set; }
    }

    [MemoryTable("PuzzleTutorialCommand")]
    [MessagePackObject(false)]
    public class PuzzleTutorialCommand
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [Key(1)]
        [SecondaryKey(5, 0)]
        [NonUnique]
        public int CommandGroup { get; set; }
        [Key(2)]
        public BattleTutorialCommandType CommandType { get; set; }
        [Key(3)]
        public string Param1 { get; set; }
        [Key(4)]
        public string Param2 { get; set; }
        [Key(5)]
        public string Param3 { get; set; }
        [Key(6)]
        public string Param4 { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("SceneTransition")]
    public class SceneTransition
    {
        [Key(0)]
        public string RewardName { get; set; }
        [NonUnique]
        [Key(1)]
        [SecondaryKey(5, 0)]
        public int RewardType { get; set; }
        [PrimaryKey(0)]
        [Key(2)]
        public int RewardDetailIdMin { get; set; }
        [Key(3)]
        public int RewardDetailIdMax { get; set; }
        [Key(4)]
        public string Button1 { get; set; }
        [Key(5)]
        public string Button1Click { get; set; }
        [Key(6)]
        public int Button1Status { get; set; }
        [Key(7)]
        public string Button2 { get; set; }
        [Key(8)]
        public string Button2Click { get; set; }
        [Key(9)]
        public int Button2Status { get; set; }
        [Key(10)]
        public string Button3 { get; set; }
        [Key(11)]
        public string Button3Click { get; set; }
        [Key(12)]
        public int Button3Status { get; set; }
    }
    public enum BattleLogType : uint { Add = 0, AddWithoutTiming = 1, None = 2, }
    public enum SideLogType : uint { None = 0, AddCommon = 1, AddInvocation = 2, }

    [MemoryTable("SkillMaster")]
    [MessagePackObject(false)]
    public class SkillMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int SkillId { get; set; }
        [Key(1)]
        public BattleLogType BattleLogType { get; set; }
        [Key(2)]
        public SideLogType SideLogType { get; set; }
        [Key(3)]
        public string SkillEffectOption { get; set; }
    }
    public enum EffectTiming : uint { Default = 0, Custom = 1, Each = 2, }
    public enum EffectPosition : uint { Default = 0, Center = 1, CenterAlly = 2, CenterOppo = 3, }

    [MessagePackObject(false)]
    [MemoryTable("SkillResourceMaster")]
    public class SkillResourceMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int SkillId { get; set; }
        [PrimaryKey(0)]
        [Key(1)]
        public int CardResourceId { get; set; }
        [Key(2)]
        public string[] SkillEffectPath { get; set; }
        [Key(3)]
        public string[] SkillMoveType { get; set; }
        [Key(4)]
        public Single SkillEffectTime { get; set; }
        [Key(5)]
        public EffectTiming SkillEffectTiming { get; set; }
        [Key(6)]
        public EffectPosition[] SkillEffectTargetPosition { get; set; }
        [Key(7)]
        public string[] SkillFx { get; set; }
        [Key(8)]
        public string[] SubEffParam { get; set; }
        [Key(9)]
        public string[] SuperEffParam { get; set; }
        [Key(10)]
        public bool IsSummonContinueEffect { get; set; }
        [Key(11)]
        public string[] PraiseSkillEffectPath { get; set; }
        [Key(12)]
        public string[] PraiseSkillMoveType { get; set; }
        [Key(13)]
        public Single PraiseSkillEffectTime { get; set; }
        [Key(14)]
        public EffectPosition[] PraiseSkillEffectTargetPosition { get; set; }
        [Key(15)]
        public string[] PraiseSkillFx { get; set; }
        [Key(16)]
        public string[] PraiseSubEffParam { get; set; }
        [Key(17)]
        public string[] PraiseSuperEffParam { get; set; }
        [Key(18)]
        public int ShakeStrength { get; set; }
        [Key(19)]
        public string[] LowSkillEffectPath { get; set; }
        [Key(20)]
        public string[] LowSkillMoveType { get; set; }
        [Key(21)]
        public Single LowSkillEffectTime { get; set; }
        [Key(22)]
        public string[] LowSkillFx { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("Sleeve")]
    public class Sleeve
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int SleeveId { get; set; }
        [Key(1)]
        public string SleeveName { get; set; }
        [Key(2)]
        public string Path { get; set; }
        [Key(3)]
        public int CategoryId { get; set; }
        [Key(4)]
        public int IsPremium { get; set; }
        [Key(5)]
        public int BaseId { get; set; }
        [Key(6)]
        public int PremiumId { get; set; }
        [Key(7)]
        public int SeriesId { get; set; }
    }

    [MemoryTable("SleeveCategotyMaster")]
    [MessagePackObject(false)]
    public class SleeveCategotyMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int CategoryId { get; set; }
        [Key(1)]
        public string CategoryName { get; set; }
    }

    [MemoryTable("Stamp")]
    [MessagePackObject(false)]
    public class Stamp
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public int Category { get; set; }
        [Key(2)]
        public string FileName { get; set; }
        [Key(3)]
        [SecondaryKey(4, 0)]
        [NonUnique]
        public bool UseInBattle { get; set; }
        [Key(4)]
        public int SortOrderInBattle { get; set; }
        [Key(5)]
        public string _LocalizedName { get; set; }
        [IgnoreMember]
        public MasterTextId LocalizedName { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("StampCategory")]
    public class StampCategory
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public string FileName { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("Story")]
    public class Story
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int StoryId { get; set; }
        [SecondaryKey(0, 0)]
        [Key(1)]
        public int SectionId { get; set; }
        [Key(2)]
        [SecondaryKey(0, 0)]
        public int EpisodeId { get; set; }
        [Key(3)]
        [SecondaryKey(0, 0)]
        public int ChapterId { get; set; }
        [Key(4)]
        public string OrderId { get; set; }
        [Key(5)]
        public string StartDate { get; set; }
    }

    [MemoryTable("StoryBattleSetting")]
    [MessagePackObject(false)]
    public class StoryBattleSetting
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int SectionId { get; set; }
        [Key(1)]
        [PrimaryKey(0)]
        public int EpisodeId { get; set; }
        [PrimaryKey(0)]
        [Key(2)]
        public int ChapterId { get; set; }
        [Key(3)]
        public int AvailableDeckClassId { get; set; }
        [Key(4)]
        public int TutorialId { get; set; }
    }

    [MemoryTable("StoryBattleTalkEvent")]
    [MessagePackObject(false)]
    public class StoryBattleTalkEvent
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int StoryId { get; set; }
        [PrimaryKey(0)]
        [Key(1)]
        public int TalkId { get; set; }
        [Key(2)]
        public int CharaId { get; set; }
        [Key(3)]
        public int FaceId { get; set; }
        [Key(4)]
        public string MessageTextId { get; set; }
    }

    [MemoryTable("StoryChapterResources")]
    [MessagePackObject(false)]
    public class StoryChapterResources
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [SecondaryKey(0, 0)]
        [Key(1)]
        public int SectionId { get; set; }
        [SecondaryKey(0, 0)]
        [Key(2)]
        public int EpisodeId { get; set; }
        [Key(3)]
        [SecondaryKey(0, 0)]
        public int ChapterId { get; set; }
        [Key(4)]
        public string ChapterSummaryBgPath { get; set; }
        [Key(5)]
        public bool MovieFlag { get; set; }
        [Key(6)]
        public string LockTitle { get; set; }
        [Key(7)]
        public string LockHint { get; set; }
    }

    [MemoryTable("StoryEpisodeResources")]
    [MessagePackObject(false)]
    public class StoryEpisodeResources
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        [NonUnique]
        [SecondaryKey(5, 0)]
        public int SectionId { get; set; }
        [SecondaryKey(5, 0)]
        [Key(2)]
        [NonUnique]
        [SecondaryKey(0, 0)]
        public int EpisodeId { get; set; }
        [Key(3)]
        public string EpisodeTitleId { get; set; }
        [Key(4)]
        public string EpisodeThumbnailPath { get; set; }
        [Key(5)]
        public string SummaryOverviewId { get; set; }
        [Key(6)]
        public string SummaryTitleId { get; set; }
        [Key(7)]
        public string SummaryTextId { get; set; }
        [Key(8)]
        public string SummaryBgPath { get; set; }
        [Key(9)]
        public string ChapterselectBgPrefabPath { get; set; }
        [Key(10)]
        public string SoloplayButtonBgPrefabPath { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("StoryHint")]
    public class StoryHint
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int SectionId { get; set; }
        [Key(1)]
        [PrimaryKey(0)]
        public int EpisodeId { get; set; }
        [Key(2)]
        [PrimaryKey(0)]
        public int ChapterId { get; set; }
        [Key(3)]
        public int HintCount { get; set; }
    }

    [MemoryTable("SupplementText")]
    [MessagePackObject(false)]
    public class SupplementText
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int BaseCardId { get; set; }
        [Key(1)]
        public string SupplementDesc { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("TwopickrankingMaster")]
    public class TwopickrankingMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public string SeasonName { get; set; }
        [Key(2)]
        public int Round { get; set; }
        [Key(3)]
        public string StartDate { get; set; }
        [Key(4)]
        public string _EndName { get; set; }
        [IgnoreMember]
        public MasterTextId EndName { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("AiMaster")]
    public class AiMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("AvatarClothSeTypeMaster")]
    public class AvatarClothSeTypeMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [Key(1)]
        public string ClothSeType { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("AvatarOverlapMaster")]
    public class AvatarOverlapMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int PrimaryId { get; set; }
        [Key(1)]
        public int CategoryId { get; set; }
        [Key(2)]
        public int TargetCategoryId { get; set; }
        [Key(3)]
        public int LengthId { get; set; }
    }

    [MemoryTable("AvatarPartsPatternMaster")]
    [MessagePackObject(false)]
    public class AvatarPartsPatternMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int PatternId { get; set; }
        [Key(1)]
        public string Name { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("AvatarStepMaterials")]
    public class AvatarStepMaterials
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public string Material { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("AvatarStepSeTypeMaster")]
    public class AvatarStepSeTypeMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [Key(1)]
        public string StepSeType { get; set; }
    }

    [MemoryTable("BattlePassMissionMaster")]
    [MessagePackObject(false)]
    public class BattlePassMissionMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [Key(1)]
        public int RewardType { get; set; }
        [Key(2)]
        public int RewardDetailId { get; set; }
        [Key(3)]
        public int RewardNumber { get; set; }
    }

    [MemoryTable("ChatStampMaster")]
    [MessagePackObject(false)]
    public class ChatStampMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int ChatStampId { get; set; }
        [Key(1)]
        public string MessageTextId { get; set; }
    }

    [MemoryTable("CountryData")]
    [MessagePackObject(false)]
    public class CountryData
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int CountryId { get; set; }
        [Key(1)]
        public string CategoryTextId { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("DefaultAjitoHologram")]
    public class DefaultAjitoHologram
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [Key(1)]
        public int SlotNum { get; set; }
        [Key(2)]
        public int Type { get; set; }
        [Key(3)]
        public int DetailId { get; set; }
        [Key(4)]
        public int ExtraId { get; set; }
    }

    [MemoryTable("LobbyTreasureBoxQuestDailyRewardMaster")]
    [MessagePackObject(false)]
    public class LobbyTreasureBoxQuestDailyRewardMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int Id { get; set; }
        [NonUnique]
        [SecondaryKey(5, 0)]
        [Key(1)]
        public int ScheduleId { get; set; }
        [Key(2)]
        public int Point { get; set; }
        [Key(3)]
        public int RewardType { get; set; }
        [Key(4)]
        public int RewardDetailId { get; set; }
        [Key(5)]
        public int RewardNumber { get; set; }
    }

    [MemoryTable("LobbyTreasureBoxRewardGroup")]
    [MessagePackObject(false)]
    public class LobbyTreasureBoxRewardGroup
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public string Name { get; set; }
    }

    [MemoryTable("MetaverseFixObjectMaster")]
    [MessagePackObject(false)]
    public class MetaverseFixObjectMaster
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int MetaverseFixObjectId { get; set; }
        [Key(1)]
        public int MapId { get; set; }
        [Key(2)]
        public int DefaultId { get; set; }
        [Key(3)]
        public Single PositionX { get; set; }
        [Key(4)]
        public Single PositionY { get; set; }
        [Key(5)]
        public Single PositionZ { get; set; }
        [Key(6)]
        public Single RotationX { get; set; }
        [Key(7)]
        public Single RotationY { get; set; }
        [Key(8)]
        public Single RotationZ { get; set; }
        [Key(9)]
        public Single DefaultScaleX { get; set; }
        [Key(10)]
        public Single DefaultScaleY { get; set; }
        [Key(11)]
        public Single DefaultScaleZ { get; set; }
        [Key(12)]
        public int ColorId { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("MetaverseLobby")]
    public class MetaverseLobby
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int LobbyId { get; set; }
        [Key(1)]
        public string Name { get; set; }
        [Key(2)]
        public int MapId { get; set; }
        [Key(3)]
        public int Type { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("MetaverseLobbyServer")]
    public class MetaverseLobbyServer
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int LobbyServerId { get; set; }
        [Key(1)]
        public int LobbyId { get; set; }
    }

    [MemoryTable("MissionMaster")]
    [MessagePackObject(false)]
    public class MissionMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public int MissionType { get; set; }
        [Key(2)]
        public int NotificationType { get; set; }
        [Key(3)]
        public int GroupId { get; set; }
        [Key(4)]
        public int BattleType { get; set; }
    }
    public enum TransitionType : uint { None = 0, EventPage = 1, ExclusivePage = 2, }

    [MessagePackObject(false)]
    [MemoryTable("ParkDialog")]
    public class ParkDialog
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int ParkDialogId { get; set; }
        [Key(1)]
        public int EventId { get; set; }
        [Key(2)]
        public ParkVenue DialogTarget { get; set; }
        [Key(3)]
        public int Sort { get; set; }
        [Key(4)]
        public string DaialogImg { get; set; }
        [Key(5)]
        public TransitionType TransitionType { get; set; }
    }

    [MemoryTable("Rank")]
    [MessagePackObject(false)]
    public class Rank
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public int Type { get; set; }
        [Key(2)]
        public int NecessaryPoint { get; set; }
        [Key(3)]
        public int AccumulatePoint { get; set; }
        [Key(4)]
        public int LowerLimitPoint { get; set; }
        [Key(5)]
        public int BaseAddPoint { get; set; }
        [Key(6)]
        public int BaseDropPoint { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("SampleA")]
    public class SampleA
    {
        [Key(0)]
        [PrimaryKey(0)]
        public int SampleId { get; set; }
        [Key(1)]
        public string Name { get; set; }
        [Key(2)]
        public string Description { get; set; }
        [Key(3)]
        public int Hp { get; set; }
        [Key(4)]
        public Single DurationSec { get; set; }
    }

    [MemoryTable("StoryRelease")]
    [MessagePackObject(false)]
    public class StoryRelease
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public int SectionId { get; set; }
        [Key(2)]
        public int EpisodeId { get; set; }
        [Key(3)]
        public int ChapterId { get; set; }
        [Key(4)]
        public int PreSectionId { get; set; }
        [Key(5)]
        public int PreEpisodeId { get; set; }
        [Key(6)]
        public int PreChapterId { get; set; }
        [Key(7)]
        public int ConditionId { get; set; }
    }

    [MemoryTable("StoryReward")]
    [MessagePackObject(false)]
    public class StoryReward
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public int SectionId { get; set; }
        [Key(2)]
        public int EpisodeId { get; set; }
        [Key(3)]
        public int ChapterId { get; set; }
        [Key(4)]
        public int RewardType { get; set; }
        [Key(5)]
        public int RewardDetailId { get; set; }
        [Key(6)]
        public string RewardName { get; set; }
        [Key(7)]
        public int RewardNumber { get; set; }
    }

    [MemoryTable("TransitionRankMaster")]
    [MessagePackObject(false)]
    public class TransitionRankMaster
    {
        [PrimaryKey(0)]
        [Key(0)]
        public int TransitionRankId { get; set; }
        [Key(1)]
        public string IconName { get; set; }
        [Key(2)]
        public string RankName { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("assetname")]
    public class AssetBundleLoadName
    {
        [Key(0)]
        [PrimaryKey(0)]
        [StringComparisonOption(StringComparison.OrdinalIgnoreCase)]
        public string AssetName { get; set; }
        [NonUnique]
        [SecondaryKey(1, 0)]
        [Key(1)]
        [StringComparisonOption(StringComparison.OrdinalIgnoreCase)]
        public string Name { get; set; }
    }

    [MessagePackObject(false)]
    [MemoryTable("asset")]
    public class ManifestAsset
    {
        [Key(0)]
        [StringComparisonOption(StringComparison.OrdinalIgnoreCase)]
        [PrimaryKey(0)]
        public string Name { get; set; }
        [Key(1)]
        [StringComparisonOption(StringComparison.Ordinal)]
        [SecondaryKey(0, 0)]
        public string Hash { get; set; }
        [Key(2)]
        [SecondaryKey(3, 0)]
        public int AssetId { get; set; }
        [Key(3)]
        public int[] AllDependencies { get; set; }
        [Key(4)]
        public long Key { get; set; }
        [Key(5)]
        public int Size { get; set; }
        [SecondaryKey(1, 0)]
        [NonUnique]
        [StringComparisonOption(StringComparison.Ordinal)]
        [Key(6)]
        public string Category { get; set; }
        [Key(7)]
        [SecondaryKey(2, 0)]
        [NonUnique]
        public int Group { get; set; }
        [Key(8)]
        public ulong CheckSum { get; set; }
    }

    [MemoryTable("config")]
    [MessagePackObject(false)]
    public class ManifestConfig
    {
        [PrimaryKey(0)]
        [Key(0)]
        [StringComparisonOption(StringComparison.OrdinalIgnoreCase)]
        public string Key { get; set; }
        [Key(1)]
        [StringComparisonOption(StringComparison.OrdinalIgnoreCase)]
        [NonUnique]
        [SecondaryKey(1, 0)]
        public string Value { get; set; }
    }

    [MemoryTable("raw_asset")]
    [MessagePackObject(false)]
    public class ManifestRawAsset
    {
        [Key(0)]
        [PrimaryKey(0)]
        [StringComparisonOption(StringComparison.OrdinalIgnoreCase)]
        public string Name { get; set; }
        [Key(1)]
        [StringComparisonOption(StringComparison.Ordinal)]
        [SecondaryKey(0, 0)]
        public string Hash { get; set; }
        [Key(2)]
        public int Size { get; set; }
        [StringComparisonOption(StringComparison.Ordinal)]
        [NonUnique]
        [Key(3)]
        [SecondaryKey(1, 0)]
        public string Category { get; set; }
        [SecondaryKey(2, 0)]
        [Key(4)]
        [NonUnique]
        public int Group { get; set; }
        [Key(5)]
        public ulong CheckSum { get; set; }
    }

    [MemoryTable("localize")]
    [MessagePackObject(false)]
    public class LocalizeText
    {
        [Key(0)]
        [PrimaryKey(0)]
        public string Id { get; set; }
        [Key(1)]
        public string Text { get; set; }
    }
}