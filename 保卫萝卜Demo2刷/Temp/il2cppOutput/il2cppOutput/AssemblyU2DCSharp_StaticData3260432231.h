#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_Singleton_1_gen142311680.h"

// System.Collections.Generic.Dictionary`2<System.Int32,MonsterInfo>
struct Dictionary_2_t2068415952;
// System.Collections.Generic.Dictionary`2<System.Int32,LuoboInfo>
struct Dictionary_2_t3895395424;
// System.Collections.Generic.Dictionary`2<System.Int32,TowerInfo>
struct Dictionary_2_t1857275084;
// System.Collections.Generic.Dictionary`2<System.Int32,BulletInfo>
struct Dictionary_2_t2261886287;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// StaticData
struct  StaticData_t3260432231  : public Singleton_1_t142311680
{
public:
	// System.Collections.Generic.Dictionary`2<System.Int32,MonsterInfo> StaticData::m_Monsters
	Dictionary_2_t2068415952 * ___m_Monsters_3;
	// System.Collections.Generic.Dictionary`2<System.Int32,LuoboInfo> StaticData::m_Luobo
	Dictionary_2_t3895395424 * ___m_Luobo_4;
	// System.Collections.Generic.Dictionary`2<System.Int32,TowerInfo> StaticData::m_Towers
	Dictionary_2_t1857275084 * ___m_Towers_5;
	// System.Collections.Generic.Dictionary`2<System.Int32,BulletInfo> StaticData::m_Bullets
	Dictionary_2_t2261886287 * ___m_Bullets_6;

public:
	inline static int32_t get_offset_of_m_Monsters_3() { return static_cast<int32_t>(offsetof(StaticData_t3260432231, ___m_Monsters_3)); }
	inline Dictionary_2_t2068415952 * get_m_Monsters_3() const { return ___m_Monsters_3; }
	inline Dictionary_2_t2068415952 ** get_address_of_m_Monsters_3() { return &___m_Monsters_3; }
	inline void set_m_Monsters_3(Dictionary_2_t2068415952 * value)
	{
		___m_Monsters_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_Monsters_3, value);
	}

	inline static int32_t get_offset_of_m_Luobo_4() { return static_cast<int32_t>(offsetof(StaticData_t3260432231, ___m_Luobo_4)); }
	inline Dictionary_2_t3895395424 * get_m_Luobo_4() const { return ___m_Luobo_4; }
	inline Dictionary_2_t3895395424 ** get_address_of_m_Luobo_4() { return &___m_Luobo_4; }
	inline void set_m_Luobo_4(Dictionary_2_t3895395424 * value)
	{
		___m_Luobo_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_Luobo_4, value);
	}

	inline static int32_t get_offset_of_m_Towers_5() { return static_cast<int32_t>(offsetof(StaticData_t3260432231, ___m_Towers_5)); }
	inline Dictionary_2_t1857275084 * get_m_Towers_5() const { return ___m_Towers_5; }
	inline Dictionary_2_t1857275084 ** get_address_of_m_Towers_5() { return &___m_Towers_5; }
	inline void set_m_Towers_5(Dictionary_2_t1857275084 * value)
	{
		___m_Towers_5 = value;
		Il2CppCodeGenWriteBarrier(&___m_Towers_5, value);
	}

	inline static int32_t get_offset_of_m_Bullets_6() { return static_cast<int32_t>(offsetof(StaticData_t3260432231, ___m_Bullets_6)); }
	inline Dictionary_2_t2261886287 * get_m_Bullets_6() const { return ___m_Bullets_6; }
	inline Dictionary_2_t2261886287 ** get_address_of_m_Bullets_6() { return &___m_Bullets_6; }
	inline void set_m_Bullets_6(Dictionary_2_t2261886287 * value)
	{
		___m_Bullets_6 = value;
		Il2CppCodeGenWriteBarrier(&___m_Bullets_6, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
