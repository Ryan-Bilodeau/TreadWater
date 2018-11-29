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

// System.Action`1<System.Boolean>
struct Action_1_t3627374100;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// DayNightManager
struct  DayNightManager_t707488325  : public MonoBehaviour_t1158329972
{
public:
	// System.Single DayNightManager::RotationSpeed
	float ___RotationSpeed_3;
	// System.Single DayNightManager::Angle
	float ___Angle_4;
	// UnityEngine.Vector3 DayNightManager::NewRot
	Vector3_t2243707580  ___NewRot_5;
	// UnityEngine.Vector3 DayNightManager::DirLightRot
	Vector3_t2243707580  ___DirLightRot_6;
	// System.Single DayNightManager::FramerateModifier
	float ___FramerateModifier_7;
	// System.Int32 DayNightManager::StartingDaySize
	int32_t ___StartingDaySize_8;
	// System.Int32 DayNightManager::DaySize
	int32_t ___DaySize_9;
	// System.Single DayNightManager::DayAngle
	float ___DayAngle_10;
	// System.Single DayNightManager::LastAngle
	float ___LastAngle_11;
	// System.Boolean DayNightManager::CanIncremenetDay
	bool ___CanIncremenetDay_12;
	// System.Boolean DayNightManager::StopIncrementingDay
	bool ___StopIncrementingDay_13;
	// System.Boolean DayNightManager::Animating
	bool ___Animating_14;

public:
	inline static int32_t get_offset_of_RotationSpeed_3() { return static_cast<int32_t>(offsetof(DayNightManager_t707488325, ___RotationSpeed_3)); }
	inline float get_RotationSpeed_3() const { return ___RotationSpeed_3; }
	inline float* get_address_of_RotationSpeed_3() { return &___RotationSpeed_3; }
	inline void set_RotationSpeed_3(float value)
	{
		___RotationSpeed_3 = value;
	}

	inline static int32_t get_offset_of_Angle_4() { return static_cast<int32_t>(offsetof(DayNightManager_t707488325, ___Angle_4)); }
	inline float get_Angle_4() const { return ___Angle_4; }
	inline float* get_address_of_Angle_4() { return &___Angle_4; }
	inline void set_Angle_4(float value)
	{
		___Angle_4 = value;
	}

	inline static int32_t get_offset_of_NewRot_5() { return static_cast<int32_t>(offsetof(DayNightManager_t707488325, ___NewRot_5)); }
	inline Vector3_t2243707580  get_NewRot_5() const { return ___NewRot_5; }
	inline Vector3_t2243707580 * get_address_of_NewRot_5() { return &___NewRot_5; }
	inline void set_NewRot_5(Vector3_t2243707580  value)
	{
		___NewRot_5 = value;
	}

	inline static int32_t get_offset_of_DirLightRot_6() { return static_cast<int32_t>(offsetof(DayNightManager_t707488325, ___DirLightRot_6)); }
	inline Vector3_t2243707580  get_DirLightRot_6() const { return ___DirLightRot_6; }
	inline Vector3_t2243707580 * get_address_of_DirLightRot_6() { return &___DirLightRot_6; }
	inline void set_DirLightRot_6(Vector3_t2243707580  value)
	{
		___DirLightRot_6 = value;
	}

	inline static int32_t get_offset_of_FramerateModifier_7() { return static_cast<int32_t>(offsetof(DayNightManager_t707488325, ___FramerateModifier_7)); }
	inline float get_FramerateModifier_7() const { return ___FramerateModifier_7; }
	inline float* get_address_of_FramerateModifier_7() { return &___FramerateModifier_7; }
	inline void set_FramerateModifier_7(float value)
	{
		___FramerateModifier_7 = value;
	}

	inline static int32_t get_offset_of_StartingDaySize_8() { return static_cast<int32_t>(offsetof(DayNightManager_t707488325, ___StartingDaySize_8)); }
	inline int32_t get_StartingDaySize_8() const { return ___StartingDaySize_8; }
	inline int32_t* get_address_of_StartingDaySize_8() { return &___StartingDaySize_8; }
	inline void set_StartingDaySize_8(int32_t value)
	{
		___StartingDaySize_8 = value;
	}

	inline static int32_t get_offset_of_DaySize_9() { return static_cast<int32_t>(offsetof(DayNightManager_t707488325, ___DaySize_9)); }
	inline int32_t get_DaySize_9() const { return ___DaySize_9; }
	inline int32_t* get_address_of_DaySize_9() { return &___DaySize_9; }
	inline void set_DaySize_9(int32_t value)
	{
		___DaySize_9 = value;
	}

	inline static int32_t get_offset_of_DayAngle_10() { return static_cast<int32_t>(offsetof(DayNightManager_t707488325, ___DayAngle_10)); }
	inline float get_DayAngle_10() const { return ___DayAngle_10; }
	inline float* get_address_of_DayAngle_10() { return &___DayAngle_10; }
	inline void set_DayAngle_10(float value)
	{
		___DayAngle_10 = value;
	}

	inline static int32_t get_offset_of_LastAngle_11() { return static_cast<int32_t>(offsetof(DayNightManager_t707488325, ___LastAngle_11)); }
	inline float get_LastAngle_11() const { return ___LastAngle_11; }
	inline float* get_address_of_LastAngle_11() { return &___LastAngle_11; }
	inline void set_LastAngle_11(float value)
	{
		___LastAngle_11 = value;
	}

	inline static int32_t get_offset_of_CanIncremenetDay_12() { return static_cast<int32_t>(offsetof(DayNightManager_t707488325, ___CanIncremenetDay_12)); }
	inline bool get_CanIncremenetDay_12() const { return ___CanIncremenetDay_12; }
	inline bool* get_address_of_CanIncremenetDay_12() { return &___CanIncremenetDay_12; }
	inline void set_CanIncremenetDay_12(bool value)
	{
		___CanIncremenetDay_12 = value;
	}

	inline static int32_t get_offset_of_StopIncrementingDay_13() { return static_cast<int32_t>(offsetof(DayNightManager_t707488325, ___StopIncrementingDay_13)); }
	inline bool get_StopIncrementingDay_13() const { return ___StopIncrementingDay_13; }
	inline bool* get_address_of_StopIncrementingDay_13() { return &___StopIncrementingDay_13; }
	inline void set_StopIncrementingDay_13(bool value)
	{
		___StopIncrementingDay_13 = value;
	}

	inline static int32_t get_offset_of_Animating_14() { return static_cast<int32_t>(offsetof(DayNightManager_t707488325, ___Animating_14)); }
	inline bool get_Animating_14() const { return ___Animating_14; }
	inline bool* get_address_of_Animating_14() { return &___Animating_14; }
	inline void set_Animating_14(bool value)
	{
		___Animating_14 = value;
	}
};

struct DayNightManager_t707488325_StaticFields
{
public:
	// System.Int32 DayNightManager::Day
	int32_t ___Day_2;
	// System.Action`1<System.Boolean> DayNightManager::<>f__am$cache0
	Action_1_t3627374100 * ___U3CU3Ef__amU24cache0_15;

public:
	inline static int32_t get_offset_of_Day_2() { return static_cast<int32_t>(offsetof(DayNightManager_t707488325_StaticFields, ___Day_2)); }
	inline int32_t get_Day_2() const { return ___Day_2; }
	inline int32_t* get_address_of_Day_2() { return &___Day_2; }
	inline void set_Day_2(int32_t value)
	{
		___Day_2 = value;
	}

	inline static int32_t get_offset_of_U3CU3Ef__amU24cache0_15() { return static_cast<int32_t>(offsetof(DayNightManager_t707488325_StaticFields, ___U3CU3Ef__amU24cache0_15)); }
	inline Action_1_t3627374100 * get_U3CU3Ef__amU24cache0_15() const { return ___U3CU3Ef__amU24cache0_15; }
	inline Action_1_t3627374100 ** get_address_of_U3CU3Ef__amU24cache0_15() { return &___U3CU3Ef__amU24cache0_15; }
	inline void set_U3CU3Ef__amU24cache0_15(Action_1_t3627374100 * value)
	{
		___U3CU3Ef__amU24cache0_15 = value;
		Il2CppCodeGenWriteBarrier(&___U3CU3Ef__amU24cache0_15, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
