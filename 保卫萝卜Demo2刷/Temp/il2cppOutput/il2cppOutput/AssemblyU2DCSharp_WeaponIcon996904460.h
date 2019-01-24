#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour3962482529.h"
#include "UnityEngine_UnityEngine_Vector33722313464.h"

// UnityEngine.SpriteRenderer
struct SpriteRenderer_t3235626157;
// TowerInfo
struct TowerInfo_t2968561753;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// WeaponIcon
struct  WeaponIcon_t996904460  : public MonoBehaviour_t3962482529
{
public:
	// UnityEngine.SpriteRenderer WeaponIcon::m_WeaponIcon
	SpriteRenderer_t3235626157 * ___m_WeaponIcon_2;
	// UnityEngine.Vector3 WeaponIcon::m_CreatPosition
	Vector3_t3722313464  ___m_CreatPosition_3;
	// TowerInfo WeaponIcon::m_TowerInfo
	TowerInfo_t2968561753 * ___m_TowerInfo_4;
	// System.Boolean WeaponIcon::m_IsEnough
	bool ___m_IsEnough_5;

public:
	inline static int32_t get_offset_of_m_WeaponIcon_2() { return static_cast<int32_t>(offsetof(WeaponIcon_t996904460, ___m_WeaponIcon_2)); }
	inline SpriteRenderer_t3235626157 * get_m_WeaponIcon_2() const { return ___m_WeaponIcon_2; }
	inline SpriteRenderer_t3235626157 ** get_address_of_m_WeaponIcon_2() { return &___m_WeaponIcon_2; }
	inline void set_m_WeaponIcon_2(SpriteRenderer_t3235626157 * value)
	{
		___m_WeaponIcon_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_WeaponIcon_2, value);
	}

	inline static int32_t get_offset_of_m_CreatPosition_3() { return static_cast<int32_t>(offsetof(WeaponIcon_t996904460, ___m_CreatPosition_3)); }
	inline Vector3_t3722313464  get_m_CreatPosition_3() const { return ___m_CreatPosition_3; }
	inline Vector3_t3722313464 * get_address_of_m_CreatPosition_3() { return &___m_CreatPosition_3; }
	inline void set_m_CreatPosition_3(Vector3_t3722313464  value)
	{
		___m_CreatPosition_3 = value;
	}

	inline static int32_t get_offset_of_m_TowerInfo_4() { return static_cast<int32_t>(offsetof(WeaponIcon_t996904460, ___m_TowerInfo_4)); }
	inline TowerInfo_t2968561753 * get_m_TowerInfo_4() const { return ___m_TowerInfo_4; }
	inline TowerInfo_t2968561753 ** get_address_of_m_TowerInfo_4() { return &___m_TowerInfo_4; }
	inline void set_m_TowerInfo_4(TowerInfo_t2968561753 * value)
	{
		___m_TowerInfo_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_TowerInfo_4, value);
	}

	inline static int32_t get_offset_of_m_IsEnough_5() { return static_cast<int32_t>(offsetof(WeaponIcon_t996904460, ___m_IsEnough_5)); }
	inline bool get_m_IsEnough_5() const { return ___m_IsEnough_5; }
	inline bool* get_address_of_m_IsEnough_5() { return &___m_IsEnough_5; }
	inline void set_m_IsEnough_5(bool value)
	{
		___m_IsEnough_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
