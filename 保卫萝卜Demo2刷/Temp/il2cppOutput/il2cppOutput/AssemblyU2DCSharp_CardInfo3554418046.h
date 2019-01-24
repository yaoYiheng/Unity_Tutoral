#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object3080106164.h"

// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// CardInfo
struct  CardInfo_t3554418046  : public Il2CppObject
{
public:
	// System.Int32 CardInfo::LevelIndex
	int32_t ___LevelIndex_0;
	// System.String CardInfo::CardName
	String_t* ___CardName_1;
	// System.Boolean CardInfo::IsLocked
	bool ___IsLocked_2;

public:
	inline static int32_t get_offset_of_LevelIndex_0() { return static_cast<int32_t>(offsetof(CardInfo_t3554418046, ___LevelIndex_0)); }
	inline int32_t get_LevelIndex_0() const { return ___LevelIndex_0; }
	inline int32_t* get_address_of_LevelIndex_0() { return &___LevelIndex_0; }
	inline void set_LevelIndex_0(int32_t value)
	{
		___LevelIndex_0 = value;
	}

	inline static int32_t get_offset_of_CardName_1() { return static_cast<int32_t>(offsetof(CardInfo_t3554418046, ___CardName_1)); }
	inline String_t* get_CardName_1() const { return ___CardName_1; }
	inline String_t** get_address_of_CardName_1() { return &___CardName_1; }
	inline void set_CardName_1(String_t* value)
	{
		___CardName_1 = value;
		Il2CppCodeGenWriteBarrier(&___CardName_1, value);
	}

	inline static int32_t get_offset_of_IsLocked_2() { return static_cast<int32_t>(offsetof(CardInfo_t3554418046, ___IsLocked_2)); }
	inline bool get_IsLocked_2() const { return ___IsLocked_2; }
	inline bool* get_address_of_IsLocked_2() { return &___IsLocked_2; }
	inline void set_IsLocked_2(bool value)
	{
		___IsLocked_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
