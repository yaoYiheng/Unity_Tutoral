#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object3080106164.h"

// System.Collections.Generic.Dictionary`2<System.String,Model>
struct Dictionary_2_t1585559280;
// System.Collections.Generic.Dictionary`2<System.String,View>
struct Dictionary_2_t3885919792;
// System.Collections.Generic.Dictionary`2<System.String,System.Type>
struct Dictionary_2_t2269201059;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// MVC
struct  MVC_t119778344  : public Il2CppObject
{
public:

public:
};

struct MVC_t119778344_StaticFields
{
public:
	// System.Collections.Generic.Dictionary`2<System.String,Model> MVC::Models
	Dictionary_2_t1585559280 * ___Models_0;
	// System.Collections.Generic.Dictionary`2<System.String,View> MVC::Views
	Dictionary_2_t3885919792 * ___Views_1;
	// System.Collections.Generic.Dictionary`2<System.String,System.Type> MVC::Controllers
	Dictionary_2_t2269201059 * ___Controllers_2;

public:
	inline static int32_t get_offset_of_Models_0() { return static_cast<int32_t>(offsetof(MVC_t119778344_StaticFields, ___Models_0)); }
	inline Dictionary_2_t1585559280 * get_Models_0() const { return ___Models_0; }
	inline Dictionary_2_t1585559280 ** get_address_of_Models_0() { return &___Models_0; }
	inline void set_Models_0(Dictionary_2_t1585559280 * value)
	{
		___Models_0 = value;
		Il2CppCodeGenWriteBarrier(&___Models_0, value);
	}

	inline static int32_t get_offset_of_Views_1() { return static_cast<int32_t>(offsetof(MVC_t119778344_StaticFields, ___Views_1)); }
	inline Dictionary_2_t3885919792 * get_Views_1() const { return ___Views_1; }
	inline Dictionary_2_t3885919792 ** get_address_of_Views_1() { return &___Views_1; }
	inline void set_Views_1(Dictionary_2_t3885919792 * value)
	{
		___Views_1 = value;
		Il2CppCodeGenWriteBarrier(&___Views_1, value);
	}

	inline static int32_t get_offset_of_Controllers_2() { return static_cast<int32_t>(offsetof(MVC_t119778344_StaticFields, ___Controllers_2)); }
	inline Dictionary_2_t2269201059 * get_Controllers_2() const { return ___Controllers_2; }
	inline Dictionary_2_t2269201059 ** get_address_of_Controllers_2() { return &___Controllers_2; }
	inline void set_Controllers_2(Dictionary_2_t2269201059 * value)
	{
		___Controllers_2 = value;
		Il2CppCodeGenWriteBarrier(&___Controllers_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
