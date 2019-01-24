#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour3962482529.h"

// System.Collections.Generic.List`1<System.String>
struct List_1_t3319525431;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// View
struct  View_t4100663493  : public MonoBehaviour_t3962482529
{
public:
	// System.Collections.Generic.List`1<System.String> View::AttentionEventList
	List_1_t3319525431 * ___AttentionEventList_2;

public:
	inline static int32_t get_offset_of_AttentionEventList_2() { return static_cast<int32_t>(offsetof(View_t4100663493, ___AttentionEventList_2)); }
	inline List_1_t3319525431 * get_AttentionEventList_2() const { return ___AttentionEventList_2; }
	inline List_1_t3319525431 ** get_address_of_AttentionEventList_2() { return &___AttentionEventList_2; }
	inline void set_AttentionEventList_2(List_1_t3319525431 * value)
	{
		___AttentionEventList_2 = value;
		Il2CppCodeGenWriteBarrier(&___AttentionEventList_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
