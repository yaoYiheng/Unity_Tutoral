#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object3080106164.h"

// UnityEngine.GameObject
struct GameObject_t1113636619;
// System.Collections.Generic.List`1<UnityEngine.GameObject>
struct List_1_t2585711361;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// SubPool
struct  SubPool_t570176514  : public Il2CppObject
{
public:
	// UnityEngine.GameObject SubPool::m_ObejctPrefab
	GameObject_t1113636619 * ___m_ObejctPrefab_0;
	// System.Collections.Generic.List`1<UnityEngine.GameObject> SubPool::m_Objects
	List_1_t2585711361 * ___m_Objects_1;

public:
	inline static int32_t get_offset_of_m_ObejctPrefab_0() { return static_cast<int32_t>(offsetof(SubPool_t570176514, ___m_ObejctPrefab_0)); }
	inline GameObject_t1113636619 * get_m_ObejctPrefab_0() const { return ___m_ObejctPrefab_0; }
	inline GameObject_t1113636619 ** get_address_of_m_ObejctPrefab_0() { return &___m_ObejctPrefab_0; }
	inline void set_m_ObejctPrefab_0(GameObject_t1113636619 * value)
	{
		___m_ObejctPrefab_0 = value;
		Il2CppCodeGenWriteBarrier(&___m_ObejctPrefab_0, value);
	}

	inline static int32_t get_offset_of_m_Objects_1() { return static_cast<int32_t>(offsetof(SubPool_t570176514, ___m_Objects_1)); }
	inline List_1_t2585711361 * get_m_Objects_1() const { return ___m_Objects_1; }
	inline List_1_t2585711361 ** get_address_of_m_Objects_1() { return &___m_Objects_1; }
	inline void set_m_Objects_1(List_1_t2585711361 * value)
	{
		___m_Objects_1 = value;
		Il2CppCodeGenWriteBarrier(&___m_Objects_1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
