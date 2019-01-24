#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_Singleton_1_gen4184268491.h"

// System.String
struct String_t;
// UnityEngine.AudioSource
struct AudioSource_t3935305588;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Sound
struct  Sound_t3007421746  : public Singleton_1_t4184268491
{
public:
	// System.String Sound::RescousePath
	String_t* ___RescousePath_3;
	// UnityEngine.AudioSource Sound::m_BgSource
	AudioSource_t3935305588 * ___m_BgSource_4;
	// UnityEngine.AudioSource Sound::m_EffectSource
	AudioSource_t3935305588 * ___m_EffectSource_5;

public:
	inline static int32_t get_offset_of_RescousePath_3() { return static_cast<int32_t>(offsetof(Sound_t3007421746, ___RescousePath_3)); }
	inline String_t* get_RescousePath_3() const { return ___RescousePath_3; }
	inline String_t** get_address_of_RescousePath_3() { return &___RescousePath_3; }
	inline void set_RescousePath_3(String_t* value)
	{
		___RescousePath_3 = value;
		Il2CppCodeGenWriteBarrier(&___RescousePath_3, value);
	}

	inline static int32_t get_offset_of_m_BgSource_4() { return static_cast<int32_t>(offsetof(Sound_t3007421746, ___m_BgSource_4)); }
	inline AudioSource_t3935305588 * get_m_BgSource_4() const { return ___m_BgSource_4; }
	inline AudioSource_t3935305588 ** get_address_of_m_BgSource_4() { return &___m_BgSource_4; }
	inline void set_m_BgSource_4(AudioSource_t3935305588 * value)
	{
		___m_BgSource_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_BgSource_4, value);
	}

	inline static int32_t get_offset_of_m_EffectSource_5() { return static_cast<int32_t>(offsetof(Sound_t3007421746, ___m_EffectSource_5)); }
	inline AudioSource_t3935305588 * get_m_EffectSource_5() const { return ___m_EffectSource_5; }
	inline AudioSource_t3935305588 ** get_address_of_m_EffectSource_5() { return &___m_EffectSource_5; }
	inline void set_m_EffectSource_5(AudioSource_t3935305588 * value)
	{
		___m_EffectSource_5 = value;
		Il2CppCodeGenWriteBarrier(&___m_EffectSource_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
