#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_View4100663493.h"

// UnityEngine.Sprite[]
struct SpriteU5BU5D_t2581906349;
// UnityEngine.UI.Image
struct Image_t2670269651;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UICountDown
struct  UICountDown_t3054287991  : public View_t4100663493
{
public:
	// UnityEngine.Sprite[] UICountDown::NumberSprite
	SpriteU5BU5D_t2581906349* ___NumberSprite_3;
	// UnityEngine.UI.Image UICountDown::m_Count
	Image_t2670269651 * ___m_Count_4;

public:
	inline static int32_t get_offset_of_NumberSprite_3() { return static_cast<int32_t>(offsetof(UICountDown_t3054287991, ___NumberSprite_3)); }
	inline SpriteU5BU5D_t2581906349* get_NumberSprite_3() const { return ___NumberSprite_3; }
	inline SpriteU5BU5D_t2581906349** get_address_of_NumberSprite_3() { return &___NumberSprite_3; }
	inline void set_NumberSprite_3(SpriteU5BU5D_t2581906349* value)
	{
		___NumberSprite_3 = value;
		Il2CppCodeGenWriteBarrier(&___NumberSprite_3, value);
	}

	inline static int32_t get_offset_of_m_Count_4() { return static_cast<int32_t>(offsetof(UICountDown_t3054287991, ___m_Count_4)); }
	inline Image_t2670269651 * get_m_Count_4() const { return ___m_Count_4; }
	inline Image_t2670269651 ** get_address_of_m_Count_4() { return &___m_Count_4; }
	inline void set_m_Count_4(Image_t2670269651 * value)
	{
		___m_Count_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_Count_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
