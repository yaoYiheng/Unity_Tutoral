#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour3962482529.h"

// System.EventHandler`1<GridClickEventArgs>
struct EventHandler_1_t3314753545;
// Level
struct Level_t2237665516;
// System.Collections.Generic.List`1<GridInfo>
struct List_1_t2141832969;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Map
struct  Map_t1232705543  : public MonoBehaviour_t3962482529
{
public:
	// System.EventHandler`1<GridClickEventArgs> Map::OnGridClick
	EventHandler_1_t3314753545 * ___OnGridClick_4;
	// System.Single Map::m_MapWidth
	float ___m_MapWidth_5;
	// System.Single Map::m_MapHeight
	float ___m_MapHeight_6;
	// System.Single Map::m_GridWidth
	float ___m_GridWidth_7;
	// System.Single Map::m_GridHeight
	float ___m_GridHeight_8;
	// Level Map::m_Level
	Level_t2237665516 * ___m_Level_9;
	// System.Boolean Map::DrawGizmos
	bool ___DrawGizmos_10;
	// System.Collections.Generic.List`1<GridInfo> Map::m_GridsList
	List_1_t2141832969 * ___m_GridsList_11;
	// System.Collections.Generic.List`1<GridInfo> Map::m_PathesList
	List_1_t2141832969 * ___m_PathesList_12;

public:
	inline static int32_t get_offset_of_OnGridClick_4() { return static_cast<int32_t>(offsetof(Map_t1232705543, ___OnGridClick_4)); }
	inline EventHandler_1_t3314753545 * get_OnGridClick_4() const { return ___OnGridClick_4; }
	inline EventHandler_1_t3314753545 ** get_address_of_OnGridClick_4() { return &___OnGridClick_4; }
	inline void set_OnGridClick_4(EventHandler_1_t3314753545 * value)
	{
		___OnGridClick_4 = value;
		Il2CppCodeGenWriteBarrier(&___OnGridClick_4, value);
	}

	inline static int32_t get_offset_of_m_MapWidth_5() { return static_cast<int32_t>(offsetof(Map_t1232705543, ___m_MapWidth_5)); }
	inline float get_m_MapWidth_5() const { return ___m_MapWidth_5; }
	inline float* get_address_of_m_MapWidth_5() { return &___m_MapWidth_5; }
	inline void set_m_MapWidth_5(float value)
	{
		___m_MapWidth_5 = value;
	}

	inline static int32_t get_offset_of_m_MapHeight_6() { return static_cast<int32_t>(offsetof(Map_t1232705543, ___m_MapHeight_6)); }
	inline float get_m_MapHeight_6() const { return ___m_MapHeight_6; }
	inline float* get_address_of_m_MapHeight_6() { return &___m_MapHeight_6; }
	inline void set_m_MapHeight_6(float value)
	{
		___m_MapHeight_6 = value;
	}

	inline static int32_t get_offset_of_m_GridWidth_7() { return static_cast<int32_t>(offsetof(Map_t1232705543, ___m_GridWidth_7)); }
	inline float get_m_GridWidth_7() const { return ___m_GridWidth_7; }
	inline float* get_address_of_m_GridWidth_7() { return &___m_GridWidth_7; }
	inline void set_m_GridWidth_7(float value)
	{
		___m_GridWidth_7 = value;
	}

	inline static int32_t get_offset_of_m_GridHeight_8() { return static_cast<int32_t>(offsetof(Map_t1232705543, ___m_GridHeight_8)); }
	inline float get_m_GridHeight_8() const { return ___m_GridHeight_8; }
	inline float* get_address_of_m_GridHeight_8() { return &___m_GridHeight_8; }
	inline void set_m_GridHeight_8(float value)
	{
		___m_GridHeight_8 = value;
	}

	inline static int32_t get_offset_of_m_Level_9() { return static_cast<int32_t>(offsetof(Map_t1232705543, ___m_Level_9)); }
	inline Level_t2237665516 * get_m_Level_9() const { return ___m_Level_9; }
	inline Level_t2237665516 ** get_address_of_m_Level_9() { return &___m_Level_9; }
	inline void set_m_Level_9(Level_t2237665516 * value)
	{
		___m_Level_9 = value;
		Il2CppCodeGenWriteBarrier(&___m_Level_9, value);
	}

	inline static int32_t get_offset_of_DrawGizmos_10() { return static_cast<int32_t>(offsetof(Map_t1232705543, ___DrawGizmos_10)); }
	inline bool get_DrawGizmos_10() const { return ___DrawGizmos_10; }
	inline bool* get_address_of_DrawGizmos_10() { return &___DrawGizmos_10; }
	inline void set_DrawGizmos_10(bool value)
	{
		___DrawGizmos_10 = value;
	}

	inline static int32_t get_offset_of_m_GridsList_11() { return static_cast<int32_t>(offsetof(Map_t1232705543, ___m_GridsList_11)); }
	inline List_1_t2141832969 * get_m_GridsList_11() const { return ___m_GridsList_11; }
	inline List_1_t2141832969 ** get_address_of_m_GridsList_11() { return &___m_GridsList_11; }
	inline void set_m_GridsList_11(List_1_t2141832969 * value)
	{
		___m_GridsList_11 = value;
		Il2CppCodeGenWriteBarrier(&___m_GridsList_11, value);
	}

	inline static int32_t get_offset_of_m_PathesList_12() { return static_cast<int32_t>(offsetof(Map_t1232705543, ___m_PathesList_12)); }
	inline List_1_t2141832969 * get_m_PathesList_12() const { return ___m_PathesList_12; }
	inline List_1_t2141832969 ** get_address_of_m_PathesList_12() { return &___m_PathesList_12; }
	inline void set_m_PathesList_12(List_1_t2141832969 * value)
	{
		___m_PathesList_12 = value;
		Il2CppCodeGenWriteBarrier(&___m_PathesList_12, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
