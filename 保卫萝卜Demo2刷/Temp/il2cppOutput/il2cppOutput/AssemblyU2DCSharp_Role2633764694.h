#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_ReusableObejct3429887225.h"

// System.Action`2<System.Int32,System.Int32>
struct Action_2_t4177122770;
// System.Action`1<Role>
struct Action_1_t2806232289;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Role
struct  Role_t2633764694  : public ReusableObejct_t3429887225
{
public:
	// System.Action`2<System.Int32,System.Int32> Role::HealthChange
	Action_2_t4177122770 * ___HealthChange_2;
	// System.Action`1<Role> Role::Dead
	Action_1_t2806232289 * ___Dead_3;
	// System.Int32 Role::m_CurrentHP
	int32_t ___m_CurrentHP_4;
	// System.Int32 Role::m_MaxHP
	int32_t ___m_MaxHP_5;

public:
	inline static int32_t get_offset_of_HealthChange_2() { return static_cast<int32_t>(offsetof(Role_t2633764694, ___HealthChange_2)); }
	inline Action_2_t4177122770 * get_HealthChange_2() const { return ___HealthChange_2; }
	inline Action_2_t4177122770 ** get_address_of_HealthChange_2() { return &___HealthChange_2; }
	inline void set_HealthChange_2(Action_2_t4177122770 * value)
	{
		___HealthChange_2 = value;
		Il2CppCodeGenWriteBarrier(&___HealthChange_2, value);
	}

	inline static int32_t get_offset_of_Dead_3() { return static_cast<int32_t>(offsetof(Role_t2633764694, ___Dead_3)); }
	inline Action_1_t2806232289 * get_Dead_3() const { return ___Dead_3; }
	inline Action_1_t2806232289 ** get_address_of_Dead_3() { return &___Dead_3; }
	inline void set_Dead_3(Action_1_t2806232289 * value)
	{
		___Dead_3 = value;
		Il2CppCodeGenWriteBarrier(&___Dead_3, value);
	}

	inline static int32_t get_offset_of_m_CurrentHP_4() { return static_cast<int32_t>(offsetof(Role_t2633764694, ___m_CurrentHP_4)); }
	inline int32_t get_m_CurrentHP_4() const { return ___m_CurrentHP_4; }
	inline int32_t* get_address_of_m_CurrentHP_4() { return &___m_CurrentHP_4; }
	inline void set_m_CurrentHP_4(int32_t value)
	{
		___m_CurrentHP_4 = value;
	}

	inline static int32_t get_offset_of_m_MaxHP_5() { return static_cast<int32_t>(offsetof(Role_t2633764694, ___m_MaxHP_5)); }
	inline int32_t get_m_MaxHP_5() const { return ___m_MaxHP_5; }
	inline int32_t* get_address_of_m_MaxHP_5() { return &___m_MaxHP_5; }
	inline void set_m_MaxHP_5(int32_t value)
	{
		___m_MaxHP_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
