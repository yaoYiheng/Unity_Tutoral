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
// System.Xml.XPath.NodeSet
struct NodeSet_t3272593155;
// System.Collections.SortedList
struct SortedList_t2427694641;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XPath.SlashIterator
struct  SlashIterator_t2421034408  : public BaseIterator_t4168896842
{
public:
	// System.Xml.XPath.BaseIterator System.Xml.XPath.SlashIterator::_iterLeft
	BaseIterator_t4168896842 * ____iterLeft_3;
	// System.Xml.XPath.BaseIterator System.Xml.XPath.SlashIterator::_iterRight
	BaseIterator_t4168896842 * ____iterRight_4;
	// System.Xml.XPath.NodeSet System.Xml.XPath.SlashIterator::_expr
	NodeSet_t3272593155 * ____expr_5;
	// System.Collections.SortedList System.Xml.XPath.SlashIterator::_iterList
	SortedList_t2427694641 * ____iterList_6;
	// System.Boolean System.Xml.XPath.SlashIterator::_finished
	bool ____finished_7;
	// System.Xml.XPath.BaseIterator System.Xml.XPath.SlashIterator::_nextIterRight
	BaseIterator_t4168896842 * ____nextIterRight_8;

public:
	inline static int32_t get_offset_of__iterLeft_3() { return static_cast<int32_t>(offsetof(SlashIterator_t2421034408, ____iterLeft_3)); }
	inline BaseIterator_t4168896842 * get__iterLeft_3() const { return ____iterLeft_3; }
	inline BaseIterator_t4168896842 ** get_address_of__iterLeft_3() { return &____iterLeft_3; }
	inline void set__iterLeft_3(BaseIterator_t4168896842 * value)
	{
		____iterLeft_3 = value;
		Il2CppCodeGenWriteBarrier(&____iterLeft_3, value);
	}

	inline static int32_t get_offset_of__iterRight_4() { return static_cast<int32_t>(offsetof(SlashIterator_t2421034408, ____iterRight_4)); }
	inline BaseIterator_t4168896842 * get__iterRight_4() const { return ____iterRight_4; }
	inline BaseIterator_t4168896842 ** get_address_of__iterRight_4() { return &____iterRight_4; }
	inline void set__iterRight_4(BaseIterator_t4168896842 * value)
	{
		____iterRight_4 = value;
		Il2CppCodeGenWriteBarrier(&____iterRight_4, value);
	}

	inline static int32_t get_offset_of__expr_5() { return static_cast<int32_t>(offsetof(SlashIterator_t2421034408, ____expr_5)); }
	inline NodeSet_t3272593155 * get__expr_5() const { return ____expr_5; }
	inline NodeSet_t3272593155 ** get_address_of__expr_5() { return &____expr_5; }
	inline void set__expr_5(NodeSet_t3272593155 * value)
	{
		____expr_5 = value;
		Il2CppCodeGenWriteBarrier(&____expr_5, value);
	}

	inline static int32_t get_offset_of__iterList_6() { return static_cast<int32_t>(offsetof(SlashIterator_t2421034408, ____iterList_6)); }
	inline SortedList_t2427694641 * get__iterList_6() const { return ____iterList_6; }
	inline SortedList_t2427694641 ** get_address_of__iterList_6() { return &____iterList_6; }
	inline void set__iterList_6(SortedList_t2427694641 * value)
	{
		____iterList_6 = value;
		Il2CppCodeGenWriteBarrier(&____iterList_6, value);
	}

	inline static int32_t get_offset_of__finished_7() { return static_cast<int32_t>(offsetof(SlashIterator_t2421034408, ____finished_7)); }
	inline bool get__finished_7() const { return ____finished_7; }
	inline bool* get_address_of__finished_7() { return &____finished_7; }
	inline void set__finished_7(bool value)
	{
		____finished_7 = value;
	}

	inline static int32_t get_offset_of__nextIterRight_8() { return static_cast<int32_t>(offsetof(SlashIterator_t2421034408, ____nextIterRight_8)); }
	inline BaseIterator_t4168896842 * get__nextIterRight_8() const { return ____nextIterRight_8; }
	inline BaseIterator_t4168896842 ** get_address_of__nextIterRight_8() { return &____nextIterRight_8; }
	inline void set__nextIterRight_8(BaseIterator_t4168896842 * value)
	{
		____nextIterRight_8 = value;
		Il2CppCodeGenWriteBarrier(&____nextIterRight_8, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
