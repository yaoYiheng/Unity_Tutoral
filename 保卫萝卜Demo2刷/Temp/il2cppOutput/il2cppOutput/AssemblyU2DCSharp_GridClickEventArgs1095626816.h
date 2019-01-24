#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_EventArgs3591816995.h"

// GridInfo
struct GridInfo_t669758227;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GridClickEventArgs
struct  GridClickEventArgs_t1095626816  : public EventArgs_t3591816995
{
public:
	// System.Int32 GridClickEventArgs::MouseDown
	int32_t ___MouseDown_1;
	// GridInfo GridClickEventArgs::GridInfo
	GridInfo_t669758227 * ___GridInfo_2;

public:
	inline static int32_t get_offset_of_MouseDown_1() { return static_cast<int32_t>(offsetof(GridClickEventArgs_t1095626816, ___MouseDown_1)); }
	inline int32_t get_MouseDown_1() const { return ___MouseDown_1; }
	inline int32_t* get_address_of_MouseDown_1() { return &___MouseDown_1; }
	inline void set_MouseDown_1(int32_t value)
	{
		___MouseDown_1 = value;
	}

	inline static int32_t get_offset_of_GridInfo_2() { return static_cast<int32_t>(offsetof(GridClickEventArgs_t1095626816, ___GridInfo_2)); }
	inline GridInfo_t669758227 * get_GridInfo_2() const { return ___GridInfo_2; }
	inline GridInfo_t669758227 ** get_address_of_GridInfo_2() { return &___GridInfo_2; }
	inline void set_GridInfo_2(GridInfo_t669758227 * value)
	{
		___GridInfo_2 = value;
		Il2CppCodeGenWriteBarrier(&___GridInfo_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
