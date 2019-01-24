#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object3080106164.h"

// UnityEngine.Object
struct Object_t631007953;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GridInfo
struct  GridInfo_t669758227  : public Il2CppObject
{
public:
	// System.Int32 GridInfo::X
	int32_t ___X_0;
	// System.Int32 GridInfo::Y
	int32_t ___Y_1;
	// System.Boolean GridInfo::CanHold
	bool ___CanHold_2;
	// UnityEngine.Object GridInfo::data
	Object_t631007953 * ___data_3;

public:
	inline static int32_t get_offset_of_X_0() { return static_cast<int32_t>(offsetof(GridInfo_t669758227, ___X_0)); }
	inline int32_t get_X_0() const { return ___X_0; }
	inline int32_t* get_address_of_X_0() { return &___X_0; }
	inline void set_X_0(int32_t value)
	{
		___X_0 = value;
	}

	inline static int32_t get_offset_of_Y_1() { return static_cast<int32_t>(offsetof(GridInfo_t669758227, ___Y_1)); }
	inline int32_t get_Y_1() const { return ___Y_1; }
	inline int32_t* get_address_of_Y_1() { return &___Y_1; }
	inline void set_Y_1(int32_t value)
	{
		___Y_1 = value;
	}

	inline static int32_t get_offset_of_CanHold_2() { return static_cast<int32_t>(offsetof(GridInfo_t669758227, ___CanHold_2)); }
	inline bool get_CanHold_2() const { return ___CanHold_2; }
	inline bool* get_address_of_CanHold_2() { return &___CanHold_2; }
	inline void set_CanHold_2(bool value)
	{
		___CanHold_2 = value;
	}

	inline static int32_t get_offset_of_data_3() { return static_cast<int32_t>(offsetof(GridInfo_t669758227, ___data_3)); }
	inline Object_t631007953 * get_data_3() const { return ___data_3; }
	inline Object_t631007953 ** get_address_of_data_3() { return &___data_3; }
	inline void set_data_3(Object_t631007953 * value)
	{
		___data_3 = value;
		Il2CppCodeGenWriteBarrier(&___data_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
