#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_XPath_Expression1452783009.h"

// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XPath.ExprLiteral
struct  ExprLiteral_t2264229068  : public Expression_t1452783009
{
public:
	// System.String System.Xml.XPath.ExprLiteral::_value
	String_t* ____value_0;

public:
	inline static int32_t get_offset_of__value_0() { return static_cast<int32_t>(offsetof(ExprLiteral_t2264229068, ____value_0)); }
	inline String_t* get__value_0() const { return ____value_0; }
	inline String_t** get_address_of__value_0() { return &____value_0; }
	inline void set__value_0(String_t* value)
	{
		____value_0 = value;
		Il2CppCodeGenWriteBarrier(&____value_0, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
