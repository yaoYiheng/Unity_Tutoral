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
#include "UnityEngine_UI_UnityEngine_UI_ObjectPool_1_gen2779729376.h"
#include "mscorlib_System_Void1185182177.h"
#include "UnityEngine_UnityEngine_Events_UnityAction_1_gen3664942305.h"
#include "System_System_Collections_Generic_Stack_1_gen3923495619.h"
#include "mscorlib_System_Object3080106164.h"
#include "mscorlib_System_Int322950945753.h"
#include "mscorlib_System_Boolean97287965.h"
#include "mscorlib_System_String1847450689.h"

// UnityEngine.UI.ObjectPool`1<System.Object>
struct ObjectPool_1_t2779729376;
// UnityEngine.Events.UnityAction`1<System.Object>
struct UnityAction_1_t3664942305;
// System.Object
struct Il2CppObject;
extern Il2CppClass* Debug_t3317548046_il2cpp_TypeInfo_var;
extern Il2CppCodeGenString* _stringLiteral46997234;
extern const uint32_t ObjectPool_1_Release_m3263354170_MetadataUsageId;




// System.Void System.Object::.ctor()
extern "C"  void Object__ctor_m297566312 (Il2CppObject * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Object::ReferenceEquals(System.Object,System.Object)
extern "C"  bool Object_ReferenceEquals_m610702577 (Il2CppObject * __this /* static, unused */, Il2CppObject * p0, Il2CppObject * p1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Debug::LogError(System.Object)
extern "C"  void Debug_LogError_m2059623341 (Il2CppObject * __this /* static, unused */, Il2CppObject * p0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.UI.ObjectPool`1<System.Object>::.ctor(UnityEngine.Events.UnityAction`1<T>,UnityEngine.Events.UnityAction`1<T>)
extern "C"  void ObjectPool_1__ctor_m2535233435_gshared (ObjectPool_1_t2779729376 * __this, UnityAction_1_t3664942305 * ___actionOnGet0, UnityAction_1_t3664942305 * ___actionOnRelease1, const MethodInfo* method)
{
	{
		Stack_1_t3923495619 * L_0 = (Stack_1_t3923495619 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->declaring_type->rgctx_data, 0));
		((  void (*) (Stack_1_t3923495619 *, const MethodInfo*))IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 1)->methodPointer)(L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 1));
		__this->set_m_Stack_0(L_0);
		NullCheck((Il2CppObject *)__this);
		Object__ctor_m297566312((Il2CppObject *)__this, /*hidden argument*/NULL);
		UnityAction_1_t3664942305 * L_1 = ___actionOnGet0;
		__this->set_m_ActionOnGet_1(L_1);
		UnityAction_1_t3664942305 * L_2 = ___actionOnRelease1;
		__this->set_m_ActionOnRelease_2(L_2);
		return;
	}
}
// System.Int32 UnityEngine.UI.ObjectPool`1<System.Object>::get_countAll()
extern "C"  int32_t ObjectPool_1_get_countAll_m819305395_gshared (ObjectPool_1_t2779729376 * __this, const MethodInfo* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = (int32_t)__this->get_U3CcountAllU3Ek__BackingField_3();
		V_0 = (int32_t)L_0;
		goto IL_000c;
	}

IL_000c:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.UI.ObjectPool`1<System.Object>::set_countAll(System.Int32)
extern "C"  void ObjectPool_1_set_countAll_m3507126863_gshared (ObjectPool_1_t2779729376 * __this, int32_t ___value0, const MethodInfo* method)
{
	{
		int32_t L_0 = ___value0;
		__this->set_U3CcountAllU3Ek__BackingField_3(L_0);
		return;
	}
}
// System.Int32 UnityEngine.UI.ObjectPool`1<System.Object>::get_countActive()
extern "C"  int32_t ObjectPool_1_get_countActive_m807006650_gshared (ObjectPool_1_t2779729376 * __this, const MethodInfo* method)
{
	int32_t V_0 = 0;
	{
		NullCheck((ObjectPool_1_t2779729376 *)__this);
		int32_t L_0 = ((  int32_t (*) (ObjectPool_1_t2779729376 *, const MethodInfo*))IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 2)->methodPointer)((ObjectPool_1_t2779729376 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 2));
		NullCheck((ObjectPool_1_t2779729376 *)__this);
		int32_t L_1 = ((  int32_t (*) (ObjectPool_1_t2779729376 *, const MethodInfo*))IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 3)->methodPointer)((ObjectPool_1_t2779729376 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 3));
		V_0 = (int32_t)((int32_t)((int32_t)L_0-(int32_t)L_1));
		goto IL_0014;
	}

IL_0014:
	{
		int32_t L_2 = V_0;
		return L_2;
	}
}
// System.Int32 UnityEngine.UI.ObjectPool`1<System.Object>::get_countInactive()
extern "C"  int32_t ObjectPool_1_get_countInactive_m526975942_gshared (ObjectPool_1_t2779729376 * __this, const MethodInfo* method)
{
	int32_t V_0 = 0;
	{
		Stack_1_t3923495619 * L_0 = (Stack_1_t3923495619 *)__this->get_m_Stack_0();
		NullCheck((Stack_1_t3923495619 *)L_0);
		int32_t L_1 = ((  int32_t (*) (Stack_1_t3923495619 *, const MethodInfo*))IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 4)->methodPointer)((Stack_1_t3923495619 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 4));
		V_0 = (int32_t)L_1;
		goto IL_0012;
	}

IL_0012:
	{
		int32_t L_2 = V_0;
		return L_2;
	}
}
// T UnityEngine.UI.ObjectPool`1<System.Object>::Get()
extern "C"  Il2CppObject * ObjectPool_1_Get_m3351668383_gshared (ObjectPool_1_t2779729376 * __this, const MethodInfo* method)
{
	Il2CppObject * V_0 = NULL;
	Il2CppObject * V_1 = NULL;
	{
		Stack_1_t3923495619 * L_0 = (Stack_1_t3923495619 *)__this->get_m_Stack_0();
		NullCheck((Stack_1_t3923495619 *)L_0);
		int32_t L_1 = ((  int32_t (*) (Stack_1_t3923495619 *, const MethodInfo*))IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 4)->methodPointer)((Stack_1_t3923495619 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 4));
		if (L_1)
		{
			goto IL_002c;
		}
	}
	{
		Il2CppObject * L_2 = ((  Il2CppObject * (*) (Il2CppObject * /* static, unused */, const MethodInfo*))IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 5)->methodPointer)(NULL /*static, unused*/, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 5));
		V_0 = (Il2CppObject *)L_2;
		NullCheck((ObjectPool_1_t2779729376 *)__this);
		int32_t L_3 = ((  int32_t (*) (ObjectPool_1_t2779729376 *, const MethodInfo*))IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 2)->methodPointer)((ObjectPool_1_t2779729376 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 2));
		NullCheck((ObjectPool_1_t2779729376 *)__this);
		((  void (*) (ObjectPool_1_t2779729376 *, int32_t, const MethodInfo*))IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 6)->methodPointer)((ObjectPool_1_t2779729376 *)__this, (int32_t)((int32_t)((int32_t)L_3+(int32_t)1)), /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 6));
		goto IL_003a;
	}

IL_002c:
	{
		Stack_1_t3923495619 * L_4 = (Stack_1_t3923495619 *)__this->get_m_Stack_0();
		NullCheck((Stack_1_t3923495619 *)L_4);
		Il2CppObject * L_5 = ((  Il2CppObject * (*) (Stack_1_t3923495619 *, const MethodInfo*))IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 7)->methodPointer)((Stack_1_t3923495619 *)L_4, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 7));
		V_0 = (Il2CppObject *)L_5;
	}

IL_003a:
	{
		UnityAction_1_t3664942305 * L_6 = (UnityAction_1_t3664942305 *)__this->get_m_ActionOnGet_1();
		if (!L_6)
		{
			goto IL_0051;
		}
	}
	{
		UnityAction_1_t3664942305 * L_7 = (UnityAction_1_t3664942305 *)__this->get_m_ActionOnGet_1();
		Il2CppObject * L_8 = V_0;
		NullCheck((UnityAction_1_t3664942305 *)L_7);
		((  void (*) (UnityAction_1_t3664942305 *, Il2CppObject *, const MethodInfo*))IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 8)->methodPointer)((UnityAction_1_t3664942305 *)L_7, (Il2CppObject *)L_8, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 8));
	}

IL_0051:
	{
		Il2CppObject * L_9 = V_0;
		V_1 = (Il2CppObject *)L_9;
		goto IL_0058;
	}

IL_0058:
	{
		Il2CppObject * L_10 = V_1;
		return L_10;
	}
}
// System.Void UnityEngine.UI.ObjectPool`1<System.Object>::Release(T)
extern "C"  void ObjectPool_1_Release_m3263354170_gshared (ObjectPool_1_t2779729376 * __this, Il2CppObject * ___element0, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ObjectPool_1_Release_m3263354170_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Stack_1_t3923495619 * L_0 = (Stack_1_t3923495619 *)__this->get_m_Stack_0();
		NullCheck((Stack_1_t3923495619 *)L_0);
		int32_t L_1 = ((  int32_t (*) (Stack_1_t3923495619 *, const MethodInfo*))IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 4)->methodPointer)((Stack_1_t3923495619 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 4));
		if ((((int32_t)L_1) <= ((int32_t)0)))
		{
			goto IL_003c;
		}
	}
	{
		Stack_1_t3923495619 * L_2 = (Stack_1_t3923495619 *)__this->get_m_Stack_0();
		NullCheck((Stack_1_t3923495619 *)L_2);
		Il2CppObject * L_3 = ((  Il2CppObject * (*) (Stack_1_t3923495619 *, const MethodInfo*))IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 9)->methodPointer)((Stack_1_t3923495619 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 9));
		Il2CppObject * L_4 = ___element0;
		bool L_5 = Object_ReferenceEquals_m610702577(NULL /*static, unused*/, (Il2CppObject *)L_3, (Il2CppObject *)L_4, /*hidden argument*/NULL);
		if (!L_5)
		{
			goto IL_003c;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_t3317548046_il2cpp_TypeInfo_var);
		Debug_LogError_m2059623341(NULL /*static, unused*/, (Il2CppObject *)_stringLiteral46997234, /*hidden argument*/NULL);
	}

IL_003c:
	{
		UnityAction_1_t3664942305 * L_6 = (UnityAction_1_t3664942305 *)__this->get_m_ActionOnRelease_2();
		if (!L_6)
		{
			goto IL_0053;
		}
	}
	{
		UnityAction_1_t3664942305 * L_7 = (UnityAction_1_t3664942305 *)__this->get_m_ActionOnRelease_2();
		Il2CppObject * L_8 = ___element0;
		NullCheck((UnityAction_1_t3664942305 *)L_7);
		((  void (*) (UnityAction_1_t3664942305 *, Il2CppObject *, const MethodInfo*))IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 8)->methodPointer)((UnityAction_1_t3664942305 *)L_7, (Il2CppObject *)L_8, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 8));
	}

IL_0053:
	{
		Stack_1_t3923495619 * L_9 = (Stack_1_t3923495619 *)__this->get_m_Stack_0();
		Il2CppObject * L_10 = ___element0;
		NullCheck((Stack_1_t3923495619 *)L_9);
		((  void (*) (Stack_1_t3923495619 *, Il2CppObject *, const MethodInfo*))IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 11)->methodPointer)((Stack_1_t3923495619 *)L_9, (Il2CppObject *)L_10, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->declaring_type->rgctx_data, 11));
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
