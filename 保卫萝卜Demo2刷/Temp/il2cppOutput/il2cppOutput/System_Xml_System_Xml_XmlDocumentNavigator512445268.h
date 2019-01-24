#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_XPath_XPathNavigator787956054.h"

// System.Xml.XmlNode
struct XmlNode_t3767805227;
// System.Xml.XmlAttribute
struct XmlAttribute_t1173852259;
// System.Collections.ArrayList
struct ArrayList_t2718874744;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlDocumentNavigator
struct  XmlDocumentNavigator_t512445268  : public XPathNavigator_t787956054
{
public:
	// System.Xml.XmlNode System.Xml.XmlDocumentNavigator::node
	XmlNode_t3767805227 * ___node_2;
	// System.Xml.XmlAttribute System.Xml.XmlDocumentNavigator::nsNode
	XmlAttribute_t1173852259 * ___nsNode_3;
	// System.Collections.ArrayList System.Xml.XmlDocumentNavigator::iteratedNsNames
	ArrayList_t2718874744 * ___iteratedNsNames_4;

public:
	inline static int32_t get_offset_of_node_2() { return static_cast<int32_t>(offsetof(XmlDocumentNavigator_t512445268, ___node_2)); }
	inline XmlNode_t3767805227 * get_node_2() const { return ___node_2; }
	inline XmlNode_t3767805227 ** get_address_of_node_2() { return &___node_2; }
	inline void set_node_2(XmlNode_t3767805227 * value)
	{
		___node_2 = value;
		Il2CppCodeGenWriteBarrier(&___node_2, value);
	}

	inline static int32_t get_offset_of_nsNode_3() { return static_cast<int32_t>(offsetof(XmlDocumentNavigator_t512445268, ___nsNode_3)); }
	inline XmlAttribute_t1173852259 * get_nsNode_3() const { return ___nsNode_3; }
	inline XmlAttribute_t1173852259 ** get_address_of_nsNode_3() { return &___nsNode_3; }
	inline void set_nsNode_3(XmlAttribute_t1173852259 * value)
	{
		___nsNode_3 = value;
		Il2CppCodeGenWriteBarrier(&___nsNode_3, value);
	}

	inline static int32_t get_offset_of_iteratedNsNames_4() { return static_cast<int32_t>(offsetof(XmlDocumentNavigator_t512445268, ___iteratedNsNames_4)); }
	inline ArrayList_t2718874744 * get_iteratedNsNames_4() const { return ___iteratedNsNames_4; }
	inline ArrayList_t2718874744 ** get_address_of_iteratedNsNames_4() { return &___iteratedNsNames_4; }
	inline void set_iteratedNsNames_4(ArrayList_t2718874744 * value)
	{
		___iteratedNsNames_4 = value;
		Il2CppCodeGenWriteBarrier(&___iteratedNsNames_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
