﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_XPath_BaseIterator4168896842.h"

// System.Xml.XPath.XPathNodeIterator
struct XPathNodeIterator_t3667290188;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XPath.WrapperIterator
struct  WrapperIterator_t1258076988  : public BaseIterator_t4168896842
{
public:
	// System.Xml.XPath.XPathNodeIterator System.Xml.XPath.WrapperIterator::iter
	XPathNodeIterator_t3667290188 * ___iter_3;

public:
	inline static int32_t get_offset_of_iter_3() { return static_cast<int32_t>(offsetof(WrapperIterator_t1258076988, ___iter_3)); }
	inline XPathNodeIterator_t3667290188 * get_iter_3() const { return ___iter_3; }
	inline XPathNodeIterator_t3667290188 ** get_address_of_iter_3() { return &___iter_3; }
	inline void set_iter_3(XPathNodeIterator_t3667290188 * value)
	{
		___iter_3 = value;
		Il2CppCodeGenWriteBarrier(&___iter_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
