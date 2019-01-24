#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_Role2633764694.h"
#include "AssemblyU2DCSharp_MonsterType2073484120.h"

// System.Action`1<Monster>
struct Action_1_t1222187370;
// UnityEngine.Vector3[]
struct Vector3U5BU5D_t1718750761;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Monster
struct  Monster_t1049719775  : public Role_t2633764694
{
public:
	// System.Action`1<Monster> Monster::Reach
	Action_1_t1222187370 * ___Reach_7;
	// System.Int32 Monster::m_MoveSpeed
	int32_t ___m_MoveSpeed_8;
	// UnityEngine.Vector3[] Monster::m_Path
	Vector3U5BU5D_t1718750761* ___m_Path_9;
	// System.Boolean Monster::m_IsReached
	bool ___m_IsReached_10;
	// MonsterType Monster::MonsterType
	int32_t ___MonsterType_11;
	// System.Int32 Monster::m_CurrentIndex
	int32_t ___m_CurrentIndex_12;
	// System.Int32 Monster::m_MonsterID
	int32_t ___m_MonsterID_13;

public:
	inline static int32_t get_offset_of_Reach_7() { return static_cast<int32_t>(offsetof(Monster_t1049719775, ___Reach_7)); }
	inline Action_1_t1222187370 * get_Reach_7() const { return ___Reach_7; }
	inline Action_1_t1222187370 ** get_address_of_Reach_7() { return &___Reach_7; }
	inline void set_Reach_7(Action_1_t1222187370 * value)
	{
		___Reach_7 = value;
		Il2CppCodeGenWriteBarrier(&___Reach_7, value);
	}

	inline static int32_t get_offset_of_m_MoveSpeed_8() { return static_cast<int32_t>(offsetof(Monster_t1049719775, ___m_MoveSpeed_8)); }
	inline int32_t get_m_MoveSpeed_8() const { return ___m_MoveSpeed_8; }
	inline int32_t* get_address_of_m_MoveSpeed_8() { return &___m_MoveSpeed_8; }
	inline void set_m_MoveSpeed_8(int32_t value)
	{
		___m_MoveSpeed_8 = value;
	}

	inline static int32_t get_offset_of_m_Path_9() { return static_cast<int32_t>(offsetof(Monster_t1049719775, ___m_Path_9)); }
	inline Vector3U5BU5D_t1718750761* get_m_Path_9() const { return ___m_Path_9; }
	inline Vector3U5BU5D_t1718750761** get_address_of_m_Path_9() { return &___m_Path_9; }
	inline void set_m_Path_9(Vector3U5BU5D_t1718750761* value)
	{
		___m_Path_9 = value;
		Il2CppCodeGenWriteBarrier(&___m_Path_9, value);
	}

	inline static int32_t get_offset_of_m_IsReached_10() { return static_cast<int32_t>(offsetof(Monster_t1049719775, ___m_IsReached_10)); }
	inline bool get_m_IsReached_10() const { return ___m_IsReached_10; }
	inline bool* get_address_of_m_IsReached_10() { return &___m_IsReached_10; }
	inline void set_m_IsReached_10(bool value)
	{
		___m_IsReached_10 = value;
	}

	inline static int32_t get_offset_of_MonsterType_11() { return static_cast<int32_t>(offsetof(Monster_t1049719775, ___MonsterType_11)); }
	inline int32_t get_MonsterType_11() const { return ___MonsterType_11; }
	inline int32_t* get_address_of_MonsterType_11() { return &___MonsterType_11; }
	inline void set_MonsterType_11(int32_t value)
	{
		___MonsterType_11 = value;
	}

	inline static int32_t get_offset_of_m_CurrentIndex_12() { return static_cast<int32_t>(offsetof(Monster_t1049719775, ___m_CurrentIndex_12)); }
	inline int32_t get_m_CurrentIndex_12() const { return ___m_CurrentIndex_12; }
	inline int32_t* get_address_of_m_CurrentIndex_12() { return &___m_CurrentIndex_12; }
	inline void set_m_CurrentIndex_12(int32_t value)
	{
		___m_CurrentIndex_12 = value;
	}

	inline static int32_t get_offset_of_m_MonsterID_13() { return static_cast<int32_t>(offsetof(Monster_t1049719775, ___m_MonsterID_13)); }
	inline int32_t get_m_MonsterID_13() const { return ___m_MonsterID_13; }
	inline int32_t* get_address_of_m_MonsterID_13() { return &___m_MonsterID_13; }
	inline void set_m_MonsterID_13(int32_t value)
	{
		___m_MonsterID_13 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
