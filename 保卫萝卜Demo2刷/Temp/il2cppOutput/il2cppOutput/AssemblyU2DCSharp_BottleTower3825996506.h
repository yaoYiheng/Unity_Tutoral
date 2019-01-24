#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_Tower684557973.h"

// UnityEngine.Transform
struct Transform_t3600365921;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// BottleTower
struct  BottleTower_t3825996506  : public Tower_t684557973
{
public:
	// UnityEngine.Transform BottleTower::m_SpawnPoint
	Transform_t3600365921 * ___m_SpawnPoint_15;

public:
	inline static int32_t get_offset_of_m_SpawnPoint_15() { return static_cast<int32_t>(offsetof(BottleTower_t3825996506, ___m_SpawnPoint_15)); }
	inline Transform_t3600365921 * get_m_SpawnPoint_15() const { return ___m_SpawnPoint_15; }
	inline Transform_t3600365921 ** get_address_of_m_SpawnPoint_15() { return &___m_SpawnPoint_15; }
	inline void set_m_SpawnPoint_15(Transform_t3600365921 * value)
	{
		___m_SpawnPoint_15 = value;
		Il2CppCodeGenWriteBarrier(&___m_SpawnPoint_15, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
