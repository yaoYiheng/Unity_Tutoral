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




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XPath.ParensIterator
struct  ParensIterator_t4020310733  : public BaseIterator_t4168896842
{
public:
	// System.Xml.XPath.BaseIterator System.Xml.XPath.ParensIterator::_iter
	BaseIterator_t4168896842 * ____iter_3;

public:
	inline static int32_t get_offset_of__iter_3() { return static_cast<int32_t>(offsetof(ParensIterator_t4020310733, ____iter_3)); }
	inline BaseIterator_t4168896842 * get__iter_3() const { return ____iter_3; }
	inline BaseIterator_t4168896842 ** get_address_of__iter_3() { return &____iter_3; }
	inline void set__iter_3(BaseIterator_t4168896842 * value)
	{
		____iter_3 = value;
		Il2CppCodeGenWriteBarrier(&____iter_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
