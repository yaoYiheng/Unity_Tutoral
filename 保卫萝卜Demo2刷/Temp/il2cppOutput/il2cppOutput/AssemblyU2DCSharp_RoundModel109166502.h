#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_Model1800302981.h"

// System.Collections.Generic.List`1<Round>
struct List_1_t184529417;
// UnityEngine.Coroutine
struct Coroutine_t3829159415;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// RoundModel
struct  RoundModel_t109166502  : public Model_t1800302981
{
public:
	// System.Collections.Generic.List`1<Round> RoundModel::m_Rounds
	List_1_t184529417 * ___m_Rounds_2;
	// System.Int32 RoundModel::m_CurrentRoundIndex
	int32_t ___m_CurrentRoundIndex_3;
	// System.Boolean RoundModel::m_IsCompleted
	bool ___m_IsCompleted_4;
	// UnityEngine.Coroutine RoundModel::m_RoundCoroutine
	Coroutine_t3829159415 * ___m_RoundCoroutine_5;
	// System.Boolean RoundModel::Restarted
	bool ___Restarted_6;

public:
	inline static int32_t get_offset_of_m_Rounds_2() { return static_cast<int32_t>(offsetof(RoundModel_t109166502, ___m_Rounds_2)); }
	inline List_1_t184529417 * get_m_Rounds_2() const { return ___m_Rounds_2; }
	inline List_1_t184529417 ** get_address_of_m_Rounds_2() { return &___m_Rounds_2; }
	inline void set_m_Rounds_2(List_1_t184529417 * value)
	{
		___m_Rounds_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_Rounds_2, value);
	}

	inline static int32_t get_offset_of_m_CurrentRoundIndex_3() { return static_cast<int32_t>(offsetof(RoundModel_t109166502, ___m_CurrentRoundIndex_3)); }
	inline int32_t get_m_CurrentRoundIndex_3() const { return ___m_CurrentRoundIndex_3; }
	inline int32_t* get_address_of_m_CurrentRoundIndex_3() { return &___m_CurrentRoundIndex_3; }
	inline void set_m_CurrentRoundIndex_3(int32_t value)
	{
		___m_CurrentRoundIndex_3 = value;
	}

	inline static int32_t get_offset_of_m_IsCompleted_4() { return static_cast<int32_t>(offsetof(RoundModel_t109166502, ___m_IsCompleted_4)); }
	inline bool get_m_IsCompleted_4() const { return ___m_IsCompleted_4; }
	inline bool* get_address_of_m_IsCompleted_4() { return &___m_IsCompleted_4; }
	inline void set_m_IsCompleted_4(bool value)
	{
		___m_IsCompleted_4 = value;
	}

	inline static int32_t get_offset_of_m_RoundCoroutine_5() { return static_cast<int32_t>(offsetof(RoundModel_t109166502, ___m_RoundCoroutine_5)); }
	inline Coroutine_t3829159415 * get_m_RoundCoroutine_5() const { return ___m_RoundCoroutine_5; }
	inline Coroutine_t3829159415 ** get_address_of_m_RoundCoroutine_5() { return &___m_RoundCoroutine_5; }
	inline void set_m_RoundCoroutine_5(Coroutine_t3829159415 * value)
	{
		___m_RoundCoroutine_5 = value;
		Il2CppCodeGenWriteBarrier(&___m_RoundCoroutine_5, value);
	}

	inline static int32_t get_offset_of_Restarted_6() { return static_cast<int32_t>(offsetof(RoundModel_t109166502, ___Restarted_6)); }
	inline bool get_Restarted_6() const { return ___Restarted_6; }
	inline bool* get_address_of_Restarted_6() { return &___Restarted_6; }
	inline void set_Restarted_6(bool value)
	{
		___Restarted_6 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
