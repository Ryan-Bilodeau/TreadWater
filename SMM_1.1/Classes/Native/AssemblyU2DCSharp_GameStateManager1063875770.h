#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// GameStateManager
struct GameStateManager_t1063875770;
// UnityEngine.Sprite[]
struct SpriteU5BU5D_t3359083662;
// UnityEngine.Object[]
struct ObjectU5BU5D_t4217747464;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GameStateManager
struct  GameStateManager_t1063875770  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Sprite[] GameStateManager::PlayerSprites
	SpriteU5BU5D_t3359083662* ___PlayerSprites_3;
	// UnityEngine.Sprite[] GameStateManager::GoldSprites
	SpriteU5BU5D_t3359083662* ___GoldSprites_4;
	// UnityEngine.Sprite[] GameStateManager::WaveSprites
	SpriteU5BU5D_t3359083662* ___WaveSprites_5;
	// UnityEngine.Sprite[] GameStateManager::MuteSprites
	SpriteU5BU5D_t3359083662* ___MuteSprites_6;
	// System.Single GameStateManager::StartingTimeScale
	float ___StartingTimeScale_7;
	// System.Boolean GameStateManager::PlayerLost
	bool ___PlayerLost_8;
	// System.Boolean GameStateManager::Muted
	bool ___Muted_9;
	// System.Boolean GameStateManager::MoveButtonDown
	bool ___MoveButtonDown_10;
	// System.Boolean GameStateManager::CanBeRevived
	bool ___CanBeRevived_11;
	// System.Boolean GameStateManager::ExtraLifeButtonPressed
	bool ___ExtraLifeButtonPressed_12;
	// System.Boolean GameStateManager::AdShowing
	bool ___AdShowing_13;
	// System.Boolean GameStateManager::BeatenGame
	bool ___BeatenGame_14;
	// System.Boolean GameStateManager::LoggedIn
	bool ___LoggedIn_15;
	// System.Boolean GameStateManager::WinsSet
	bool ___WinsSet_16;
	// System.Boolean GameStateManager::InvokePlayerLost
	bool ___InvokePlayerLost_17;
	// UnityEngine.Object[] GameStateManager::tempSprites
	ObjectU5BU5D_t4217747464* ___tempSprites_18;
	// UnityEngine.Object[] GameStateManager::tempWaves
	ObjectU5BU5D_t4217747464* ___tempWaves_19;
	// UnityEngine.Object[] GameStateManager::tempMutes
	ObjectU5BU5D_t4217747464* ___tempMutes_20;
	// UnityEngine.Object[] GameStateManager::tempGold
	ObjectU5BU5D_t4217747464* ___tempGold_21;

public:
	inline static int32_t get_offset_of_PlayerSprites_3() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___PlayerSprites_3)); }
	inline SpriteU5BU5D_t3359083662* get_PlayerSprites_3() const { return ___PlayerSprites_3; }
	inline SpriteU5BU5D_t3359083662** get_address_of_PlayerSprites_3() { return &___PlayerSprites_3; }
	inline void set_PlayerSprites_3(SpriteU5BU5D_t3359083662* value)
	{
		___PlayerSprites_3 = value;
		Il2CppCodeGenWriteBarrier(&___PlayerSprites_3, value);
	}

	inline static int32_t get_offset_of_GoldSprites_4() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___GoldSprites_4)); }
	inline SpriteU5BU5D_t3359083662* get_GoldSprites_4() const { return ___GoldSprites_4; }
	inline SpriteU5BU5D_t3359083662** get_address_of_GoldSprites_4() { return &___GoldSprites_4; }
	inline void set_GoldSprites_4(SpriteU5BU5D_t3359083662* value)
	{
		___GoldSprites_4 = value;
		Il2CppCodeGenWriteBarrier(&___GoldSprites_4, value);
	}

	inline static int32_t get_offset_of_WaveSprites_5() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___WaveSprites_5)); }
	inline SpriteU5BU5D_t3359083662* get_WaveSprites_5() const { return ___WaveSprites_5; }
	inline SpriteU5BU5D_t3359083662** get_address_of_WaveSprites_5() { return &___WaveSprites_5; }
	inline void set_WaveSprites_5(SpriteU5BU5D_t3359083662* value)
	{
		___WaveSprites_5 = value;
		Il2CppCodeGenWriteBarrier(&___WaveSprites_5, value);
	}

	inline static int32_t get_offset_of_MuteSprites_6() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___MuteSprites_6)); }
	inline SpriteU5BU5D_t3359083662* get_MuteSprites_6() const { return ___MuteSprites_6; }
	inline SpriteU5BU5D_t3359083662** get_address_of_MuteSprites_6() { return &___MuteSprites_6; }
	inline void set_MuteSprites_6(SpriteU5BU5D_t3359083662* value)
	{
		___MuteSprites_6 = value;
		Il2CppCodeGenWriteBarrier(&___MuteSprites_6, value);
	}

	inline static int32_t get_offset_of_StartingTimeScale_7() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___StartingTimeScale_7)); }
	inline float get_StartingTimeScale_7() const { return ___StartingTimeScale_7; }
	inline float* get_address_of_StartingTimeScale_7() { return &___StartingTimeScale_7; }
	inline void set_StartingTimeScale_7(float value)
	{
		___StartingTimeScale_7 = value;
	}

	inline static int32_t get_offset_of_PlayerLost_8() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___PlayerLost_8)); }
	inline bool get_PlayerLost_8() const { return ___PlayerLost_8; }
	inline bool* get_address_of_PlayerLost_8() { return &___PlayerLost_8; }
	inline void set_PlayerLost_8(bool value)
	{
		___PlayerLost_8 = value;
	}

	inline static int32_t get_offset_of_Muted_9() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___Muted_9)); }
	inline bool get_Muted_9() const { return ___Muted_9; }
	inline bool* get_address_of_Muted_9() { return &___Muted_9; }
	inline void set_Muted_9(bool value)
	{
		___Muted_9 = value;
	}

	inline static int32_t get_offset_of_MoveButtonDown_10() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___MoveButtonDown_10)); }
	inline bool get_MoveButtonDown_10() const { return ___MoveButtonDown_10; }
	inline bool* get_address_of_MoveButtonDown_10() { return &___MoveButtonDown_10; }
	inline void set_MoveButtonDown_10(bool value)
	{
		___MoveButtonDown_10 = value;
	}

	inline static int32_t get_offset_of_CanBeRevived_11() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___CanBeRevived_11)); }
	inline bool get_CanBeRevived_11() const { return ___CanBeRevived_11; }
	inline bool* get_address_of_CanBeRevived_11() { return &___CanBeRevived_11; }
	inline void set_CanBeRevived_11(bool value)
	{
		___CanBeRevived_11 = value;
	}

	inline static int32_t get_offset_of_ExtraLifeButtonPressed_12() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___ExtraLifeButtonPressed_12)); }
	inline bool get_ExtraLifeButtonPressed_12() const { return ___ExtraLifeButtonPressed_12; }
	inline bool* get_address_of_ExtraLifeButtonPressed_12() { return &___ExtraLifeButtonPressed_12; }
	inline void set_ExtraLifeButtonPressed_12(bool value)
	{
		___ExtraLifeButtonPressed_12 = value;
	}

	inline static int32_t get_offset_of_AdShowing_13() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___AdShowing_13)); }
	inline bool get_AdShowing_13() const { return ___AdShowing_13; }
	inline bool* get_address_of_AdShowing_13() { return &___AdShowing_13; }
	inline void set_AdShowing_13(bool value)
	{
		___AdShowing_13 = value;
	}

	inline static int32_t get_offset_of_BeatenGame_14() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___BeatenGame_14)); }
	inline bool get_BeatenGame_14() const { return ___BeatenGame_14; }
	inline bool* get_address_of_BeatenGame_14() { return &___BeatenGame_14; }
	inline void set_BeatenGame_14(bool value)
	{
		___BeatenGame_14 = value;
	}

	inline static int32_t get_offset_of_LoggedIn_15() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___LoggedIn_15)); }
	inline bool get_LoggedIn_15() const { return ___LoggedIn_15; }
	inline bool* get_address_of_LoggedIn_15() { return &___LoggedIn_15; }
	inline void set_LoggedIn_15(bool value)
	{
		___LoggedIn_15 = value;
	}

	inline static int32_t get_offset_of_WinsSet_16() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___WinsSet_16)); }
	inline bool get_WinsSet_16() const { return ___WinsSet_16; }
	inline bool* get_address_of_WinsSet_16() { return &___WinsSet_16; }
	inline void set_WinsSet_16(bool value)
	{
		___WinsSet_16 = value;
	}

	inline static int32_t get_offset_of_InvokePlayerLost_17() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___InvokePlayerLost_17)); }
	inline bool get_InvokePlayerLost_17() const { return ___InvokePlayerLost_17; }
	inline bool* get_address_of_InvokePlayerLost_17() { return &___InvokePlayerLost_17; }
	inline void set_InvokePlayerLost_17(bool value)
	{
		___InvokePlayerLost_17 = value;
	}

	inline static int32_t get_offset_of_tempSprites_18() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___tempSprites_18)); }
	inline ObjectU5BU5D_t4217747464* get_tempSprites_18() const { return ___tempSprites_18; }
	inline ObjectU5BU5D_t4217747464** get_address_of_tempSprites_18() { return &___tempSprites_18; }
	inline void set_tempSprites_18(ObjectU5BU5D_t4217747464* value)
	{
		___tempSprites_18 = value;
		Il2CppCodeGenWriteBarrier(&___tempSprites_18, value);
	}

	inline static int32_t get_offset_of_tempWaves_19() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___tempWaves_19)); }
	inline ObjectU5BU5D_t4217747464* get_tempWaves_19() const { return ___tempWaves_19; }
	inline ObjectU5BU5D_t4217747464** get_address_of_tempWaves_19() { return &___tempWaves_19; }
	inline void set_tempWaves_19(ObjectU5BU5D_t4217747464* value)
	{
		___tempWaves_19 = value;
		Il2CppCodeGenWriteBarrier(&___tempWaves_19, value);
	}

	inline static int32_t get_offset_of_tempMutes_20() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___tempMutes_20)); }
	inline ObjectU5BU5D_t4217747464* get_tempMutes_20() const { return ___tempMutes_20; }
	inline ObjectU5BU5D_t4217747464** get_address_of_tempMutes_20() { return &___tempMutes_20; }
	inline void set_tempMutes_20(ObjectU5BU5D_t4217747464* value)
	{
		___tempMutes_20 = value;
		Il2CppCodeGenWriteBarrier(&___tempMutes_20, value);
	}

	inline static int32_t get_offset_of_tempGold_21() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___tempGold_21)); }
	inline ObjectU5BU5D_t4217747464* get_tempGold_21() const { return ___tempGold_21; }
	inline ObjectU5BU5D_t4217747464** get_address_of_tempGold_21() { return &___tempGold_21; }
	inline void set_tempGold_21(ObjectU5BU5D_t4217747464* value)
	{
		___tempGold_21 = value;
		Il2CppCodeGenWriteBarrier(&___tempGold_21, value);
	}
};

struct GameStateManager_t1063875770_StaticFields
{
public:
	// GameStateManager GameStateManager::Instance
	GameStateManager_t1063875770 * ___Instance_2;

public:
	inline static int32_t get_offset_of_Instance_2() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770_StaticFields, ___Instance_2)); }
	inline GameStateManager_t1063875770 * get_Instance_2() const { return ___Instance_2; }
	inline GameStateManager_t1063875770 ** get_address_of_Instance_2() { return &___Instance_2; }
	inline void set_Instance_2(GameStateManager_t1063875770 * value)
	{
		___Instance_2 = value;
		Il2CppCodeGenWriteBarrier(&___Instance_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
