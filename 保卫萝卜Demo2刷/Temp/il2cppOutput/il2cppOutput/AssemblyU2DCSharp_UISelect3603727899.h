#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_View4100663493.h"

// UnityEngine.UI.Button
struct Button_t4055032469;
// System.Collections.Generic.List`1<CardInfo>
struct List_1_t731525492;
// GameModel
struct GameModel_t1326992162;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UISelect
struct  UISelect_t3603727899  : public View_t4100663493
{
public:
	// UnityEngine.UI.Button UISelect::StartButton
	Button_t4055032469 * ___StartButton_3;
	// System.Collections.Generic.List`1<CardInfo> UISelect::m_Cards
	List_1_t731525492 * ___m_Cards_4;
	// System.Int32 UISelect::m_SelectIndex
	int32_t ___m_SelectIndex_5;
	// GameModel UISelect::m_GameModel
	GameModel_t1326992162 * ___m_GameModel_6;

public:
	inline static int32_t get_offset_of_StartButton_3() { return static_cast<int32_t>(offsetof(UISelect_t3603727899, ___StartButton_3)); }
	inline Button_t4055032469 * get_StartButton_3() const { return ___StartButton_3; }
	inline Button_t4055032469 ** get_address_of_StartButton_3() { return &___StartButton_3; }
	inline void set_StartButton_3(Button_t4055032469 * value)
	{
		___StartButton_3 = value;
		Il2CppCodeGenWriteBarrier(&___StartButton_3, value);
	}

	inline static int32_t get_offset_of_m_Cards_4() { return static_cast<int32_t>(offsetof(UISelect_t3603727899, ___m_Cards_4)); }
	inline List_1_t731525492 * get_m_Cards_4() const { return ___m_Cards_4; }
	inline List_1_t731525492 ** get_address_of_m_Cards_4() { return &___m_Cards_4; }
	inline void set_m_Cards_4(List_1_t731525492 * value)
	{
		___m_Cards_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_Cards_4, value);
	}

	inline static int32_t get_offset_of_m_SelectIndex_5() { return static_cast<int32_t>(offsetof(UISelect_t3603727899, ___m_SelectIndex_5)); }
	inline int32_t get_m_SelectIndex_5() const { return ___m_SelectIndex_5; }
	inline int32_t* get_address_of_m_SelectIndex_5() { return &___m_SelectIndex_5; }
	inline void set_m_SelectIndex_5(int32_t value)
	{
		___m_SelectIndex_5 = value;
	}

	inline static int32_t get_offset_of_m_GameModel_6() { return static_cast<int32_t>(offsetof(UISelect_t3603727899, ___m_GameModel_6)); }
	inline GameModel_t1326992162 * get_m_GameModel_6() const { return ___m_GameModel_6; }
	inline GameModel_t1326992162 ** get_address_of_m_GameModel_6() { return &___m_GameModel_6; }
	inline void set_m_GameModel_6(GameModel_t1326992162 * value)
	{
		___m_GameModel_6 = value;
		Il2CppCodeGenWriteBarrier(&___m_GameModel_6, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
