﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_XPath_XPathNodeIterator3667290188.h"

// System.Collections.IEnumerable
struct IEnumerable_t1941168011;
// System.Collections.IEnumerator
struct IEnumerator_t1853284238;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XPath.XPathNavigator/EnumerableIterator
struct  EnumerableIterator_t1590428576  : public XPathNodeIterator_t3667290188
{
public:
	// System.Collections.IEnumerable System.Xml.XPath.XPathNavigator/EnumerableIterator::source
	Il2CppObject * ___source_1;
	// System.Collections.IEnumerator System.Xml.XPath.XPathNavigator/EnumerableIterator::e
	Il2CppObject * ___e_2;
	// System.Int32 System.Xml.XPath.XPathNavigator/EnumerableIterator::pos
	int32_t ___pos_3;

public:
	inline static int32_t get_offset_of_source_1() { return static_cast<int32_t>(offsetof(EnumerableIterator_t1590428576, ___source_1)); }
	inline Il2CppObject * get_source_1() const { return ___source_1; }
	inline Il2CppObject ** get_address_of_source_1() { return &___source_1; }
	inline void set_source_1(Il2CppObject * value)
	{
		___source_1 = value;
		Il2CppCodeGenWriteBarrier(&___source_1, value);
	}

	inline static int32_t get_offset_of_e_2() { return static_cast<int32_t>(offsetof(EnumerableIterator_t1590428576, ___e_2)); }
	inline Il2CppObject * get_e_2() const { return ___e_2; }
	inline Il2CppObject ** get_address_of_e_2() { return &___e_2; }
	inline void set_e_2(Il2CppObject * value)
	{
		___e_2 = value;
		Il2CppCodeGenWriteBarrier(&___e_2, value);
	}

	inline static int32_t get_offset_of_pos_3() { return static_cast<int32_t>(offsetof(EnumerableIterator_t1590428576, ___pos_3)); }
	inline int32_t get_pos_3() const { return ___pos_3; }
	inline int32_t* get_address_of_pos_3() { return &___pos_3; }
	inline void set_pos_3(int32_t value)
	{
		___pos_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
