#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour3962482529.h"

// UpgradeIcon
struct UpgradeIcon_t1709491177;
// SellIcon
struct SellIcon_t1076240179;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UpgradePanel
struct  UpgradePanel_t940885652  : public MonoBehaviour_t3962482529
{
public:
	// UpgradeIcon UpgradePanel::m_UpgradeIcon
	UpgradeIcon_t1709491177 * ___m_UpgradeIcon_2;
	// SellIcon UpgradePanel::m_SellIcon
	SellIcon_t1076240179 * ___m_SellIcon_3;

public:
	inline static int32_t get_offset_of_m_UpgradeIcon_2() { return static_cast<int32_t>(offsetof(UpgradePanel_t940885652, ___m_UpgradeIcon_2)); }
	inline UpgradeIcon_t1709491177 * get_m_UpgradeIcon_2() const { return ___m_UpgradeIcon_2; }
	inline UpgradeIcon_t1709491177 ** get_address_of_m_UpgradeIcon_2() { return &___m_UpgradeIcon_2; }
	inline void set_m_UpgradeIcon_2(UpgradeIcon_t1709491177 * value)
	{
		___m_UpgradeIcon_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_UpgradeIcon_2, value);
	}

	inline static int32_t get_offset_of_m_SellIcon_3() { return static_cast<int32_t>(offsetof(UpgradePanel_t940885652, ___m_SellIcon_3)); }
	inline SellIcon_t1076240179 * get_m_SellIcon_3() const { return ___m_SellIcon_3; }
	inline SellIcon_t1076240179 ** get_address_of_m_SellIcon_3() { return &___m_SellIcon_3; }
	inline void set_m_SellIcon_3(SellIcon_t1076240179 * value)
	{
		___m_SellIcon_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_SellIcon_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
