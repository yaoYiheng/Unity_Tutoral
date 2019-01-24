#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour3962482529.h"





#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Bird
struct  Bird_t3453780280  : public MonoBehaviour_t3962482529
{
public:
	// System.Single Bird::OffsetY
	float ___OffsetY_2;
	// System.Single Bird::LoopTime
	float ___LoopTime_3;

public:
	inline static int32_t get_offset_of_OffsetY_2() { return static_cast<int32_t>(offsetof(Bird_t3453780280, ___OffsetY_2)); }
	inline float get_OffsetY_2() const { return ___OffsetY_2; }
	inline float* get_address_of_OffsetY_2() { return &___OffsetY_2; }
	inline void set_OffsetY_2(float value)
	{
		___OffsetY_2 = value;
	}

	inline static int32_t get_offset_of_LoopTime_3() { return static_cast<int32_t>(offsetof(Bird_t3453780280, ___LoopTime_3)); }
	inline float get_LoopTime_3() const { return ___LoopTime_3; }
	inline float* get_address_of_LoopTime_3() { return &___LoopTime_3; }
	inline void set_LoopTime_3(float value)
	{
		___LoopTime_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
