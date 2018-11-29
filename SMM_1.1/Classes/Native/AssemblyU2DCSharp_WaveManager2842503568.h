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





#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// WaveManager
struct  WaveManager_t2842503568  : public MonoBehaviour_t1158329972
{
public:
	// System.Single WaveManager::AnimationSpeed
	float ___AnimationSpeed_2;
	// UnityEngine.Vector3 WaveManager::TempPos
	Vector3_t2243707580  ___TempPos_3;
	// System.Boolean WaveManager::PlayerWasAboveWater
	bool ___PlayerWasAboveWater_4;

public:
	inline static int32_t get_offset_of_AnimationSpeed_2() { return static_cast<int32_t>(offsetof(WaveManager_t2842503568, ___AnimationSpeed_2)); }
	inline float get_AnimationSpeed_2() const { return ___AnimationSpeed_2; }
	inline float* get_address_of_AnimationSpeed_2() { return &___AnimationSpeed_2; }
	inline void set_AnimationSpeed_2(float value)
	{
		___AnimationSpeed_2 = value;
	}

	inline static int32_t get_offset_of_TempPos_3() { return static_cast<int32_t>(offsetof(WaveManager_t2842503568, ___TempPos_3)); }
	inline Vector3_t2243707580  get_TempPos_3() const { return ___TempPos_3; }
	inline Vector3_t2243707580 * get_address_of_TempPos_3() { return &___TempPos_3; }
	inline void set_TempPos_3(Vector3_t2243707580  value)
	{
		___TempPos_3 = value;
	}

	inline static int32_t get_offset_of_PlayerWasAboveWater_4() { return static_cast<int32_t>(offsetof(WaveManager_t2842503568, ___PlayerWasAboveWater_4)); }
	inline bool get_PlayerWasAboveWater_4() const { return ___PlayerWasAboveWater_4; }
	inline bool* get_address_of_PlayerWasAboveWater_4() { return &___PlayerWasAboveWater_4; }
	inline void set_PlayerWasAboveWater_4(bool value)
	{
		___PlayerWasAboveWater_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
