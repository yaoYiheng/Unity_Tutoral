#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object3080106164.h"
#include "UnityEngine_UnityEngine_Vector33722313464.h"





#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// CreatPanelArgs
struct  CreatPanelArgs_t1295004762  : public Il2CppObject
{
public:
	// UnityEngine.Vector3 CreatPanelArgs::Position
	Vector3_t3722313464  ___Position_0;
	// System.Boolean CreatPanelArgs::IsUpside
	bool ___IsUpside_1;

public:
	inline static int32_t get_offset_of_Position_0() { return static_cast<int32_t>(offsetof(CreatPanelArgs_t1295004762, ___Position_0)); }
	inline Vector3_t3722313464  get_Position_0() const { return ___Position_0; }
	inline Vector3_t3722313464 * get_address_of_Position_0() { return &___Position_0; }
	inline void set_Position_0(Vector3_t3722313464  value)
	{
		___Position_0 = value;
	}

	inline static int32_t get_offset_of_IsUpside_1() { return static_cast<int32_t>(offsetof(CreatPanelArgs_t1295004762, ___IsUpside_1)); }
	inline bool get_IsUpside_1() const { return ___IsUpside_1; }
	inline bool* get_address_of_IsUpside_1() { return &___IsUpside_1; }
	inline void set_IsUpside_1(bool value)
	{
		___IsUpside_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
