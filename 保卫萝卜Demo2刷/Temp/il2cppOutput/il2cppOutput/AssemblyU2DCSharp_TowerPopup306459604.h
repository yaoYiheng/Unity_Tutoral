#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_View4100663493.h"

// TowerPopup
struct TowerPopup_t306459604;
// CreatPanel
struct CreatPanel_t4228869952;
// UpgradePanel
struct UpgradePanel_t940885652;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// TowerPopup
struct  TowerPopup_t306459604  : public View_t4100663493
{
public:
	// CreatPanel TowerPopup::CreatPanel
	CreatPanel_t4228869952 * ___CreatPanel_4;
	// UpgradePanel TowerPopup::UpgradePanel
	UpgradePanel_t940885652 * ___UpgradePanel_5;

public:
	inline static int32_t get_offset_of_CreatPanel_4() { return static_cast<int32_t>(offsetof(TowerPopup_t306459604, ___CreatPanel_4)); }
	inline CreatPanel_t4228869952 * get_CreatPanel_4() const { return ___CreatPanel_4; }
	inline CreatPanel_t4228869952 ** get_address_of_CreatPanel_4() { return &___CreatPanel_4; }
	inline void set_CreatPanel_4(CreatPanel_t4228869952 * value)
	{
		___CreatPanel_4 = value;
		Il2CppCodeGenWriteBarrier(&___CreatPanel_4, value);
	}

	inline static int32_t get_offset_of_UpgradePanel_5() { return static_cast<int32_t>(offsetof(TowerPopup_t306459604, ___UpgradePanel_5)); }
	inline UpgradePanel_t940885652 * get_UpgradePanel_5() const { return ___UpgradePanel_5; }
	inline UpgradePanel_t940885652 ** get_address_of_UpgradePanel_5() { return &___UpgradePanel_5; }
	inline void set_UpgradePanel_5(UpgradePanel_t940885652 * value)
	{
		___UpgradePanel_5 = value;
		Il2CppCodeGenWriteBarrier(&___UpgradePanel_5, value);
	}
};

struct TowerPopup_t306459604_StaticFields
{
public:
	// TowerPopup TowerPopup::m_Instance
	TowerPopup_t306459604 * ___m_Instance_3;

public:
	inline static int32_t get_offset_of_m_Instance_3() { return static_cast<int32_t>(offsetof(TowerPopup_t306459604_StaticFields, ___m_Instance_3)); }
	inline TowerPopup_t306459604 * get_m_Instance_3() const { return ___m_Instance_3; }
	inline TowerPopup_t306459604 ** get_address_of_m_Instance_3() { return &___m_Instance_3; }
	inline void set_m_Instance_3(TowerPopup_t306459604 * value)
	{
		___m_Instance_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_Instance_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
