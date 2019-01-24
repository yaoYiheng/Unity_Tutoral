#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour3962482529.h"

// StaticData
struct StaticData_t3260432231;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Singleton`1<StaticData>
struct  Singleton_1_t142311680  : public MonoBehaviour_t3962482529
{
public:

public:
};

struct Singleton_1_t142311680_StaticFields
{
public:
	// T Singleton`1::m_Instance
	StaticData_t3260432231 * ___m_Instance_2;

public:
	inline static int32_t get_offset_of_m_Instance_2() { return static_cast<int32_t>(offsetof(Singleton_1_t142311680_StaticFields, ___m_Instance_2)); }
	inline StaticData_t3260432231 * get_m_Instance_2() const { return ___m_Instance_2; }
	inline StaticData_t3260432231 ** get_address_of_m_Instance_2() { return &___m_Instance_2; }
	inline void set_m_Instance_2(StaticData_t3260432231 * value)
	{
		___m_Instance_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_Instance_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
