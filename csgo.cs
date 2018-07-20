using System;

// 2018-07-20 17:41:55.325149200 UTC

namespace hazedumper
{
    public static class netvars
    {
        public const Int32 m_ArmorValue = 0xB24C;
        public const Int32 m_Collision = 0x318;
        public const Int32 m_CollisionGroup = 0x470;
        public const Int32 m_Local = 0x2FAC;
        public const Int32 m_MoveType = 0x258;
        public const Int32 m_OriginalOwnerXuidHigh = 0x31A4;
        public const Int32 m_OriginalOwnerXuidLow = 0x31A0;
        public const Int32 m_aimPunchAngle = 0x301C;
        public const Int32 m_aimPunchAngleVel = 0x3028;
        public const Int32 m_bGunGameImmunity = 0x38A4;
        public const Int32 m_bHasDefuser = 0xB25C;
        public const Int32 m_bHasHelmet = 0xB240;
        public const Int32 m_bInReload = 0x3275;
        public const Int32 m_bIsDefusing = 0x3898;
        public const Int32 m_bIsScoped = 0x388E;
        public const Int32 m_bSpotted = 0x939;
        public const Int32 m_bSpottedByMask = 0x97C;
        public const Int32 m_clrRender = 0x70;
        public const Int32 m_dwBoneMatrix = 0x2698;
        public const Int32 m_fAccuracyPenalty = 0x32E0;
        public const Int32 m_fFlags = 0x100;
        public const Int32 m_flFallbackWear = 0x31B0;
        public const Int32 m_flFlashDuration = 0xA308;
        public const Int32 m_flFlashMaxAlpha = 0xA304;
        public const Int32 m_flNextPrimaryAttack = 0x3208;
        public const Int32 m_hActiveWeapon = 0x2EE8;
        public const Int32 m_hMyWeapons = 0x2DE8;
        public const Int32 m_hObserverTarget = 0x3360;
        public const Int32 m_hOwner = 0x29BC;
        public const Int32 m_hOwnerEntity = 0x148;
        public const Int32 m_iAccountID = 0x2FB8;
        public const Int32 m_iClip1 = 0x3234;
        public const Int32 m_iCompetitiveRanking = 0x1A84;
        public const Int32 m_iCompetitiveWins = 0x1B88;
        public const Int32 m_iCrosshairId = 0xB2B8;
        public const Int32 m_iEntityQuality = 0x2F9C;
        public const Int32 m_iFOVStart = 0x31D8;
        public const Int32 m_iGlowIndex = 0xA320;
        public const Int32 m_iHealth = 0xFC;
        public const Int32 m_iItemDefinitionIndex = 0x2F9A;
        public const Int32 m_iItemIDHigh = 0x2FB0;
        public const Int32 m_iObserverMode = 0x334C;
        public const Int32 m_iShotsFired = 0xA2C0;
        public const Int32 m_iState = 0x3228;
        public const Int32 m_iTeamNum = 0xF0;
        public const Int32 m_lifeState = 0x25B;
        public const Int32 m_nFallbackPaintKit = 0x31A8;
        public const Int32 m_nFallbackSeed = 0x31AC;
        public const Int32 m_nFallbackStatTrak = 0x31B4;
        public const Int32 m_nForceBone = 0x267C;
        public const Int32 m_nTickBase = 0x3404;
        public const Int32 m_rgflCoordinateFrame = 0x440;
        public const Int32 m_szCustomName = 0x302C;
        public const Int32 m_szLastPlaceName = 0x3588;
        public const Int32 m_thirdPersonViewAngles = 0x31C8;
        public const Int32 m_vecOrigin = 0x134;
        public const Int32 m_vecVelocity = 0x110;
        public const Int32 m_vecViewOffset = 0x104;
        public const Int32 m_viewPunchAngle = 0x3010;
    }
    public static class signatures
    {
        public const Int32 dwClientState = 0x586A74;
        public const Int32 dwClientState_GetLocalPlayer = 0x180;
        public const Int32 dwClientState_IsHLTV = 0x4CC8;
        public const Int32 dwClientState_Map = 0x28C;
        public const Int32 dwClientState_MapDirectory = 0x188;
        public const Int32 dwClientState_MaxPlayer = 0x310;
        public const Int32 dwClientState_PlayerInfo = 0x5240;
        public const Int32 dwClientState_State = 0x108;
        public const Int32 dwClientState_ViewAngles = 0x4D10;
        public const Int32 dwEntityList = 0x4A923A4;
        public const Int32 dwForceAttack = 0x2ED46EC;
        public const Int32 dwForceAttack2 = 0x2ED46F8;
        public const Int32 dwForceBackward = 0x2ED4770;
        public const Int32 dwForceForward = 0x2ED4734;
        public const Int32 dwForceJump = 0x4F2C890;
        public const Int32 dwForceLeft = 0x2ED477C;
        public const Int32 dwForceRight = 0x2ED4758;
        public const Int32 dwGameDir = 0x624BE8;
        public const Int32 dwGameRulesProxy = 0x4F96C2C;
        public const Int32 dwGetAllClasses = 0xADBAE4;
        public const Int32 dwGlobalVars = 0x586778;
        public const Int32 dwGlowObjectManager = 0x4FC1EC0;
        public const Int32 dwInput = 0x4EDD020;
        public const Int32 dwInterfaceLinkList = 0x6EFD54;
        public const Int32 dwLocalPlayer = 0xAB6D6C;
        public const Int32 dwMouseEnable = 0xABC6E0;
        public const Int32 dwMouseEnablePtr = 0xABC6B0;
        public const Int32 dwPlayerResource = 0x2ED2A7C;
        public const Int32 dwRadarBase = 0x4EC708C;
        public const Int32 dwSensitivity = 0xABC57C;
        public const Int32 dwSensitivityPtr = 0xABC550;
        public const Int32 dwSetClanTag = 0x88680;
        public const Int32 dwViewMatrix = 0x4A83DD4;
        public const Int32 dwWeaponTable = 0x4EDDABC;
        public const Int32 dwWeaponTableIndex = 0x322C;
        public const Int32 dwYawPtr = 0xABC340;
        public const Int32 dwZoomSensitivityRatioPtr = 0xAC1400;
        public const Int32 dwbSendPackets = 0xD086A;
        public const Int32 dwppDirect3DDevice9 = 0xA2F20;
        public const Int32 m_pStudioHdr = 0x293C;
        public const Int32 m_pitchClassPtr = 0x4EC7338;
        public const Int32 m_yawClassPtr = 0xABC340;
    }
} // namespace hazedumper
