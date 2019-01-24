#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_ApplicationBase_1_gen3076642620.h"

// ObjectPool
struct ObjectPool_t251773294;
// Sound
struct Sound_t3007421746;
// StaticData
struct StaticData_t3260432231;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Game
struct  Game_t1067549660  : public ApplicationBase_1_t3076642620
{
public:
	// ObjectPool Game::ObjectPool
	ObjectPool_t251773294 * ___ObjectPool_3;
	// Sound Game::Sound
	Sound_t3007421746 * ___Sound_4;
	// StaticData Game::StaticData
	StaticData_t3260432231 * ___StaticData_5;

public:
	inline static int32_t get_offset_of_ObjectPool_3() { return static_cast<int32_t>(offsetof(Game_t1067549660, ___ObjectPool_3)); }
	inline ObjectPool_t251773294 * get_ObjectPool_3() const { return ___ObjectPool_3; }
	inline ObjectPool_t251773294 ** get_address_of_ObjectPool_3() { return &___ObjectPool_3; }
	inline void set_ObjectPool_3(ObjectPool_t251773294 * value)
	{
		___ObjectPool_3 = value;
		Il2CppCodeGenWriteBarrier(&___ObjectPool_3, value);
	}

	inline static int32_t get_offset_of_Sound_4() { return static_cast<int32_t>(offsetof(Game_t1067549660, ___Sound_4)); }
	inline Sound_t3007421746 * get_Sound_4() const { return ___Sound_4; }
	inline Sound_t3007421746 ** get_address_of_Sound_4() { return &___Sound_4; }
	inline void set_Sound_4(Sound_t3007421746 * value)
	{
		___Sound_4 = value;
		Il2CppCodeGenWriteBarrier(&___Sound_4, value);
	}

	inline static int32_t get_offset_of_StaticData_5() { return static_cast<int32_t>(offsetof(Game_t1067549660, ___StaticData_5)); }
	inline StaticData_t3260432231 * get_StaticData_5() const { return ___StaticData_5; }
	inline StaticData_t3260432231 ** get_address_of_StaticData_5() { return &___StaticData_5; }
	inline void set_StaticData_5(StaticData_t3260432231 * value)
	{
		___StaticData_5 = value;
		Il2CppCodeGenWriteBarrier(&___StaticData_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
