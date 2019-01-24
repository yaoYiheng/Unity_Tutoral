#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_XPath_XPathFunction857746608.h"

// System.Xml.XPath.Expression
struct Expression_t1452783009;
// System.Char[]
struct CharU5BU5D_t3528271667;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XPath.XPathFunctionId
struct  XPathFunctionId_t1670301333  : public XPathFunction_t857746608
{
public:
	// System.Xml.XPath.Expression System.Xml.XPath.XPathFunctionId::arg0
	Expression_t1452783009 * ___arg0_0;

public:
	inline static int32_t get_offset_of_arg0_0() { return static_cast<int32_t>(offsetof(XPathFunctionId_t1670301333, ___arg0_0)); }
	inline Expression_t1452783009 * get_arg0_0() const { return ___arg0_0; }
	inline Expression_t1452783009 ** get_address_of_arg0_0() { return &___arg0_0; }
	inline void set_arg0_0(Expression_t1452783009 * value)
	{
		___arg0_0 = value;
		Il2CppCodeGenWriteBarrier(&___arg0_0, value);
	}
};

struct XPathFunctionId_t1670301333_StaticFields
{
public:
	// System.Char[] System.Xml.XPath.XPathFunctionId::rgchWhitespace
	CharU5BU5D_t3528271667* ___rgchWhitespace_1;

public:
	inline static int32_t get_offset_of_rgchWhitespace_1() { return static_cast<int32_t>(offsetof(XPathFunctionId_t1670301333_StaticFields, ___rgchWhitespace_1)); }
	inline CharU5BU5D_t3528271667* get_rgchWhitespace_1() const { return ___rgchWhitespace_1; }
	inline CharU5BU5D_t3528271667** get_address_of_rgchWhitespace_1() { return &___rgchWhitespace_1; }
	inline void set_rgchWhitespace_1(CharU5BU5D_t3528271667* value)
	{
		___rgchWhitespace_1 = value;
		Il2CppCodeGenWriteBarrier(&___rgchWhitespace_1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
