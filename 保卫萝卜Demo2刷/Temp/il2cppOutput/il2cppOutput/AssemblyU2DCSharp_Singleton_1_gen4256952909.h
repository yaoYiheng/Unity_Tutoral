#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour3962482529.h"

// System.Object
struct Il2CppObject;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Singleton`1<System.Object>
struct  Singleton_1_t4256952909  : public MonoBehaviour_t3962482529
{
public:

public:
};

struct Singleton_1_t4256952909_StaticFields
{
public:
	// T Singleton`1::m_Instance
	Il2CppObject * ___m_Instance_2;

public:
	inline static int32_t get_offset_of_m_Instance_2() { return static_cast<int32_t>(offsetof(Singleton_1_t4256952909_StaticFields, ___m_Instance_2)); }
	inline Il2CppObject * get_m_Instance_2() const { return ___m_Instance_2; }
	inline Il2CppObject ** get_address_of_m_Instance_2() { return &___m_Instance_2; }
	inline void set_m_Instance_2(Il2CppObject * value)
	{
		___m_Instance_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_Instance_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
