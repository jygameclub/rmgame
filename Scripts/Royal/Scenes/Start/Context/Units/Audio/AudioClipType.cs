using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Audio
{
    public enum AudioClipType
    {
        // Fields
        None = 0
        ,AreaChestComing = 1
        ,AreaCompleted = 2
        ,AreaCompletedIdle = 3
        ,AreaTaskStarHit = 4
        ,AreaTaskStarThrow = 5
        ,AreaUnlocked = 6
        ,ArrowUse = 7
        ,BirdCollect1 = 8
        ,BirdCollect2 = 9
        ,BirdNestEgg1 = 10
        ,BirdNestEgg2 = 11
        ,BirdNestEgg3 = 12
        ,BirdNestEgg4 = 13
        ,BirdNestWall1 = 14
        ,BirdNestWall2 = 15
        ,BirdNestDoor = 16
        ,BirdNestDestroy1 = 17
        ,BirdNestDestroy2 = 18
        ,BirdNestThrow1 = 19
        ,BirdNestThrow2 = 20
        ,BirdNestLand = 21
        ,BoosterAppear = 22
        ,BoosterCollect = 23
        ,BoosterReveal = 24
        ,BowtieOpening = 25
        ,BowtieClosing = 26
        ,BowtieBreak1 = 27
        ,BowtieBreak2 = 28
        ,BoxBreak1 = 29
        ,BoxBreak2 = 30
        ,BoxBreak3 = 31
        ,BoxLayerBreak1 = 32
        ,BoxLayerBreak2 = 33
        ,BoxLayerBreak3 = 34
        ,BushContainerBreak = 35
        ,BushFlowerClear = 36
        ,BushGrassClear = 37
        ,BushGrassClear2 = 38
        ,BushGrassSpread = 39
        ,ButtonClick = 40
        ,Caldron1B = 41
        ,Caldron2A = 42
        ,CaldronClose = 43
        ,CaldronPumpkinLand1A = 44
        ,CaldronPumpkinLand1B = 45
        ,CaldronThrow1A = 46
        ,CaldronThrow1B = 47
        ,CaldronTrigger = 48
        ,CannonUse = 49
        ,ChainBreak1 = 50
        ,ChainBreak2 = 51
        ,ChainWrongMove1 = 52
        ,ChainWrongMove2 = 53
        ,ChainWrongMove3 = 54
        ,ChestJump = 55
        ,ChestOpen = 56
        ,CloseButtonClick = 57
        ,ClochePropellerThrow = 58
        ,ClocheTntThrow = 59
        ,ClocheLightballThrow = 60
        ,ClocheSilverEnter = 61
        ,ClocheSilverExit = 62
        ,ClocheGoldEnter = 63
        ,ClocheGoldExit = 64
        ,ClocheDiamondEnter = 65
        ,ClocheDiamondExit = 66
        ,ClocheUpgrade = 67
        ,ClocheDowngrade = 68
        ,ClocheWarningButler = 69
        ,ClocheWarningTalkingBalloon = 70
        ,CoinAppear = 71
        ,CoinCollect = 72
        ,CoinCollectPiggy = 73
        ,CoinCounter = 74
        ,CoinSpend = 75
        ,Completed1000ThLevel = 76
        ,ColorBoxBreak1 = 77
        ,ColorBoxBreak2 = 78
        ,ColorBoxBreak3 = 79
        ,ColorBoxLayerBreak1 = 80
        ,ColorBoxLayerBreak2 = 81
        ,ColorBoxLayerBreak3 = 82
        ,CookieExit = 83
        ,CookieJarExplode = 84
        ,CupboardContainerBreak = 85
        ,CupboardDoorBreak = 86
        ,CupboardPlate1 = 87
        ,CupboardPlate2 = 88
        ,CupboardPlate3 = 89
        ,CupAppear = 90
        ,CupBreak1 = 91
        ,CupBreak2 = 92
        ,CupCollect = 93
        ,KeyCollect = 94
        ,ShieldCollect = 95
        ,CurtainCollect = 96
        ,CurtainDestroy = 97
        ,CurtainChain = 98
        ,CurtainOpen = 99
        ,DrillFill = 100
        ,DrillFillRotation1 = 101
        ,DrillFillRotation2 = 102
        ,DrillActivate = 103
        ,DynamiteBoxIn1 = 104
        ,DynamiteBoxIn2 = 105
        ,DynamiteBoxShake1 = 106
        ,DynamiteBoxShake2 = 107
        ,DynamiteBoxBlip = 108
        ,DynamiteBoxExplode = 109
        ,DynamiteBoxFuse = 110
        ,EggBreak1 = 111
        ,EggBreak2 = 112
        ,EggBreak3 = 113
        ,EgoBuy = 114
        ,EgoEnter = 115
        ,FallHit1 = 116
        ,FallHit2 = 117
        ,FireworkExplode1 = 118
        ,FireworkExplode2 = 119
        ,FireworkExplode3 = 120
        ,FireworkShoot = 121
        ,FlowerOpen1 = 122
        ,FlowerOpen2 = 123
        ,FlowerBreak1 = 124
        ,FlowerBreak2 = 125
        ,FlowerGrassSpread = 126
        ,FrogCollect = 127
        ,FrogCollect2 = 128
        ,FrogJump = 129
        ,FrogCollectJump = 130
        ,GoalComplete = 131
        ,GrassClear = 132
        ,GrassClear2 = 133
        ,HammerUse = 134
        ,HoneyClear1 = 135
        ,HoneyClear2 = 136
        ,ImpossibleMove = 137
        ,IceCrusherLoop = 138
        ,IceCrusherLoopEnd = 139
        ,IceCrusherExplode = 140
        ,JesterUse = 141
        ,KingsCupGiftAppear = 142
        ,KingsCupGiftJump = 143
        ,KingsCupGiftOpen = 144
        ,LadderOfferLocked = 145
        ,LadderOfferUnlock = 146
        ,LevelCompleted = 147
        ,LevelEnterBoard = 148
        ,LevelEnterUi = 149
        ,LevelFailed = 150
        ,LightballCreation = 151
        ,LightballExplode = 152
        ,LightballLightball = 153
        ,LightballRay1 = 154
        ,LightballRay2 = 155
        ,LightballRay3 = 156
        ,LightballStart = 157
        ,LightBulbExplode = 158
        ,LightBulbShatter1 = 159
        ,LightBulbShatter2 = 160
        ,LightBulbShatter3 = 161
        ,MadnessChestComing = 162
        ,MadnessChestJump = 163
        ,MadnessChestOpen = 164
        ,MadnessCollectFly = 165
        ,MadnessNewRewardLand = 166
        ,MadnessRewardClaim = 167
        ,MagicHatTrigger = 168
        ,MagicHatGemLand = 169
        ,MagicHat1 = 170
        ,MagicHat2 = 171
        ,MagicHatThrow1 = 172
        ,MagicHatThrow2 = 173
        ,MagicHatWhoosh1 = 174
        ,MagicHatWhoosh2 = 175
        ,MagicHatClose = 176
        ,MailBoxClose = 177
        ,MailExit = 178
        ,MatchExplode1 = 179
        ,MatchExplode2 = 180
        ,MatchExplode3 = 181
        ,MatchExplode4 = 182
        ,MatchExplode5 = 183
        ,MatchExplode6 = 184
        ,MatchItemCollect = 185
        ,MatchItemSwipe = 186
        ,MetalCrusherMelt = 187
        ,MetalCrusherExplode = 188
        ,MoveChestAppear = 189
        ,OutOfMovesEnter = 190
        ,OutOfMovesExit = 191
        ,OwlBreak = 192
        ,OwlCrack1 = 193
        ,OwlCrack2 = 194
        ,OwlCrack3 = 195
        ,OwlCrack4 = 196
        ,OysterOpen1A = 197
        ,OysterOpen1B = 198
        ,OysterOpen2A = 199
        ,OysterOpen2B = 200
        ,OysterBreak1 = 201
        ,OysterBreak2 = 202
        ,SoilDestroy = 203
        ,SoilState1 = 204
        ,SoilState2 = 205
        ,SoilState3 = 206
        ,SoilState4 = 207
        ,PumpkinExplode1A = 208
        ,PumpkinExplode1B = 209
        ,PumpkinExplode2A = 210
        ,PumpkinExplode2B = 211
        ,PotionBottleBreak = 212
        ,PotionBottleBreak2 = 213
        ,PotionContainerBreak = 214
        ,ProgressBarFill = 215
        ,PropellerCreation = 216
        ,PropellerFly = 217
        ,PropellerHit = 218
        ,PropellerTakeOff = 219
        ,PropellerTntCombo = 220
        ,PiggyBreak1 = 221
        ,PiggyBreak2 = 222
        ,PiggyBreak3 = 223
        ,PiggyBankCoinCollect = 224
        ,PiggyBankBreak = 225
        ,RemainingItemLand1 = 226
        ,RemainingItemLand2 = 227
        ,RemainingMoveThrow1 = 228
        ,RemainingMoveThrow2 = 229
        ,RockBreak1 = 230
        ,RockBreak2 = 231
        ,RockGemBreak1 = 232
        ,RockGemBreak2 = 233
        ,RocketCreation = 234
        ,RocketExplode = 235
        ,RocketTntCombo = 236
        ,RoyalPassTutorialScroll = 237
        ,RoyalPassStepUpBarChange = 238
        ,RoyalPassStepUpLineOpen = 239
        ,RoyalPassStepUpLineClose = 240
        ,RoyalPassClaimTick = 241
        ,RoyalPassBonusBankStepUp = 242
        ,RoyalPassBonusBankAppear = 243
        ,RoyalPassBonusBankJump = 244
        ,RoyalPassBonusBankOpen = 245
        ,RoyalPassRewardRevealCongratulation = 246
        ,RoyalPassRewardRevealGiftAppear = 247
        ,RoyalPassRewardRevealGiftMove = 248
        ,SafeContainerBreak = 249
        ,SafeDoorBreak = 250
        ,SafeHandleBreak = 251
        ,ShelfBreak1 = 252
        ,StarCollect = 253
        ,TaskCheck = 254
        ,TntCreation = 255
        ,TntExplode = 256
        ,TntTntCombo = 257
        ,ToolTipOpen = 258
        ,VaseBreak = 259
        ,VaseBreak2 = 260
        ,VaseCrack = 261
        ,VaseCrack2 = 262
        ,WellDoneIdle = 263
        ,WellDoneStarHit = 264
        ,WrongMove = 265
        
    
    }

}
