#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_XPath_BaseIterator4168896842.h"
#include "System_Xml_System_Xml_XPath_XPathResultType2828988488.h"

// System.Xml.XPath.BaseIterator
struct BaseIterator_t4168896842;
// System.Xml.XPath.Expression
struct Expression_t1452783009;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XPath.PredicateIterator
struct  PredicateIterator_t4231391432  : public BaseIterator_t4168896842
{
public:
	// System.Xml.XPath.BaseIterator System.Xml.XPath.PredicateIterator::_iter
	BaseIterator_t4168896842 * ____iter_3;
	// System.Xml.XPath.Expression System.Xml.XPath.PredicateIterator::_pred
	Expression_t1452783009 * ____pred_4;
	// System.Xml.XPath.XPathResultType System.Xml.XPath.PredicateIterator::resType
	int32_t ___resType_5;
	// System.Boolean System.Xml.XPath.PredicateIterator::finished
	bool ___finished_6;

public:
	inline static int32_t get_offset_of__iter_3() { return static_cast<int32_t>(offsetof(PredicateIterator_t4231391432, ____iter_3)); }
	inline BaseIterator_t4168896842 * get__iter_3() const { return ____iter_3; }
	inline BaseIterator_t4168896842 ** get_address_of__iter_3() { return &____iter_3; }
	inline void set__iter_3(BaseIterator_t4168896842 * value)
	{
		____iter_3 = value;
		Il2CppCodeGenWriteBarrier(&____iter_3, value);
	}

	inline static int32_t get_offset_of__pred_4() { return static_cast<int32_t>(offsetof(PredicateIterator_t4231391432, ____pred_4)); }
	inline Expression_t1452783009 * get__pred_4() const { return ____pred_4; }
	inline Expression_t1452783009 ** get_address_of__pred_4() { return &____pred_4; }
	inline void set__pred_4(Expression_t1452783009 * value)
	{
		____pred_4 = value;
		Il2CppCodeGenWriteBarrier(&____pred_4, value);
	}

	inline static int32_t get_offset_of_resType_5() { return static_cast<int32_t>(offsetof(PredicateIterator_t4231391432, ___resType_5)); }
	inline int32_t get_resType_5() const { return ___resType_5; }
	inline int32_t* get_address_of_resType_5() { return &___resType_5; }
	inline void set_resType_5(int32_t value)
	{
		___resType_5 = value;
	}

	inline static int32_t get_offset_of_finished_6() { return static_cast<int32_t>(offsetof(PredicateIterator_t4231391432, ___finished_6)); }
	inline bool get_finished_6() const { return ___finished_6; }
	inline bool* get_address_of_finished_6() { return &___finished_6; }
	inline void set_finished_6(bool value)
	{
		___finished_6 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
