#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_View4100663493.h"

// Map
struct Map_t1232705543;
// Luobo
struct Luobo_t3783404128;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Spawner
struct  Spawner_t1718608084  : public View_t4100663493
{
public:
	// Map Spawner::m_Map
	Map_t1232705543 * ___m_Map_3;
	// Luobo Spawner::m_Luobo
	Luobo_t3783404128 * ___m_Luobo_4;

public:
	inline static int32_t get_offset_of_m_Map_3() { return static_cast<int32_t>(offsetof(Spawner_t1718608084, ___m_Map_3)); }
	inline Map_t1232705543 * get_m_Map_3() const { return ___m_Map_3; }
	inline Map_t1232705543 ** get_address_of_m_Map_3() { return &___m_Map_3; }
	inline void set_m_Map_3(Map_t1232705543 * value)
	{
		___m_Map_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_Map_3, value);
	}

	inline static int32_t get_offset_of_m_Luobo_4() { return static_cast<int32_t>(offsetof(Spawner_t1718608084, ___m_Luobo_4)); }
	inline Luobo_t3783404128 * get_m_Luobo_4() const { return ___m_Luobo_4; }
	inline Luobo_t3783404128 ** get_address_of_m_Luobo_4() { return &___m_Luobo_4; }
	inline void set_m_Luobo_4(Luobo_t3783404128 * value)
	{
		___m_Luobo_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_Luobo_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
