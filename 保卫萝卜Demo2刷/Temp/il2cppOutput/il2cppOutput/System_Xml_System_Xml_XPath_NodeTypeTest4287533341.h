﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_XPath_NodeTest747859056.h"
#include "System_Xml_System_Xml_XPath_XPathNodeType3031007223.h"

// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XPath.NodeTypeTest
struct  NodeTypeTest_t4287533341  : public NodeTest_t747859056
{
public:
	// System.Xml.XPath.XPathNodeType System.Xml.XPath.NodeTypeTest::type
	int32_t ___type_1;
	// System.String System.Xml.XPath.NodeTypeTest::_param
	String_t* ____param_2;

public:
	inline static int32_t get_offset_of_type_1() { return static_cast<int32_t>(offsetof(NodeTypeTest_t4287533341, ___type_1)); }
	inline int32_t get_type_1() const { return ___type_1; }
	inline int32_t* get_address_of_type_1() { return &___type_1; }
	inline void set_type_1(int32_t value)
	{
		___type_1 = value;
	}

	inline static int32_t get_offset_of__param_2() { return static_cast<int32_t>(offsetof(NodeTypeTest_t4287533341, ____param_2)); }
	inline String_t* get__param_2() const { return ____param_2; }
	inline String_t** get_address_of__param_2() { return &____param_2; }
	inline void set__param_2(String_t* value)
	{
		____param_2 = value;
		Il2CppCodeGenWriteBarrier(&____param_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
