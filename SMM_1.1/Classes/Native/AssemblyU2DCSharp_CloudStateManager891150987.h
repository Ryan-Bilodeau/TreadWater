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

// CloudStateManager
struct  CloudStateManager_t891150987  : public MonoBehaviour_t1158329972
{
public:
	// System.Single CloudStateManager::DisableDist
	float ___DisableDist_2;
	// System.Single CloudStateManager::MovementSpeed
	float ___MovementSpeed_3;
	// UnityEngine.Vector3 CloudStateManager::TempPos
	Vector3_t2243707580  ___TempPos_4;
	// System.Single CloudStateManager::FramerateTimer
	float ___FramerateTimer_5;

public:
	inline static int32_t get_offset_of_DisableDist_2() { return static_cast<int32_t>(offsetof(CloudStateManager_t891150987, ___DisableDist_2)); }
	inline float get_DisableDist_2() const { return ___DisableDist_2; }
	inline float* get_address_of_DisableDist_2() { return &___DisableDist_2; }
	inline void set_DisableDist_2(float value)
	{
		___DisableDist_2 = value;
	}

	inline static int32_t get_offset_of_MovementSpeed_3() { return static_cast<int32_t>(offsetof(CloudStateManager_t891150987, ___MovementSpeed_3)); }
	inline float get_MovementSpeed_3() const { return ___MovementSpeed_3; }
	inline float* get_address_of_MovementSpeed_3() { return &___MovementSpeed_3; }
	inline void set_MovementSpeed_3(float value)
	{
		___MovementSpeed_3 = value;
	}

	inline static int32_t get_offset_of_TempPos_4() { return static_cast<int32_t>(offsetof(CloudStateManager_t891150987, ___TempPos_4)); }
	inline Vector3_t2243707580  get_TempPos_4() const { return ___TempPos_4; }
	inline Vector3_t2243707580 * get_address_of_TempPos_4() { return &___TempPos_4; }
	inline void set_TempPos_4(Vector3_t2243707580  value)
	{
		___TempPos_4 = value;
	}

	inline static int32_t get_offset_of_FramerateTimer_5() { return static_cast<int32_t>(offsetof(CloudStateManager_t891150987, ___FramerateTimer_5)); }
	inline float get_FramerateTimer_5() const { return ___FramerateTimer_5; }
	inline float* get_address_of_FramerateTimer_5() { return &___FramerateTimer_5; }
	inline void set_FramerateTimer_5(float value)
	{
		___FramerateTimer_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
