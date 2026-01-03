#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>


template <typename T1, typename T2>
struct VirtualActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename R>
struct VirtualFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1, typename T2>
struct GenericVirtualActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1, T2 p2)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename T1, typename T2>
struct InterfaceActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename T1, typename T2>
struct GenericInterfaceActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1, T2 p2)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};

struct Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA;
struct Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718;
struct IEqualityComparer_1_tAE94C8F24AD5B94D4EE85CA9FC59E3409D41CAF7;
struct KeyCollection_t5B7460650B19BE05981C934307853A5F7B2AC452;
struct ValueCollection_t038245E04B5D2A80048D9F8021A23E69A0C9DBAA;
struct ValueCollection_t45574612A30062D13F998617ED6AAAB0503DA316;
struct EntryU5BU5D_tE262E2F44DB8D711A7D8AF3BE0E7992F29890E9B;
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
struct IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832;
struct StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF;
struct TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB;
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C;
struct Binder_t91BFCE95A7057FADF4D8A1A342AFE52872246235;
struct Delegate_t;
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
struct Exception_t;
struct IAsyncResult_t7B9B5A0ECB35DCEC31B8A8122C37D687369253B5;
struct IDictionary_t6D03155AF1FA9083817AA5B6AD7DEEACC26AB220;
struct LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416;
struct Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD;
struct MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553;
struct MethodInfo_t;
struct SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6;
struct SherlogAssertException_t2924294ADFD5C193F5430C249E3C61949BA8DC0E;
struct String_t;
struct Type_t;
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;

IL2CPP_EXTERN_C RuntimeClass* Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* LogLevel_t240AEA1F5FF2507110152824B4C9E6F8FB556C58_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SherlogAssertException_t2924294ADFD5C193F5430C249E3C61949BA8DC0E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_Add_m7112C58069BEE843B49C4FCCE2D18C539A874C75_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_Clear_mE542AC4B4EF756E531FE29479ED3D01B6D1C329F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_TryGetValue_mB71314BCFE163779671CAAE3E4FC84BF222A0269_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2__ctor_mF1446AF7EAC828E096FBCED8FAA3C66BE6CC3391_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_get_Values_m6CCF0662EAE3F3DB9D405559A89744B948FA477D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_Dispose_m0E3C6CF27F1D5BCBA06FBD97F760A8D1B519C9E1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_MoveNext_m91FE3CEAB5E3484BB006B22E763BEF655FCDDBDB_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_get_Current_m724883BD65E8EF5E61DA8FEAF5DD2FF43EE081D7_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Logger_Assert_m6CADB6534254FBA3380EEBCADFA32E1C126E5379_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ValueCollection_GetEnumerator_mC7347BF77D8FA87385F1520C079AD79E28BEA4E6_RuntimeMethod_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
struct U3CModuleU3E_t830E16105B1714970FA2C4D5EF0DD8856B429B3F 
{
};
struct Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718  : public RuntimeObject
{
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____buckets;
	EntryU5BU5D_tE262E2F44DB8D711A7D8AF3BE0E7992F29890E9B* ____entries;
	int32_t ____count;
	int32_t ____freeList;
	int32_t ____freeCount;
	int32_t ____version;
	RuntimeObject* ____comparer;
	KeyCollection_t5B7460650B19BE05981C934307853A5F7B2AC452* ____keys;
	ValueCollection_t45574612A30062D13F998617ED6AAAB0503DA316* ____values;
	RuntimeObject* ____syncRoot;
};
struct ValueCollection_t45574612A30062D13F998617ED6AAAB0503DA316  : public RuntimeObject
{
	Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718* ____dictionary;
};
struct MemberInfo_t  : public RuntimeObject
{
};
struct String_t  : public RuntimeObject
{
	int32_t ____stringLength;
	Il2CppChar ____firstChar;
};
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};
struct Enumerator_t44124D16E0B2F7308FF4069BE06369B5A83896EB 
{
	Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* ____dictionary;
	int32_t ____index;
	int32_t ____version;
	RuntimeObject* ____currentValue;
};
struct Enumerator_t10E83AD353186F18522BD4B2BC4F65DA882561BF 
{
	Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718* ____dictionary;
	int32_t ____index;
	int32_t ____version;
	Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* ____currentValue;
};
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	bool ___m_value;
};
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2  : public ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F
{
};
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_marshaled_pinvoke
{
};
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_marshaled_com
{
};
struct IntPtr_t 
{
	void* ___m_value;
};
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};
struct Delegate_t  : public RuntimeObject
{
	intptr_t ___method_ptr;
	intptr_t ___invoke_impl;
	RuntimeObject* ___m_target;
	intptr_t ___method;
	intptr_t ___delegate_trampoline;
	intptr_t ___extra_arg;
	intptr_t ___method_code;
	intptr_t ___interp_method;
	intptr_t ___interp_invoke_impl;
	MethodInfo_t* ___method_info;
	MethodInfo_t* ___original_method_info;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data;
	bool ___method_is_virtual;
};
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr;
	intptr_t ___invoke_impl;
	Il2CppIUnknown* ___m_target;
	intptr_t ___method;
	intptr_t ___delegate_trampoline;
	intptr_t ___extra_arg;
	intptr_t ___method_code;
	intptr_t ___interp_method;
	intptr_t ___interp_invoke_impl;
	MethodInfo_t* ___method_info;
	MethodInfo_t* ___original_method_info;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data;
	int32_t ___method_is_virtual;
};
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr;
	intptr_t ___invoke_impl;
	Il2CppIUnknown* ___m_target;
	intptr_t ___method;
	intptr_t ___delegate_trampoline;
	intptr_t ___extra_arg;
	intptr_t ___method_code;
	intptr_t ___interp_method;
	intptr_t ___interp_invoke_impl;
	MethodInfo_t* ___method_info;
	MethodInfo_t* ___original_method_info;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data;
	int32_t ___method_is_virtual;
};
struct Exception_t  : public RuntimeObject
{
	String_t* ____className;
	String_t* ____message;
	RuntimeObject* ____data;
	Exception_t* ____innerException;
	String_t* ____helpURL;
	RuntimeObject* ____stackTrace;
	String_t* ____stackTraceString;
	String_t* ____remoteStackTraceString;
	int32_t ____remoteStackIndex;
	RuntimeObject* ____dynamicMethods;
	int32_t ____HResult;
	String_t* ____source;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces;
	IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832* ___native_trace_ips;
	int32_t ___caught_in_unmanaged;
};
struct Exception_t_marshaled_pinvoke
{
	char* ____className;
	char* ____message;
	RuntimeObject* ____data;
	Exception_t_marshaled_pinvoke* ____innerException;
	char* ____helpURL;
	Il2CppIUnknown* ____stackTrace;
	char* ____stackTraceString;
	char* ____remoteStackTraceString;
	int32_t ____remoteStackIndex;
	Il2CppIUnknown* ____dynamicMethods;
	int32_t ____HResult;
	char* ____source;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces;
	Il2CppSafeArray* ___native_trace_ips;
	int32_t ___caught_in_unmanaged;
};
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className;
	Il2CppChar* ____message;
	RuntimeObject* ____data;
	Exception_t_marshaled_com* ____innerException;
	Il2CppChar* ____helpURL;
	Il2CppIUnknown* ____stackTrace;
	Il2CppChar* ____stackTraceString;
	Il2CppChar* ____remoteStackTraceString;
	int32_t ____remoteStackIndex;
	Il2CppIUnknown* ____dynamicMethods;
	int32_t ____HResult;
	Il2CppChar* ____source;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces;
	Il2CppSafeArray* ___native_trace_ips;
	int32_t ___caught_in_unmanaged;
};
struct LogLevel_t240AEA1F5FF2507110152824B4C9E6F8FB556C58 
{
	int32_t ___value__;
};
struct RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B 
{
	intptr_t ___value;
};
struct Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD  : public RuntimeObject
{
	LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* ___OnLog;
	String_t* ___Name;
	int32_t ___LogLevel;
};
struct MulticastDelegate_t  : public Delegate_t
{
	DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* ___delegates;
};
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates;
};
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates;
};
struct SherlogAssertException_t2924294ADFD5C193F5430C249E3C61949BA8DC0E  : public Exception_t
{
};
struct Type_t  : public MemberInfo_t
{
	RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B ____impl;
};
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C  : public MulticastDelegate_t
{
};
struct LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416  : public MulticastDelegate_t
{
};
struct String_t_StaticFields
{
	String_t* ___Empty;
};
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	String_t* ___TrueString;
	String_t* ___FalseString;
};
struct IntPtr_t_StaticFields
{
	intptr_t ___Zero;
};
struct Exception_t_StaticFields
{
	RuntimeObject* ___s_EDILock;
};
struct Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields
{
	Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718* ___Loggers;
	int32_t ____globalLogLevel;
	LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* ____appenders;
};
struct Type_t_StaticFields
{
	Binder_t91BFCE95A7057FADF4D8A1A342AFE52872246235* ___s_defaultBinder;
	Il2CppChar ___Delimiter;
	TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB* ___EmptyTypes;
	RuntimeObject* ___Missing;
	MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553* ___FilterAttribute;
	MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553* ___FilterName;
	MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553* ___FilterNameIgnoreCase;
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771  : public RuntimeArray
{
	ALIGN_FIELD (8) Delegate_t* m_Items[1];

	inline Delegate_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Delegate_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Delegate_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Delegate_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ValueCollection_t038245E04B5D2A80048D9F8021A23E69A0C9DBAA* Dictionary_2_get_Values_mA0C01DEA55329E55380E96BBD04D4D228B437EC5_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Enumerator_t44124D16E0B2F7308FF4069BE06369B5A83896EB ValueCollection_GetEnumerator_m025EE28BE2F31676E08BC3D7C8E39D8232BDBBF8_gshared (ValueCollection_t038245E04B5D2A80048D9F8021A23E69A0C9DBAA* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator_Dispose_mFD8FAB8D9FF5EDF9AE3B14CF539A8A34AA9527A8_gshared (Enumerator_t44124D16E0B2F7308FF4069BE06369B5A83896EB* __this, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* Enumerator_get_Current_mB407E755F3B4C51C54D24338D00A352E5B16E7F3_gshared_inline (Enumerator_t44124D16E0B2F7308FF4069BE06369B5A83896EB* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_mBE11DA1DAFC756EB87E884AADC5EDC4BB72FB032_gshared (Enumerator_t44124D16E0B2F7308FF4069BE06369B5A83896EB* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Dictionary_2_TryGetValue_mD15380A4ED7CDEE99EA45881577D26BA9CE1B849_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, RuntimeObject* ___0_key, RuntimeObject** ___1_value, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2_Add_m93FFFABE8FCE7FA9793F0915E2A8842C7CD0C0C1_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, RuntimeObject* ___0_key, RuntimeObject* ___1_value, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2_Clear_mCFB5EA7351D5860D2B91592B91A84CA265A41433_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2__ctor_m5B32FBC624618211EB461D59CFBB10E987FD1329_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, const RuntimeMethod* method) ;

IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Delegate_t* Delegate_Combine_m1F725AEF318BE6F0426863490691A6F4606E7D00 (Delegate_t* ___0_a, Delegate_t* ___1_b, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Delegate_t* Delegate_Remove_m8B7DD5661308FA972E23CA1CC3FC9CEB355504E3 (Delegate_t* ___0_source, Delegate_t* ___1_value, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_Log_mA46EEEE7A1692322CED5CA640B6AC9C2F0EE3971 (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* __this, int32_t ___0_logLvl, String_t* ___1_message, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SherlogAssertException__ctor_m0715DCA69AF2364BE6BBACA58D1D0861ED8D4322 (SherlogAssertException_t2924294ADFD5C193F5430C249E3C61949BA8DC0E* __this, String_t* ___0_message, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LogDelegate_Invoke_mAADCB9EAB22B25DC3A047BA5A59465471E5BA010_inline (LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* __this, Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* ___0_logger, int32_t ___1_logLevel, String_t* ___2_message, const RuntimeMethod* method) ;
inline ValueCollection_t45574612A30062D13F998617ED6AAAB0503DA316* Dictionary_2_get_Values_m6CCF0662EAE3F3DB9D405559A89744B948FA477D (Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718* __this, const RuntimeMethod* method)
{
	return ((  ValueCollection_t45574612A30062D13F998617ED6AAAB0503DA316* (*) (Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718*, const RuntimeMethod*))Dictionary_2_get_Values_mA0C01DEA55329E55380E96BBD04D4D228B437EC5_gshared)(__this, method);
}
inline Enumerator_t10E83AD353186F18522BD4B2BC4F65DA882561BF ValueCollection_GetEnumerator_mC7347BF77D8FA87385F1520C079AD79E28BEA4E6 (ValueCollection_t45574612A30062D13F998617ED6AAAB0503DA316* __this, const RuntimeMethod* method)
{
	return ((  Enumerator_t10E83AD353186F18522BD4B2BC4F65DA882561BF (*) (ValueCollection_t45574612A30062D13F998617ED6AAAB0503DA316*, const RuntimeMethod*))ValueCollection_GetEnumerator_m025EE28BE2F31676E08BC3D7C8E39D8232BDBBF8_gshared)(__this, method);
}
inline void Enumerator_Dispose_m0E3C6CF27F1D5BCBA06FBD97F760A8D1B519C9E1 (Enumerator_t10E83AD353186F18522BD4B2BC4F65DA882561BF* __this, const RuntimeMethod* method)
{
	((  void (*) (Enumerator_t10E83AD353186F18522BD4B2BC4F65DA882561BF*, const RuntimeMethod*))Enumerator_Dispose_mFD8FAB8D9FF5EDF9AE3B14CF539A8A34AA9527A8_gshared)(__this, method);
}
inline Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* Enumerator_get_Current_m724883BD65E8EF5E61DA8FEAF5DD2FF43EE081D7_inline (Enumerator_t10E83AD353186F18522BD4B2BC4F65DA882561BF* __this, const RuntimeMethod* method)
{
	return ((  Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* (*) (Enumerator_t10E83AD353186F18522BD4B2BC4F65DA882561BF*, const RuntimeMethod*))Enumerator_get_Current_mB407E755F3B4C51C54D24338D00A352E5B16E7F3_gshared_inline)(__this, method);
}
inline bool Enumerator_MoveNext_m91FE3CEAB5E3484BB006B22E763BEF655FCDDBDB (Enumerator_t10E83AD353186F18522BD4B2BC4F65DA882561BF* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_t10E83AD353186F18522BD4B2BC4F65DA882561BF*, const RuntimeMethod*))Enumerator_MoveNext_mBE11DA1DAFC756EB87E884AADC5EDC4BB72FB032_gshared)(__this, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_add_OnLog_mEA27658ECFE56B378935CFE75EE4A00247C465B4 (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* __this, LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* ___0_value, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_remove_OnLog_mBEF3444F9E216366015A1D2DFA8C3A852B3F30F0 (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* __this, LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* ___0_value, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* Logger_GetLogger_mDCCE0B3E9ECE3DC1B3B38DD59F586BC0790997C6 (String_t* ___0_name, const RuntimeMethod* method) ;
inline bool Dictionary_2_TryGetValue_mB71314BCFE163779671CAAE3E4FC84BF222A0269 (Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718* __this, String_t* ___0_key, Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD** ___1_value, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718*, String_t*, Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD**, const RuntimeMethod*))Dictionary_2_TryGetValue_mD15380A4ED7CDEE99EA45881577D26BA9CE1B849_gshared)(__this, ___0_key, ___1_value, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger__ctor_m82CE34DE97B95E8FAEA5DE405CB4A4395BEBA6EE (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* __this, String_t* ___0_name, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Logger_get_GlobalLogLevel_mD7A21149F0E68419132501FE6EA4FF6955211BFD_inline (const RuntimeMethod* method) ;
inline void Dictionary_2_Add_m7112C58069BEE843B49C4FCCE2D18C539A874C75 (Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718* __this, String_t* ___0_key, Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* ___1_value, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718*, String_t*, Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD*, const RuntimeMethod*))Dictionary_2_Add_m93FFFABE8FCE7FA9793F0915E2A8842C7CD0C0C1_gshared)(__this, ___0_key, ___1_value, method);
}
inline void Dictionary_2_Clear_mE542AC4B4EF756E531FE29479ED3D01B6D1C329F (Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718* __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718*, const RuntimeMethod*))Dictionary_2_Clear_mCFB5EA7351D5860D2B91592B91A84CA265A41433_gshared)(__this, method);
}
inline void Dictionary_2__ctor_mF1446AF7EAC828E096FBCED8FAA3C66BE6CC3391 (Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718* __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718*, const RuntimeMethod*))Dictionary_2__ctor_m5B32FBC624618211EB461D59CFBB10E987FD1329_gshared)(__this, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Exception__ctor_m9B2BD92CD68916245A75109105D9071C9D430E7F (Exception_t* __this, String_t* ___0_message, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void LogDelegate_Invoke_mAADCB9EAB22B25DC3A047BA5A59465471E5BA010_Multicast(LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* __this, Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* ___0_logger, int32_t ___1_logLevel, String_t* ___2_message, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* currentDelegate = reinterpret_cast<LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD*, int32_t, String_t*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_logger, ___1_logLevel, ___2_message, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void LogDelegate_Invoke_mAADCB9EAB22B25DC3A047BA5A59465471E5BA010_OpenInst(LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* __this, Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* ___0_logger, int32_t ___1_logLevel, String_t* ___2_message, const RuntimeMethod* method)
{
	NullCheck(___0_logger);
	typedef void (*FunctionPointerType) (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD*, int32_t, String_t*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_logger, ___1_logLevel, ___2_message, method);
}
void LogDelegate_Invoke_mAADCB9EAB22B25DC3A047BA5A59465471E5BA010_OpenStatic(LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* __this, Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* ___0_logger, int32_t ___1_logLevel, String_t* ___2_message, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD*, int32_t, String_t*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_logger, ___1_logLevel, ___2_message, method);
}
void LogDelegate_Invoke_mAADCB9EAB22B25DC3A047BA5A59465471E5BA010_OpenVirtual(LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* __this, Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* ___0_logger, int32_t ___1_logLevel, String_t* ___2_message, const RuntimeMethod* method)
{
	NullCheck(___0_logger);
	VirtualActionInvoker2< int32_t, String_t* >::Invoke(il2cpp_codegen_method_get_slot(method), ___0_logger, ___1_logLevel, ___2_message);
}
void LogDelegate_Invoke_mAADCB9EAB22B25DC3A047BA5A59465471E5BA010_OpenInterface(LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* __this, Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* ___0_logger, int32_t ___1_logLevel, String_t* ___2_message, const RuntimeMethod* method)
{
	NullCheck(___0_logger);
	InterfaceActionInvoker2< int32_t, String_t* >::Invoke(il2cpp_codegen_method_get_slot(method), il2cpp_codegen_method_get_declaring_type(method), ___0_logger, ___1_logLevel, ___2_message);
}
void LogDelegate_Invoke_mAADCB9EAB22B25DC3A047BA5A59465471E5BA010_OpenGenericVirtual(LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* __this, Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* ___0_logger, int32_t ___1_logLevel, String_t* ___2_message, const RuntimeMethod* method)
{
	NullCheck(___0_logger);
	GenericVirtualActionInvoker2< int32_t, String_t* >::Invoke(method, ___0_logger, ___1_logLevel, ___2_message);
}
void LogDelegate_Invoke_mAADCB9EAB22B25DC3A047BA5A59465471E5BA010_OpenGenericInterface(LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* __this, Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* ___0_logger, int32_t ___1_logLevel, String_t* ___2_message, const RuntimeMethod* method)
{
	NullCheck(___0_logger);
	GenericInterfaceActionInvoker2< int32_t, String_t* >::Invoke(method, ___0_logger, ___1_logLevel, ___2_message);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LogDelegate__ctor_m29538CCCBE68E77CAB24E63FAB368EDFDFDCFF0E (LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 3;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&LogDelegate_Invoke_mAADCB9EAB22B25DC3A047BA5A59465471E5BA010_OpenStatic;
		else
			{
				__this->___invoke_impl = __this->___method_ptr;
				__this->___method_code = (intptr_t)__this->___m_target;
			}
	}
	else
	{
		bool isOpen = parameterCount == 2;
		if (isOpen)
		{
			if (__this->___method_is_virtual)
			{
				if (il2cpp_codegen_method_is_generic_instance_method((RuntimeMethod*)___1_method))
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&LogDelegate_Invoke_mAADCB9EAB22B25DC3A047BA5A59465471E5BA010_OpenGenericInterface;
					else
						__this->___invoke_impl = (intptr_t)&LogDelegate_Invoke_mAADCB9EAB22B25DC3A047BA5A59465471E5BA010_OpenGenericVirtual;
				else
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&LogDelegate_Invoke_mAADCB9EAB22B25DC3A047BA5A59465471E5BA010_OpenInterface;
					else
						__this->___invoke_impl = (intptr_t)&LogDelegate_Invoke_mAADCB9EAB22B25DC3A047BA5A59465471E5BA010_OpenVirtual;
			}
			else
			{
				__this->___invoke_impl = (intptr_t)&LogDelegate_Invoke_mAADCB9EAB22B25DC3A047BA5A59465471E5BA010_OpenInst;
			}
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = __this->___method_ptr;
			__this->___method_code = (intptr_t)__this->___m_target;
		}
	}
	__this->___extra_arg = (intptr_t)&LogDelegate_Invoke_mAADCB9EAB22B25DC3A047BA5A59465471E5BA010_Multicast;
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LogDelegate_Invoke_mAADCB9EAB22B25DC3A047BA5A59465471E5BA010 (LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* __this, Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* ___0_logger, int32_t ___1_logLevel, String_t* ___2_message, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD*, int32_t, String_t*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_logger, ___1_logLevel, ___2_message, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* LogDelegate_BeginInvoke_mB01B306C7278744958BA882DBDBC15244E723116 (LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* __this, Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* ___0_logger, int32_t ___1_logLevel, String_t* ___2_message, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___3_callback, RuntimeObject* ___4_object, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&LogLevel_t240AEA1F5FF2507110152824B4C9E6F8FB556C58_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[4] = {0};
	__d_args[0] = ___0_logger;
	__d_args[1] = Box(LogLevel_t240AEA1F5FF2507110152824B4C9E6F8FB556C58_il2cpp_TypeInfo_var, &___1_logLevel);
	__d_args[2] = ___2_message;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___3_callback, (RuntimeObject*)___4_object);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LogDelegate_EndInvoke_mE1D413694D61134A5D7E3CECEE5D29C90C268798 (LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* __this, RuntimeObject* ___0_result, const RuntimeMethod* method) 
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___0_result, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_add_OnLog_mEA27658ECFE56B378935CFE75EE4A00247C465B4 (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* __this, LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* V_0 = NULL;
	LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* V_1 = NULL;
	LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* V_2 = NULL;
	{
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_0 = __this->___OnLog;
		V_0 = L_0;
	}

IL_0007:
	{
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_1 = V_0;
		V_1 = L_1;
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_2 = V_1;
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_3 = ___0_value;
		Delegate_t* L_4;
		L_4 = Delegate_Combine_m1F725AEF318BE6F0426863490691A6F4606E7D00(L_2, L_3, NULL);
		V_2 = ((LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*)CastclassSealed((RuntimeObject*)L_4, LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416_il2cpp_TypeInfo_var));
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416** L_5 = (LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416**)(&__this->___OnLog);
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_6 = V_2;
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_7 = V_1;
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_8;
		L_8 = InterlockedCompareExchangeImpl<LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*>(L_5, L_6, L_7);
		V_0 = L_8;
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_9 = V_0;
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_10 = V_1;
		if ((!(((RuntimeObject*)(LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*)L_9) == ((RuntimeObject*)(LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_remove_OnLog_mBEF3444F9E216366015A1D2DFA8C3A852B3F30F0 (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* __this, LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* V_0 = NULL;
	LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* V_1 = NULL;
	LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* V_2 = NULL;
	{
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_0 = __this->___OnLog;
		V_0 = L_0;
	}

IL_0007:
	{
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_1 = V_0;
		V_1 = L_1;
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_2 = V_1;
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_3 = ___0_value;
		Delegate_t* L_4;
		L_4 = Delegate_Remove_m8B7DD5661308FA972E23CA1CC3FC9CEB355504E3(L_2, L_3, NULL);
		V_2 = ((LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*)CastclassSealed((RuntimeObject*)L_4, LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416_il2cpp_TypeInfo_var));
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416** L_5 = (LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416**)(&__this->___OnLog);
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_6 = V_2;
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_7 = V_1;
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_8;
		L_8 = InterlockedCompareExchangeImpl<LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*>(L_5, L_6, L_7);
		V_0 = L_8;
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_9 = V_0;
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_10 = V_1;
		if ((!(((RuntimeObject*)(LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*)L_9) == ((RuntimeObject*)(LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger__ctor_m82CE34DE97B95E8FAEA5DE405CB4A4395BEBA6EE (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* __this, String_t* ___0_name, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		String_t* L_0 = ___0_name;
		__this->___Name = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___Name), (void*)L_0);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_Trace_m25B924D8F34B927D9E9174CED0DE016EA62669EA (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* __this, String_t* ___0_message, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___0_message;
		Logger_Log_mA46EEEE7A1692322CED5CA640B6AC9C2F0EE3971(__this, 1, L_0, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_Debug_m4DFDE68805E30E0232B87D2B212B32D36475EE66 (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* __this, String_t* ___0_message, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___0_message;
		Logger_Log_mA46EEEE7A1692322CED5CA640B6AC9C2F0EE3971(__this, 2, L_0, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_Info_mA7352A6A8377BBA6A2D2A3D0C1E74F8BBC6D3D6F (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* __this, String_t* ___0_message, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___0_message;
		Logger_Log_mA46EEEE7A1692322CED5CA640B6AC9C2F0EE3971(__this, 3, L_0, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_Warn_m8D4B5370F1D4C8FD5A2FAB7B05C3EE20EAD5940E (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* __this, String_t* ___0_message, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___0_message;
		Logger_Log_mA46EEEE7A1692322CED5CA640B6AC9C2F0EE3971(__this, 4, L_0, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_Error_mB005744B49F27911EE97DEFCC130B906CBCA0029 (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* __this, String_t* ___0_message, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___0_message;
		Logger_Log_mA46EEEE7A1692322CED5CA640B6AC9C2F0EE3971(__this, 5, L_0, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_Fatal_m4D5FE6553C1D92309287C2340CDEBFF720AEFEC2 (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* __this, String_t* ___0_message, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___0_message;
		Logger_Log_mA46EEEE7A1692322CED5CA640B6AC9C2F0EE3971(__this, 6, L_0, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_Assert_m6CADB6534254FBA3380EEBCADFA32E1C126E5379 (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* __this, bool ___0_condition, String_t* ___1_message, const RuntimeMethod* method) 
{
	{
		bool L_0 = ___0_condition;
		if (L_0)
		{
			goto IL_000a;
		}
	}
	{
		String_t* L_1 = ___1_message;
		SherlogAssertException_t2924294ADFD5C193F5430C249E3C61949BA8DC0E* L_2 = (SherlogAssertException_t2924294ADFD5C193F5430C249E3C61949BA8DC0E*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&SherlogAssertException_t2924294ADFD5C193F5430C249E3C61949BA8DC0E_il2cpp_TypeInfo_var)));
		SherlogAssertException__ctor_m0715DCA69AF2364BE6BBACA58D1D0861ED8D4322(L_2, L_1, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Logger_Assert_m6CADB6534254FBA3380EEBCADFA32E1C126E5379_RuntimeMethod_var)));
	}

IL_000a:
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_Log_mA46EEEE7A1692322CED5CA640B6AC9C2F0EE3971 (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* __this, int32_t ___0_logLvl, String_t* ___1_message, const RuntimeMethod* method) 
{
	LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* G_B3_0 = NULL;
	LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* G_B2_0 = NULL;
	{
		int32_t L_0 = __this->___LogLevel;
		int32_t L_1 = ___0_logLvl;
		if ((((int32_t)L_0) > ((int32_t)L_1)))
		{
			goto IL_001c;
		}
	}
	{
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_2 = __this->___OnLog;
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_3 = L_2;
		if (L_3)
		{
			G_B3_0 = L_3;
			goto IL_0014;
		}
		G_B2_0 = L_3;
	}
	{
		return;
	}

IL_0014:
	{
		int32_t L_4 = ___0_logLvl;
		String_t* L_5 = ___1_message;
		NullCheck(G_B3_0);
		LogDelegate_Invoke_mAADCB9EAB22B25DC3A047BA5A59465471E5BA010_inline(G_B3_0, __this, L_4, L_5, NULL);
	}

IL_001c:
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_Reset_m7C3E71940990A40E5E3A07280B31EBBAAE5260B1 (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* __this, const RuntimeMethod* method) 
{
	{
		__this->___OnLog = (LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___OnLog), (void*)(LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*)NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Logger_get_GlobalLogLevel_mD7A21149F0E68419132501FE6EA4FF6955211BFD (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		int32_t L_0 = ((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->____globalLogLevel;
		return L_0;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_set_GlobalLogLevel_mB0DE5803BCB3E4828A15FFDE8459F72866EBF984 (int32_t ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_get_Values_m6CCF0662EAE3F3DB9D405559A89744B948FA477D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_Dispose_m0E3C6CF27F1D5BCBA06FBD97F760A8D1B519C9E1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_MoveNext_m91FE3CEAB5E3484BB006B22E763BEF655FCDDBDB_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_get_Current_m724883BD65E8EF5E61DA8FEAF5DD2FF43EE081D7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ValueCollection_GetEnumerator_mC7347BF77D8FA87385F1520C079AD79E28BEA4E6_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	Enumerator_t10E83AD353186F18522BD4B2BC4F65DA882561BF V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		int32_t L_0 = ___0_value;
		il2cpp_codegen_runtime_class_init_inline(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->____globalLogLevel = L_0;
		Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718* L_1 = ((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->___Loggers;
		NullCheck(L_1);
		ValueCollection_t45574612A30062D13F998617ED6AAAB0503DA316* L_2;
		L_2 = Dictionary_2_get_Values_m6CCF0662EAE3F3DB9D405559A89744B948FA477D(L_1, Dictionary_2_get_Values_m6CCF0662EAE3F3DB9D405559A89744B948FA477D_RuntimeMethod_var);
		NullCheck(L_2);
		Enumerator_t10E83AD353186F18522BD4B2BC4F65DA882561BF L_3;
		L_3 = ValueCollection_GetEnumerator_mC7347BF77D8FA87385F1520C079AD79E28BEA4E6(L_2, ValueCollection_GetEnumerator_mC7347BF77D8FA87385F1520C079AD79E28BEA4E6_RuntimeMethod_var);
		V_0 = L_3;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0030:
			{
				Enumerator_Dispose_m0E3C6CF27F1D5BCBA06FBD97F760A8D1B519C9E1((&V_0), Enumerator_Dispose_m0E3C6CF27F1D5BCBA06FBD97F760A8D1B519C9E1_RuntimeMethod_var);
				return;
			}
		});
		try
		{
			{
				goto IL_0025_1;
			}

IL_0018_1:
			{
				Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* L_4;
				L_4 = Enumerator_get_Current_m724883BD65E8EF5E61DA8FEAF5DD2FF43EE081D7_inline((&V_0), Enumerator_get_Current_m724883BD65E8EF5E61DA8FEAF5DD2FF43EE081D7_RuntimeMethod_var);
				int32_t L_5 = ___0_value;
				NullCheck(L_4);
				L_4->___LogLevel = L_5;
			}

IL_0025_1:
			{
				bool L_6;
				L_6 = Enumerator_MoveNext_m91FE3CEAB5E3484BB006B22E763BEF655FCDDBDB((&V_0), Enumerator_MoveNext_m91FE3CEAB5E3484BB006B22E763BEF655FCDDBDB_RuntimeMethod_var);
				if (L_6)
				{
					goto IL_0018_1;
				}
			}
			{
				goto IL_003e;
			}
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_003e:
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_AddAppender_mF250B0FDC1269D12A19204726AF019B635980D9D (LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* ___0_appender, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_get_Values_m6CCF0662EAE3F3DB9D405559A89744B948FA477D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_Dispose_m0E3C6CF27F1D5BCBA06FBD97F760A8D1B519C9E1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_MoveNext_m91FE3CEAB5E3484BB006B22E763BEF655FCDDBDB_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_get_Current_m724883BD65E8EF5E61DA8FEAF5DD2FF43EE081D7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ValueCollection_GetEnumerator_mC7347BF77D8FA87385F1520C079AD79E28BEA4E6_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	Enumerator_t10E83AD353186F18522BD4B2BC4F65DA882561BF V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		il2cpp_codegen_runtime_class_init_inline(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_0 = ((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->____appenders;
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_1 = ___0_appender;
		Delegate_t* L_2;
		L_2 = Delegate_Combine_m1F725AEF318BE6F0426863490691A6F4606E7D00(L_0, L_1, NULL);
		((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->____appenders = ((LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*)CastclassSealed((RuntimeObject*)L_2, LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416_il2cpp_TypeInfo_var));
		Il2CppCodeGenWriteBarrier((void**)(&((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->____appenders), (void*)((LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*)CastclassSealed((RuntimeObject*)L_2, LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416_il2cpp_TypeInfo_var)));
		Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718* L_3 = ((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->___Loggers;
		NullCheck(L_3);
		ValueCollection_t45574612A30062D13F998617ED6AAAB0503DA316* L_4;
		L_4 = Dictionary_2_get_Values_m6CCF0662EAE3F3DB9D405559A89744B948FA477D(L_3, Dictionary_2_get_Values_m6CCF0662EAE3F3DB9D405559A89744B948FA477D_RuntimeMethod_var);
		NullCheck(L_4);
		Enumerator_t10E83AD353186F18522BD4B2BC4F65DA882561BF L_5;
		L_5 = ValueCollection_GetEnumerator_mC7347BF77D8FA87385F1520C079AD79E28BEA4E6(L_4, ValueCollection_GetEnumerator_mC7347BF77D8FA87385F1520C079AD79E28BEA4E6_RuntimeMethod_var);
		V_0 = L_5;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_003f:
			{
				Enumerator_Dispose_m0E3C6CF27F1D5BCBA06FBD97F760A8D1B519C9E1((&V_0), Enumerator_Dispose_m0E3C6CF27F1D5BCBA06FBD97F760A8D1B519C9E1_RuntimeMethod_var);
				return;
			}
		});
		try
		{
			{
				goto IL_0034_1;
			}

IL_0027_1:
			{
				Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* L_6;
				L_6 = Enumerator_get_Current_m724883BD65E8EF5E61DA8FEAF5DD2FF43EE081D7_inline((&V_0), Enumerator_get_Current_m724883BD65E8EF5E61DA8FEAF5DD2FF43EE081D7_RuntimeMethod_var);
				LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_7 = ___0_appender;
				NullCheck(L_6);
				Logger_add_OnLog_mEA27658ECFE56B378935CFE75EE4A00247C465B4(L_6, L_7, NULL);
			}

IL_0034_1:
			{
				bool L_8;
				L_8 = Enumerator_MoveNext_m91FE3CEAB5E3484BB006B22E763BEF655FCDDBDB((&V_0), Enumerator_MoveNext_m91FE3CEAB5E3484BB006B22E763BEF655FCDDBDB_RuntimeMethod_var);
				if (L_8)
				{
					goto IL_0027_1;
				}
			}
			{
				goto IL_004d;
			}
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_004d:
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_RemoveAppender_m1FF92343B6618546849DD2FC41228410B305CA3A (LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* ___0_appender, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_get_Values_m6CCF0662EAE3F3DB9D405559A89744B948FA477D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_Dispose_m0E3C6CF27F1D5BCBA06FBD97F760A8D1B519C9E1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_MoveNext_m91FE3CEAB5E3484BB006B22E763BEF655FCDDBDB_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_get_Current_m724883BD65E8EF5E61DA8FEAF5DD2FF43EE081D7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ValueCollection_GetEnumerator_mC7347BF77D8FA87385F1520C079AD79E28BEA4E6_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	Enumerator_t10E83AD353186F18522BD4B2BC4F65DA882561BF V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		il2cpp_codegen_runtime_class_init_inline(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_0 = ((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->____appenders;
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_1 = ___0_appender;
		Delegate_t* L_2;
		L_2 = Delegate_Remove_m8B7DD5661308FA972E23CA1CC3FC9CEB355504E3(L_0, L_1, NULL);
		((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->____appenders = ((LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*)CastclassSealed((RuntimeObject*)L_2, LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416_il2cpp_TypeInfo_var));
		Il2CppCodeGenWriteBarrier((void**)(&((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->____appenders), (void*)((LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*)CastclassSealed((RuntimeObject*)L_2, LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416_il2cpp_TypeInfo_var)));
		Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718* L_3 = ((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->___Loggers;
		NullCheck(L_3);
		ValueCollection_t45574612A30062D13F998617ED6AAAB0503DA316* L_4;
		L_4 = Dictionary_2_get_Values_m6CCF0662EAE3F3DB9D405559A89744B948FA477D(L_3, Dictionary_2_get_Values_m6CCF0662EAE3F3DB9D405559A89744B948FA477D_RuntimeMethod_var);
		NullCheck(L_4);
		Enumerator_t10E83AD353186F18522BD4B2BC4F65DA882561BF L_5;
		L_5 = ValueCollection_GetEnumerator_mC7347BF77D8FA87385F1520C079AD79E28BEA4E6(L_4, ValueCollection_GetEnumerator_mC7347BF77D8FA87385F1520C079AD79E28BEA4E6_RuntimeMethod_var);
		V_0 = L_5;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_003f:
			{
				Enumerator_Dispose_m0E3C6CF27F1D5BCBA06FBD97F760A8D1B519C9E1((&V_0), Enumerator_Dispose_m0E3C6CF27F1D5BCBA06FBD97F760A8D1B519C9E1_RuntimeMethod_var);
				return;
			}
		});
		try
		{
			{
				goto IL_0034_1;
			}

IL_0027_1:
			{
				Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* L_6;
				L_6 = Enumerator_get_Current_m724883BD65E8EF5E61DA8FEAF5DD2FF43EE081D7_inline((&V_0), Enumerator_get_Current_m724883BD65E8EF5E61DA8FEAF5DD2FF43EE081D7_RuntimeMethod_var);
				LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_7 = ___0_appender;
				NullCheck(L_6);
				Logger_remove_OnLog_mBEF3444F9E216366015A1D2DFA8C3A852B3F30F0(L_6, L_7, NULL);
			}

IL_0034_1:
			{
				bool L_8;
				L_8 = Enumerator_MoveNext_m91FE3CEAB5E3484BB006B22E763BEF655FCDDBDB((&V_0), Enumerator_MoveNext_m91FE3CEAB5E3484BB006B22E763BEF655FCDDBDB_RuntimeMethod_var);
				if (L_8)
				{
					goto IL_0027_1;
				}
			}
			{
				goto IL_004d;
			}
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_004d:
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* Logger_GetLogger_mB15CE59486B346F3AE9AFBA8B75D420C7E82D473 (Type_t* ___0_type, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Type_t* L_0 = ___0_type;
		NullCheck(L_0);
		String_t* L_1;
		L_1 = VirtualFuncInvoker0< String_t* >::Invoke(26, L_0);
		il2cpp_codegen_runtime_class_init_inline(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* L_2;
		L_2 = Logger_GetLogger_mDCCE0B3E9ECE3DC1B3B38DD59F586BC0790997C6(L_1, NULL);
		return L_2;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* Logger_GetLogger_mDCCE0B3E9ECE3DC1B3B38DD59F586BC0790997C6 (String_t* ___0_name, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_Add_m7112C58069BEE843B49C4FCCE2D18C539A874C75_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_TryGetValue_mB71314BCFE163779671CAAE3E4FC84BF222A0269_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* V_0 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718* L_0 = ((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->___Loggers;
		String_t* L_1 = ___0_name;
		NullCheck(L_0);
		bool L_2;
		L_2 = Dictionary_2_TryGetValue_mB71314BCFE163779671CAAE3E4FC84BF222A0269(L_0, L_1, (&V_0), Dictionary_2_TryGetValue_mB71314BCFE163779671CAAE3E4FC84BF222A0269_RuntimeMethod_var);
		if (L_2)
		{
			goto IL_0038;
		}
	}
	{
		String_t* L_3 = ___0_name;
		Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* L_4 = (Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD*)il2cpp_codegen_object_new(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		Logger__ctor_m82CE34DE97B95E8FAEA5DE405CB4A4395BEBA6EE(L_4, L_3, NULL);
		Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* L_5 = L_4;
		il2cpp_codegen_runtime_class_init_inline(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		int32_t L_6;
		L_6 = Logger_get_GlobalLogLevel_mD7A21149F0E68419132501FE6EA4FF6955211BFD_inline(NULL);
		NullCheck(L_5);
		L_5->___LogLevel = L_6;
		V_0 = L_5;
		Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* L_7 = V_0;
		LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* L_8 = ((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->____appenders;
		NullCheck(L_7);
		Logger_add_OnLog_mEA27658ECFE56B378935CFE75EE4A00247C465B4(L_7, L_8, NULL);
		Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718* L_9 = ((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->___Loggers;
		String_t* L_10 = ___0_name;
		Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* L_11 = V_0;
		NullCheck(L_9);
		Dictionary_2_Add_m7112C58069BEE843B49C4FCCE2D18C539A874C75(L_9, L_10, L_11, Dictionary_2_Add_m7112C58069BEE843B49C4FCCE2D18C539A874C75_RuntimeMethod_var);
	}

IL_0038:
	{
		Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* L_12 = V_0;
		return L_12;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_ClearLoggers_m52575EFD7925974B211B42C0E41EE3C8832D021F (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_Clear_mE542AC4B4EF756E531FE29479ED3D01B6D1C329F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718* L_0 = ((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->___Loggers;
		NullCheck(L_0);
		Dictionary_2_Clear_mE542AC4B4EF756E531FE29479ED3D01B6D1C329F(L_0, Dictionary_2_Clear_mE542AC4B4EF756E531FE29479ED3D01B6D1C329F_RuntimeMethod_var);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_ClearAppenders_m25E4DBBB145CD19BB8FDDFD02A3147DF377EA327 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_get_Values_m6CCF0662EAE3F3DB9D405559A89744B948FA477D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_Dispose_m0E3C6CF27F1D5BCBA06FBD97F760A8D1B519C9E1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_MoveNext_m91FE3CEAB5E3484BB006B22E763BEF655FCDDBDB_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_get_Current_m724883BD65E8EF5E61DA8FEAF5DD2FF43EE081D7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ValueCollection_GetEnumerator_mC7347BF77D8FA87385F1520C079AD79E28BEA4E6_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	Enumerator_t10E83AD353186F18522BD4B2BC4F65DA882561BF V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		il2cpp_codegen_runtime_class_init_inline(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->____appenders = (LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->____appenders), (void*)(LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*)NULL);
		Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718* L_0 = ((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->___Loggers;
		NullCheck(L_0);
		ValueCollection_t45574612A30062D13F998617ED6AAAB0503DA316* L_1;
		L_1 = Dictionary_2_get_Values_m6CCF0662EAE3F3DB9D405559A89744B948FA477D(L_0, Dictionary_2_get_Values_m6CCF0662EAE3F3DB9D405559A89744B948FA477D_RuntimeMethod_var);
		NullCheck(L_1);
		Enumerator_t10E83AD353186F18522BD4B2BC4F65DA882561BF L_2;
		L_2 = ValueCollection_GetEnumerator_mC7347BF77D8FA87385F1520C079AD79E28BEA4E6(L_1, ValueCollection_GetEnumerator_mC7347BF77D8FA87385F1520C079AD79E28BEA4E6_RuntimeMethod_var);
		V_0 = L_2;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0030:
			{
				Enumerator_Dispose_m0E3C6CF27F1D5BCBA06FBD97F760A8D1B519C9E1((&V_0), Enumerator_Dispose_m0E3C6CF27F1D5BCBA06FBD97F760A8D1B519C9E1_RuntimeMethod_var);
				return;
			}
		});
		try
		{
			{
				goto IL_0025_1;
			}

IL_0018_1:
			{
				Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* L_3;
				L_3 = Enumerator_get_Current_m724883BD65E8EF5E61DA8FEAF5DD2FF43EE081D7_inline((&V_0), Enumerator_get_Current_m724883BD65E8EF5E61DA8FEAF5DD2FF43EE081D7_RuntimeMethod_var);
				NullCheck(L_3);
				L_3->___OnLog = (LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*)NULL;
				Il2CppCodeGenWriteBarrier((void**)(&L_3->___OnLog), (void*)(LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416*)NULL);
			}

IL_0025_1:
			{
				bool L_4;
				L_4 = Enumerator_MoveNext_m91FE3CEAB5E3484BB006B22E763BEF655FCDDBDB((&V_0), Enumerator_MoveNext_m91FE3CEAB5E3484BB006B22E763BEF655FCDDBDB_RuntimeMethod_var);
				if (L_4)
				{
					goto IL_0018_1;
				}
			}
			{
				goto IL_003e;
			}
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_003e:
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger__cctor_m8499EBE5E4794FA4122E952848A46B0CABA118BE (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_mF1446AF7EAC828E096FBCED8FAA3C66BE6CC3391_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718* L_0 = (Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718*)il2cpp_codegen_object_new(Dictionary_2_t330316A484704B7AA23BD2BDCB1FCC5A6DC80718_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_mF1446AF7EAC828E096FBCED8FAA3C66BE6CC3391(L_0, Dictionary_2__ctor_mF1446AF7EAC828E096FBCED8FAA3C66BE6CC3391_RuntimeMethod_var);
		((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->___Loggers = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->___Loggers), (void*)L_0);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SherlogAssertException__ctor_m0715DCA69AF2364BE6BBACA58D1D0861ED8D4322 (SherlogAssertException_t2924294ADFD5C193F5430C249E3C61949BA8DC0E* __this, String_t* ___0_message, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_message;
		il2cpp_codegen_runtime_class_init_inline(Exception_t_il2cpp_TypeInfo_var);
		Exception__ctor_m9B2BD92CD68916245A75109105D9071C9D430E7F(__this, L_0, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LogDelegate_Invoke_mAADCB9EAB22B25DC3A047BA5A59465471E5BA010_inline (LogDelegate_tED8FD813E161D7B5BD8585F1932F419F59811416* __this, Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD* ___0_logger, int32_t ___1_logLevel, String_t* ___2_message, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD*, int32_t, String_t*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_logger, ___1_logLevel, ___2_message, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Logger_get_GlobalLogLevel_mD7A21149F0E68419132501FE6EA4FF6955211BFD_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var);
		int32_t L_0 = ((Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_StaticFields*)il2cpp_codegen_static_fields_for(Logger_tBF715A8FEFDB3874524ED9820D0FFDB21B0E9FAD_il2cpp_TypeInfo_var))->____globalLogLevel;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* Enumerator_get_Current_mB407E755F3B4C51C54D24338D00A352E5B16E7F3_gshared_inline (Enumerator_t44124D16E0B2F7308FF4069BE06369B5A83896EB* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->____currentValue;
		return L_0;
	}
}
