#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_Bullet1042140031.h"
#include "UnityEngine_UnityEngine_Vector33722313464.h"

// Monster
struct Monster_t1049719775;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// BallBullet
struct  BallBullet_t3600799918  : public Bullet_t1042140031
{
public:
	// Monster BallBullet::m_Target
	Monster_t1049719775 * ___m_Target_10;
	// UnityEngine.Vector3 BallBullet::<Direction>k__BackingField
	Vector3_t3722313464  ___U3CDirectionU3Ek__BackingField_11;

public:
	inline static int32_t get_offset_of_m_Target_10() { return static_cast<int32_t>(offsetof(BallBullet_t3600799918, ___m_Target_10)); }
	inline Monster_t1049719775 * get_m_Target_10() const { return ___m_Target_10; }
	inline Monster_t1049719775 ** get_address_of_m_Target_10() { return &___m_Target_10; }
	inline void set_m_Target_10(Monster_t1049719775 * value)
	{
		___m_Target_10 = value;
		Il2CppCodeGenWriteBarrier(&___m_Target_10, value);
	}

	inline static int32_t get_offset_of_U3CDirectionU3Ek__BackingField_11() { return static_cast<int32_t>(offsetof(BallBullet_t3600799918, ___U3CDirectionU3Ek__BackingField_11)); }
	inline Vector3_t3722313464  get_U3CDirectionU3Ek__BackingField_11() const { return ___U3CDirectionU3Ek__BackingField_11; }
	inline Vector3_t3722313464 * get_address_of_U3CDirectionU3Ek__BackingField_11() { return &___U3CDirectionU3Ek__BackingField_11; }
	inline void set_U3CDirectionU3Ek__BackingField_11(Vector3_t3722313464  value)
	{
		___U3CDirectionU3Ek__BackingField_11 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
