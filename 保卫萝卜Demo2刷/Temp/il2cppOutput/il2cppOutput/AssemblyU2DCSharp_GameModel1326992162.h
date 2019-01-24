#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_Model1800302981.h"

// System.Collections.Generic.List`1<Level>
struct List_1_t3709740258;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GameModel
struct  GameModel_t1326992162  : public Model_t1800302981
{
public:
	// System.Int32 GameModel::m_Gold
	int32_t ___m_Gold_0;
	// System.Boolean GameModel::m_IsPlaying
	bool ___m_IsPlaying_1;
	// System.Collections.Generic.List`1<Level> GameModel::m_Levels
	List_1_t3709740258 * ___m_Levels_2;
	// System.Int32 GameModel::m_CurrentPlayingIndex
	int32_t ___m_CurrentPlayingIndex_3;
	// System.Int32 GameModel::m_GameProgress
	int32_t ___m_GameProgress_4;
	// System.Boolean GameModel::m_IsInit
	bool ___m_IsInit_5;

public:
	inline static int32_t get_offset_of_m_Gold_0() { return static_cast<int32_t>(offsetof(GameModel_t1326992162, ___m_Gold_0)); }
	inline int32_t get_m_Gold_0() const { return ___m_Gold_0; }
	inline int32_t* get_address_of_m_Gold_0() { return &___m_Gold_0; }
	inline void set_m_Gold_0(int32_t value)
	{
		___m_Gold_0 = value;
	}

	inline static int32_t get_offset_of_m_IsPlaying_1() { return static_cast<int32_t>(offsetof(GameModel_t1326992162, ___m_IsPlaying_1)); }
	inline bool get_m_IsPlaying_1() const { return ___m_IsPlaying_1; }
	inline bool* get_address_of_m_IsPlaying_1() { return &___m_IsPlaying_1; }
	inline void set_m_IsPlaying_1(bool value)
	{
		___m_IsPlaying_1 = value;
	}

	inline static int32_t get_offset_of_m_Levels_2() { return static_cast<int32_t>(offsetof(GameModel_t1326992162, ___m_Levels_2)); }
	inline List_1_t3709740258 * get_m_Levels_2() const { return ___m_Levels_2; }
	inline List_1_t3709740258 ** get_address_of_m_Levels_2() { return &___m_Levels_2; }
	inline void set_m_Levels_2(List_1_t3709740258 * value)
	{
		___m_Levels_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_Levels_2, value);
	}

	inline static int32_t get_offset_of_m_CurrentPlayingIndex_3() { return static_cast<int32_t>(offsetof(GameModel_t1326992162, ___m_CurrentPlayingIndex_3)); }
	inline int32_t get_m_CurrentPlayingIndex_3() const { return ___m_CurrentPlayingIndex_3; }
	inline int32_t* get_address_of_m_CurrentPlayingIndex_3() { return &___m_CurrentPlayingIndex_3; }
	inline void set_m_CurrentPlayingIndex_3(int32_t value)
	{
		___m_CurrentPlayingIndex_3 = value;
	}

	inline static int32_t get_offset_of_m_GameProgress_4() { return static_cast<int32_t>(offsetof(GameModel_t1326992162, ___m_GameProgress_4)); }
	inline int32_t get_m_GameProgress_4() const { return ___m_GameProgress_4; }
	inline int32_t* get_address_of_m_GameProgress_4() { return &___m_GameProgress_4; }
	inline void set_m_GameProgress_4(int32_t value)
	{
		___m_GameProgress_4 = value;
	}

	inline static int32_t get_offset_of_m_IsInit_5() { return static_cast<int32_t>(offsetof(GameModel_t1326992162, ___m_IsInit_5)); }
	inline bool get_m_IsInit_5() const { return ___m_IsInit_5; }
	inline bool* get_address_of_m_IsInit_5() { return &___m_IsInit_5; }
	inline void set_m_IsInit_5(bool value)
	{
		___m_IsInit_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
