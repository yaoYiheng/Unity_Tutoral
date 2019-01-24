#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_XPath_BaseIterator4168896842.h"

// System.Collections.ArrayList
struct ArrayList_t2718874744;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XPath.SortedIterator
struct  SortedIterator_t2904376427  : public BaseIterator_t4168896842
{
public:
	// System.Collections.ArrayList System.Xml.XPath.SortedIterator::list
	ArrayList_t2718874744 * ___list_3;

public:
	inline static int32_t get_offset_of_list_3() { return static_cast<int32_t>(offsetof(SortedIterator_t2904376427, ___list_3)); }
	inline ArrayList_t2718874744 * get_list_3() const { return ___list_3; }
	inline ArrayList_t2718874744 ** get_address_of_list_3() { return &___list_3; }
	inline void set_list_3(ArrayList_t2718874744 * value)
	{
		___list_3 = value;
		Il2CppCodeGenWriteBarrier(&___list_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
