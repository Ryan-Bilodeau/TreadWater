#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"

// UnityEngine.GameObject
struct GameObject_t1756533147;
// UnityEngine.GameObject[]
struct GameObjectU5BU5D_t3057952154;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// OceanManager
struct  OceanManager_t4124689315  : public MonoBehaviour_t1158329972
{
public:
	// System.Single OceanManager::BackgroundXSpeed
	float ___BackgroundXSpeed_2;
	// System.Single OceanManager::BackgroundYSpeed
	float ___BackgroundYSpeed_3;
	// System.Single OceanManager::BackgroundYVariance
	float ___BackgroundYVariance_4;
	// System.Single OceanManager::ForegroundXSpeed
	float ___ForegroundXSpeed_5;
	// System.Single OceanManager::ForegroundYSpeed
	float ___ForegroundYSpeed_6;
	// System.Single OceanManager::ForegroundYVariance
	float ___ForegroundYVariance_7;
	// UnityEngine.GameObject OceanManager::Background
	GameObject_t1756533147 * ___Background_8;
	// UnityEngine.GameObject OceanManager::Foreground
	GameObject_t1756533147 * ___Foreground_9;
	// UnityEngine.GameObject[] OceanManager::BgOcean
	GameObjectU5BU5D_t3057952154* ___BgOcean_10;
	// UnityEngine.GameObject[] OceanManager::FgOcean
	GameObjectU5BU5D_t3057952154* ___FgOcean_11;
	// UnityEngine.Vector3 OceanManager::StartingBgPos
	Vector3_t2243707580  ___StartingBgPos_12;
	// UnityEngine.Vector3 OceanManager::StartingFgPos
	Vector3_t2243707580  ___StartingFgPos_13;
	// System.Single OceanManager::SpeedModifier
	float ___SpeedModifier_14;
	// System.Single OceanManager::HeightModifer
	float ___HeightModifer_15;
	// System.Boolean OceanManager::BgYIncreasing
	bool ___BgYIncreasing_16;
	// System.Boolean OceanManager::FgYIncreasing
	bool ___FgYIncreasing_17;
	// UnityEngine.Vector3 OceanManager::TempPos
	Vector3_t2243707580  ___TempPos_18;
	// System.Single OceanManager::FramerateModifier
	float ___FramerateModifier_19;

public:
	inline static int32_t get_offset_of_BackgroundXSpeed_2() { return static_cast<int32_t>(offsetof(OceanManager_t4124689315, ___BackgroundXSpeed_2)); }
	inline float get_BackgroundXSpeed_2() const { return ___BackgroundXSpeed_2; }
	inline float* get_address_of_BackgroundXSpeed_2() { return &___BackgroundXSpeed_2; }
	inline void set_BackgroundXSpeed_2(float value)
	{
		___BackgroundXSpeed_2 = value;
	}

	inline static int32_t get_offset_of_BackgroundYSpeed_3() { return static_cast<int32_t>(offsetof(OceanManager_t4124689315, ___BackgroundYSpeed_3)); }
	inline float get_BackgroundYSpeed_3() const { return ___BackgroundYSpeed_3; }
	inline float* get_address_of_BackgroundYSpeed_3() { return &___BackgroundYSpeed_3; }
	inline void set_BackgroundYSpeed_3(float value)
	{
		___BackgroundYSpeed_3 = value;
	}

	inline static int32_t get_offset_of_BackgroundYVariance_4() { return static_cast<int32_t>(offsetof(OceanManager_t4124689315, ___BackgroundYVariance_4)); }
	inline float get_BackgroundYVariance_4() const { return ___BackgroundYVariance_4; }
	inline float* get_address_of_BackgroundYVariance_4() { return &___BackgroundYVariance_4; }
	inline void set_BackgroundYVariance_4(float value)
	{
		___BackgroundYVariance_4 = value;
	}

	inline static int32_t get_offset_of_ForegroundXSpeed_5() { return static_cast<int32_t>(offsetof(OceanManager_t4124689315, ___ForegroundXSpeed_5)); }
	inline float get_ForegroundXSpeed_5() const { return ___ForegroundXSpeed_5; }
	inline float* get_address_of_ForegroundXSpeed_5() { return &___ForegroundXSpeed_5; }
	inline void set_ForegroundXSpeed_5(float value)
	{
		___ForegroundXSpeed_5 = value;
	}

	inline static int32_t get_offset_of_ForegroundYSpeed_6() { return static_cast<int32_t>(offsetof(OceanManager_t4124689315, ___ForegroundYSpeed_6)); }
	inline float get_ForegroundYSpeed_6() const { return ___ForegroundYSpeed_6; }
	inline float* get_address_of_ForegroundYSpeed_6() { return &___ForegroundYSpeed_6; }
	inline void set_ForegroundYSpeed_6(float value)
	{
		___ForegroundYSpeed_6 = value;
	}

	inline static int32_t get_offset_of_ForegroundYVariance_7() { return static_cast<int32_t>(offsetof(OceanManager_t4124689315, ___ForegroundYVariance_7)); }
	inline float get_ForegroundYVariance_7() const { return ___ForegroundYVariance_7; }
	inline float* get_address_of_ForegroundYVariance_7() { return &___ForegroundYVariance_7; }
	inline void set_ForegroundYVariance_7(float value)
	{
		___ForegroundYVariance_7 = value;
	}

	inline static int32_t get_offset_of_Background_8() { return static_cast<int32_t>(offsetof(OceanManager_t4124689315, ___Background_8)); }
	inline GameObject_t1756533147 * get_Background_8() const { return ___Background_8; }
	inline GameObject_t1756533147 ** get_address_of_Background_8() { return &___Background_8; }
	inline void set_Background_8(GameObject_t1756533147 * value)
	{
		___Background_8 = value;
		Il2CppCodeGenWriteBarrier(&___Background_8, value);
	}

	inline static int32_t get_offset_of_Foreground_9() { return static_cast<int32_t>(offsetof(OceanManager_t4124689315, ___Foreground_9)); }
	inline GameObject_t1756533147 * get_Foreground_9() const { return ___Foreground_9; }
	inline GameObject_t1756533147 ** get_address_of_Foreground_9() { return &___Foreground_9; }
	inline void set_Foreground_9(GameObject_t1756533147 * value)
	{
		___Foreground_9 = value;
		Il2CppCodeGenWriteBarrier(&___Foreground_9, value);
	}

	inline static int32_t get_offset_of_BgOcean_10() { return static_cast<int32_t>(offsetof(OceanManager_t4124689315, ___BgOcean_10)); }
	inline GameObjectU5BU5D_t3057952154* get_BgOcean_10() const { return ___BgOcean_10; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_BgOcean_10() { return &___BgOcean_10; }
	inline void set_BgOcean_10(GameObjectU5BU5D_t3057952154* value)
	{
		___BgOcean_10 = value;
		Il2CppCodeGenWriteBarrier(&___BgOcean_10, value);
	}

	inline static int32_t get_offset_of_FgOcean_11() { return static_cast<int32_t>(offsetof(OceanManager_t4124689315, ___FgOcean_11)); }
	inline GameObjectU5BU5D_t3057952154* get_FgOcean_11() const { return ___FgOcean_11; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_FgOcean_11() { return &___FgOcean_11; }
	inline void set_FgOcean_11(GameObjectU5BU5D_t3057952154* value)
	{
		___FgOcean_11 = value;
		Il2CppCodeGenWriteBarrier(&___FgOcean_11, value);
	}

	inline static int32_t get_offset_of_StartingBgPos_12() { return static_cast<int32_t>(offsetof(OceanManager_t4124689315, ___StartingBgPos_12)); }
	inline Vector3_t2243707580  get_StartingBgPos_12() const { return ___StartingBgPos_12; }
	inline Vector3_t2243707580 * get_address_of_StartingBgPos_12() { return &___StartingBgPos_12; }
	inline void set_StartingBgPos_12(Vector3_t2243707580  value)
	{
		___StartingBgPos_12 = value;
	}

	inline static int32_t get_offset_of_StartingFgPos_13() { return static_cast<int32_t>(offsetof(OceanManager_t4124689315, ___StartingFgPos_13)); }
	inline Vector3_t2243707580  get_StartingFgPos_13() const { return ___StartingFgPos_13; }
	inline Vector3_t2243707580 * get_address_of_StartingFgPos_13() { return &___StartingFgPos_13; }
	inline void set_StartingFgPos_13(Vector3_t2243707580  value)
	{
		___StartingFgPos_13 = value;
	}

	inline static int32_t get_offset_of_SpeedModifier_14() { return static_cast<int32_t>(offsetof(OceanManager_t4124689315, ___SpeedModifier_14)); }
	inline float get_SpeedModifier_14() const { return ___SpeedModifier_14; }
	inline float* get_address_of_SpeedModifier_14() { return &___SpeedModifier_14; }
	inline void set_SpeedModifier_14(float value)
	{
		___SpeedModifier_14 = value;
	}

	inline static int32_t get_offset_of_HeightModifer_15() { return static_cast<int32_t>(offsetof(OceanManager_t4124689315, ___HeightModifer_15)); }
	inline float get_HeightModifer_15() const { return ___HeightModifer_15; }
	inline float* get_address_of_HeightModifer_15() { return &___HeightModifer_15; }
	inline void set_HeightModifer_15(float value)
	{
		___HeightModifer_15 = value;
	}

	inline static int32_t get_offset_of_BgYIncreasing_16() { return static_cast<int32_t>(offsetof(OceanManager_t4124689315, ___BgYIncreasing_16)); }
	inline bool get_BgYIncreasing_16() const { return ___BgYIncreasing_16; }
	inline bool* get_address_of_BgYIncreasing_16() { return &___BgYIncreasing_16; }
	inline void set_BgYIncreasing_16(bool value)
	{
		___BgYIncreasing_16 = value;
	}

	inline static int32_t get_offset_of_FgYIncreasing_17() { return static_cast<int32_t>(offsetof(OceanManager_t4124689315, ___FgYIncreasing_17)); }
	inline bool get_FgYIncreasing_17() const { return ___FgYIncreasing_17; }
	inline bool* get_address_of_FgYIncreasing_17() { return &___FgYIncreasing_17; }
	inline void set_FgYIncreasing_17(bool value)
	{
		___FgYIncreasing_17 = value;
	}

	inline static int32_t get_offset_of_TempPos_18() { return static_cast<int32_t>(offsetof(OceanManager_t4124689315, ___TempPos_18)); }
	inline Vector3_t2243707580  get_TempPos_18() const { return ___TempPos_18; }
	inline Vector3_t2243707580 * get_address_of_TempPos_18() { return &___TempPos_18; }
	inline void set_TempPos_18(Vector3_t2243707580  value)
	{
		___TempPos_18 = value;
	}

	inline static int32_t get_offset_of_FramerateModifier_19() { return static_cast<int32_t>(offsetof(OceanManager_t4124689315, ___FramerateModifier_19)); }
	inline float get_FramerateModifier_19() const { return ___FramerateModifier_19; }
	inline float* get_address_of_FramerateModifier_19() { return &___FramerateModifier_19; }
	inline void set_FramerateModifier_19(float value)
	{
		___FramerateModifier_19 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
