#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>

#include "class-internals.h"
#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_Array3549286319.h"
#include "UnityEngine_UnityEngine_WWW3688466362.h"
#include "mscorlib_System_String1847450689.h"
#include "mscorlib_System_Void1185182177.h"
#include "mscorlib_System_Object3080106164.h"
#include "mscorlib_System_Byte1134296376.h"
#include "mscorlib_System_Boolean97287965.h"
#include "UnityEngine_UnityEngine_Texture2D3840446185.h"
#include "UnityEngine_UnityEngine_YieldInstruction403091072.h"
#include "UnityEngine_UnityEngineInternal_GenericStack1310059385.h"
#include "mscorlib_System_Collections_Stack2329662280.h"
#include "UnityEngine_UnityEngineInternal_MathfInternal624072491.h"
#include "mscorlib_System_Single1397266774.h"
#include "UnityEngine_UnityEngineInternal_NetFxCoreExtension4089902045.h"
#include "mscorlib_System_Reflection_MethodInfo1877626248.h"
#include "mscorlib_System_Type2483944760.h"
#include "mscorlib_System_Delegate1188392813.h"
#include "UnityEngine_UnityEngineInternal_ScriptingUtils2624832893.h"
#include "UnityEngine_UnityEngineInternal_TypeInferenceRuleAt254868554.h"
#include "UnityEngine_UnityEngineInternal_TypeInferenceRules96689094.h"
#include "mscorlib_System_Attribute861562559.h"
#include "UnityEngine_UnityEngineInternal_WebRequestUtils3541624225.h"
#include "System_System_UriKind3816567336.h"
#include "System_System_Uri100236324.h"
#include "mscorlib_System_Char3634460470.h"
#include "mscorlib_System_Int322950945753.h"
#include "System_System_Text_RegularExpressions_Regex3657309853.h"

// UnityEngine.WWW
struct WWW_t3688466362;
// System.String
struct String_t;
// System.Object
struct Il2CppObject;
// System.Byte[]
struct ByteU5BU5D_t4116647657;
// System.String[]
struct StringU5BU5D_t1281789340;
// UnityEngine.Texture2D
struct Texture2D_t3840446185;
// UnityEngine.YieldInstruction
struct YieldInstruction_t403091072;
// UnityEngineInternal.GenericStack
struct GenericStack_t1310059385;
// System.Collections.Stack
struct Stack_t2329662280;
// System.Delegate
struct Delegate_t1188392813;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.Type
struct Type_t;
// UnityEngineInternal.TypeInferenceRuleAttribute
struct TypeInferenceRuleAttribute_t254868554;
// System.Attribute
struct Attribute_t861562559;
// System.Uri
struct Uri_t100236324;
// System.Text.RegularExpressions.Regex
struct Regex_t3657309853;
extern Il2CppClass* MathfInternal_t624072491_il2cpp_TypeInfo_var;
extern const uint32_t MathfInternal__cctor_m3796400441_MetadataUsageId;
extern Il2CppClass* TypeInferenceRules_t96689094_il2cpp_TypeInfo_var;
extern const uint32_t TypeInferenceRuleAttribute__ctor_m2525341982_MetadataUsageId;
extern Il2CppClass* Uri_t100236324_il2cpp_TypeInfo_var;
extern const uint32_t WebRequestUtils_RedirectTo_m3521340638_MetadataUsageId;
extern Il2CppClass* Regex_t3657309853_il2cpp_TypeInfo_var;
extern Il2CppClass* WebRequestUtils_t3541624225_il2cpp_TypeInfo_var;
extern Il2CppCodeGenString* _stringLiteral3847659558;
extern const uint32_t WebRequestUtils__cctor_m2866502633_MetadataUsageId;

// System.Byte[]
struct ByteU5BU5D_t4116647657  : public Il2CppArray
{
public:
	ALIGN_FIELD (8) uint8_t m_Items[1];

public:
	inline uint8_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline uint8_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, uint8_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline uint8_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline uint8_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, uint8_t value)
	{
		m_Items[index] = value;
	}
};
// System.String[]
struct StringU5BU5D_t1281789340  : public Il2CppArray
{
public:
	ALIGN_FIELD (8) String_t* m_Items[1];

public:
	inline String_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline String_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, String_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
	inline String_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline String_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, String_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};



// System.Void System.Object::.ctor()
extern "C"  void Object__ctor_m297566312 (Il2CppObject * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.WWW::InitWWW(System.String,System.Byte[],System.String[])
extern "C"  void WWW_InitWWW_m2012169222 (WWW_t3688466362 * __this, String_t* ___url0, ByteU5BU5D_t4116647657* ___postData1, StringU5BU5D_t1281789340* ___iHeaders2, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.WWW::DestroyWWW(System.Boolean)
extern "C"  void WWW_DestroyWWW_m68359087 (WWW_t3688466362 * __this, bool ___cancel0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Object::Finalize()
extern "C"  void Object_Finalize_m3076187857 (Il2CppObject * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Texture2D UnityEngine.WWW::GetTexture(System.Boolean)
extern "C"  Texture2D_t3840446185 * WWW_GetTexture_m1713217513 (WWW_t3688466362 * __this, bool ___markNonReadable0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Stack::.ctor()
extern "C"  void Stack__ctor_m2907601956 (Stack_t2329662280 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Delegate System.Delegate::CreateDelegate(System.Type,System.Object,System.Reflection.MethodInfo)
extern "C"  Delegate_t1188392813 * Delegate_CreateDelegate_m995503480 (Il2CppObject * __this /* static, unused */, Type_t * p0, Il2CppObject * p1, MethodInfo_t * p2, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Reflection.MethodInfo System.Delegate::get_Method()
extern "C"  MethodInfo_t * Delegate_get_Method_m3071622864 (Delegate_t1188392813 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Delegate System.Delegate::CreateDelegate(System.Type,System.Reflection.MethodInfo)
extern "C"  Delegate_t1188392813 * Delegate_CreateDelegate_m2396489936 (Il2CppObject * __this /* static, unused */, Type_t * p0, MethodInfo_t * p1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngineInternal.TypeInferenceRuleAttribute::.ctor(System.String)
extern "C"  void TypeInferenceRuleAttribute__ctor_m365663141 (TypeInferenceRuleAttribute_t254868554 * __this, String_t* ___rule0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Attribute::.ctor()
extern "C"  void Attribute__ctor_m1529526131 (Attribute_t861562559 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Char System.String::get_Chars(System.Int32)
extern "C"  Il2CppChar String_get_Chars_m2986988803 (String_t* __this, int32_t p0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Uri::.ctor(System.String,System.UriKind)
extern "C"  void Uri__ctor_m3040793867 (Uri_t100236324 * __this, String_t* p0, int32_t p1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Uri::get_IsAbsoluteUri()
extern "C"  bool Uri_get_IsAbsoluteUri_m3666899587 (Uri_t100236324 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String System.Uri::get_AbsoluteUri()
extern "C"  String_t* Uri_get_AbsoluteUri_m2582056986 (Uri_t100236324 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Uri::.ctor(System.Uri,System.Uri)
extern "C"  void Uri__ctor_m253204164 (Uri_t100236324 * __this, Uri_t100236324 * p0, Uri_t100236324 * p1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Text.RegularExpressions.Regex::.ctor(System.String)
extern "C"  void Regex__ctor_m897876424 (Regex_t3657309853 * __this, String_t* p0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.WWW::.ctor(System.String)
extern "C"  void WWW__ctor_m1181807108 (WWW_t3688466362 * __this, String_t* ___url0, const MethodInfo* method)
{
	{
		Object__ctor_m297566312(__this, /*hidden argument*/NULL);
		String_t* L_0 = ___url0;
		WWW_InitWWW_m2012169222(__this, L_0, (ByteU5BU5D_t4116647657*)(ByteU5BU5D_t4116647657*)NULL, (StringU5BU5D_t1281789340*)(StringU5BU5D_t1281789340*)NULL, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.WWW::Dispose()
extern "C"  void WWW_Dispose_m2234569747 (WWW_t3688466362 * __this, const MethodInfo* method)
{
	{
		WWW_DestroyWWW_m68359087(__this, (bool)1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.WWW::Finalize()
extern "C"  void WWW_Finalize_m2292869093 (WWW_t3688466362 * __this, const MethodInfo* method)
{
	Exception_t1436737249 * __last_unhandled_exception = 0;
	NO_UNUSED_WARNING (__last_unhandled_exception);
	Exception_t1436737249 * __exception_local = 0;
	NO_UNUSED_WARNING (__exception_local);
	int32_t __leave_target = 0;
	NO_UNUSED_WARNING (__leave_target);
	{
	}

IL_0001:
	try
	{ // begin try (depth: 1)
		WWW_DestroyWWW_m68359087(__this, (bool)0, /*hidden argument*/NULL);
		IL2CPP_LEAVE(0x14, FINALLY_000d);
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t1436737249 *)e.ex;
		goto FINALLY_000d;
	}

FINALLY_000d:
	{ // begin finally (depth: 1)
		Object_Finalize_m3076187857(__this, /*hidden argument*/NULL);
		IL2CPP_END_FINALLY(13)
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(13)
	{
		IL2CPP_JUMP_TBL(0x14, IL_0014)
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t1436737249 *)
	}

IL_0014:
	{
		return;
	}
}
// System.Void UnityEngine.WWW::DestroyWWW(System.Boolean)
extern "C"  void WWW_DestroyWWW_m68359087 (WWW_t3688466362 * __this, bool ___cancel0, const MethodInfo* method)
{
	typedef void (*WWW_DestroyWWW_m68359087_ftn) (WWW_t3688466362 *, bool);
	static WWW_DestroyWWW_m68359087_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (WWW_DestroyWWW_m68359087_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.WWW::DestroyWWW(System.Boolean)");
	_il2cpp_icall_func(__this, ___cancel0);
}
// System.Void UnityEngine.WWW::InitWWW(System.String,System.Byte[],System.String[])
extern "C"  void WWW_InitWWW_m2012169222 (WWW_t3688466362 * __this, String_t* ___url0, ByteU5BU5D_t4116647657* ___postData1, StringU5BU5D_t1281789340* ___iHeaders2, const MethodInfo* method)
{
	typedef void (*WWW_InitWWW_m2012169222_ftn) (WWW_t3688466362 *, String_t*, ByteU5BU5D_t4116647657*, StringU5BU5D_t1281789340*);
	static WWW_InitWWW_m2012169222_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (WWW_InitWWW_m2012169222_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.WWW::InitWWW(System.String,System.Byte[],System.String[])");
	_il2cpp_icall_func(__this, ___url0, ___postData1, ___iHeaders2);
}
// UnityEngine.Texture2D UnityEngine.WWW::GetTexture(System.Boolean)
extern "C"  Texture2D_t3840446185 * WWW_GetTexture_m1713217513 (WWW_t3688466362 * __this, bool ___markNonReadable0, const MethodInfo* method)
{
	typedef Texture2D_t3840446185 * (*WWW_GetTexture_m1713217513_ftn) (WWW_t3688466362 *, bool);
	static WWW_GetTexture_m1713217513_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (WWW_GetTexture_m1713217513_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.WWW::GetTexture(System.Boolean)");
	return _il2cpp_icall_func(__this, ___markNonReadable0);
}
// UnityEngine.Texture2D UnityEngine.WWW::get_texture()
extern "C"  Texture2D_t3840446185 * WWW_get_texture_m1724981587 (WWW_t3688466362 * __this, const MethodInfo* method)
{
	Texture2D_t3840446185 * V_0 = NULL;
	{
		Texture2D_t3840446185 * L_0 = WWW_GetTexture_m1713217513(__this, (bool)0, /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_000e;
	}

IL_000e:
	{
		Texture2D_t3840446185 * L_1 = V_0;
		return L_1;
	}
}
// System.Boolean UnityEngine.WWW::get_isDone()
extern "C"  bool WWW_get_isDone_m3171063254 (WWW_t3688466362 * __this, const MethodInfo* method)
{
	typedef bool (*WWW_get_isDone_m3171063254_ftn) (WWW_t3688466362 *);
	static WWW_get_isDone_m3171063254_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (WWW_get_isDone_m3171063254_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.WWW::get_isDone()");
	return _il2cpp_icall_func(__this);
}
// Conversion methods for marshalling of: UnityEngine.YieldInstruction
extern "C" void YieldInstruction_t403091072_marshal_pinvoke(const YieldInstruction_t403091072& unmarshaled, YieldInstruction_t403091072_marshaled_pinvoke& marshaled)
{
}
extern "C" void YieldInstruction_t403091072_marshal_pinvoke_back(const YieldInstruction_t403091072_marshaled_pinvoke& marshaled, YieldInstruction_t403091072& unmarshaled)
{
}
// Conversion method for clean up from marshalling of: UnityEngine.YieldInstruction
extern "C" void YieldInstruction_t403091072_marshal_pinvoke_cleanup(YieldInstruction_t403091072_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngine.YieldInstruction
extern "C" void YieldInstruction_t403091072_marshal_com(const YieldInstruction_t403091072& unmarshaled, YieldInstruction_t403091072_marshaled_com& marshaled)
{
}
extern "C" void YieldInstruction_t403091072_marshal_com_back(const YieldInstruction_t403091072_marshaled_com& marshaled, YieldInstruction_t403091072& unmarshaled)
{
}
// Conversion method for clean up from marshalling of: UnityEngine.YieldInstruction
extern "C" void YieldInstruction_t403091072_marshal_com_cleanup(YieldInstruction_t403091072_marshaled_com& marshaled)
{
}
// System.Void UnityEngine.YieldInstruction::.ctor()
extern "C"  void YieldInstruction__ctor_m3893172416 (YieldInstruction_t403091072 * __this, const MethodInfo* method)
{
	{
		Object__ctor_m297566312(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngineInternal.GenericStack::.ctor()
extern "C"  void GenericStack__ctor_m3065521290 (GenericStack_t1310059385 * __this, const MethodInfo* method)
{
	{
		Stack__ctor_m2907601956(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngineInternal.MathfInternal::.cctor()
extern "C"  void MathfInternal__cctor_m3796400441 (Il2CppObject * __this /* static, unused */, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (MathfInternal__cctor_m3796400441_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_memory_barrier();
		((MathfInternal_t624072491_StaticFields*)MathfInternal_t624072491_il2cpp_TypeInfo_var->static_fields)->set_FloatMinNormal_0((1.17549435E-38f));
		il2cpp_codegen_memory_barrier();
		((MathfInternal_t624072491_StaticFields*)MathfInternal_t624072491_il2cpp_TypeInfo_var->static_fields)->set_FloatMinDenormal_1((1.401298E-45f));
		((MathfInternal_t624072491_StaticFields*)MathfInternal_t624072491_il2cpp_TypeInfo_var->static_fields)->set_IsFlushToZeroEnabled_2((bool)1);
		return;
	}
}
// System.Delegate UnityEngineInternal.NetFxCoreExtensions::CreateDelegate(System.Reflection.MethodInfo,System.Type,System.Object)
extern "C"  Delegate_t1188392813 * NetFxCoreExtensions_CreateDelegate_m4283065679 (Il2CppObject * __this /* static, unused */, MethodInfo_t * ___self0, Type_t * ___delegateType1, Il2CppObject * ___target2, const MethodInfo* method)
{
	Delegate_t1188392813 * V_0 = NULL;
	{
		Type_t * L_0 = ___delegateType1;
		Il2CppObject * L_1 = ___target2;
		MethodInfo_t * L_2 = ___self0;
		Delegate_t1188392813 * L_3 = Delegate_CreateDelegate_m995503480(NULL /*static, unused*/, L_0, L_1, L_2, /*hidden argument*/NULL);
		V_0 = L_3;
		goto IL_000f;
	}

IL_000f:
	{
		Delegate_t1188392813 * L_4 = V_0;
		return L_4;
	}
}
// System.Reflection.MethodInfo UnityEngineInternal.NetFxCoreExtensions::GetMethodInfo(System.Delegate)
extern "C"  MethodInfo_t * NetFxCoreExtensions_GetMethodInfo_m3154548066 (Il2CppObject * __this /* static, unused */, Delegate_t1188392813 * ___self0, const MethodInfo* method)
{
	MethodInfo_t * V_0 = NULL;
	{
		Delegate_t1188392813 * L_0 = ___self0;
		NullCheck(L_0);
		MethodInfo_t * L_1 = Delegate_get_Method_m3071622864(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000d;
	}

IL_000d:
	{
		MethodInfo_t * L_2 = V_0;
		return L_2;
	}
}
// System.Delegate UnityEngineInternal.ScriptingUtils::CreateDelegate(System.Type,System.Reflection.MethodInfo)
extern "C"  Delegate_t1188392813 * ScriptingUtils_CreateDelegate_m1614232900 (Il2CppObject * __this /* static, unused */, Type_t * ___type0, MethodInfo_t * ___methodInfo1, const MethodInfo* method)
{
	Delegate_t1188392813 * V_0 = NULL;
	{
		Type_t * L_0 = ___type0;
		MethodInfo_t * L_1 = ___methodInfo1;
		Delegate_t1188392813 * L_2 = Delegate_CreateDelegate_m2396489936(NULL /*static, unused*/, L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_000e;
	}

IL_000e:
	{
		Delegate_t1188392813 * L_3 = V_0;
		return L_3;
	}
}
// System.Void UnityEngineInternal.TypeInferenceRuleAttribute::.ctor(UnityEngineInternal.TypeInferenceRules)
extern "C"  void TypeInferenceRuleAttribute__ctor_m2525341982 (TypeInferenceRuleAttribute_t254868554 * __this, int32_t ___rule0, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TypeInferenceRuleAttribute__ctor_m2525341982_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Il2CppObject * L_0 = Box(TypeInferenceRules_t96689094_il2cpp_TypeInfo_var, (&___rule0));
		NullCheck(L_0);
		String_t* L_1 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_0);
		TypeInferenceRuleAttribute__ctor_m365663141(__this, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngineInternal.TypeInferenceRuleAttribute::.ctor(System.String)
extern "C"  void TypeInferenceRuleAttribute__ctor_m365663141 (TypeInferenceRuleAttribute_t254868554 * __this, String_t* ___rule0, const MethodInfo* method)
{
	{
		Attribute__ctor_m1529526131(__this, /*hidden argument*/NULL);
		String_t* L_0 = ___rule0;
		__this->set__rule_0(L_0);
		return;
	}
}
// System.String UnityEngineInternal.TypeInferenceRuleAttribute::ToString()
extern "C"  String_t* TypeInferenceRuleAttribute_ToString_m915908059 (TypeInferenceRuleAttribute_t254868554 * __this, const MethodInfo* method)
{
	String_t* V_0 = NULL;
	{
		String_t* L_0 = __this->get__rule_0();
		V_0 = L_0;
		goto IL_000d;
	}

IL_000d:
	{
		String_t* L_1 = V_0;
		return L_1;
	}
}
// System.String UnityEngineInternal.WebRequestUtils::RedirectTo(System.String,System.String)
extern "C"  String_t* WebRequestUtils_RedirectTo_m3521340638 (Il2CppObject * __this /* static, unused */, String_t* ___baseUri0, String_t* ___redirectUri1, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (WebRequestUtils_RedirectTo_m3521340638_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Uri_t100236324 * V_0 = NULL;
	String_t* V_1 = NULL;
	Uri_t100236324 * V_2 = NULL;
	Uri_t100236324 * V_3 = NULL;
	{
		String_t* L_0 = ___redirectUri1;
		NullCheck(L_0);
		Il2CppChar L_1 = String_get_Chars_m2986988803(L_0, 0, /*hidden argument*/NULL);
		if ((!(((uint32_t)L_1) == ((uint32_t)((int32_t)47)))))
		{
			goto IL_001c;
		}
	}
	{
		String_t* L_2 = ___redirectUri1;
		Uri_t100236324 * L_3 = (Uri_t100236324 *)il2cpp_codegen_object_new(Uri_t100236324_il2cpp_TypeInfo_var);
		Uri__ctor_m3040793867(L_3, L_2, 2, /*hidden argument*/NULL);
		V_0 = L_3;
		goto IL_0024;
	}

IL_001c:
	{
		String_t* L_4 = ___redirectUri1;
		Uri_t100236324 * L_5 = (Uri_t100236324 *)il2cpp_codegen_object_new(Uri_t100236324_il2cpp_TypeInfo_var);
		Uri__ctor_m3040793867(L_5, L_4, 0, /*hidden argument*/NULL);
		V_0 = L_5;
	}

IL_0024:
	{
		Uri_t100236324 * L_6 = V_0;
		NullCheck(L_6);
		bool L_7 = Uri_get_IsAbsoluteUri_m3666899587(L_6, /*hidden argument*/NULL);
		if (!L_7)
		{
			goto IL_003b;
		}
	}
	{
		Uri_t100236324 * L_8 = V_0;
		NullCheck(L_8);
		String_t* L_9 = Uri_get_AbsoluteUri_m2582056986(L_8, /*hidden argument*/NULL);
		V_1 = L_9;
		goto IL_0057;
	}

IL_003b:
	{
		String_t* L_10 = ___baseUri0;
		Uri_t100236324 * L_11 = (Uri_t100236324 *)il2cpp_codegen_object_new(Uri_t100236324_il2cpp_TypeInfo_var);
		Uri__ctor_m3040793867(L_11, L_10, 1, /*hidden argument*/NULL);
		V_2 = L_11;
		Uri_t100236324 * L_12 = V_2;
		Uri_t100236324 * L_13 = V_0;
		Uri_t100236324 * L_14 = (Uri_t100236324 *)il2cpp_codegen_object_new(Uri_t100236324_il2cpp_TypeInfo_var);
		Uri__ctor_m253204164(L_14, L_12, L_13, /*hidden argument*/NULL);
		V_3 = L_14;
		Uri_t100236324 * L_15 = V_3;
		NullCheck(L_15);
		String_t* L_16 = Uri_get_AbsoluteUri_m2582056986(L_15, /*hidden argument*/NULL);
		V_1 = L_16;
		goto IL_0057;
	}

IL_0057:
	{
		String_t* L_17 = V_1;
		return L_17;
	}
}
// System.Void UnityEngineInternal.WebRequestUtils::.cctor()
extern "C"  void WebRequestUtils__cctor_m2866502633 (Il2CppObject * __this /* static, unused */, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (WebRequestUtils__cctor_m2866502633_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Regex_t3657309853 * L_0 = (Regex_t3657309853 *)il2cpp_codegen_object_new(Regex_t3657309853_il2cpp_TypeInfo_var);
		Regex__ctor_m897876424(L_0, _stringLiteral3847659558, /*hidden argument*/NULL);
		((WebRequestUtils_t3541624225_StaticFields*)WebRequestUtils_t3541624225_il2cpp_TypeInfo_var->static_fields)->set_domainRegex_0(L_0);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
