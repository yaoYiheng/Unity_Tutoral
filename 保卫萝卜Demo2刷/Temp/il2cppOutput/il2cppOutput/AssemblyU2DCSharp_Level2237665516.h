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
// System.Collections.Generic.List`1<Point>
struct List_1_t2510128191;
// System.Collections.Generic.List`1<Round>
struct List_1_t184529417;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Level
struct  Level_t2237665516  : public Il2CppObject
{
public:
	// System.String Level::Name
	String_t* ___Name_0;
	// System.String Level::CardImage
	String_t* ___CardImage_1;
	// System.String Level::Background
	String_t* ___Background_2;
	// System.String Level::Road
	String_t* ___Road_3;
	// System.Int32 Level::InitGold
	int32_t ___InitGold_4;
	// System.Collections.Generic.List`1<Point> Level::WeaponPos
	List_1_t2510128191 * ___WeaponPos_5;
	// System.Collections.Generic.List`1<Point> Level::MonsterRoute
	List_1_t2510128191 * ___MonsterRoute_6;
	// System.Collections.Generic.List`1<Round> Level::Rounds
	List_1_t184529417 * ___Rounds_7;

public:
	inline static int32_t get_offset_of_Name_0() { return static_cast<int32_t>(offsetof(Level_t2237665516, ___Name_0)); }
	inline String_t* get_Name_0() const { return ___Name_0; }
	inline String_t** get_address_of_Name_0() { return &___Name_0; }
	inline void set_Name_0(String_t* value)
	{
		___Name_0 = value;
		Il2CppCodeGenWriteBarrier(&___Name_0, value);
	}

	inline static int32_t get_offset_of_CardImage_1() { return static_cast<int32_t>(offsetof(Level_t2237665516, ___CardImage_1)); }
	inline String_t* get_CardImage_1() const { return ___CardImage_1; }
	inline String_t** get_address_of_CardImage_1() { return &___CardImage_1; }
	inline void set_CardImage_1(String_t* value)
	{
		___CardImage_1 = value;
		Il2CppCodeGenWriteBarrier(&___CardImage_1, value);
	}

	inline static int32_t get_offset_of_Background_2() { return static_cast<int32_t>(offsetof(Level_t2237665516, ___Background_2)); }
	inline String_t* get_Background_2() const { return ___Background_2; }
	inline String_t** get_address_of_Background_2() { return &___Background_2; }
	inline void set_Background_2(String_t* value)
	{
		___Background_2 = value;
		Il2CppCodeGenWriteBarrier(&___Background_2, value);
	}

	inline static int32_t get_offset_of_Road_3() { return static_cast<int32_t>(offsetof(Level_t2237665516, ___Road_3)); }
	inline String_t* get_Road_3() const { return ___Road_3; }
	inline String_t** get_address_of_Road_3() { return &___Road_3; }
	inline void set_Road_3(String_t* value)
	{
		___Road_3 = value;
		Il2CppCodeGenWriteBarrier(&___Road_3, value);
	}

	inline static int32_t get_offset_of_InitGold_4() { return static_cast<int32_t>(offsetof(Level_t2237665516, ___InitGold_4)); }
	inline int32_t get_InitGold_4() const { return ___InitGold_4; }
	inline int32_t* get_address_of_InitGold_4() { return &___InitGold_4; }
	inline void set_InitGold_4(int32_t value)
	{
		___InitGold_4 = value;
	}

	inline static int32_t get_offset_of_WeaponPos_5() { return static_cast<int32_t>(offsetof(Level_t2237665516, ___WeaponPos_5)); }
	inline List_1_t2510128191 * get_WeaponPos_5() const { return ___WeaponPos_5; }
	inline List_1_t2510128191 ** get_address_of_WeaponPos_5() { return &___WeaponPos_5; }
	inline void set_WeaponPos_5(List_1_t2510128191 * value)
	{
		___WeaponPos_5 = value;
		Il2CppCodeGenWriteBarrier(&___WeaponPos_5, value);
	}

	inline static int32_t get_offset_of_MonsterRoute_6() { return static_cast<int32_t>(offsetof(Level_t2237665516, ___MonsterRoute_6)); }
	inline List_1_t2510128191 * get_MonsterRoute_6() const { return ___MonsterRoute_6; }
	inline List_1_t2510128191 ** get_address_of_MonsterRoute_6() { return &___MonsterRoute_6; }
	inline void set_MonsterRoute_6(List_1_t2510128191 * value)
	{
		___MonsterRoute_6 = value;
		Il2CppCodeGenWriteBarrier(&___MonsterRoute_6, value);
	}

	inline static int32_t get_offset_of_Rounds_7() { return static_cast<int32_t>(offsetof(Level_t2237665516, ___Rounds_7)); }
	inline List_1_t184529417 * get_Rounds_7() const { return ___Rounds_7; }
	inline List_1_t184529417 ** get_address_of_Rounds_7() { return &___Rounds_7; }
	inline void set_Rounds_7(List_1_t184529417 * value)
	{
		___Rounds_7 = value;
		Il2CppCodeGenWriteBarrier(&___Rounds_7, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
