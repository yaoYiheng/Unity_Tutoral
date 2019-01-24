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

// BulletInfo
struct  BulletInfo_t3373172956  : public Il2CppObject
{
public:
	// System.Int32 BulletInfo::BulletID
	int32_t ___BulletID_0;
	// System.String BulletInfo::PrefabName
	String_t* ___PrefabName_1;
	// System.Int32 BulletInfo::BaseSpeed
	int32_t ___BaseSpeed_2;
	// System.Int32 BulletInfo::AttackPoint
	int32_t ___AttackPoint_3;

public:
	inline static int32_t get_offset_of_BulletID_0() { return static_cast<int32_t>(offsetof(BulletInfo_t3373172956, ___BulletID_0)); }
	inline int32_t get_BulletID_0() const { return ___BulletID_0; }
	inline int32_t* get_address_of_BulletID_0() { return &___BulletID_0; }
	inline void set_BulletID_0(int32_t value)
	{
		___BulletID_0 = value;
	}

	inline static int32_t get_offset_of_PrefabName_1() { return static_cast<int32_t>(offsetof(BulletInfo_t3373172956, ___PrefabName_1)); }
	inline String_t* get_PrefabName_1() const { return ___PrefabName_1; }
	inline String_t** get_address_of_PrefabName_1() { return &___PrefabName_1; }
	inline void set_PrefabName_1(String_t* value)
	{
		___PrefabName_1 = value;
		Il2CppCodeGenWriteBarrier(&___PrefabName_1, value);
	}

	inline static int32_t get_offset_of_BaseSpeed_2() { return static_cast<int32_t>(offsetof(BulletInfo_t3373172956, ___BaseSpeed_2)); }
	inline int32_t get_BaseSpeed_2() const { return ___BaseSpeed_2; }
	inline int32_t* get_address_of_BaseSpeed_2() { return &___BaseSpeed_2; }
	inline void set_BaseSpeed_2(int32_t value)
	{
		___BaseSpeed_2 = value;
	}

	inline static int32_t get_offset_of_AttackPoint_3() { return static_cast<int32_t>(offsetof(BulletInfo_t3373172956, ___AttackPoint_3)); }
	inline int32_t get_AttackPoint_3() const { return ___AttackPoint_3; }
	inline int32_t* get_address_of_AttackPoint_3() { return &___AttackPoint_3; }
	inline void set_AttackPoint_3(int32_t value)
	{
		___AttackPoint_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
