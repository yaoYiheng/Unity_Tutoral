#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_XPath_NodeSet3272593155.h"

// System.Xml.XPath.Expression
struct Expression_t1452783009;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XPath.ExprFilter
struct  ExprFilter_t2551926938  : public NodeSet_t3272593155
{
public:
	// System.Xml.XPath.Expression System.Xml.XPath.ExprFilter::expr
	Expression_t1452783009 * ___expr_0;
	// System.Xml.XPath.Expression System.Xml.XPath.ExprFilter::pred
	Expression_t1452783009 * ___pred_1;

public:
	inline static int32_t get_offset_of_expr_0() { return static_cast<int32_t>(offsetof(ExprFilter_t2551926938, ___expr_0)); }
	inline Expression_t1452783009 * get_expr_0() const { return ___expr_0; }
	inline Expression_t1452783009 ** get_address_of_expr_0() { return &___expr_0; }
	inline void set_expr_0(Expression_t1452783009 * value)
	{
		___expr_0 = value;
		Il2CppCodeGenWriteBarrier(&___expr_0, value);
	}

	inline static int32_t get_offset_of_pred_1() { return static_cast<int32_t>(offsetof(ExprFilter_t2551926938, ___pred_1)); }
	inline Expression_t1452783009 * get_pred_1() const { return ___pred_1; }
	inline Expression_t1452783009 ** get_address_of_pred_1() { return &___pred_1; }
	inline void set_pred_1(Expression_t1452783009 * value)
	{
		___pred_1 = value;
		Il2CppCodeGenWriteBarrier(&___pred_1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
