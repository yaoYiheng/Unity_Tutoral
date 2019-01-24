#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object3080106164.h"
#include "UnityEngine_UnityEngine_Vector33722313464.h"





#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// SpawnTowerArgs
struct  SpawnTowerArgs_t4067361295  : public Il2CppObject
{
public:
	// System.Int32 SpawnTowerArgs::TowerID
	int32_t ___TowerID_0;
	// UnityEngine.Vector3 SpawnTowerArgs::Position
	Vector3_t3722313464  ___Position_1;

public:
	inline static int32_t get_offset_of_TowerID_0() { return static_cast<int32_t>(offsetof(SpawnTowerArgs_t4067361295, ___TowerID_0)); }
	inline int32_t get_TowerID_0() const { return ___TowerID_0; }
	inline int32_t* get_address_of_TowerID_0() { return &___TowerID_0; }
	inline void set_TowerID_0(int32_t value)
	{
		___TowerID_0 = value;
	}

	inline static int32_t get_offset_of_Position_1() { return static_cast<int32_t>(offsetof(SpawnTowerArgs_t4067361295, ___Position_1)); }
	inline Vector3_t3722313464  get_Position_1() const { return ___Position_1; }
	inline Vector3_t3722313464 * get_address_of_Position_1() { return &___Position_1; }
	inline void set_Position_1(Vector3_t3722313464  value)
	{
		___Position_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
