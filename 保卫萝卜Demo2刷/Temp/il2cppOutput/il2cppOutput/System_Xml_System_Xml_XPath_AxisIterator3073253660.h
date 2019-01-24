#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_XPath_BaseIterator4168896842.h"

// System.Xml.XPath.BaseIterator
struct BaseIterator_t4168896842;
// System.Xml.XPath.NodeTest
struct NodeTest_t747859056;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XPath.AxisIterator
struct  AxisIterator_t3073253660  : public BaseIterator_t4168896842
{
public:
	// System.Xml.XPath.BaseIterator System.Xml.XPath.AxisIterator::_iter
	BaseIterator_t4168896842 * ____iter_3;
	// System.Xml.XPath.NodeTest System.Xml.XPath.AxisIterator::_test
	NodeTest_t747859056 * ____test_4;

public:
	inline static int32_t get_offset_of__iter_3() { return static_cast<int32_t>(offsetof(AxisIterator_t3073253660, ____iter_3)); }
	inline BaseIterator_t4168896842 * get__iter_3() const { return ____iter_3; }
	inline BaseIterator_t4168896842 ** get_address_of__iter_3() { return &____iter_3; }
	inline void set__iter_3(BaseIterator_t4168896842 * value)
	{
		____iter_3 = value;
		Il2CppCodeGenWriteBarrier(&____iter_3, value);
	}

	inline static int32_t get_offset_of__test_4() { return static_cast<int32_t>(offsetof(AxisIterator_t3073253660, ____test_4)); }
	inline NodeTest_t747859056 * get__test_4() const { return ____test_4; }
	inline NodeTest_t747859056 ** get_address_of__test_4() { return &____test_4; }
	inline void set__test_4(NodeTest_t747859056 * value)
	{
		____test_4 = value;
		Il2CppCodeGenWriteBarrier(&____test_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
