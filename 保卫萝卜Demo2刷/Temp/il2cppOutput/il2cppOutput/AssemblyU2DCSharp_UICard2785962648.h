#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour3962482529.h"

// System.Action`1<CardInfo>
struct Action_1_t3726885641;
// UnityEngine.UI.Image
struct Image_t2670269651;
// CardInfo
struct CardInfo_t3554418046;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UICard
struct  UICard_t2785962648  : public MonoBehaviour_t3962482529
{
public:
	// System.Action`1<CardInfo> UICard::OnCardClick
	Action_1_t3726885641 * ___OnCardClick_2;
	// UnityEngine.UI.Image UICard::m_CardImage
	Image_t2670269651 * ___m_CardImage_3;
	// UnityEngine.UI.Image UICard::m_LockImage
	Image_t2670269651 * ___m_LockImage_4;
	// CardInfo UICard::m_CardInfo
	CardInfo_t3554418046 * ___m_CardInfo_5;
	// System.Boolean UICard::m_IsTransparent
	bool ___m_IsTransparent_6;

public:
	inline static int32_t get_offset_of_OnCardClick_2() { return static_cast<int32_t>(offsetof(UICard_t2785962648, ___OnCardClick_2)); }
	inline Action_1_t3726885641 * get_OnCardClick_2() const { return ___OnCardClick_2; }
	inline Action_1_t3726885641 ** get_address_of_OnCardClick_2() { return &___OnCardClick_2; }
	inline void set_OnCardClick_2(Action_1_t3726885641 * value)
	{
		___OnCardClick_2 = value;
		Il2CppCodeGenWriteBarrier(&___OnCardClick_2, value);
	}

	inline static int32_t get_offset_of_m_CardImage_3() { return static_cast<int32_t>(offsetof(UICard_t2785962648, ___m_CardImage_3)); }
	inline Image_t2670269651 * get_m_CardImage_3() const { return ___m_CardImage_3; }
	inline Image_t2670269651 ** get_address_of_m_CardImage_3() { return &___m_CardImage_3; }
	inline void set_m_CardImage_3(Image_t2670269651 * value)
	{
		___m_CardImage_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_CardImage_3, value);
	}

	inline static int32_t get_offset_of_m_LockImage_4() { return static_cast<int32_t>(offsetof(UICard_t2785962648, ___m_LockImage_4)); }
	inline Image_t2670269651 * get_m_LockImage_4() const { return ___m_LockImage_4; }
	inline Image_t2670269651 ** get_address_of_m_LockImage_4() { return &___m_LockImage_4; }
	inline void set_m_LockImage_4(Image_t2670269651 * value)
	{
		___m_LockImage_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_LockImage_4, value);
	}

	inline static int32_t get_offset_of_m_CardInfo_5() { return static_cast<int32_t>(offsetof(UICard_t2785962648, ___m_CardInfo_5)); }
	inline CardInfo_t3554418046 * get_m_CardInfo_5() const { return ___m_CardInfo_5; }
	inline CardInfo_t3554418046 ** get_address_of_m_CardInfo_5() { return &___m_CardInfo_5; }
	inline void set_m_CardInfo_5(CardInfo_t3554418046 * value)
	{
		___m_CardInfo_5 = value;
		Il2CppCodeGenWriteBarrier(&___m_CardInfo_5, value);
	}

	inline static int32_t get_offset_of_m_IsTransparent_6() { return static_cast<int32_t>(offsetof(UICard_t2785962648, ___m_IsTransparent_6)); }
	inline bool get_m_IsTransparent_6() const { return ___m_IsTransparent_6; }
	inline bool* get_address_of_m_IsTransparent_6() { return &___m_IsTransparent_6; }
	inline void set_m_IsTransparent_6(bool value)
	{
		___m_IsTransparent_6 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
