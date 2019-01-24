#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_View4100663493.h"

// UnityEngine.UI.Text
struct Text_t1901882714;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UIWin
struct  UIWin_t1635840832  : public View_t4100663493
{
public:
	// UnityEngine.UI.Text UIWin::txtCurrent
	Text_t1901882714 * ___txtCurrent_3;
	// UnityEngine.UI.Text UIWin::txtTotal
	Text_t1901882714 * ___txtTotal_4;

public:
	inline static int32_t get_offset_of_txtCurrent_3() { return static_cast<int32_t>(offsetof(UIWin_t1635840832, ___txtCurrent_3)); }
	inline Text_t1901882714 * get_txtCurrent_3() const { return ___txtCurrent_3; }
	inline Text_t1901882714 ** get_address_of_txtCurrent_3() { return &___txtCurrent_3; }
	inline void set_txtCurrent_3(Text_t1901882714 * value)
	{
		___txtCurrent_3 = value;
		Il2CppCodeGenWriteBarrier(&___txtCurrent_3, value);
	}

	inline static int32_t get_offset_of_txtTotal_4() { return static_cast<int32_t>(offsetof(UIWin_t1635840832, ___txtTotal_4)); }
	inline Text_t1901882714 * get_txtTotal_4() const { return ___txtTotal_4; }
	inline Text_t1901882714 ** get_address_of_txtTotal_4() { return &___txtTotal_4; }
	inline void set_txtTotal_4(Text_t1901882714 * value)
	{
		___txtTotal_4 = value;
		Il2CppCodeGenWriteBarrier(&___txtTotal_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
