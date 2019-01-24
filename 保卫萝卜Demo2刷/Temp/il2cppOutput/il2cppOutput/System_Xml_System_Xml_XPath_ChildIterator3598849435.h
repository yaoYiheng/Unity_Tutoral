#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_XPath_BaseIterator4168896842.h"

// System.Xml.XPath.XPathNavigator
struct XPathNavigator_t787956054;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XPath.ChildIterator
struct  ChildIterator_t3598849435  : public BaseIterator_t4168896842
{
public:
	// System.Xml.XPath.XPathNavigator System.Xml.XPath.ChildIterator::_nav
	XPathNavigator_t787956054 * ____nav_3;

public:
	inline static int32_t get_offset_of__nav_3() { return static_cast<int32_t>(offsetof(ChildIterator_t3598849435, ____nav_3)); }
	inline XPathNavigator_t787956054 * get__nav_3() const { return ____nav_3; }
	inline XPathNavigator_t787956054 ** get_address_of__nav_3() { return &____nav_3; }
	inline void set__nav_3(XPathNavigator_t787956054 * value)
	{
		____nav_3 = value;
		Il2CppCodeGenWriteBarrier(&____nav_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
