#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_Singleton_1_gen1428620039.h"

// System.String
struct String_t;
// System.Collections.Generic.Dictionary`2<System.String,SubPool>
struct Dictionary_2_t355432813;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ObjectPool
struct  ObjectPool_t251773294  : public Singleton_1_t1428620039
{
public:
	// System.String ObjectPool::ResourcePath
	String_t* ___ResourcePath_3;
	// System.Collections.Generic.Dictionary`2<System.String,SubPool> ObjectPool::m_Pools
	Dictionary_2_t355432813 * ___m_Pools_4;

public:
	inline static int32_t get_offset_of_ResourcePath_3() { return static_cast<int32_t>(offsetof(ObjectPool_t251773294, ___ResourcePath_3)); }
	inline String_t* get_ResourcePath_3() const { return ___ResourcePath_3; }
	inline String_t** get_address_of_ResourcePath_3() { return &___ResourcePath_3; }
	inline void set_ResourcePath_3(String_t* value)
	{
		___ResourcePath_3 = value;
		Il2CppCodeGenWriteBarrier(&___ResourcePath_3, value);
	}

	inline static int32_t get_offset_of_m_Pools_4() { return static_cast<int32_t>(offsetof(ObjectPool_t251773294, ___m_Pools_4)); }
	inline Dictionary_2_t355432813 * get_m_Pools_4() const { return ___m_Pools_4; }
	inline Dictionary_2_t355432813 ** get_address_of_m_Pools_4() { return &___m_Pools_4; }
	inline void set_m_Pools_4(Dictionary_2_t355432813 * value)
	{
		___m_Pools_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_Pools_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
