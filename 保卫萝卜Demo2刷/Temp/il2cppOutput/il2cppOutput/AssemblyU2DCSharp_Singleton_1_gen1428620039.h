#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour3962482529.h"

// ObjectPool
struct ObjectPool_t251773294;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Singleton`1<ObjectPool>
struct  Singleton_1_t1428620039  : public MonoBehaviour_t3962482529
{
public:

public:
};

struct Singleton_1_t1428620039_StaticFields
{
public:
	// T Singleton`1::m_Instance
	ObjectPool_t251773294 * ___m_Instance_2;

public:
	inline static int32_t get_offset_of_m_Instance_2() { return static_cast<int32_t>(offsetof(Singleton_1_t1428620039_StaticFields, ___m_Instance_2)); }
	inline ObjectPool_t251773294 * get_m_Instance_2() const { return ___m_Instance_2; }
	inline ObjectPool_t251773294 ** get_address_of_m_Instance_2() { return &___m_Instance_2; }
	inline void set_m_Instance_2(ObjectPool_t251773294 * value)
	{
		___m_Instance_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_Instance_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
