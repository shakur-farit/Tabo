#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>


struct VirtualActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct VirtualActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
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
template <typename T1, typename T2, typename T3>
struct VirtualActionInvoker3
{
	typedef void (*Action)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
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
template <typename R, typename T1>
struct VirtualFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
struct GenericVirtualActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct GenericVirtualActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
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
template <typename T1, typename T2, typename T3>
struct GenericVirtualActionInvoker3
{
	typedef void (*Action)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
	}
};
struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct InterfaceActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
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
template <typename T1, typename T2, typename T3>
struct InterfaceActionInvoker3
{
	typedef void (*Action)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
	}
};
template <typename R>
struct InterfaceFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R, typename T1>
struct InterfaceFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename R, typename T1, typename T2>
struct InterfaceFuncInvoker2
{
	typedef R (*Func)(void*, T1, T2, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
struct GenericInterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct GenericInterfaceActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
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
template <typename T1, typename T2, typename T3>
struct GenericInterfaceActionInvoker3
{
	typedef void (*Action)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
	}
};

struct Func_2_t6D2E58ECD14989F315928FF171DED6E65CBAB6E5;
struct Func_2_tACBF5A1656250800CE861707354491F0611F6624;
struct Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B;
struct HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885;
struct ICollection_1_t873BC7044D20F9CC7BA5AFA879A876DC31440F2A;
struct IEnumerable_1_t443B7E1CE7C51DFD2FB283D22C27572400E5BBDB;
struct IEnumerable_1_tF95C9E01A913DD50575531C8305932628663D9E9;
struct IEnumerable_1_t349E66EC5F09B881A8E52EE40A1AB9EC60E08E44;
struct IEqualityComparer_1_t2CA7720C7ADCCDECD3B02E45878B4478619D5347;
struct List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4;
struct List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3;
struct List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB;
struct List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4;
struct List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6;
struct List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73;
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D;
struct Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335;
struct Stack_1_tAD790A47551563636908E21E4F08C54C0C323EB5;
struct SlotU5BU5D_tF596AD324082C553DB364C768406A40BB3C85343;
struct Stack_1U5BU5D_tBDFDA00CAA03620C331BE5D3BB61FA8ED82F2A21;
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
struct ICleanupSystemU5BU5D_t96B14578DB90465CD8C966E1B85CC0A47A4C6F3E;
struct IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50;
struct IExecuteSystemU5BU5D_t02D314117498D01157EEC87156E182072C553CD1;
struct IInitializeSystemU5BU5D_t0B8D7DB03A30EB8DDC989B9F7C7E35C141F503EA;
struct ITearDownSystemU5BU5D_t2136606D8FCE67F24490E5107E6A7C53C1BA1258;
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
struct IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832;
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
struct StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF;
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;
struct TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB;
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C;
struct Binder_t91BFCE95A7057FADF4D8A1A342AFE52872246235;
struct CollectorException_t57D1B1EA14CFFC9C5996CBCFA04F3360C625C5BB;
struct ContextDoesNotContainEntityException_t78A395CA84D8B92D90EC31EC184FF38AD76ACDD9;
struct ContextEntityChanged_t664F55E3A651D2713CC38B64092750E8816DBF42;
struct ContextEntityIndexDoesAlreadyExistException_t9E716ABFE7F1565F5BB62657B36343AB2DC9B5E9;
struct ContextEntityIndexDoesNotExistException_t23EBA6EDC3488CC51532BB47E86847F248977036;
struct ContextGroupChanged_t40BC410925FACFB7B33FAE12A39E00B5275B580F;
struct ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD;
struct ContextInfoException_t552346465EEC6A53F2D058FDA974D3147D830782;
struct ContextStillHasRetainedEntitiesException_t5ABFA49A47FEDC2AE63CE8487800212BE92AFA33;
struct Decoder_tE16E789E38B25DD304004FC630EA8B21000ECBBC;
struct Delegate_t;
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
struct Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095;
struct EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD;
struct Entity_tB4178C475C4604A531B84ABE4E804A477025267D;
struct EntityAlreadyHasComponentException_t180376056AF6FAEE24DCEA02957A565B06F3D63D;
struct EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4;
struct EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D;
struct EntityDoesNotHaveComponentException_t2204861A7C3C0EEA828CF52D0A151A00E413020C;
struct EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0;
struct EntityIndexException_t9BABEB3E99FFE1156DCFEC91285714BD7C96FED8;
struct EntityIsAlreadyRetainedByOwnerException_tB58BD16D6DB0C073D792DFE04F76CEBAE2EE58FE;
struct EntityIsNotDestroyedException_t91EDFD71B22E7B3D73184DEAB30CE79A2CAC79A8;
struct EntityIsNotEnabledException_tC48798BE7CA57C50EF69705FC8BF2F440DD7957C;
struct EntityIsNotRetainedByOwnerException_t5C9A88040F783ECA528614B562071C871DF738DE;
struct Exception_t;
struct IAERC_t69CBD4DE45FBA9F66D967261934D07F291315957;
struct IAsyncResult_t7B9B5A0ECB35DCEC31B8A8122C37D687369253B5;
struct ICleanupSystem_tF99E4939D5332AA0B91FEB2F59FB859B1215F0CE;
struct IComponent_tDC3779C7595B53CAC684EFC24FCC4D2189E89601;
struct IContext_t0801D5F43915BAD7010CF74F4DC08ADEDBCFC8DF;
struct IDictionary_t6D03155AF1FA9083817AA5B6AD7DEEACC26AB220;
struct IEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F;
struct IExecuteSystem_t4E30FED777E2D68FE364CF650299C3CFC2EE2B75;
struct IGroup_tE01B838EB4FAEA9FAA983A6366D662AD49873849;
struct IInitializeSystem_t35D02C33CCCC76426F530F7A98156337997FAA21;
struct IReactiveSystem_t097169972AA4253A075D1360A0EBED4AAC6E7F96;
struct ISystem_tB7045233E555B3CD1E25C6CF8BB9B9869F31C287;
struct ITearDownSystem_t7690882D96402E660A661CF00AEEB2FD33CBBFB8;
struct MatcherException_t98972F509249B23D4B5F525E68570C7AE8089BA4;
struct MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553;
struct MethodInfo_t;
struct SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2;
struct SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6;
struct SemaphoreSlim_t0D5CB5685D9BFA5BF95CEC6E7395490F933E8DB2;
struct SerializationInfo_t3C47F63E24BEB9FCE2DC6309E027F238DC5C5E37;
struct SingleEntityException_t183BAB11477B2A57E37055080769CEA53FA77858;
struct Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE;
struct StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B;
struct String_t;
struct StringBuilder_t;
struct Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E;
struct Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572;
struct Type_t;
struct UnsafeAERC_tAE5B355208C71BFF1D4400DCE8C30652EFF2696F;
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
struct U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85;
struct ReadWriteTask_t0821BF49EE38596C7734E86E1A6A39D769BE2C05;

IL2CPP_EXTERN_C RuntimeClass* ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* EntityAlreadyHasComponentException_t180376056AF6FAEE24DCEA02957A565B06F3D63D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* EntityDoesNotHaveComponentException_t2204861A7C3C0EEA828CF52D0A151A00E413020C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* EntityIsAlreadyRetainedByOwnerException_tB58BD16D6DB0C073D792DFE04F76CEBAE2EE58FE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* EntityIsNotEnabledException_tC48798BE7CA57C50EF69705FC8BF2F440DD7957C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* EntityIsNotRetainedByOwnerException_t5C9A88040F783ECA528614B562071C871DF738DE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Func_2_t6D2E58ECD14989F315928FF171DED6E65CBAB6E5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IAERC_t69CBD4DE45FBA9F66D967261934D07F291315957_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ICleanupSystem_tF99E4939D5332AA0B91FEB2F59FB859B1215F0CE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ICollection_1_t873BC7044D20F9CC7BA5AFA879A876DC31440F2A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IComponent_tDC3779C7595B53CAC684EFC24FCC4D2189E89601_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IContext_t0801D5F43915BAD7010CF74F4DC08ADEDBCFC8DF_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IExecuteSystem_t4E30FED777E2D68FE364CF650299C3CFC2EE2B75_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IInitializeSystem_t35D02C33CCCC76426F530F7A98156337997FAA21_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IReactiveSystem_t097169972AA4253A075D1360A0EBED4AAC6E7F96_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ITearDownSystem_t7690882D96402E660A661CF00AEEB2FD33CBBFB8_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SingleEntityException_t183BAB11477B2A57E37055080769CEA53FA77858_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringBuilder_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Type_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral00B28FF06B788B9B67C6B259800F404F9F3761FD;
IL2CPP_EXTERN_C String_t* _stringLiteral0335C65EEF6379144CEBFCCFBA3673189514186C;
IL2CPP_EXTERN_C String_t* _stringLiteral07CB67C10A967C89D59286FBEA68B6BEED636C60;
IL2CPP_EXTERN_C String_t* _stringLiteral0849E26A6A4A2DAE7ACBD20B9787BC3CB5CF6F4D;
IL2CPP_EXTERN_C String_t* _stringLiteral2473CC51372648FEA0BFF865384FA2BE6D9757BA;
IL2CPP_EXTERN_C String_t* _stringLiteral282A064B307B2F72FC822DDE19359CFEA54529D2;
IL2CPP_EXTERN_C String_t* _stringLiteral28FDB1B7B90FD3CAA3338AFD1A1D7E4231A513CE;
IL2CPP_EXTERN_C String_t* _stringLiteral30BCA17AD2287D35B6E19DEE4768DBE6A7677318;
IL2CPP_EXTERN_C String_t* _stringLiteral30D6B7F89E28AF655DC86036AC3C892360265A99;
IL2CPP_EXTERN_C String_t* _stringLiteral3125B63029085F66AA6486C20739994CD2F327DA;
IL2CPP_EXTERN_C String_t* _stringLiteral35D9703651C0B5FE577BAA089212BEF91D370ADB;
IL2CPP_EXTERN_C String_t* _stringLiteral43F28CD211DC51B56AA10E5BACE57607ECA413FA;
IL2CPP_EXTERN_C String_t* _stringLiteral46271EED90F0BDB046A97E6BB3D268FA9DA9E2B9;
IL2CPP_EXTERN_C String_t* _stringLiteral4899007D1B5035A1FDE7D96666CC174630C601BB;
IL2CPP_EXTERN_C String_t* _stringLiteral552BA9BD8DC606651C356E825380CB6A7B858A73;
IL2CPP_EXTERN_C String_t* _stringLiteral57A73DDAE80B092D40521059D162EF5AF60EA12F;
IL2CPP_EXTERN_C String_t* _stringLiteral5D35E6992FED4911709FE05C4D0D58AA494F59F9;
IL2CPP_EXTERN_C String_t* _stringLiteral5DB5DACAACEF2F6E16BFEA20819AB3E510AE97FE;
IL2CPP_EXTERN_C String_t* _stringLiteral5DFC00054C72CA06D0162955D17D64895EB1837C;
IL2CPP_EXTERN_C String_t* _stringLiteral5FF374709F3F171D980E4E8BEA80A7954877FE64;
IL2CPP_EXTERN_C String_t* _stringLiteral6103095F8626AAF90D00D05CCC2158E55AE5154C;
IL2CPP_EXTERN_C String_t* _stringLiteral7479CB2153D35E226E315DCE47F0D5024C373F2D;
IL2CPP_EXTERN_C String_t* _stringLiteral758733BDBED83CBFF4F635AC26CA92AAE477F75D;
IL2CPP_EXTERN_C String_t* _stringLiteral9A5253BF31B79E22DF1C48DB0D96B50B43A9E0A5;
IL2CPP_EXTERN_C String_t* _stringLiteral9CF1F76013B09A2ABD7A5D6D8AE2A9E11813E8C7;
IL2CPP_EXTERN_C String_t* _stringLiteralA0EE3D9CB3B08C45C63674FB94E4423D499457FC;
IL2CPP_EXTERN_C String_t* _stringLiteralA3DFC0C77ACADE0EE48DCC73E795A597D0270A73;
IL2CPP_EXTERN_C String_t* _stringLiteralB3F14BF976EFD974E34846B742502C802FABAE9D;
IL2CPP_EXTERN_C String_t* _stringLiteralB79F3D98860D557F6828ED8EE2B870DFE0DB88A5;
IL2CPP_EXTERN_C String_t* _stringLiteralB8A2098365A498F63ACC657AEFADE2F393D1251B;
IL2CPP_EXTERN_C String_t* _stringLiteralC0CC69D3E2CD8043D76150E07F46527F1A0F1773;
IL2CPP_EXTERN_C String_t* _stringLiteralC6465D3AD9309DC52459E14C31B60E28CD5BC45C;
IL2CPP_EXTERN_C String_t* _stringLiteralC87C3306A14EB48EDEB0E161294EA58A949D1584;
IL2CPP_EXTERN_C String_t* _stringLiteralD93758B5185819AEFE21A48FB425EC792CD52046;
IL2CPP_EXTERN_C String_t* _stringLiteralDEF84EBA6C9A8E7BB2723A279F7980993BF92544;
IL2CPP_EXTERN_C String_t* _stringLiteralE006008788ACD78A3DA9418A85208D7602DC81D0;
IL2CPP_EXTERN_C String_t* _stringLiteralE080F46B020E5B0229541CB5E558D863B4C83BA8;
IL2CPP_EXTERN_C String_t* _stringLiteralE52DEC78EB9E6776057DF91F0724F3CEFA2A90A0;
IL2CPP_EXTERN_C String_t* _stringLiteralEABEAB522AED307CC857B033B01F36B4FBC38414;
IL2CPP_EXTERN_C String_t* _stringLiteralEC48BC6AECF8DAF6AF054E221860A4D7DE26515B;
IL2CPP_EXTERN_C String_t* _stringLiteralF2DB551E14481A942CC7D789D7D1AAAD3B2EE6EA;
IL2CPP_EXTERN_C String_t* _stringLiteralF5A4E134A104F68811845EBEE5EAFB427080DCA2;
IL2CPP_EXTERN_C String_t* _stringLiteralF7014D5B895CFF0AD6A94980DA31BD4DB5B19472;
IL2CPP_EXTERN_C const RuntimeMethod* CollectionExtension_SingleEntity_mFE455291EBCC96A8E7A04A189CB561182FD5EB3F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Entity_AddComponent_m8EB577742A15B2499E87728B721CCC2659F60EC8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Entity_Destroy_mD3F6059226F9C43E48A2B8C8A8FB29E331AF6B1D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Entity_GetComponent_m48E5240DCCBD9062C45E22A12BC09565807E7191_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Entity_RemoveComponent_mFC479EABD6ED87F235F6B3F75AE2DFCF79846413_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Entity_ReplaceComponent_m753F0DB897BD7A12953E9AE8302662965AFEBC0D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerable_First_TisIEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_m17BD4F6C644B3FAA39249ADCB412B1BB54243FC7_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerable_Select_TisIEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_TisString_t_mA368DA5BA6807B07594C8842DDBF8560BBF7AFEC_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerable_Select_TisRuntimeObject_TisString_t_m4212A6B9DDC97D402346EC78AE3115A600469C8C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1_Add_m2CD7657B3459B61DD4BBA47024AC71F7D319658B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1_Remove_mF1D84C0A2829DDA2A0CEE1D82A5B999B5F6627CB_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1__ctor_m9132EE1422BAA45E44B7FFF495F378790D36D90E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1_get_Count_m41CC85EEB7855CEFA3BC7A32F115387939318ED3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m3470969576B79057EE94FCA211CB46D0AA243DF9_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m54A91912B2411D0D35AC46B000D66485CC8798BA_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m926AD2B85E6E1FBC5F98037D94B427F7E4D9B5A2_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m955BFC0F3B491F15CD74C678A961B4900A9874DA_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_mBD3B17EDD7711457A94E0B737F51E4A3035D8810_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Clear_mC293DD9E1F021871B58449F0A2B1BEC545F82C3F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Remove_m182DFED6A1B299DD2A354BA960398B9652725F25_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Remove_m32C3786ECC7F4F1AA1EA443227F00743B7650B6B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Remove_m9DB7970F74E8C72B6D41E372BA7CB82D2B3EA7C8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Remove_mFD32512352FDB857E97A6E36C8A0C1FEE19E6714_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_ToArray_m65479FB75A5FE539EA1A0D6681172717D23CEAAA_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_ToArray_m9F5C9D47065498DFB59420502E4A0349EAFD1EC5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m2F2A619D23D0C508C3AB62A578A007B27C312C73_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m63F0297745C6B4C4B204AD379F764E2E82C555A8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m69A54ED11B9857404699079358C757A11363E887_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m857E572D5CC61334AB231EFA59092D30857DCFD3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m98C7F81FA64837DD6E162E5C70A13BDEF7C18C0F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Count_m34A818667B41D76E9D3322A642D03BB33900380B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Count_m7639C2A449943F673350F560F544B8B9FAB8A37D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Count_mBCC89E3A732616D2D45184D8A5D7780C41025B2E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Count_mC8EC69FAFB2FE4AB7E1CBC7465512DDA4A5C4B6D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Item_m008F12FFE7C434066EB70D102092AC7A3406DFE5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Item_m136BBBD4A6AAF2E1775292CAD7C27A34F3738BA3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Item_mAC23816FC8101220D796791157C5C1E7B74FE2F3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Item_mEF669AC0B44B77803D582B526D2C08269A722F4B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* SafeAERC_Release_m68ECDB31C850E8A2DB6BB6A097AD2EC02333D4B5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* SafeAERC_Retain_mBE0924B7AC1821EA3C6F266EFFFE02CE4B5583D6_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Stack_1_Pop_m6501363A3DCBFB09583A65306FFEA89DFC4108E9_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Stack_1_Push_m1A3A5ABAF9EBA6B669577B6E9F1CEBE57289870B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Stack_1__ctor_m34EB03F352ED5B57BD4AD4C41C87A0F2ADC47B79_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Stack_1_get_Count_m06BE4BC0BD3700E0E08866F4E1D53F2A91F1FA91_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec_U3CEntitiesToStringU3Eb__1_0_m22BB117CFB28336F4D2526F0C4A46A6014A664C8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec_U3CEntitiesToStringU3Eb__1_1_m82511CA63C9C9B4464F0D61E8DD07B7D584B3E2A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeType* Entity_tB4178C475C4604A531B84ABE4E804A477025267D_0_0_0_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct Stack_1U5BU5D_tBDFDA00CAA03620C331BE5D3BB61FA8ED82F2A21;
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
struct IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50;
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;
struct TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
struct U3CModuleU3E_t369F3024442649010B630BA9BBA2ED89BFBF3075 
{
};
struct HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885  : public RuntimeObject
{
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____buckets;
	SlotU5BU5D_tF596AD324082C553DB364C768406A40BB3C85343* ____slots;
	int32_t ____count;
	int32_t ____lastIndex;
	int32_t ____freeList;
	RuntimeObject* ____comparer;
	int32_t ____version;
	SerializationInfo_t3C47F63E24BEB9FCE2DC6309E027F238DC5C5E37* ____siInfo;
};
struct List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4  : public RuntimeObject
{
	ICleanupSystemU5BU5D_t96B14578DB90465CD8C966E1B85CC0A47A4C6F3E* ____items;
	int32_t ____size;
	int32_t ____version;
	RuntimeObject* ____syncRoot;
};
struct List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3  : public RuntimeObject
{
	IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* ____items;
	int32_t ____size;
	int32_t ____version;
	RuntimeObject* ____syncRoot;
};
struct List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB  : public RuntimeObject
{
	IExecuteSystemU5BU5D_t02D314117498D01157EEC87156E182072C553CD1* ____items;
	int32_t ____size;
	int32_t ____version;
	RuntimeObject* ____syncRoot;
};
struct List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4  : public RuntimeObject
{
	IInitializeSystemU5BU5D_t0B8D7DB03A30EB8DDC989B9F7C7E35C141F503EA* ____items;
	int32_t ____size;
	int32_t ____version;
	RuntimeObject* ____syncRoot;
};
struct List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6  : public RuntimeObject
{
	ITearDownSystemU5BU5D_t2136606D8FCE67F24490E5107E6A7C53C1BA1258* ____items;
	int32_t ____size;
	int32_t ____version;
	RuntimeObject* ____syncRoot;
};
struct List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73  : public RuntimeObject
{
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____items;
	int32_t ____size;
	int32_t ____version;
	RuntimeObject* ____syncRoot;
};
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D  : public RuntimeObject
{
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ____items;
	int32_t ____size;
	int32_t ____version;
	RuntimeObject* ____syncRoot;
};
struct Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335  : public RuntimeObject
{
	IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* ____array;
	int32_t ____size;
	int32_t ____version;
	RuntimeObject* ____syncRoot;
};
struct Stack_1_tAD790A47551563636908E21E4F08C54C0C323EB5  : public RuntimeObject
{
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ____array;
	int32_t ____size;
	int32_t ____version;
	RuntimeObject* ____syncRoot;
};
struct Assembly_t  : public RuntimeObject
{
};
struct Assembly_t_marshaled_pinvoke
{
};
struct Assembly_t_marshaled_com
{
};
struct CollectionExtension_tA83658BFAB89A525D420BF37039848A63AE7CA0A  : public RuntimeObject
{
};
struct CollectorContextExtension_tB63DA09F92DB63CA375BAD41BC811E8F657B6A90  : public RuntimeObject
{
};
struct ContextExtension_tBC290721F5B841C148B67A51ED7BF12FECD79EC3  : public RuntimeObject
{
};
struct ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD  : public RuntimeObject
{
	String_t* ___name;
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___componentNames;
	TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB* ___componentTypes;
};
struct EntitasResources_tF6215C9FBA732C77A507E02CB6B8FA512233AA3E  : public RuntimeObject
{
};
struct EntitasStringExtension_t68348C522D9EFCFD4EC0FBA792CBAA6B8DE7778C  : public RuntimeObject
{
};
struct Entity_tB4178C475C4604A531B84ABE4E804A477025267D  : public RuntimeObject
{
	EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* ___OnComponentAdded;
	EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* ___OnComponentRemoved;
	EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* ___OnComponentReplaced;
	EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* ___OnEntityReleased;
	EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* ___OnDestroyEntity;
	List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3* ____componentBuffer;
	List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* ____indexBuffer;
	int32_t ____creationIndex;
	bool ____isEnabled;
	int32_t ____totalComponents;
	IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* ____components;
	Stack_1U5BU5D_tBDFDA00CAA03620C331BE5D3BB61FA8ED82F2A21* ____componentPools;
	ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* ____contextInfo;
	RuntimeObject* ____aerc;
	IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* ____componentsCache;
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____componentIndicesCache;
	String_t* ____toStringCache;
	StringBuilder_t* ____toStringBuilder;
};
struct GroupExtension_t16C4CD26CCB852665ABCB957DF5978F4992D610C  : public RuntimeObject
{
};
struct MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE  : public RuntimeObject
{
	RuntimeObject* ____identity;
};
struct MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE_marshaled_pinvoke
{
	Il2CppIUnknown* ____identity;
};
struct MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE_marshaled_com
{
	Il2CppIUnknown* ____identity;
};
struct MemberInfo_t  : public RuntimeObject
{
};
struct PublicMemberInfoEntityExtension_tF25D68C5976FD4659F3547D44CD6CCD2879F5402  : public RuntimeObject
{
};
struct SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2  : public RuntimeObject
{
	RuntimeObject* ____entity;
	HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* ____owners;
};
struct String_t  : public RuntimeObject
{
	int32_t ____stringLength;
	Il2CppChar ____firstChar;
};
struct StringBuilder_t  : public RuntimeObject
{
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___m_ChunkChars;
	StringBuilder_t* ___m_ChunkPrevious;
	int32_t ___m_ChunkLength;
	int32_t ___m_ChunkOffset;
	int32_t ___m_MaxCapacity;
};
struct Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E  : public RuntimeObject
{
	List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4* ____initializeSystems;
	List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB* ____executeSystems;
	List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4* ____cleanupSystems;
	List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6* ____tearDownSystems;
};
struct TriggerOnEventMatcherExtension_t28493743AB5F21E1A4CD97FCD69A929A81D9CC19  : public RuntimeObject
{
};
struct UnsafeAERC_tAE5B355208C71BFF1D4400DCE8C30652EFF2696F  : public RuntimeObject
{
	int32_t ____retainCount;
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
struct U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85  : public RuntimeObject
{
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
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	int32_t ___m_value;
};
struct IntPtr_t 
{
	void* ___m_value;
};
struct Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE  : public MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE
{
	ReadWriteTask_t0821BF49EE38596C7734E86E1A6A39D769BE2C05* ____activeReadWriteTask;
	SemaphoreSlim_t0D5CB5685D9BFA5BF95CEC6E7395490F933E8DB2* ____asyncActiveSemaphore;
};
struct TextReader_tB8D43017CB6BE1633E5A86D64E7757366507C1F7  : public MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE
{
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
struct GroupEvent_t7304B1E95FE260403F39C702DB9827D98AD6911D 
{
	uint8_t ___value__;
};
struct RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B 
{
	intptr_t ___value;
};
struct StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B  : public TextReader_tB8D43017CB6BE1633E5A86D64E7757366507C1F7
{
	Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ____stream;
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ____encoding;
	Decoder_tE16E789E38B25DD304004FC630EA8B21000ECBBC* ____decoder;
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ____byteBuffer;
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ____charBuffer;
	int32_t ____charPos;
	int32_t ____charLen;
	int32_t ____byteLen;
	int32_t ____bytePos;
	int32_t ____maxCharsPerBuffer;
	bool ____detectEncoding;
	bool ____checkPreamble;
	bool ____isBlocked;
	bool ____closable;
	Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* ____asyncReadTask;
};
struct StringComparison_tE14A55CCFA001A5AC85D754179BF2888F45CC94D 
{
	int32_t ___value__;
};
struct EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD  : public Exception_t
{
};
struct MatcherException_t98972F509249B23D4B5F525E68570C7AE8089BA4  : public Exception_t
{
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
struct Type_t  : public MemberInfo_t
{
	RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B ____impl;
};
struct Func_2_t6D2E58ECD14989F315928FF171DED6E65CBAB6E5  : public MulticastDelegate_t
{
};
struct Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B  : public MulticastDelegate_t
{
};
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C  : public MulticastDelegate_t
{
};
struct CollectorException_t57D1B1EA14CFFC9C5996CBCFA04F3360C625C5BB  : public EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD
{
};
struct ContextDoesNotContainEntityException_t78A395CA84D8B92D90EC31EC184FF38AD76ACDD9  : public EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD
{
};
struct ContextEntityChanged_t664F55E3A651D2713CC38B64092750E8816DBF42  : public MulticastDelegate_t
{
};
struct ContextEntityIndexDoesAlreadyExistException_t9E716ABFE7F1565F5BB62657B36343AB2DC9B5E9  : public EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD
{
};
struct ContextEntityIndexDoesNotExistException_t23EBA6EDC3488CC51532BB47E86847F248977036  : public EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD
{
};
struct ContextGroupChanged_t40BC410925FACFB7B33FAE12A39E00B5275B580F  : public MulticastDelegate_t
{
};
struct ContextInfoException_t552346465EEC6A53F2D058FDA974D3147D830782  : public EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD
{
};
struct ContextStillHasRetainedEntitiesException_t5ABFA49A47FEDC2AE63CE8487800212BE92AFA33  : public EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD
{
};
struct EntityAlreadyHasComponentException_t180376056AF6FAEE24DCEA02957A565B06F3D63D  : public EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD
{
};
struct EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4  : public MulticastDelegate_t
{
};
struct EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D  : public MulticastDelegate_t
{
};
struct EntityDoesNotHaveComponentException_t2204861A7C3C0EEA828CF52D0A151A00E413020C  : public EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD
{
};
struct EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0  : public MulticastDelegate_t
{
};
struct EntityIndexException_t9BABEB3E99FFE1156DCFEC91285714BD7C96FED8  : public EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD
{
};
struct EntityIsAlreadyRetainedByOwnerException_tB58BD16D6DB0C073D792DFE04F76CEBAE2EE58FE  : public EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD
{
};
struct EntityIsNotDestroyedException_t91EDFD71B22E7B3D73184DEAB30CE79A2CAC79A8  : public EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD
{
};
struct EntityIsNotEnabledException_tC48798BE7CA57C50EF69705FC8BF2F440DD7957C  : public EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD
{
};
struct EntityIsNotRetainedByOwnerException_t5C9A88040F783ECA528614B562071C871DF738DE  : public EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD
{
};
struct SingleEntityException_t183BAB11477B2A57E37055080769CEA53FA77858  : public EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD
{
};
struct List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4_StaticFields
{
	ICleanupSystemU5BU5D_t96B14578DB90465CD8C966E1B85CC0A47A4C6F3E* ___s_emptyArray;
};
struct List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3_StaticFields
{
	IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* ___s_emptyArray;
};
struct List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB_StaticFields
{
	IExecuteSystemU5BU5D_t02D314117498D01157EEC87156E182072C553CD1* ___s_emptyArray;
};
struct List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4_StaticFields
{
	IInitializeSystemU5BU5D_t0B8D7DB03A30EB8DDC989B9F7C7E35C141F503EA* ___s_emptyArray;
};
struct List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6_StaticFields
{
	ITearDownSystemU5BU5D_t2136606D8FCE67F24490E5107E6A7C53C1BA1258* ___s_emptyArray;
};
struct List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_StaticFields
{
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___s_emptyArray;
};
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_StaticFields
{
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___s_emptyArray;
};
struct String_t_StaticFields
{
	String_t* ___Empty;
};
struct U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_StaticFields
{
	U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85* ___U3CU3E9;
	Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B* ___U3CU3E9__1_1;
	Func_2_t6D2E58ECD14989F315928FF171DED6E65CBAB6E5* ___U3CU3E9__1_0;
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
struct Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE_StaticFields
{
	Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___Null;
};
struct TextReader_tB8D43017CB6BE1633E5A86D64E7757366507C1F7_StaticFields
{
	TextReader_tB8D43017CB6BE1633E5A86D64E7757366507C1F7* ___Null;
};
struct Exception_t_StaticFields
{
	RuntimeObject* ___s_EDILock;
};
struct StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B_StaticFields
{
	StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B* ___Null;
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
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248  : public RuntimeArray
{
	ALIGN_FIELD (8) String_t* m_Items[1];

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
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
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
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
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
struct TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB  : public RuntimeArray
{
	ALIGN_FIELD (8) Type_t* m_Items[1];

	inline Type_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Type_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Type_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Type_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Type_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Type_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
struct Stack_1U5BU5D_tBDFDA00CAA03620C331BE5D3BB61FA8ED82F2A21  : public RuntimeArray
{
	ALIGN_FIELD (8) Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* m_Items[1];

	inline Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
struct IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50  : public RuntimeArray
{
	ALIGN_FIELD (8) RuntimeObject* m_Items[1];

	inline RuntimeObject* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline RuntimeObject* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C  : public RuntimeArray
{
	ALIGN_FIELD (8) int32_t m_Items[1];

	inline int32_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline int32_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, int32_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline int32_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline int32_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, int32_t value)
	{
		m_Items[index] = value;
	}
};
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918  : public RuntimeArray
{
	ALIGN_FIELD (8) RuntimeObject* m_Items[1];

	inline RuntimeObject* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline RuntimeObject* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Func_2__ctor_m7F8A01C0B02BC1D4063F4EB1E817F7A48562A398_gshared (Func_2_tACBF5A1656250800CE861707354491F0611F6624* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Enumerable_Select_TisRuntimeObject_TisRuntimeObject_m67C538A5EBF57C4844107A8EF25DB2CAAFBAF8FB_gshared (RuntimeObject* ___0_source, Func_2_tACBF5A1656250800CE861707354491F0611F6624* ___1_selector, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_gshared (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Stack_1_Push_m709DD11BC1291A905814182CF9A367DE7399A778_gshared (Stack_1_tAD790A47551563636908E21E4F08C54C0C323EB5* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* List_1_ToArray_mD7E4F8E7C11C3C67CB5739FCC0A6E86106A6291F_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Clear_m16C1F2C61FED5955F10EB36BC1CB2DF34B128994_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_gshared_inline (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___0_item, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* List_1_ToArray_m65479FB75A5FE539EA1A0D6681172717D23CEAAA_gshared (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_gshared_inline (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Stack_1__ctor_m70E8EDA96A608CE9BAB7FC8313B233AADA573BD4_gshared (Stack_1_tAD790A47551563636908E21E4F08C54C0C323EB5* __this, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Stack_1_get_Count_mD08AE71D49787D30DDD9D484BCD323D646744D2E_gshared_inline (Stack_1_tAD790A47551563636908E21E4F08C54C0C323EB5* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Stack_1_Pop_m2AFF69249659372F07EE25817DBCAFE74E1CF778_gshared (Stack_1_tAD790A47551563636908E21E4F08C54C0C323EB5* __this, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t HashSet_1_get_Count_m41CC85EEB7855CEFA3BC7A32F115387939318ED3_gshared_inline (HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void HashSet_1__ctor_m9132EE1422BAA45E44B7FFF495F378790D36D90E_gshared (HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool HashSet_1_Add_m2CD7657B3459B61DD4BBA47024AC71F7D319658B_gshared (HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool HashSet_1_Remove_mF1D84C0A2829DDA2A0CEE1D82A5B999B5F6627CB_gshared (HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Enumerable_First_TisRuntimeObject_mEFECF1B8C3201589C5AF34176DCBF8DD926642D6_gshared (RuntimeObject* ___0_source, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool List_1_Remove_m4DFA48F4CEB9169601E75FC28517C5C06EFA5AD7_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, int32_t ___0_index, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_NO_INLINE IL2CPP_METHOD_ATTR void List_1_AddWithResize_m79A9BF770BEF9C06BE40D5401E55E375F2726CC4_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_NO_INLINE IL2CPP_METHOD_ATTR void List_1_AddWithResize_m378B392086AAB6F400944FA9839516326B3F7BB8_gshared (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___0_item, const RuntimeMethod* method) ;

IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntitasException__ctor_mE2E152AD2BDD2D60BA7D31980081F7FC5EC73E7E (EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD* __this, String_t* ___0_message, String_t* ___1_hint, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m9E3155FB84015C823606188F53B47CB44C444991 (String_t* ___0_str0, String_t* ___1_str1, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987 (String_t* ___0_format, RuntimeObject* ___1_arg0, RuntimeObject* ___2_arg1, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_mA0534D6E2AE4D67A6BD8D45B3321323930EB930C (String_t* ___0_format, RuntimeObject* ___1_arg0, RuntimeObject* ___2_arg1, RuntimeObject* ___3_arg2, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Join_m557B6B554B87C1742FA0B128500073B421ED0BFD (String_t* ___0_separator, StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___1_value, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_mA8DBB4C2516B9723C5A41E6CB1E2FAF4BBE96DD8 (String_t* ___0_format, RuntimeObject* ___1_arg0, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ContextStillHasRetainedEntitiesException_EntitiesToString_mF6CA67B30BEF775451343861B6B440066575B759 (RuntimeObject* ___0_entities, const RuntimeMethod* method) ;
inline void Func_2__ctor_mC6091E8E8B6D64F03D0E0053E726ED562F51F2CC (Func_2_t6D2E58ECD14989F315928FF171DED6E65CBAB6E5* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method)
{
	((  void (*) (Func_2_t6D2E58ECD14989F315928FF171DED6E65CBAB6E5*, RuntimeObject*, intptr_t, const RuntimeMethod*))Func_2__ctor_m7F8A01C0B02BC1D4063F4EB1E817F7A48562A398_gshared)(__this, ___0_object, ___1_method, method);
}
inline RuntimeObject* Enumerable_Select_TisIEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_TisString_t_mA368DA5BA6807B07594C8842DDBF8560BBF7AFEC (RuntimeObject* ___0_source, Func_2_t6D2E58ECD14989F315928FF171DED6E65CBAB6E5* ___1_selector, const RuntimeMethod* method)
{
	return ((  RuntimeObject* (*) (RuntimeObject*, Func_2_t6D2E58ECD14989F315928FF171DED6E65CBAB6E5*, const RuntimeMethod*))Enumerable_Select_TisRuntimeObject_TisRuntimeObject_m67C538A5EBF57C4844107A8EF25DB2CAAFBAF8FB_gshared)(___0_source, ___1_selector, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Join_m8159F953B3D62AA54A0853A6E9573CDC0F63E158 (String_t* ___0_separator, RuntimeObject* ___1_values, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_m1F2AC3C6282B5951095AB3E31532337B2D7FFB71 (U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* SafeAERC_get_owners_m1AB169D663164AA81CD105D5507E4F10EF283252_inline (SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2* __this, const RuntimeMethod* method) ;
inline void Func_2__ctor_mD6767DE619116219CD1567BC735C4AC96B9348CF (Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method)
{
	((  void (*) (Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B*, RuntimeObject*, intptr_t, const RuntimeMethod*))Func_2__ctor_m7F8A01C0B02BC1D4063F4EB1E817F7A48562A398_gshared)(__this, ___0_object, ___1_method, method);
}
inline RuntimeObject* Enumerable_Select_TisRuntimeObject_TisString_t_m4212A6B9DDC97D402346EC78AE3115A600469C8C (RuntimeObject* ___0_source, Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B* ___1_selector, const RuntimeMethod* method)
{
	return ((  RuntimeObject* (*) (RuntimeObject*, Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B*, const RuntimeMethod*))Enumerable_Select_TisRuntimeObject_TisRuntimeObject_m67C538A5EBF57C4844107A8EF25DB2CAAFBAF8FB_gshared)(___0_source, ___1_selector, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m8855A6DE10F84DA7F4EC113CADDB59873A25573B (String_t* ___0_str0, String_t* ___1_str1, String_t* ___2_str2, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Exception__ctor_m9B2BD92CD68916245A75109105D9071C9D430E7F (Exception_t* __this, String_t* ___0_message, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t* Type_GetTypeFromHandle_m6062B81682F79A4D6DF2640692EE6D9987858C57 (RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B ___0_handle, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StreamReader__ctor_mAFA827D6D825FEC2C29C73B65C2DD1AB9076DEC7 (StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B* __this, Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___0_stream, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Delegate_t* Delegate_Combine_m1F725AEF318BE6F0426863490691A6F4606E7D00 (Delegate_t* ___0_a, Delegate_t* ___1_b, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Delegate_t* Delegate_Remove_m8B7DD5661308FA972E23CA1CC3FC9CEB355504E3 (Delegate_t* ___0_source, Delegate_t* ___1_value, const RuntimeMethod* method) ;
inline void List_1__ctor_m63F0297745C6B4C4B204AD379F764E2E82C555A8 (List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3*, const RuntimeMethod*))List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared)(__this, method);
}
inline void List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8 (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, const RuntimeMethod*))List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_gshared)(__this, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_Reactivate_m2303F059BF0993EBC6BFEB400DA2E78BA25912CC (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, int32_t ___0_creationIndex, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* Entity_createDefaultContextInfo_m0F5FB3A4229BED3A4F9C249997E0D8D3D55CBA3D (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SafeAERC__ctor_mC581C185C97CE4CF301AE39B0D2E26B5142FDEB4 (SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2* __this, RuntimeObject* ___0_entity, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Entity_get_totalComponents_mCD78FA06E98D931D5E6AAA689358E3327A430A5E_inline (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Int32_ToString_m030E01C24E294D6762FB0B6F37CB541581F55CA5 (int32_t* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ContextInfo__ctor_mA5B146303B6AB8161E318A1F5866CE5D8804BEF0 (ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* __this, String_t* ___0_name, StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___1_componentNames, TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB* ___2_componentTypes, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityIsNotEnabledException__ctor_m252F304FAE1EFD9D9674291D35E2D650648FDE08 (EntityIsNotEnabledException_tC48798BE7CA57C50EF69705FC8BF2F440DD7957C* __this, String_t* ___0_message, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Entity_HasComponent_m97FC1729493A4274D38700A5C7CEB9A063BCDF48 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, int32_t ___0_index, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityAlreadyHasComponentException__ctor_mBA4E32B23CDDF8515EB6BC6A2CA509FB95C5B790 (EntityAlreadyHasComponentException_t180376056AF6FAEE24DCEA02957A565B06F3D63D* __this, int32_t ___0_index, String_t* ___1_message, String_t* ___2_hint, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14_inline (EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_component, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityDoesNotHaveComponentException__ctor_m79427698C1E92941BFFF19395ED18922D56941BB (EntityDoesNotHaveComponentException_t2204861A7C3C0EEA828CF52D0A151A00E413020C* __this, int32_t ___0_index, String_t* ___1_message, String_t* ___2_hint, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_replaceComponent_mC1F12DBE9487C2A98C5CB386DF4BF482C594BB89 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, int32_t ___0_index, RuntimeObject* ___1_replacement, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_AddComponent_m8EB577742A15B2499E87728B721CCC2659F60EC8 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, int32_t ___0_index, RuntimeObject* ___1_component, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70_inline (EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_previousComponent, RuntimeObject* ___3_newComponent, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* Entity_GetComponentPool_m7A27D771E1F05FD55B754771D6C118F4E4CC75BA (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, int32_t ___0_index, const RuntimeMethod* method) ;
inline void Stack_1_Push_m1A3A5ABAF9EBA6B669577B6E9F1CEBE57289870B (Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* __this, RuntimeObject* ___0_item, const RuntimeMethod* method)
{
	((  void (*) (Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335*, RuntimeObject*, const RuntimeMethod*))Stack_1_Push_m709DD11BC1291A905814182CF9A367DE7399A778_gshared)(__this, ___0_item, method);
}
inline void List_1_Add_m926AD2B85E6E1FBC5F98037D94B427F7E4D9B5A2_inline (List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3* __this, RuntimeObject* ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3*, RuntimeObject*, const RuntimeMethod*))List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline)(__this, ___0_item, method);
}
inline IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* List_1_ToArray_m9F5C9D47065498DFB59420502E4A0349EAFD1EC5 (List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3* __this, const RuntimeMethod* method)
{
	return ((  IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* (*) (List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3*, const RuntimeMethod*))List_1_ToArray_mD7E4F8E7C11C3C67CB5739FCC0A6E86106A6291F_gshared)(__this, method);
}
inline void List_1_Clear_mC293DD9E1F021871B58449F0A2B1BEC545F82C3F_inline (List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3*, const RuntimeMethod*))List_1_Clear_m16C1F2C61FED5955F10EB36BC1CB2DF34B128994_gshared_inline)(__this, method);
}
inline void List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_inline (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, int32_t, const RuntimeMethod*))List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_gshared_inline)(__this, ___0_item, method);
}
inline Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* List_1_ToArray_m65479FB75A5FE539EA1A0D6681172717D23CEAAA (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method)
{
	return ((  Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, const RuntimeMethod*))List_1_ToArray_m65479FB75A5FE539EA1A0D6681172717D23CEAAA_gshared)(__this, method);
}
inline void List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_inline (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, const RuntimeMethod*))List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_gshared_inline)(__this, method);
}
inline void Stack_1__ctor_m34EB03F352ED5B57BD4AD4C41C87A0F2ADC47B79 (Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* __this, const RuntimeMethod* method)
{
	((  void (*) (Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335*, const RuntimeMethod*))Stack_1__ctor_m70E8EDA96A608CE9BAB7FC8313B233AADA573BD4_gshared)(__this, method);
}
inline int32_t Stack_1_get_Count_m06BE4BC0BD3700E0E08866F4E1D53F2A91F1FA91_inline (Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335*, const RuntimeMethod*))Stack_1_get_Count_mD08AE71D49787D30DDD9D484BCD323D646744D2E_gshared_inline)(__this, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Activator_CreateInstance_mFF030428C64FDDFACC74DFAC97388A1C628BFBCF (Type_t* ___0_type, const RuntimeMethod* method) ;
inline RuntimeObject* Stack_1_Pop_m6501363A3DCBFB09583A65306FFEA89DFC4108E9 (Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* __this, const RuntimeMethod* method)
{
	return ((  RuntimeObject* (*) (Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335*, const RuntimeMethod*))Stack_1_Pop_m2AFF69249659372F07EE25817DBCAFE74E1CF778_gshared)(__this, method);
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234_inline (EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* __this, RuntimeObject* ___0_entity, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_RemoveAllComponents_m6D3FEA2B1BCA3EC9FC0550DBCC30A80EB19756DA (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StringBuilder__ctor_m1D99713357DE05DAFA296633639DB55F8C30587D (StringBuilder_t* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StringBuilder_set_Length_mE2427BDAEF91C4E4A6C80F3BDF1F6E01DBCC2414 (StringBuilder_t* __this, int32_t ___0_value, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringBuilder_t* StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D (StringBuilder_t* __this, String_t* ___0_value, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringBuilder_t* StringBuilder_Append_m283B617AC29FB0DD6F3A7D8C01D385C25A5F0FAA (StringBuilder_t* __this, int32_t ___0_value, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* Entity_GetComponents_mFFEEBD86D8BC111D8148A0F816AF377DCF7CD693 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) ;
inline int32_t HashSet_1_get_Count_m41CC85EEB7855CEFA3BC7A32F115387939318ED3_inline (HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885*, const RuntimeMethod*))HashSet_1_get_Count_m41CC85EEB7855CEFA3BC7A32F115387939318ED3_gshared_inline)(__this, method);
}
inline void HashSet_1__ctor_m9132EE1422BAA45E44B7FFF495F378790D36D90E (HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* __this, const RuntimeMethod* method)
{
	((  void (*) (HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885*, const RuntimeMethod*))HashSet_1__ctor_m9132EE1422BAA45E44B7FFF495F378790D36D90E_gshared)(__this, method);
}
inline bool HashSet_1_Add_m2CD7657B3459B61DD4BBA47024AC71F7D319658B (HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* __this, RuntimeObject* ___0_item, const RuntimeMethod* method)
{
	return ((  bool (*) (HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885*, RuntimeObject*, const RuntimeMethod*))HashSet_1_Add_m2CD7657B3459B61DD4BBA47024AC71F7D319658B_gshared)(__this, ___0_item, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityIsAlreadyRetainedByOwnerException__ctor_m02B6DD1E20F09F4F4A1571B591B4075F41BC746E (EntityIsAlreadyRetainedByOwnerException_tB58BD16D6DB0C073D792DFE04F76CEBAE2EE58FE* __this, RuntimeObject* ___0_entity, RuntimeObject* ___1_owner, const RuntimeMethod* method) ;
inline bool HashSet_1_Remove_mF1D84C0A2829DDA2A0CEE1D82A5B999B5F6627CB (HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* __this, RuntimeObject* ___0_item, const RuntimeMethod* method)
{
	return ((  bool (*) (HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885*, RuntimeObject*, const RuntimeMethod*))HashSet_1_Remove_mF1D84C0A2829DDA2A0CEE1D82A5B999B5F6627CB_gshared)(__this, ___0_item, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityIsNotRetainedByOwnerException__ctor_m2DCE0D9B0197B5C86B7A2038AFF8B06581976727 (EntityIsNotRetainedByOwnerException_t5C9A88040F783ECA528614B562071C871DF738DE* __this, RuntimeObject* ___0_entity, RuntimeObject* ___1_owner, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SingleEntityException__ctor_m4A81150F6003B9F03E3A073B980C5539F2BDB502 (SingleEntityException_t183BAB11477B2A57E37055080769CEA53FA77858* __this, int32_t ___0_count, const RuntimeMethod* method) ;
inline RuntimeObject* Enumerable_First_TisIEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_m17BD4F6C644B3FAA39249ADCB412B1BB54243FC7 (RuntimeObject* ___0_source, const RuntimeMethod* method)
{
	return ((  RuntimeObject* (*) (RuntimeObject*, const RuntimeMethod*))Enumerable_First_TisRuntimeObject_mEFECF1B8C3201589C5AF34176DCBF8DD926642D6_gshared)(___0_source, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* EntitasStringExtension_addSuffix_m1C778B10E5D5902E82B5462849EB930DAEAF85BF (String_t* ___0_str, String_t* ___1_suffix, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* EntitasStringExtension_removeSuffix_mE16E89BECF4C68E7AB7D15758CE19B7DA8BF448A (String_t* ___0_str, String_t* ___1_suffix, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool EntitasStringExtension_hasSuffix_m59B90CCA8206264D5FB8D8CE282B8093A3D92D6F (String_t* ___0_str, String_t* ___1_suffix, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline (String_t* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Substring_mB1D94F47935D22E130FF2C01DBB6A4135FBB76CE (String_t* __this, int32_t ___0_startIndex, int32_t ___1_length, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_EndsWith_m5E5D307CA6AEB7C08CE782B4693B19D07ADC9075 (String_t* __this, String_t* ___0_value, int32_t ___1_comparisonType, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t* Object_GetType_mE10A8FC1E57F3DF29972CCBC026C2DC3942263B3 (RuntimeObject* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PublicMemberInfoExtension_CopyPublicMemberValues_m3C010A39C4784E74F286FAF10598EE167C107C9C (RuntimeObject* ___0_source, RuntimeObject* ___1_target, const RuntimeMethod* method) ;
inline void List_1__ctor_m69A54ED11B9857404699079358C757A11363E887 (List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4*, const RuntimeMethod*))List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared)(__this, method);
}
inline void List_1__ctor_m857E572D5CC61334AB231EFA59092D30857DCFD3 (List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB*, const RuntimeMethod*))List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared)(__this, method);
}
inline void List_1__ctor_m2F2A619D23D0C508C3AB62A578A007B27C312C73 (List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4*, const RuntimeMethod*))List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared)(__this, method);
}
inline void List_1__ctor_m98C7F81FA64837DD6E162E5C70A13BDEF7C18C0F (List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6*, const RuntimeMethod*))List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared)(__this, method);
}
inline void List_1_Add_mBD3B17EDD7711457A94E0B737F51E4A3035D8810_inline (List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4* __this, RuntimeObject* ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4*, RuntimeObject*, const RuntimeMethod*))List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline)(__this, ___0_item, method);
}
inline void List_1_Add_m955BFC0F3B491F15CD74C678A961B4900A9874DA_inline (List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB* __this, RuntimeObject* ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB*, RuntimeObject*, const RuntimeMethod*))List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline)(__this, ___0_item, method);
}
inline void List_1_Add_m3470969576B79057EE94FCA211CB46D0AA243DF9_inline (List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4* __this, RuntimeObject* ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4*, RuntimeObject*, const RuntimeMethod*))List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline)(__this, ___0_item, method);
}
inline void List_1_Add_m54A91912B2411D0D35AC46B000D66485CC8798BA_inline (List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6* __this, RuntimeObject* ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6*, RuntimeObject*, const RuntimeMethod*))List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline)(__this, ___0_item, method);
}
inline bool List_1_Remove_m182DFED6A1B299DD2A354BA960398B9652725F25 (List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4* __this, RuntimeObject* ___0_item, const RuntimeMethod* method)
{
	return ((  bool (*) (List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4*, RuntimeObject*, const RuntimeMethod*))List_1_Remove_m4DFA48F4CEB9169601E75FC28517C5C06EFA5AD7_gshared)(__this, ___0_item, method);
}
inline bool List_1_Remove_m9DB7970F74E8C72B6D41E372BA7CB82D2B3EA7C8 (List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB* __this, RuntimeObject* ___0_item, const RuntimeMethod* method)
{
	return ((  bool (*) (List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB*, RuntimeObject*, const RuntimeMethod*))List_1_Remove_m4DFA48F4CEB9169601E75FC28517C5C06EFA5AD7_gshared)(__this, ___0_item, method);
}
inline bool List_1_Remove_m32C3786ECC7F4F1AA1EA443227F00743B7650B6B (List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4* __this, RuntimeObject* ___0_item, const RuntimeMethod* method)
{
	return ((  bool (*) (List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4*, RuntimeObject*, const RuntimeMethod*))List_1_Remove_m4DFA48F4CEB9169601E75FC28517C5C06EFA5AD7_gshared)(__this, ___0_item, method);
}
inline bool List_1_Remove_mFD32512352FDB857E97A6E36C8A0C1FEE19E6714 (List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6* __this, RuntimeObject* ___0_item, const RuntimeMethod* method)
{
	return ((  bool (*) (List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6*, RuntimeObject*, const RuntimeMethod*))List_1_Remove_m4DFA48F4CEB9169601E75FC28517C5C06EFA5AD7_gshared)(__this, ___0_item, method);
}
inline RuntimeObject* List_1_get_Item_m008F12FFE7C434066EB70D102092AC7A3406DFE5 (List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4* __this, int32_t ___0_index, const RuntimeMethod* method)
{
	return ((  RuntimeObject* (*) (List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4*, int32_t, const RuntimeMethod*))List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_gshared)(__this, ___0_index, method);
}
inline int32_t List_1_get_Count_mBCC89E3A732616D2D45184D8A5D7780C41025B2E_inline (List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4*, const RuntimeMethod*))List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline)(__this, method);
}
inline RuntimeObject* List_1_get_Item_mEF669AC0B44B77803D582B526D2C08269A722F4B (List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB* __this, int32_t ___0_index, const RuntimeMethod* method)
{
	return ((  RuntimeObject* (*) (List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB*, int32_t, const RuntimeMethod*))List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_gshared)(__this, ___0_index, method);
}
inline int32_t List_1_get_Count_m7639C2A449943F673350F560F544B8B9FAB8A37D_inline (List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB*, const RuntimeMethod*))List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline)(__this, method);
}
inline RuntimeObject* List_1_get_Item_mAC23816FC8101220D796791157C5C1E7B74FE2F3 (List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4* __this, int32_t ___0_index, const RuntimeMethod* method)
{
	return ((  RuntimeObject* (*) (List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4*, int32_t, const RuntimeMethod*))List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_gshared)(__this, ___0_index, method);
}
inline int32_t List_1_get_Count_m34A818667B41D76E9D3322A642D03BB33900380B_inline (List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4*, const RuntimeMethod*))List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline)(__this, method);
}
inline RuntimeObject* List_1_get_Item_m136BBBD4A6AAF2E1775292CAD7C27A34F3738BA3 (List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6* __this, int32_t ___0_index, const RuntimeMethod* method)
{
	return ((  RuntimeObject* (*) (List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6*, int32_t, const RuntimeMethod*))List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_gshared)(__this, ___0_index, method);
}
inline int32_t List_1_get_Count_mC8EC69FAFB2FE4AB7E1CBC7465512DDA4A5C4B6D_inline (List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6*, const RuntimeMethod*))List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline)(__this, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Systems_ActivateReactiveSystems_m8CC189427D7FE5CB907A67FBCDCF9F96FDA7F0FC (Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Systems_DeactivateReactiveSystems_mCFF9E5EC8DD87FAF1437FF4314365C73592EFE42 (Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Systems_ClearReactiveSystems_m944D8FA4D4324865D74EB78C392994B6170F5830 (Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* __this, const RuntimeMethod* method) ;
inline void List_1_AddWithResize_m79A9BF770BEF9C06BE40D5401E55E375F2726CC4 (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, RuntimeObject*, const RuntimeMethod*))List_1_AddWithResize_m79A9BF770BEF9C06BE40D5401E55E375F2726CC4_gshared)(__this, ___0_item, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Array_Clear_m50BAA3751899858B097D3FF2ED31F284703FE5CB (RuntimeArray* ___0_array, int32_t ___1_index, int32_t ___2_length, const RuntimeMethod* method) ;
inline void List_1_AddWithResize_m378B392086AAB6F400944FA9839516326B3F7BB8 (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, int32_t, const RuntimeMethod*))List_1_AddWithResize_m378B392086AAB6F400944FA9839516326B3F7BB8_gshared)(__this, ___0_item, method);
}
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CollectorException__ctor_m697D555590A484D9A2F36B8C35353436ADA2768F (CollectorException_t57D1B1EA14CFFC9C5996CBCFA04F3360C625C5BB* __this, String_t* ___0_message, String_t* ___1_hint, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___0_message;
		String_t* L_1 = ___1_hint;
		EntitasException__ctor_mE2E152AD2BDD2D60BA7D31980081F7FC5EC73E7E(__this, L_0, L_1, NULL);
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ContextDoesNotContainEntityException__ctor_mD9E43A7F7C959235595BD9594ED211BB998B5AFB (ContextDoesNotContainEntityException_t78A395CA84D8B92D90EC31EC184FF38AD76ACDD9* __this, String_t* ___0_message, String_t* ___1_hint, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9A5253BF31B79E22DF1C48DB0D96B50B43A9E0A5);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_message;
		String_t* L_1;
		L_1 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(L_0, _stringLiteral9A5253BF31B79E22DF1C48DB0D96B50B43A9E0A5, NULL);
		String_t* L_2 = ___1_hint;
		EntitasException__ctor_mE2E152AD2BDD2D60BA7D31980081F7FC5EC73E7E(__this, L_1, L_2, NULL);
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ContextEntityIndexDoesAlreadyExistException__ctor_mD40BEC1DCB38EF8CC9C808D520F0E002E766DE4E (ContextEntityIndexDoesAlreadyExistException_t9E716ABFE7F1565F5BB62657B36343AB2DC9B5E9* __this, RuntimeObject* ___0_context, String_t* ___1_name, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5DB5DACAACEF2F6E16BFEA20819AB3E510AE97FE);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE52DEC78EB9E6776057DF91F0724F3CEFA2A90A0);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___1_name;
		RuntimeObject* L_1 = ___0_context;
		String_t* L_2;
		L_2 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(_stringLiteralE52DEC78EB9E6776057DF91F0724F3CEFA2A90A0, L_0, L_1, NULL);
		EntitasException__ctor_mE2E152AD2BDD2D60BA7D31980081F7FC5EC73E7E(__this, L_2, _stringLiteral5DB5DACAACEF2F6E16BFEA20819AB3E510AE97FE, NULL);
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ContextEntityIndexDoesNotExistException__ctor_mFADEA51A77F2AA27EE9F34A0D2F4100B7BAAC757 (ContextEntityIndexDoesNotExistException_t23EBA6EDC3488CC51532BB47E86847F248977036* __this, RuntimeObject* ___0_context, String_t* ___1_name, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral28FDB1B7B90FD3CAA3338AFD1A1D7E4231A513CE);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral30BCA17AD2287D35B6E19DEE4768DBE6A7677318);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___1_name;
		RuntimeObject* L_1 = ___0_context;
		String_t* L_2;
		L_2 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(_stringLiteral28FDB1B7B90FD3CAA3338AFD1A1D7E4231A513CE, L_0, L_1, NULL);
		EntitasException__ctor_mE2E152AD2BDD2D60BA7D31980081F7FC5EC73E7E(__this, L_2, _stringLiteral30BCA17AD2287D35B6E19DEE4768DBE6A7677318, NULL);
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ContextInfoException__ctor_m032988BE9BE5523E81414A9AC35CD54C2BAF4168 (ContextInfoException_t552346465EEC6A53F2D058FDA974D3147D830782* __this, RuntimeObject* ___0_context, ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* ___1_contextInfo, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IContext_t0801D5F43915BAD7010CF74F4DC08ADEDBCFC8DF_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral00B28FF06B788B9B67C6B259800F404F9F3761FD);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral46271EED90F0BDB046A97E6BB3D268FA9DA9E2B9);
		s_Il2CppMethodInitialized = true;
	}
	{
		RuntimeObject* L_0 = ___0_context;
		RuntimeObject* L_1 = ___0_context;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = InterfaceFuncInvoker0< int32_t >::Invoke(8, IContext_t0801D5F43915BAD7010CF74F4DC08ADEDBCFC8DF_il2cpp_TypeInfo_var, L_1);
		int32_t L_3 = L_2;
		RuntimeObject* L_4 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_3);
		ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* L_5 = ___1_contextInfo;
		NullCheck(L_5);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_6 = L_5->___componentNames;
		NullCheck(L_6);
		int32_t L_7 = ((int32_t)(((RuntimeArray*)L_6)->max_length));
		RuntimeObject* L_8 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_7);
		String_t* L_9;
		L_9 = String_Format_mA0534D6E2AE4D67A6BD8D45B3321323930EB930C(_stringLiteral46271EED90F0BDB046A97E6BB3D268FA9DA9E2B9, L_0, L_4, L_8, NULL);
		ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* L_10 = ___1_contextInfo;
		NullCheck(L_10);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_11 = L_10->___componentNames;
		String_t* L_12;
		L_12 = String_Join_m557B6B554B87C1742FA0B128500073B421ED0BFD(_stringLiteral00B28FF06B788B9B67C6B259800F404F9F3761FD, L_11, NULL);
		EntitasException__ctor_mE2E152AD2BDD2D60BA7D31980081F7FC5EC73E7E(__this, L_9, L_12, NULL);
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ContextStillHasRetainedEntitiesException__ctor_mAA367E07641C914758DBB796CE0C7BA531F970BA (ContextStillHasRetainedEntitiesException_t5ABFA49A47FEDC2AE63CE8487800212BE92AFA33* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_entities, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral07CB67C10A967C89D59286FBEA68B6BEED636C60);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEABEAB522AED307CC857B033B01F36B4FBC38414);
		s_Il2CppMethodInitialized = true;
	}
	{
		RuntimeObject* L_0 = ___0_context;
		String_t* L_1;
		L_1 = String_Format_mA8DBB4C2516B9723C5A41E6CB1E2FAF4BBE96DD8(_stringLiteralEABEAB522AED307CC857B033B01F36B4FBC38414, L_0, NULL);
		RuntimeObject* L_2 = ___1_entities;
		String_t* L_3;
		L_3 = ContextStillHasRetainedEntitiesException_EntitiesToString_mF6CA67B30BEF775451343861B6B440066575B759(L_2, NULL);
		String_t* L_4;
		L_4 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(_stringLiteral07CB67C10A967C89D59286FBEA68B6BEED636C60, L_3, NULL);
		EntitasException__ctor_mE2E152AD2BDD2D60BA7D31980081F7FC5EC73E7E(__this, L_1, L_4, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ContextStillHasRetainedEntitiesException_EntitiesToString_mF6CA67B30BEF775451343861B6B440066575B759 (RuntimeObject* ___0_entities, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerable_Select_TisIEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_TisString_t_mA368DA5BA6807B07594C8842DDBF8560BBF7AFEC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_2_t6D2E58ECD14989F315928FF171DED6E65CBAB6E5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_U3CEntitiesToStringU3Eb__1_0_m22BB117CFB28336F4D2526F0C4A46A6014A664C8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral00B28FF06B788B9B67C6B259800F404F9F3761FD);
		s_Il2CppMethodInitialized = true;
	}
	Func_2_t6D2E58ECD14989F315928FF171DED6E65CBAB6E5* G_B2_0 = NULL;
	RuntimeObject* G_B2_1 = NULL;
	String_t* G_B2_2 = NULL;
	Func_2_t6D2E58ECD14989F315928FF171DED6E65CBAB6E5* G_B1_0 = NULL;
	RuntimeObject* G_B1_1 = NULL;
	String_t* G_B1_2 = NULL;
	{
		RuntimeObject* L_0 = ___0_entities;
		il2cpp_codegen_runtime_class_init_inline(U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var);
		Func_2_t6D2E58ECD14989F315928FF171DED6E65CBAB6E5* L_1 = ((U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var))->___U3CU3E9__1_0;
		Func_2_t6D2E58ECD14989F315928FF171DED6E65CBAB6E5* L_2 = L_1;
		if (L_2)
		{
			G_B2_0 = L_2;
			G_B2_1 = L_0;
			G_B2_2 = _stringLiteral00B28FF06B788B9B67C6B259800F404F9F3761FD;
			goto IL_0025;
		}
		G_B1_0 = L_2;
		G_B1_1 = L_0;
		G_B1_2 = _stringLiteral00B28FF06B788B9B67C6B259800F404F9F3761FD;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var);
		U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85* L_3 = ((U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var))->___U3CU3E9;
		Func_2_t6D2E58ECD14989F315928FF171DED6E65CBAB6E5* L_4 = (Func_2_t6D2E58ECD14989F315928FF171DED6E65CBAB6E5*)il2cpp_codegen_object_new(Func_2_t6D2E58ECD14989F315928FF171DED6E65CBAB6E5_il2cpp_TypeInfo_var);
		Func_2__ctor_mC6091E8E8B6D64F03D0E0053E726ED562F51F2CC(L_4, L_3, (intptr_t)((void*)U3CU3Ec_U3CEntitiesToStringU3Eb__1_0_m22BB117CFB28336F4D2526F0C4A46A6014A664C8_RuntimeMethod_var), NULL);
		Func_2_t6D2E58ECD14989F315928FF171DED6E65CBAB6E5* L_5 = L_4;
		((U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var))->___U3CU3E9__1_0 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&((U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var))->___U3CU3E9__1_0), (void*)L_5);
		G_B2_0 = L_5;
		G_B2_1 = G_B1_1;
		G_B2_2 = G_B1_2;
	}

IL_0025:
	{
		RuntimeObject* L_6;
		L_6 = Enumerable_Select_TisIEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_TisString_t_mA368DA5BA6807B07594C8842DDBF8560BBF7AFEC(G_B2_1, G_B2_0, Enumerable_Select_TisIEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_TisString_t_mA368DA5BA6807B07594C8842DDBF8560BBF7AFEC_RuntimeMethod_var);
		String_t* L_7;
		L_7 = String_Join_m8159F953B3D62AA54A0853A6E9573CDC0F63E158(G_B2_2, L_6, NULL);
		return L_7;
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__cctor_mC9BF554700812A0B95CF6E3EA13CF77E996B5AB0 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85* L_0 = (U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85*)il2cpp_codegen_object_new(U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var);
		U3CU3Ec__ctor_m1F2AC3C6282B5951095AB3E31532337B2D7FFB71(L_0, NULL);
		((U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var))->___U3CU3E9 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&((U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var))->___U3CU3E9), (void*)L_0);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_m1F2AC3C6282B5951095AB3E31532337B2D7FFB71 (U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* U3CU3Ec_U3CEntitiesToStringU3Eb__1_0_m22BB117CFB28336F4D2526F0C4A46A6014A664C8 (U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85* __this, RuntimeObject* ___0_e, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerable_Select_TisRuntimeObject_TisString_t_m4212A6B9DDC97D402346EC78AE3115A600469C8C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_U3CEntitiesToStringU3Eb__1_1_m82511CA63C9C9B4464F0D61E8DD07B7D584B3E2A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral35D9703651C0B5FE577BAA089212BEF91D370ADB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral758733BDBED83CBFF4F635AC26CA92AAE477F75D);
		s_Il2CppMethodInitialized = true;
	}
	SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2* V_0 = NULL;
	Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B* G_B4_0 = NULL;
	HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* G_B4_1 = NULL;
	String_t* G_B4_2 = NULL;
	RuntimeObject* G_B4_3 = NULL;
	String_t* G_B4_4 = NULL;
	Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B* G_B3_0 = NULL;
	HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* G_B3_1 = NULL;
	String_t* G_B3_2 = NULL;
	RuntimeObject* G_B3_3 = NULL;
	String_t* G_B3_4 = NULL;
	{
		RuntimeObject* L_0 = ___0_e;
		NullCheck(L_0);
		RuntimeObject* L_1;
		L_1 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(15, IEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_il2cpp_TypeInfo_var, L_0);
		V_0 = ((SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2*)IsInstSealed((RuntimeObject*)L_1, SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2_il2cpp_TypeInfo_var));
		SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2* L_2 = V_0;
		if (L_2)
		{
			goto IL_0016;
		}
	}
	{
		RuntimeObject* L_3 = ___0_e;
		NullCheck(L_3);
		String_t* L_4;
		L_4 = VirtualFuncInvoker0< String_t* >::Invoke(3, L_3);
		return L_4;
	}

IL_0016:
	{
		RuntimeObject* L_5 = ___0_e;
		SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2* L_6 = V_0;
		NullCheck(L_6);
		HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* L_7;
		L_7 = SafeAERC_get_owners_m1AB169D663164AA81CD105D5507E4F10EF283252_inline(L_6, NULL);
		il2cpp_codegen_runtime_class_init_inline(U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var);
		Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B* L_8 = ((U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var))->___U3CU3E9__1_1;
		Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B* L_9 = L_8;
		if (L_9)
		{
			G_B4_0 = L_9;
			G_B4_1 = L_7;
			G_B4_2 = _stringLiteral758733BDBED83CBFF4F635AC26CA92AAE477F75D;
			G_B4_3 = L_5;
			G_B4_4 = _stringLiteral35D9703651C0B5FE577BAA089212BEF91D370ADB;
			goto IL_0046;
		}
		G_B3_0 = L_9;
		G_B3_1 = L_7;
		G_B3_2 = _stringLiteral758733BDBED83CBFF4F635AC26CA92AAE477F75D;
		G_B3_3 = L_5;
		G_B3_4 = _stringLiteral35D9703651C0B5FE577BAA089212BEF91D370ADB;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var);
		U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85* L_10 = ((U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var))->___U3CU3E9;
		Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B* L_11 = (Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B*)il2cpp_codegen_object_new(Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B_il2cpp_TypeInfo_var);
		Func_2__ctor_mD6767DE619116219CD1567BC735C4AC96B9348CF(L_11, L_10, (intptr_t)((void*)U3CU3Ec_U3CEntitiesToStringU3Eb__1_1_m82511CA63C9C9B4464F0D61E8DD07B7D584B3E2A_RuntimeMethod_var), NULL);
		Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B* L_12 = L_11;
		((U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var))->___U3CU3E9__1_1 = L_12;
		Il2CppCodeGenWriteBarrier((void**)(&((U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85_il2cpp_TypeInfo_var))->___U3CU3E9__1_1), (void*)L_12);
		G_B4_0 = L_12;
		G_B4_1 = G_B3_1;
		G_B4_2 = G_B3_2;
		G_B4_3 = G_B3_3;
		G_B4_4 = G_B3_4;
	}

IL_0046:
	{
		RuntimeObject* L_13;
		L_13 = Enumerable_Select_TisRuntimeObject_TisString_t_m4212A6B9DDC97D402346EC78AE3115A600469C8C(G_B4_1, G_B4_0, Enumerable_Select_TisRuntimeObject_TisString_t_m4212A6B9DDC97D402346EC78AE3115A600469C8C_RuntimeMethod_var);
		String_t* L_14;
		L_14 = String_Join_m8159F953B3D62AA54A0853A6E9573CDC0F63E158(G_B4_2, L_13, NULL);
		String_t* L_15;
		L_15 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(G_B4_4, G_B4_3, L_14, NULL);
		return L_15;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* U3CU3Ec_U3CEntitiesToStringU3Eb__1_1_m82511CA63C9C9B4464F0D61E8DD07B7D584B3E2A (U3CU3Ec_tED35ACB0CE60DC167BA870072EF905605A3FAC85* __this, RuntimeObject* ___0_o, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = ___0_o;
		NullCheck(L_0);
		String_t* L_1;
		L_1 = VirtualFuncInvoker0< String_t* >::Invoke(3, L_0);
		return L_1;
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityIsNotDestroyedException__ctor_mCA521C10DFE315016BFD23366CF0D93FB059CDAE (EntityIsNotDestroyedException_t91EDFD71B22E7B3D73184DEAB30CE79A2CAC79A8* __this, String_t* ___0_message, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5D35E6992FED4911709FE05C4D0D58AA494F59F9);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6103095F8626AAF90D00D05CCC2158E55AE5154C);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_message;
		String_t* L_1;
		L_1 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(L_0, _stringLiteral6103095F8626AAF90D00D05CCC2158E55AE5154C, NULL);
		EntitasException__ctor_mE2E152AD2BDD2D60BA7D31980081F7FC5EC73E7E(__this, L_1, _stringLiteral5D35E6992FED4911709FE05C4D0D58AA494F59F9, NULL);
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
void ContextEntityChanged_Invoke_m811DE4E693BA1DC673FB3D7D5B70FCFD1A2226C2_Multicast(ContextEntityChanged_t664F55E3A651D2713CC38B64092750E8816DBF42* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_entity, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		ContextEntityChanged_t664F55E3A651D2713CC38B64092750E8816DBF42* currentDelegate = reinterpret_cast<ContextEntityChanged_t664F55E3A651D2713CC38B64092750E8816DBF42*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_context, ___1_entity, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void ContextEntityChanged_Invoke_m811DE4E693BA1DC673FB3D7D5B70FCFD1A2226C2_OpenInst(ContextEntityChanged_t664F55E3A651D2713CC38B64092750E8816DBF42* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_entity, const RuntimeMethod* method)
{
	NullCheck(___0_context);
	typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_context, ___1_entity, method);
}
void ContextEntityChanged_Invoke_m811DE4E693BA1DC673FB3D7D5B70FCFD1A2226C2_OpenStatic(ContextEntityChanged_t664F55E3A651D2713CC38B64092750E8816DBF42* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_entity, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_context, ___1_entity, method);
}
void ContextEntityChanged_Invoke_m811DE4E693BA1DC673FB3D7D5B70FCFD1A2226C2_OpenVirtual(ContextEntityChanged_t664F55E3A651D2713CC38B64092750E8816DBF42* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_entity, const RuntimeMethod* method)
{
	NullCheck(___0_context);
	VirtualActionInvoker1< RuntimeObject* >::Invoke(il2cpp_codegen_method_get_slot(method), ___0_context, ___1_entity);
}
void ContextEntityChanged_Invoke_m811DE4E693BA1DC673FB3D7D5B70FCFD1A2226C2_OpenInterface(ContextEntityChanged_t664F55E3A651D2713CC38B64092750E8816DBF42* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_entity, const RuntimeMethod* method)
{
	NullCheck(___0_context);
	InterfaceActionInvoker1< RuntimeObject* >::Invoke(il2cpp_codegen_method_get_slot(method), il2cpp_codegen_method_get_declaring_type(method), ___0_context, ___1_entity);
}
void ContextEntityChanged_Invoke_m811DE4E693BA1DC673FB3D7D5B70FCFD1A2226C2_OpenGenericVirtual(ContextEntityChanged_t664F55E3A651D2713CC38B64092750E8816DBF42* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_entity, const RuntimeMethod* method)
{
	NullCheck(___0_context);
	GenericVirtualActionInvoker1< RuntimeObject* >::Invoke(method, ___0_context, ___1_entity);
}
void ContextEntityChanged_Invoke_m811DE4E693BA1DC673FB3D7D5B70FCFD1A2226C2_OpenGenericInterface(ContextEntityChanged_t664F55E3A651D2713CC38B64092750E8816DBF42* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_entity, const RuntimeMethod* method)
{
	NullCheck(___0_context);
	GenericInterfaceActionInvoker1< RuntimeObject* >::Invoke(method, ___0_context, ___1_entity);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ContextEntityChanged__ctor_mE9220FC1EAC9839BF4549817DC8FC7F69CA8D1AF (ContextEntityChanged_t664F55E3A651D2713CC38B64092750E8816DBF42* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 2;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&ContextEntityChanged_Invoke_m811DE4E693BA1DC673FB3D7D5B70FCFD1A2226C2_OpenStatic;
		else
			{
				__this->___invoke_impl = __this->___method_ptr;
				__this->___method_code = (intptr_t)__this->___m_target;
			}
	}
	else
	{
		bool isOpen = parameterCount == 1;
		if (isOpen)
		{
			if (__this->___method_is_virtual)
			{
				if (il2cpp_codegen_method_is_generic_instance_method((RuntimeMethod*)___1_method))
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ContextEntityChanged_Invoke_m811DE4E693BA1DC673FB3D7D5B70FCFD1A2226C2_OpenGenericInterface;
					else
						__this->___invoke_impl = (intptr_t)&ContextEntityChanged_Invoke_m811DE4E693BA1DC673FB3D7D5B70FCFD1A2226C2_OpenGenericVirtual;
				else
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ContextEntityChanged_Invoke_m811DE4E693BA1DC673FB3D7D5B70FCFD1A2226C2_OpenInterface;
					else
						__this->___invoke_impl = (intptr_t)&ContextEntityChanged_Invoke_m811DE4E693BA1DC673FB3D7D5B70FCFD1A2226C2_OpenVirtual;
			}
			else
			{
				__this->___invoke_impl = (intptr_t)&ContextEntityChanged_Invoke_m811DE4E693BA1DC673FB3D7D5B70FCFD1A2226C2_OpenInst;
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
	__this->___extra_arg = (intptr_t)&ContextEntityChanged_Invoke_m811DE4E693BA1DC673FB3D7D5B70FCFD1A2226C2_Multicast;
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ContextEntityChanged_Invoke_m811DE4E693BA1DC673FB3D7D5B70FCFD1A2226C2 (ContextEntityChanged_t664F55E3A651D2713CC38B64092750E8816DBF42* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_entity, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_context, ___1_entity, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ContextEntityChanged_BeginInvoke_m53691AB502728FEAEAC3FB79D05C7CA89E801BF5 (ContextEntityChanged_t664F55E3A651D2713CC38B64092750E8816DBF42* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_entity, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___2_callback, RuntimeObject* ___3_object, const RuntimeMethod* method) 
{
	void *__d_args[3] = {0};
	__d_args[0] = ___0_context;
	__d_args[1] = ___1_entity;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___2_callback, (RuntimeObject*)___3_object);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ContextEntityChanged_EndInvoke_mA0A47560371263740D9866189E716B601716A5AF (ContextEntityChanged_t664F55E3A651D2713CC38B64092750E8816DBF42* __this, RuntimeObject* ___0_result, const RuntimeMethod* method) 
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
void ContextGroupChanged_Invoke_m3213A08CDC92412376663946496F808CB7FB4742_Multicast(ContextGroupChanged_t40BC410925FACFB7B33FAE12A39E00B5275B580F* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_group, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		ContextGroupChanged_t40BC410925FACFB7B33FAE12A39E00B5275B580F* currentDelegate = reinterpret_cast<ContextGroupChanged_t40BC410925FACFB7B33FAE12A39E00B5275B580F*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_context, ___1_group, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void ContextGroupChanged_Invoke_m3213A08CDC92412376663946496F808CB7FB4742_OpenInst(ContextGroupChanged_t40BC410925FACFB7B33FAE12A39E00B5275B580F* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_group, const RuntimeMethod* method)
{
	NullCheck(___0_context);
	typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_context, ___1_group, method);
}
void ContextGroupChanged_Invoke_m3213A08CDC92412376663946496F808CB7FB4742_OpenStatic(ContextGroupChanged_t40BC410925FACFB7B33FAE12A39E00B5275B580F* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_group, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_context, ___1_group, method);
}
void ContextGroupChanged_Invoke_m3213A08CDC92412376663946496F808CB7FB4742_OpenVirtual(ContextGroupChanged_t40BC410925FACFB7B33FAE12A39E00B5275B580F* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_group, const RuntimeMethod* method)
{
	NullCheck(___0_context);
	VirtualActionInvoker1< RuntimeObject* >::Invoke(il2cpp_codegen_method_get_slot(method), ___0_context, ___1_group);
}
void ContextGroupChanged_Invoke_m3213A08CDC92412376663946496F808CB7FB4742_OpenInterface(ContextGroupChanged_t40BC410925FACFB7B33FAE12A39E00B5275B580F* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_group, const RuntimeMethod* method)
{
	NullCheck(___0_context);
	InterfaceActionInvoker1< RuntimeObject* >::Invoke(il2cpp_codegen_method_get_slot(method), il2cpp_codegen_method_get_declaring_type(method), ___0_context, ___1_group);
}
void ContextGroupChanged_Invoke_m3213A08CDC92412376663946496F808CB7FB4742_OpenGenericVirtual(ContextGroupChanged_t40BC410925FACFB7B33FAE12A39E00B5275B580F* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_group, const RuntimeMethod* method)
{
	NullCheck(___0_context);
	GenericVirtualActionInvoker1< RuntimeObject* >::Invoke(method, ___0_context, ___1_group);
}
void ContextGroupChanged_Invoke_m3213A08CDC92412376663946496F808CB7FB4742_OpenGenericInterface(ContextGroupChanged_t40BC410925FACFB7B33FAE12A39E00B5275B580F* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_group, const RuntimeMethod* method)
{
	NullCheck(___0_context);
	GenericInterfaceActionInvoker1< RuntimeObject* >::Invoke(method, ___0_context, ___1_group);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ContextGroupChanged__ctor_mDC739D99C53E6F24F91C71116E46C6132078DD66 (ContextGroupChanged_t40BC410925FACFB7B33FAE12A39E00B5275B580F* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 2;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&ContextGroupChanged_Invoke_m3213A08CDC92412376663946496F808CB7FB4742_OpenStatic;
		else
			{
				__this->___invoke_impl = __this->___method_ptr;
				__this->___method_code = (intptr_t)__this->___m_target;
			}
	}
	else
	{
		bool isOpen = parameterCount == 1;
		if (isOpen)
		{
			if (__this->___method_is_virtual)
			{
				if (il2cpp_codegen_method_is_generic_instance_method((RuntimeMethod*)___1_method))
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ContextGroupChanged_Invoke_m3213A08CDC92412376663946496F808CB7FB4742_OpenGenericInterface;
					else
						__this->___invoke_impl = (intptr_t)&ContextGroupChanged_Invoke_m3213A08CDC92412376663946496F808CB7FB4742_OpenGenericVirtual;
				else
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ContextGroupChanged_Invoke_m3213A08CDC92412376663946496F808CB7FB4742_OpenInterface;
					else
						__this->___invoke_impl = (intptr_t)&ContextGroupChanged_Invoke_m3213A08CDC92412376663946496F808CB7FB4742_OpenVirtual;
			}
			else
			{
				__this->___invoke_impl = (intptr_t)&ContextGroupChanged_Invoke_m3213A08CDC92412376663946496F808CB7FB4742_OpenInst;
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
	__this->___extra_arg = (intptr_t)&ContextGroupChanged_Invoke_m3213A08CDC92412376663946496F808CB7FB4742_Multicast;
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ContextGroupChanged_Invoke_m3213A08CDC92412376663946496F808CB7FB4742 (ContextGroupChanged_t40BC410925FACFB7B33FAE12A39E00B5275B580F* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_group, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_context, ___1_group, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ContextGroupChanged_BeginInvoke_m65C81A5646CC0237316B77A8D5A1E857FE323FDC (ContextGroupChanged_t40BC410925FACFB7B33FAE12A39E00B5275B580F* __this, RuntimeObject* ___0_context, RuntimeObject* ___1_group, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___2_callback, RuntimeObject* ___3_object, const RuntimeMethod* method) 
{
	void *__d_args[3] = {0};
	__d_args[0] = ___0_context;
	__d_args[1] = ___1_group;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___2_callback, (RuntimeObject*)___3_object);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ContextGroupChanged_EndInvoke_mB88AC0717B226314119C977E0658E534E2EFAE8F (ContextGroupChanged_t40BC410925FACFB7B33FAE12A39E00B5275B580F* __this, RuntimeObject* ___0_result, const RuntimeMethod* method) 
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ContextInfo__ctor_mA5B146303B6AB8161E318A1F5866CE5D8804BEF0 (ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* __this, String_t* ___0_name, StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___1_componentNames, TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB* ___2_componentTypes, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		String_t* L_0 = ___0_name;
		__this->___name = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___name), (void*)L_0);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_1 = ___1_componentNames;
		__this->___componentNames = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___componentNames), (void*)L_1);
		TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB* L_2 = ___2_componentTypes;
		__this->___componentTypes = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___componentTypes), (void*)L_2);
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntitasException__ctor_mE2E152AD2BDD2D60BA7D31980081F7FC5EC73E7E (EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD* __this, String_t* ___0_message, String_t* ___1_hint, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral00B28FF06B788B9B67C6B259800F404F9F3761FD);
		s_Il2CppMethodInitialized = true;
	}
	EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD* G_B2_0 = NULL;
	EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD* G_B1_0 = NULL;
	String_t* G_B3_0 = NULL;
	EntitasException_tCF713E0DA03CB155FC2C2E30652A842FE732B2DD* G_B3_1 = NULL;
	{
		String_t* L_0 = ___1_hint;
		if (L_0)
		{
			G_B2_0 = __this;
			goto IL_0007;
		}
		G_B1_0 = __this;
	}
	{
		String_t* L_1 = ___0_message;
		G_B3_0 = L_1;
		G_B3_1 = G_B1_0;
		goto IL_0013;
	}

IL_0007:
	{
		String_t* L_2 = ___0_message;
		String_t* L_3 = ___1_hint;
		String_t* L_4;
		L_4 = String_Concat_m8855A6DE10F84DA7F4EC113CADDB59873A25573B(L_2, _stringLiteral00B28FF06B788B9B67C6B259800F404F9F3761FD, L_3, NULL);
		G_B3_0 = L_4;
		G_B3_1 = G_B2_0;
	}

IL_0013:
	{
		il2cpp_codegen_runtime_class_init_inline(Exception_t_il2cpp_TypeInfo_var);
		Exception__ctor_m9B2BD92CD68916245A75109105D9071C9D430E7F(G_B3_1, G_B3_0, NULL);
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* EntitasResources_GetVersion_m3591303CD191734FBB4F27583242D457A5F8910D (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Entity_tB4178C475C4604A531B84ABE4E804A477025267D_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0335C65EEF6379144CEBFCCFBA3673189514186C);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B* V_1 = NULL;
	{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_0 = { reinterpret_cast<intptr_t> (Entity_tB4178C475C4604A531B84ABE4E804A477025267D_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_1;
		L_1 = Type_GetTypeFromHandle_m6062B81682F79A4D6DF2640692EE6D9987858C57(L_0, NULL);
		NullCheck(L_1);
		Assembly_t* L_2;
		L_2 = VirtualFuncInvoker0< Assembly_t* >::Invoke(27, L_1);
		NullCheck(L_2);
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_3;
		L_3 = VirtualFuncInvoker1< Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE*, String_t* >::Invoke(16, L_2, _stringLiteral0335C65EEF6379144CEBFCCFBA3673189514186C);
		StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B* L_4 = (StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B*)il2cpp_codegen_object_new(StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B_il2cpp_TypeInfo_var);
		StreamReader__ctor_mAFA827D6D825FEC2C29C73B65C2DD1AB9076DEC7(L_4, L_3, NULL);
		V_1 = L_4;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0028:
			{
				{
					StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B* L_5 = V_1;
					if (!L_5)
					{
						goto IL_0031;
					}
				}
				{
					StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B* L_6 = V_1;
					NullCheck(L_6);
					InterfaceActionInvoker0::Invoke(0, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_6);
				}

IL_0031:
				{
					return;
				}
			}
		});
		try
		{
			StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B* L_7 = V_1;
			NullCheck(L_7);
			String_t* L_8;
			L_8 = VirtualFuncInvoker0< String_t* >::Invoke(13, L_7);
			V_0 = L_8;
			goto IL_0032;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0032:
	{
		String_t* L_9 = V_0;
		return L_9;
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_add_OnComponentAdded_mE3F56CECFFF576AA65574EF1C69C7D8374FAC3DF (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* V_0 = NULL;
	EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* V_1 = NULL;
	EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* V_2 = NULL;
	{
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_0 = __this->___OnComponentAdded;
		V_0 = L_0;
	}

IL_0007:
	{
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_1 = V_0;
		V_1 = L_1;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_2 = V_1;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_3 = ___0_value;
		Delegate_t* L_4;
		L_4 = Delegate_Combine_m1F725AEF318BE6F0426863490691A6F4606E7D00(L_2, L_3, NULL);
		V_2 = ((EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*)CastclassSealed((RuntimeObject*)L_4, EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4_il2cpp_TypeInfo_var));
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4** L_5 = (EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4**)(&__this->___OnComponentAdded);
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_6 = V_2;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_7 = V_1;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_8;
		L_8 = InterlockedCompareExchangeImpl<EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*>(L_5, L_6, L_7);
		V_0 = L_8;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_9 = V_0;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_10 = V_1;
		if ((!(((RuntimeObject*)(EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*)L_9) == ((RuntimeObject*)(EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_remove_OnComponentAdded_mE43B5F627B2CBC16C98F3BA606FCDFA215B563BA (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* V_0 = NULL;
	EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* V_1 = NULL;
	EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* V_2 = NULL;
	{
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_0 = __this->___OnComponentAdded;
		V_0 = L_0;
	}

IL_0007:
	{
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_1 = V_0;
		V_1 = L_1;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_2 = V_1;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_3 = ___0_value;
		Delegate_t* L_4;
		L_4 = Delegate_Remove_m8B7DD5661308FA972E23CA1CC3FC9CEB355504E3(L_2, L_3, NULL);
		V_2 = ((EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*)CastclassSealed((RuntimeObject*)L_4, EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4_il2cpp_TypeInfo_var));
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4** L_5 = (EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4**)(&__this->___OnComponentAdded);
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_6 = V_2;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_7 = V_1;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_8;
		L_8 = InterlockedCompareExchangeImpl<EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*>(L_5, L_6, L_7);
		V_0 = L_8;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_9 = V_0;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_10 = V_1;
		if ((!(((RuntimeObject*)(EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*)L_9) == ((RuntimeObject*)(EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_add_OnComponentRemoved_m891ED7F9FDF0C8AD53E2BD5D1B96B5C7476869FF (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* V_0 = NULL;
	EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* V_1 = NULL;
	EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* V_2 = NULL;
	{
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_0 = __this->___OnComponentRemoved;
		V_0 = L_0;
	}

IL_0007:
	{
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_1 = V_0;
		V_1 = L_1;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_2 = V_1;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_3 = ___0_value;
		Delegate_t* L_4;
		L_4 = Delegate_Combine_m1F725AEF318BE6F0426863490691A6F4606E7D00(L_2, L_3, NULL);
		V_2 = ((EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*)CastclassSealed((RuntimeObject*)L_4, EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4_il2cpp_TypeInfo_var));
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4** L_5 = (EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4**)(&__this->___OnComponentRemoved);
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_6 = V_2;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_7 = V_1;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_8;
		L_8 = InterlockedCompareExchangeImpl<EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*>(L_5, L_6, L_7);
		V_0 = L_8;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_9 = V_0;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_10 = V_1;
		if ((!(((RuntimeObject*)(EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*)L_9) == ((RuntimeObject*)(EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_remove_OnComponentRemoved_m0139CE2520DCF84FE0E417ACE4C597D9688C599D (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* V_0 = NULL;
	EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* V_1 = NULL;
	EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* V_2 = NULL;
	{
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_0 = __this->___OnComponentRemoved;
		V_0 = L_0;
	}

IL_0007:
	{
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_1 = V_0;
		V_1 = L_1;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_2 = V_1;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_3 = ___0_value;
		Delegate_t* L_4;
		L_4 = Delegate_Remove_m8B7DD5661308FA972E23CA1CC3FC9CEB355504E3(L_2, L_3, NULL);
		V_2 = ((EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*)CastclassSealed((RuntimeObject*)L_4, EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4_il2cpp_TypeInfo_var));
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4** L_5 = (EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4**)(&__this->___OnComponentRemoved);
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_6 = V_2;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_7 = V_1;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_8;
		L_8 = InterlockedCompareExchangeImpl<EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*>(L_5, L_6, L_7);
		V_0 = L_8;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_9 = V_0;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_10 = V_1;
		if ((!(((RuntimeObject*)(EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*)L_9) == ((RuntimeObject*)(EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_add_OnComponentReplaced_m22C1ED88258788FDDF8DA204BBFA51B2B72AA909 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* V_0 = NULL;
	EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* V_1 = NULL;
	EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* V_2 = NULL;
	{
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_0 = __this->___OnComponentReplaced;
		V_0 = L_0;
	}

IL_0007:
	{
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_1 = V_0;
		V_1 = L_1;
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_2 = V_1;
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_3 = ___0_value;
		Delegate_t* L_4;
		L_4 = Delegate_Combine_m1F725AEF318BE6F0426863490691A6F4606E7D00(L_2, L_3, NULL);
		V_2 = ((EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D*)CastclassSealed((RuntimeObject*)L_4, EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D_il2cpp_TypeInfo_var));
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D** L_5 = (EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D**)(&__this->___OnComponentReplaced);
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_6 = V_2;
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_7 = V_1;
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_8;
		L_8 = InterlockedCompareExchangeImpl<EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D*>(L_5, L_6, L_7);
		V_0 = L_8;
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_9 = V_0;
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_10 = V_1;
		if ((!(((RuntimeObject*)(EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D*)L_9) == ((RuntimeObject*)(EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D*)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_remove_OnComponentReplaced_mE53D3B8C3F4125CBEEA4818B4F0D8DB1104FCC26 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* V_0 = NULL;
	EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* V_1 = NULL;
	EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* V_2 = NULL;
	{
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_0 = __this->___OnComponentReplaced;
		V_0 = L_0;
	}

IL_0007:
	{
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_1 = V_0;
		V_1 = L_1;
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_2 = V_1;
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_3 = ___0_value;
		Delegate_t* L_4;
		L_4 = Delegate_Remove_m8B7DD5661308FA972E23CA1CC3FC9CEB355504E3(L_2, L_3, NULL);
		V_2 = ((EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D*)CastclassSealed((RuntimeObject*)L_4, EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D_il2cpp_TypeInfo_var));
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D** L_5 = (EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D**)(&__this->___OnComponentReplaced);
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_6 = V_2;
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_7 = V_1;
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_8;
		L_8 = InterlockedCompareExchangeImpl<EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D*>(L_5, L_6, L_7);
		V_0 = L_8;
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_9 = V_0;
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_10 = V_1;
		if ((!(((RuntimeObject*)(EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D*)L_9) == ((RuntimeObject*)(EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D*)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_add_OnEntityReleased_mFEFAD438C615A11787BA18D255D2A3C5536D2921 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* V_0 = NULL;
	EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* V_1 = NULL;
	EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* V_2 = NULL;
	{
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_0 = __this->___OnEntityReleased;
		V_0 = L_0;
	}

IL_0007:
	{
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_1 = V_0;
		V_1 = L_1;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_2 = V_1;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_3 = ___0_value;
		Delegate_t* L_4;
		L_4 = Delegate_Combine_m1F725AEF318BE6F0426863490691A6F4606E7D00(L_2, L_3, NULL);
		V_2 = ((EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*)CastclassSealed((RuntimeObject*)L_4, EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0_il2cpp_TypeInfo_var));
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0** L_5 = (EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0**)(&__this->___OnEntityReleased);
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_6 = V_2;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_7 = V_1;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_8;
		L_8 = InterlockedCompareExchangeImpl<EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*>(L_5, L_6, L_7);
		V_0 = L_8;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_9 = V_0;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_10 = V_1;
		if ((!(((RuntimeObject*)(EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*)L_9) == ((RuntimeObject*)(EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_remove_OnEntityReleased_m289F9FD40ACF0B48E9C6D2B2518F1B32284DEC7A (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* V_0 = NULL;
	EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* V_1 = NULL;
	EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* V_2 = NULL;
	{
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_0 = __this->___OnEntityReleased;
		V_0 = L_0;
	}

IL_0007:
	{
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_1 = V_0;
		V_1 = L_1;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_2 = V_1;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_3 = ___0_value;
		Delegate_t* L_4;
		L_4 = Delegate_Remove_m8B7DD5661308FA972E23CA1CC3FC9CEB355504E3(L_2, L_3, NULL);
		V_2 = ((EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*)CastclassSealed((RuntimeObject*)L_4, EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0_il2cpp_TypeInfo_var));
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0** L_5 = (EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0**)(&__this->___OnEntityReleased);
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_6 = V_2;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_7 = V_1;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_8;
		L_8 = InterlockedCompareExchangeImpl<EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*>(L_5, L_6, L_7);
		V_0 = L_8;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_9 = V_0;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_10 = V_1;
		if ((!(((RuntimeObject*)(EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*)L_9) == ((RuntimeObject*)(EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_add_OnDestroyEntity_m4C38035BD26E6D9DF3EAEF6CF98DDFC334B77028 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* V_0 = NULL;
	EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* V_1 = NULL;
	EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* V_2 = NULL;
	{
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_0 = __this->___OnDestroyEntity;
		V_0 = L_0;
	}

IL_0007:
	{
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_1 = V_0;
		V_1 = L_1;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_2 = V_1;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_3 = ___0_value;
		Delegate_t* L_4;
		L_4 = Delegate_Combine_m1F725AEF318BE6F0426863490691A6F4606E7D00(L_2, L_3, NULL);
		V_2 = ((EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*)CastclassSealed((RuntimeObject*)L_4, EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0_il2cpp_TypeInfo_var));
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0** L_5 = (EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0**)(&__this->___OnDestroyEntity);
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_6 = V_2;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_7 = V_1;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_8;
		L_8 = InterlockedCompareExchangeImpl<EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*>(L_5, L_6, L_7);
		V_0 = L_8;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_9 = V_0;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_10 = V_1;
		if ((!(((RuntimeObject*)(EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*)L_9) == ((RuntimeObject*)(EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_remove_OnDestroyEntity_m6702E982BFBD701F66502D23DBAC80FC128CAF5A (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* V_0 = NULL;
	EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* V_1 = NULL;
	EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* V_2 = NULL;
	{
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_0 = __this->___OnDestroyEntity;
		V_0 = L_0;
	}

IL_0007:
	{
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_1 = V_0;
		V_1 = L_1;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_2 = V_1;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_3 = ___0_value;
		Delegate_t* L_4;
		L_4 = Delegate_Remove_m8B7DD5661308FA972E23CA1CC3FC9CEB355504E3(L_2, L_3, NULL);
		V_2 = ((EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*)CastclassSealed((RuntimeObject*)L_4, EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0_il2cpp_TypeInfo_var));
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0** L_5 = (EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0**)(&__this->___OnDestroyEntity);
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_6 = V_2;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_7 = V_1;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_8;
		L_8 = InterlockedCompareExchangeImpl<EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*>(L_5, L_6, L_7);
		V_0 = L_8;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_9 = V_0;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_10 = V_1;
		if ((!(((RuntimeObject*)(EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*)L_9) == ((RuntimeObject*)(EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Entity_get_totalComponents_mCD78FA06E98D931D5E6AAA689358E3327A430A5E (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____totalComponents;
		return L_0;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Entity_get_creationIndex_m54E102EC17FDA194512DC5718989395B6B3307AE (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____creationIndex;
		return L_0;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Entity_get_isEnabled_m4833C9952FA87E420C96DED687E8E4679C7639A9 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) 
{
	{
		bool L_0 = __this->____isEnabled;
		return L_0;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Stack_1U5BU5D_tBDFDA00CAA03620C331BE5D3BB61FA8ED82F2A21* Entity_get_componentPools_mDA88FCCFCD956EDDDBCAD6B0C9F3C05F7D74022B (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) 
{
	{
		Stack_1U5BU5D_tBDFDA00CAA03620C331BE5D3BB61FA8ED82F2A21* L_0 = __this->____componentPools;
		return L_0;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* Entity_get_contextInfo_mEB2CE38774398D19AE1D65A540D30466F4B4DB41 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) 
{
	{
		ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* L_0 = __this->____contextInfo;
		return L_0;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Entity_get_aerc_m3E971E578DE9035CAAE26A96767A752A614FC8B6 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->____aerc;
		return L_0;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity__ctor_m945FDD0C3C50C2316EC7D64A5BAE085A36E9C752 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m63F0297745C6B4C4B204AD379F764E2E82C555A8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3* L_0 = (List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3*)il2cpp_codegen_object_new(List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3_il2cpp_TypeInfo_var);
		List_1__ctor_m63F0297745C6B4C4B204AD379F764E2E82C555A8(L_0, List_1__ctor_m63F0297745C6B4C4B204AD379F764E2E82C555A8_RuntimeMethod_var);
		__this->____componentBuffer = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____componentBuffer), (void*)L_0);
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_1 = (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*)il2cpp_codegen_object_new(List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_il2cpp_TypeInfo_var);
		List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8(L_1, List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_RuntimeMethod_var);
		__this->____indexBuffer = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____indexBuffer), (void*)L_1);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_Initialize_m7DDBCB35837D4B7FA92F84621F689B944F1977B9 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, int32_t ___0_creationIndex, int32_t ___1_totalComponents, Stack_1U5BU5D_tBDFDA00CAA03620C331BE5D3BB61FA8ED82F2A21* ___2_componentPools, ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* ___3_contextInfo, RuntimeObject* ___4_aerc, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* G_B2_0 = NULL;
	Entity_tB4178C475C4604A531B84ABE4E804A477025267D* G_B2_1 = NULL;
	ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* G_B1_0 = NULL;
	Entity_tB4178C475C4604A531B84ABE4E804A477025267D* G_B1_1 = NULL;
	RuntimeObject* G_B4_0 = NULL;
	Entity_tB4178C475C4604A531B84ABE4E804A477025267D* G_B4_1 = NULL;
	RuntimeObject* G_B3_0 = NULL;
	Entity_tB4178C475C4604A531B84ABE4E804A477025267D* G_B3_1 = NULL;
	{
		int32_t L_0 = ___0_creationIndex;
		Entity_Reactivate_m2303F059BF0993EBC6BFEB400DA2E78BA25912CC(__this, L_0, NULL);
		int32_t L_1 = ___1_totalComponents;
		__this->____totalComponents = L_1;
		int32_t L_2 = ___1_totalComponents;
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_3 = (IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50*)(IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50*)SZArrayNew(IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50_il2cpp_TypeInfo_var, (uint32_t)L_2);
		__this->____components = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____components), (void*)L_3);
		Stack_1U5BU5D_tBDFDA00CAA03620C331BE5D3BB61FA8ED82F2A21* L_4 = ___2_componentPools;
		__this->____componentPools = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____componentPools), (void*)L_4);
		ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* L_5 = ___3_contextInfo;
		ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* L_6 = L_5;
		if (L_6)
		{
			G_B2_0 = L_6;
			G_B2_1 = __this;
			goto IL_002e;
		}
		G_B1_0 = L_6;
		G_B1_1 = __this;
	}
	{
		ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* L_7;
		L_7 = Entity_createDefaultContextInfo_m0F5FB3A4229BED3A4F9C249997E0D8D3D55CBA3D(__this, NULL);
		G_B2_0 = L_7;
		G_B2_1 = G_B1_1;
	}

IL_002e:
	{
		NullCheck(G_B2_1);
		G_B2_1->____contextInfo = G_B2_0;
		Il2CppCodeGenWriteBarrier((void**)(&G_B2_1->____contextInfo), (void*)G_B2_0);
		RuntimeObject* L_8 = ___4_aerc;
		RuntimeObject* L_9 = L_8;
		if (L_9)
		{
			G_B4_0 = L_9;
			G_B4_1 = __this;
			goto IL_0040;
		}
		G_B3_0 = L_9;
		G_B3_1 = __this;
	}
	{
		SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2* L_10 = (SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2*)il2cpp_codegen_object_new(SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2_il2cpp_TypeInfo_var);
		SafeAERC__ctor_mC581C185C97CE4CF301AE39B0D2E26B5142FDEB4(L_10, __this, NULL);
		G_B4_0 = ((RuntimeObject*)(L_10));
		G_B4_1 = G_B3_1;
	}

IL_0040:
	{
		NullCheck(G_B4_1);
		G_B4_1->____aerc = G_B4_0;
		Il2CppCodeGenWriteBarrier((void**)(&G_B4_1->____aerc), (void*)G_B4_0);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* Entity_createDefaultContextInfo_m0F5FB3A4229BED3A4F9C249997E0D8D3D55CBA3D (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4899007D1B5035A1FDE7D96666CC174630C601BB);
		s_Il2CppMethodInitialized = true;
	}
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* V_0 = NULL;
	int32_t V_1 = 0;
	{
		int32_t L_0;
		L_0 = Entity_get_totalComponents_mCD78FA06E98D931D5E6AAA689358E3327A430A5E_inline(__this, NULL);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_1 = (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)SZArrayNew(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var, (uint32_t)L_0);
		V_0 = L_1;
		V_1 = 0;
		goto IL_001e;
	}

IL_0010:
	{
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_2 = V_0;
		int32_t L_3 = V_1;
		String_t* L_4;
		L_4 = Int32_ToString_m030E01C24E294D6762FB0B6F37CB541581F55CA5((&V_1), NULL);
		NullCheck(L_2);
		(L_2)->SetAt(static_cast<il2cpp_array_size_t>(L_3), (String_t*)L_4);
		int32_t L_5 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_5, 1));
	}

IL_001e:
	{
		int32_t L_6 = V_1;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_7 = V_0;
		NullCheck(L_7);
		if ((((int32_t)L_6) < ((int32_t)((int32_t)(((RuntimeArray*)L_7)->max_length)))))
		{
			goto IL_0010;
		}
	}
	{
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_8 = V_0;
		ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* L_9 = (ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD*)il2cpp_codegen_object_new(ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD_il2cpp_TypeInfo_var);
		ContextInfo__ctor_mA5B146303B6AB8161E318A1F5866CE5D8804BEF0(L_9, _stringLiteral4899007D1B5035A1FDE7D96666CC174630C601BB, L_8, (TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB*)NULL, NULL);
		return L_9;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_Reactivate_m2303F059BF0993EBC6BFEB400DA2E78BA25912CC (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, int32_t ___0_creationIndex, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___0_creationIndex;
		__this->____creationIndex = L_0;
		__this->____isEnabled = (bool)1;
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_AddComponent_m8EB577742A15B2499E87728B721CCC2659F60EC8 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, int32_t ___0_index, RuntimeObject* ___1_component, const RuntimeMethod* method) 
{
	EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* G_B6_0 = NULL;
	EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* G_B5_0 = NULL;
	{
		bool L_0 = __this->____isEnabled;
		if (L_0)
		{
			goto IL_0026;
		}
	}
	{
		ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* L_1 = __this->____contextInfo;
		NullCheck(L_1);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_2 = L_1->___componentNames;
		int32_t L_3 = ___0_index;
		NullCheck(L_2);
		int32_t L_4 = L_3;
		String_t* L_5 = (L_2)->GetAt(static_cast<il2cpp_array_size_t>(L_4));
		String_t* L_6;
		L_6 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralC6465D3AD9309DC52459E14C31B60E28CD5BC45C)), L_5, __this, NULL);
		EntityIsNotEnabledException_tC48798BE7CA57C50EF69705FC8BF2F440DD7957C* L_7 = (EntityIsNotEnabledException_tC48798BE7CA57C50EF69705FC8BF2F440DD7957C*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&EntityIsNotEnabledException_tC48798BE7CA57C50EF69705FC8BF2F440DD7957C_il2cpp_TypeInfo_var)));
		EntityIsNotEnabledException__ctor_m252F304FAE1EFD9D9674291D35E2D650648FDE08(L_7, L_6, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_7, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Entity_AddComponent_m8EB577742A15B2499E87728B721CCC2659F60EC8_RuntimeMethod_var)));
	}

IL_0026:
	{
		int32_t L_8 = ___0_index;
		bool L_9;
		L_9 = Entity_HasComponent_m97FC1729493A4274D38700A5C7CEB9A063BCDF48(__this, L_8, NULL);
		if (!L_9)
		{
			goto IL_0053;
		}
	}
	{
		int32_t L_10 = ___0_index;
		ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* L_11 = __this->____contextInfo;
		NullCheck(L_11);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_12 = L_11->___componentNames;
		int32_t L_13 = ___0_index;
		NullCheck(L_12);
		int32_t L_14 = L_13;
		String_t* L_15 = (L_12)->GetAt(static_cast<il2cpp_array_size_t>(L_14));
		String_t* L_16;
		L_16 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralC6465D3AD9309DC52459E14C31B60E28CD5BC45C)), L_15, __this, NULL);
		EntityAlreadyHasComponentException_t180376056AF6FAEE24DCEA02957A565B06F3D63D* L_17 = (EntityAlreadyHasComponentException_t180376056AF6FAEE24DCEA02957A565B06F3D63D*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&EntityAlreadyHasComponentException_t180376056AF6FAEE24DCEA02957A565B06F3D63D_il2cpp_TypeInfo_var)));
		EntityAlreadyHasComponentException__ctor_mBA4E32B23CDDF8515EB6BC6A2CA509FB95C5B790(L_17, L_10, L_16, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralEC48BC6AECF8DAF6AF054E221860A4D7DE26515B)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_17, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Entity_AddComponent_m8EB577742A15B2499E87728B721CCC2659F60EC8_RuntimeMethod_var)));
	}

IL_0053:
	{
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_18 = __this->____components;
		int32_t L_19 = ___0_index;
		RuntimeObject* L_20 = ___1_component;
		NullCheck(L_18);
		ArrayElementTypeCheck (L_18, L_20);
		(L_18)->SetAt(static_cast<il2cpp_array_size_t>(L_19), (RuntimeObject*)L_20);
		__this->____componentsCache = (IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____componentsCache), (void*)(IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50*)NULL);
		__this->____componentIndicesCache = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____componentIndicesCache), (void*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)NULL);
		__this->____toStringCache = (String_t*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____toStringCache), (void*)(String_t*)NULL);
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_21 = __this->___OnComponentAdded;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_22 = L_21;
		if (L_22)
		{
			G_B6_0 = L_22;
			goto IL_007c;
		}
		G_B5_0 = L_22;
	}
	{
		return;
	}

IL_007c:
	{
		int32_t L_23 = ___0_index;
		RuntimeObject* L_24 = ___1_component;
		NullCheck(G_B6_0);
		EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14_inline(G_B6_0, __this, L_23, L_24, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_RemoveComponent_mFC479EABD6ED87F235F6B3F75AE2DFCF79846413 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, int32_t ___0_index, const RuntimeMethod* method) 
{
	{
		bool L_0 = __this->____isEnabled;
		if (L_0)
		{
			goto IL_0026;
		}
	}
	{
		ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* L_1 = __this->____contextInfo;
		NullCheck(L_1);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_2 = L_1->___componentNames;
		int32_t L_3 = ___0_index;
		NullCheck(L_2);
		int32_t L_4 = L_3;
		String_t* L_5 = (L_2)->GetAt(static_cast<il2cpp_array_size_t>(L_4));
		String_t* L_6;
		L_6 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralC0CC69D3E2CD8043D76150E07F46527F1A0F1773)), L_5, __this, NULL);
		EntityIsNotEnabledException_tC48798BE7CA57C50EF69705FC8BF2F440DD7957C* L_7 = (EntityIsNotEnabledException_tC48798BE7CA57C50EF69705FC8BF2F440DD7957C*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&EntityIsNotEnabledException_tC48798BE7CA57C50EF69705FC8BF2F440DD7957C_il2cpp_TypeInfo_var)));
		EntityIsNotEnabledException__ctor_m252F304FAE1EFD9D9674291D35E2D650648FDE08(L_7, L_6, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_7, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Entity_RemoveComponent_mFC479EABD6ED87F235F6B3F75AE2DFCF79846413_RuntimeMethod_var)));
	}

IL_0026:
	{
		int32_t L_8 = ___0_index;
		bool L_9;
		L_9 = Entity_HasComponent_m97FC1729493A4274D38700A5C7CEB9A063BCDF48(__this, L_8, NULL);
		if (L_9)
		{
			goto IL_0053;
		}
	}
	{
		int32_t L_10 = ___0_index;
		ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* L_11 = __this->____contextInfo;
		NullCheck(L_11);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_12 = L_11->___componentNames;
		int32_t L_13 = ___0_index;
		NullCheck(L_12);
		int32_t L_14 = L_13;
		String_t* L_15 = (L_12)->GetAt(static_cast<il2cpp_array_size_t>(L_14));
		String_t* L_16;
		L_16 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralC0CC69D3E2CD8043D76150E07F46527F1A0F1773)), L_15, __this, NULL);
		EntityDoesNotHaveComponentException_t2204861A7C3C0EEA828CF52D0A151A00E413020C* L_17 = (EntityDoesNotHaveComponentException_t2204861A7C3C0EEA828CF52D0A151A00E413020C*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&EntityDoesNotHaveComponentException_t2204861A7C3C0EEA828CF52D0A151A00E413020C_il2cpp_TypeInfo_var)));
		EntityDoesNotHaveComponentException__ctor_m79427698C1E92941BFFF19395ED18922D56941BB(L_17, L_10, L_16, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral9CF1F76013B09A2ABD7A5D6D8AE2A9E11813E8C7)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_17, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Entity_RemoveComponent_mFC479EABD6ED87F235F6B3F75AE2DFCF79846413_RuntimeMethod_var)));
	}

IL_0053:
	{
		int32_t L_18 = ___0_index;
		Entity_replaceComponent_mC1F12DBE9487C2A98C5CB386DF4BF482C594BB89(__this, L_18, (RuntimeObject*)NULL, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_ReplaceComponent_m753F0DB897BD7A12953E9AE8302662965AFEBC0D (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, int32_t ___0_index, RuntimeObject* ___1_component, const RuntimeMethod* method) 
{
	{
		bool L_0 = __this->____isEnabled;
		if (L_0)
		{
			goto IL_0026;
		}
	}
	{
		ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* L_1 = __this->____contextInfo;
		NullCheck(L_1);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_2 = L_1->___componentNames;
		int32_t L_3 = ___0_index;
		NullCheck(L_2);
		int32_t L_4 = L_3;
		String_t* L_5 = (L_2)->GetAt(static_cast<il2cpp_array_size_t>(L_4));
		String_t* L_6;
		L_6 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral2473CC51372648FEA0BFF865384FA2BE6D9757BA)), L_5, __this, NULL);
		EntityIsNotEnabledException_tC48798BE7CA57C50EF69705FC8BF2F440DD7957C* L_7 = (EntityIsNotEnabledException_tC48798BE7CA57C50EF69705FC8BF2F440DD7957C*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&EntityIsNotEnabledException_tC48798BE7CA57C50EF69705FC8BF2F440DD7957C_il2cpp_TypeInfo_var)));
		EntityIsNotEnabledException__ctor_m252F304FAE1EFD9D9674291D35E2D650648FDE08(L_7, L_6, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_7, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Entity_ReplaceComponent_m753F0DB897BD7A12953E9AE8302662965AFEBC0D_RuntimeMethod_var)));
	}

IL_0026:
	{
		int32_t L_8 = ___0_index;
		bool L_9;
		L_9 = Entity_HasComponent_m97FC1729493A4274D38700A5C7CEB9A063BCDF48(__this, L_8, NULL);
		if (!L_9)
		{
			goto IL_0038;
		}
	}
	{
		int32_t L_10 = ___0_index;
		RuntimeObject* L_11 = ___1_component;
		Entity_replaceComponent_mC1F12DBE9487C2A98C5CB386DF4BF482C594BB89(__this, L_10, L_11, NULL);
		return;
	}

IL_0038:
	{
		RuntimeObject* L_12 = ___1_component;
		if (!L_12)
		{
			goto IL_0043;
		}
	}
	{
		int32_t L_13 = ___0_index;
		RuntimeObject* L_14 = ___1_component;
		Entity_AddComponent_m8EB577742A15B2499E87728B721CCC2659F60EC8(__this, L_13, L_14, NULL);
	}

IL_0043:
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_replaceComponent_mC1F12DBE9487C2A98C5CB386DF4BF482C594BB89 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, int32_t ___0_index, RuntimeObject* ___1_replacement, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Stack_1_Push_m1A3A5ABAF9EBA6B669577B6E9F1CEBE57289870B_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* G_B4_0 = NULL;
	EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* G_B3_0 = NULL;
	EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* G_B7_0 = NULL;
	EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* G_B6_0 = NULL;
	EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* G_B11_0 = NULL;
	EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* G_B10_0 = NULL;
	{
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_0 = __this->____components;
		int32_t L_1 = ___0_index;
		NullCheck(L_0);
		int32_t L_2 = L_1;
		RuntimeObject* L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		V_0 = L_3;
		RuntimeObject* L_4 = ___1_replacement;
		RuntimeObject* L_5 = V_0;
		if ((((RuntimeObject*)(RuntimeObject*)L_4) == ((RuntimeObject*)(RuntimeObject*)L_5)))
		{
			goto IL_0067;
		}
	}
	{
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_6 = __this->____components;
		int32_t L_7 = ___0_index;
		RuntimeObject* L_8 = ___1_replacement;
		NullCheck(L_6);
		ArrayElementTypeCheck (L_6, L_8);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (RuntimeObject*)L_8);
		__this->____componentsCache = (IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____componentsCache), (void*)(IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50*)NULL);
		RuntimeObject* L_9 = ___1_replacement;
		if (!L_9)
		{
			goto IL_0037;
		}
	}
	{
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_10 = __this->___OnComponentReplaced;
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_11 = L_10;
		if (L_11)
		{
			G_B4_0 = L_11;
			goto IL_002c;
		}
		G_B3_0 = L_11;
	}
	{
		goto IL_0059;
	}

IL_002c:
	{
		int32_t L_12 = ___0_index;
		RuntimeObject* L_13 = V_0;
		RuntimeObject* L_14 = ___1_replacement;
		NullCheck(G_B4_0);
		EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70_inline(G_B4_0, __this, L_12, L_13, L_14, NULL);
		goto IL_0059;
	}

IL_0037:
	{
		__this->____componentIndicesCache = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____componentIndicesCache), (void*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)NULL);
		__this->____toStringCache = (String_t*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____toStringCache), (void*)(String_t*)NULL);
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_15 = __this->___OnComponentRemoved;
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* L_16 = L_15;
		if (L_16)
		{
			G_B7_0 = L_16;
			goto IL_0051;
		}
		G_B6_0 = L_16;
	}
	{
		goto IL_0059;
	}

IL_0051:
	{
		int32_t L_17 = ___0_index;
		RuntimeObject* L_18 = V_0;
		NullCheck(G_B7_0);
		EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14_inline(G_B7_0, __this, L_17, L_18, NULL);
	}

IL_0059:
	{
		int32_t L_19 = ___0_index;
		Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* L_20;
		L_20 = Entity_GetComponentPool_m7A27D771E1F05FD55B754771D6C118F4E4CC75BA(__this, L_19, NULL);
		RuntimeObject* L_21 = V_0;
		NullCheck(L_20);
		Stack_1_Push_m1A3A5ABAF9EBA6B669577B6E9F1CEBE57289870B(L_20, L_21, Stack_1_Push_m1A3A5ABAF9EBA6B669577B6E9F1CEBE57289870B_RuntimeMethod_var);
		return;
	}

IL_0067:
	{
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_22 = __this->___OnComponentReplaced;
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* L_23 = L_22;
		if (L_23)
		{
			G_B11_0 = L_23;
			goto IL_0072;
		}
		G_B10_0 = L_23;
	}
	{
		return;
	}

IL_0072:
	{
		int32_t L_24 = ___0_index;
		RuntimeObject* L_25 = V_0;
		RuntimeObject* L_26 = ___1_replacement;
		NullCheck(G_B11_0);
		EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70_inline(G_B11_0, __this, L_24, L_25, L_26, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Entity_GetComponent_m48E5240DCCBD9062C45E22A12BC09565807E7191 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, int32_t ___0_index, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___0_index;
		bool L_1;
		L_1 = Entity_HasComponent_m97FC1729493A4274D38700A5C7CEB9A063BCDF48(__this, L_0, NULL);
		if (L_1)
		{
			goto IL_002d;
		}
	}
	{
		int32_t L_2 = ___0_index;
		ContextInfo_t471F16CB7FF9A3DF0F1B360A38F8DF5CD28749AD* L_3 = __this->____contextInfo;
		NullCheck(L_3);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_4 = L_3->___componentNames;
		int32_t L_5 = ___0_index;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		String_t* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		String_t* L_8;
		L_8 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralB8A2098365A498F63ACC657AEFADE2F393D1251B)), L_7, __this, NULL);
		EntityDoesNotHaveComponentException_t2204861A7C3C0EEA828CF52D0A151A00E413020C* L_9 = (EntityDoesNotHaveComponentException_t2204861A7C3C0EEA828CF52D0A151A00E413020C*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&EntityDoesNotHaveComponentException_t2204861A7C3C0EEA828CF52D0A151A00E413020C_il2cpp_TypeInfo_var)));
		EntityDoesNotHaveComponentException__ctor_m79427698C1E92941BFFF19395ED18922D56941BB(L_9, L_2, L_8, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral282A064B307B2F72FC822DDE19359CFEA54529D2)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_9, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Entity_GetComponent_m48E5240DCCBD9062C45E22A12BC09565807E7191_RuntimeMethod_var)));
	}

IL_002d:
	{
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_10 = __this->____components;
		int32_t L_11 = ___0_index;
		NullCheck(L_10);
		int32_t L_12 = L_11;
		RuntimeObject* L_13 = (L_10)->GetAt(static_cast<il2cpp_array_size_t>(L_12));
		return L_13;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* Entity_GetComponents_mFFEEBD86D8BC111D8148A0F816AF377DCF7CD693 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m926AD2B85E6E1FBC5F98037D94B427F7E4D9B5A2_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Clear_mC293DD9E1F021871B58449F0A2B1BEC545F82C3F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_ToArray_m9F5C9D47065498DFB59420502E4A0349EAFD1EC5_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	RuntimeObject* V_1 = NULL;
	{
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_0 = __this->____componentsCache;
		if (L_0)
		{
			goto IL_004f;
		}
	}
	{
		V_0 = 0;
		goto IL_0028;
	}

IL_000c:
	{
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_1 = __this->____components;
		int32_t L_2 = V_0;
		NullCheck(L_1);
		int32_t L_3 = L_2;
		RuntimeObject* L_4 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_1 = L_4;
		RuntimeObject* L_5 = V_1;
		if (!L_5)
		{
			goto IL_0024;
		}
	}
	{
		List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3* L_6 = __this->____componentBuffer;
		RuntimeObject* L_7 = V_1;
		NullCheck(L_6);
		List_1_Add_m926AD2B85E6E1FBC5F98037D94B427F7E4D9B5A2_inline(L_6, L_7, List_1_Add_m926AD2B85E6E1FBC5F98037D94B427F7E4D9B5A2_RuntimeMethod_var);
	}

IL_0024:
	{
		int32_t L_8 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_8, 1));
	}

IL_0028:
	{
		int32_t L_9 = V_0;
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_10 = __this->____components;
		NullCheck(L_10);
		if ((((int32_t)L_9) < ((int32_t)((int32_t)(((RuntimeArray*)L_10)->max_length)))))
		{
			goto IL_000c;
		}
	}
	{
		List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3* L_11 = __this->____componentBuffer;
		NullCheck(L_11);
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_12;
		L_12 = List_1_ToArray_m9F5C9D47065498DFB59420502E4A0349EAFD1EC5(L_11, List_1_ToArray_m9F5C9D47065498DFB59420502E4A0349EAFD1EC5_RuntimeMethod_var);
		__this->____componentsCache = L_12;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____componentsCache), (void*)L_12);
		List_1_tFC012DB3686C1DDFFF429C09A5DD7B416A470DA3* L_13 = __this->____componentBuffer;
		NullCheck(L_13);
		List_1_Clear_mC293DD9E1F021871B58449F0A2B1BEC545F82C3F_inline(L_13, List_1_Clear_mC293DD9E1F021871B58449F0A2B1BEC545F82C3F_RuntimeMethod_var);
	}

IL_004f:
	{
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_14 = __this->____componentsCache;
		return L_14;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* Entity_GetComponentIndices_m76AF67018BEB92729FE848A281E44A75DD9ADA51 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_ToArray_m65479FB75A5FE539EA1A0D6681172717D23CEAAA_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_0 = __this->____componentIndicesCache;
		if (L_0)
		{
			goto IL_004d;
		}
	}
	{
		V_0 = 0;
		goto IL_0026;
	}

IL_000c:
	{
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_1 = __this->____components;
		int32_t L_2 = V_0;
		NullCheck(L_1);
		int32_t L_3 = L_2;
		RuntimeObject* L_4 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		if (!L_4)
		{
			goto IL_0022;
		}
	}
	{
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_5 = __this->____indexBuffer;
		int32_t L_6 = V_0;
		NullCheck(L_5);
		List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_inline(L_5, L_6, List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_RuntimeMethod_var);
	}

IL_0022:
	{
		int32_t L_7 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_7, 1));
	}

IL_0026:
	{
		int32_t L_8 = V_0;
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_9 = __this->____components;
		NullCheck(L_9);
		if ((((int32_t)L_8) < ((int32_t)((int32_t)(((RuntimeArray*)L_9)->max_length)))))
		{
			goto IL_000c;
		}
	}
	{
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_10 = __this->____indexBuffer;
		NullCheck(L_10);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_11;
		L_11 = List_1_ToArray_m65479FB75A5FE539EA1A0D6681172717D23CEAAA(L_10, List_1_ToArray_m65479FB75A5FE539EA1A0D6681172717D23CEAAA_RuntimeMethod_var);
		__this->____componentIndicesCache = L_11;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____componentIndicesCache), (void*)L_11);
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_12 = __this->____indexBuffer;
		NullCheck(L_12);
		List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_inline(L_12, List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_RuntimeMethod_var);
	}

IL_004d:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_13 = __this->____componentIndicesCache;
		return L_13;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Entity_HasComponent_m97FC1729493A4274D38700A5C7CEB9A063BCDF48 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, int32_t ___0_index, const RuntimeMethod* method) 
{
	{
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_0 = __this->____components;
		int32_t L_1 = ___0_index;
		NullCheck(L_0);
		int32_t L_2 = L_1;
		RuntimeObject* L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		return (bool)((!(((RuntimeObject*)(RuntimeObject*)L_3) <= ((RuntimeObject*)(RuntimeObject*)NULL)))? 1 : 0);
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Entity_HasComponents_m96BF3D6FB3C811EB8AFFD640C09BF20CC9E4FE5F (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___0_indices, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		V_0 = 0;
		goto IL_0016;
	}

IL_0004:
	{
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_0 = __this->____components;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1 = ___0_indices;
		int32_t L_2 = V_0;
		NullCheck(L_1);
		int32_t L_3 = L_2;
		int32_t L_4 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		NullCheck(L_0);
		int32_t L_5 = L_4;
		RuntimeObject* L_6 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		if (L_6)
		{
			goto IL_0012;
		}
	}
	{
		return (bool)0;
	}

IL_0012:
	{
		int32_t L_7 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_7, 1));
	}

IL_0016:
	{
		int32_t L_8 = V_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_9 = ___0_indices;
		NullCheck(L_9);
		if ((((int32_t)L_8) < ((int32_t)((int32_t)(((RuntimeArray*)L_9)->max_length)))))
		{
			goto IL_0004;
		}
	}
	{
		return (bool)1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Entity_HasAnyComponent_m959BC73516E99058FDEFC153D774C9E47152AF5A (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___0_indices, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		V_0 = 0;
		goto IL_0016;
	}

IL_0004:
	{
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_0 = __this->____components;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1 = ___0_indices;
		int32_t L_2 = V_0;
		NullCheck(L_1);
		int32_t L_3 = L_2;
		int32_t L_4 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		NullCheck(L_0);
		int32_t L_5 = L_4;
		RuntimeObject* L_6 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		if (!L_6)
		{
			goto IL_0012;
		}
	}
	{
		return (bool)1;
	}

IL_0012:
	{
		int32_t L_7 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_7, 1));
	}

IL_0016:
	{
		int32_t L_8 = V_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_9 = ___0_indices;
		NullCheck(L_9);
		if ((((int32_t)L_8) < ((int32_t)((int32_t)(((RuntimeArray*)L_9)->max_length)))))
		{
			goto IL_0004;
		}
	}
	{
		return (bool)0;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_RemoveAllComponents_m6D3FEA2B1BCA3EC9FC0550DBCC30A80EB19756DA (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		__this->____toStringCache = (String_t*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____toStringCache), (void*)(String_t*)NULL);
		V_0 = 0;
		goto IL_0021;
	}

IL_000b:
	{
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_0 = __this->____components;
		int32_t L_1 = V_0;
		NullCheck(L_0);
		int32_t L_2 = L_1;
		RuntimeObject* L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		if (!L_3)
		{
			goto IL_001d;
		}
	}
	{
		int32_t L_4 = V_0;
		Entity_replaceComponent_mC1F12DBE9487C2A98C5CB386DF4BF482C594BB89(__this, L_4, (RuntimeObject*)NULL, NULL);
	}

IL_001d:
	{
		int32_t L_5 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_5, 1));
	}

IL_0021:
	{
		int32_t L_6 = V_0;
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_7 = __this->____components;
		NullCheck(L_7);
		if ((((int32_t)L_6) < ((int32_t)((int32_t)(((RuntimeArray*)L_7)->max_length)))))
		{
			goto IL_000b;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* Entity_GetComponentPool_m7A27D771E1F05FD55B754771D6C118F4E4CC75BA (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, int32_t ___0_index, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Stack_1__ctor_m34EB03F352ED5B57BD4AD4C41C87A0F2ADC47B79_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* V_0 = NULL;
	{
		Stack_1U5BU5D_tBDFDA00CAA03620C331BE5D3BB61FA8ED82F2A21* L_0 = __this->____componentPools;
		int32_t L_1 = ___0_index;
		NullCheck(L_0);
		int32_t L_2 = L_1;
		Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		V_0 = L_3;
		Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* L_4 = V_0;
		if (L_4)
		{
			goto IL_001b;
		}
	}
	{
		Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* L_5 = (Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335*)il2cpp_codegen_object_new(Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335_il2cpp_TypeInfo_var);
		Stack_1__ctor_m34EB03F352ED5B57BD4AD4C41C87A0F2ADC47B79(L_5, Stack_1__ctor_m34EB03F352ED5B57BD4AD4C41C87A0F2ADC47B79_RuntimeMethod_var);
		V_0 = L_5;
		Stack_1U5BU5D_tBDFDA00CAA03620C331BE5D3BB61FA8ED82F2A21* L_6 = __this->____componentPools;
		int32_t L_7 = ___0_index;
		Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* L_8 = V_0;
		NullCheck(L_6);
		ArrayElementTypeCheck (L_6, L_8);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335*)L_8);
	}

IL_001b:
	{
		Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* L_9 = V_0;
		return L_9;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Entity_CreateComponent_mC7D282D4A08331F829DE35BA5408B4BDEDEF3E60 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, int32_t ___0_index, Type_t* ___1_type, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IComponent_tDC3779C7595B53CAC684EFC24FCC4D2189E89601_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Stack_1_Pop_m6501363A3DCBFB09583A65306FFEA89DFC4108E9_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Stack_1_get_Count_m06BE4BC0BD3700E0E08866F4E1D53F2A91F1FA91_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* V_0 = NULL;
	{
		int32_t L_0 = ___0_index;
		Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* L_1;
		L_1 = Entity_GetComponentPool_m7A27D771E1F05FD55B754771D6C118F4E4CC75BA(__this, L_0, NULL);
		V_0 = L_1;
		Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* L_2 = V_0;
		NullCheck(L_2);
		int32_t L_3;
		L_3 = Stack_1_get_Count_m06BE4BC0BD3700E0E08866F4E1D53F2A91F1FA91_inline(L_2, Stack_1_get_Count_m06BE4BC0BD3700E0E08866F4E1D53F2A91F1FA91_RuntimeMethod_var);
		if ((((int32_t)L_3) > ((int32_t)0)))
		{
			goto IL_001d;
		}
	}
	{
		Type_t* L_4 = ___1_type;
		RuntimeObject* L_5;
		L_5 = Activator_CreateInstance_mFF030428C64FDDFACC74DFAC97388A1C628BFBCF(L_4, NULL);
		return ((RuntimeObject*)Castclass((RuntimeObject*)L_5, IComponent_tDC3779C7595B53CAC684EFC24FCC4D2189E89601_il2cpp_TypeInfo_var));
	}

IL_001d:
	{
		Stack_1_t52E22E362E0225C299C21AA1E48AAA12B52B5335* L_6 = V_0;
		NullCheck(L_6);
		RuntimeObject* L_7;
		L_7 = Stack_1_Pop_m6501363A3DCBFB09583A65306FFEA89DFC4108E9(L_6, Stack_1_Pop_m6501363A3DCBFB09583A65306FFEA89DFC4108E9_RuntimeMethod_var);
		return L_7;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Entity_get_retainCount_m676992DE58920B46D96078B2BDF47BF664F58E9C (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IAERC_t69CBD4DE45FBA9F66D967261934D07F291315957_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		RuntimeObject* L_0 = __this->____aerc;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = InterfaceFuncInvoker0< int32_t >::Invoke(0, IAERC_t69CBD4DE45FBA9F66D967261934D07F291315957_il2cpp_TypeInfo_var, L_0);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_Retain_m00D0E8E349F8DF30986EC895C1CEA07853FF7449 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, RuntimeObject* ___0_owner, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IAERC_t69CBD4DE45FBA9F66D967261934D07F291315957_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		RuntimeObject* L_0 = __this->____aerc;
		RuntimeObject* L_1 = ___0_owner;
		NullCheck(L_0);
		InterfaceActionInvoker1< RuntimeObject* >::Invoke(1, IAERC_t69CBD4DE45FBA9F66D967261934D07F291315957_il2cpp_TypeInfo_var, L_0, L_1);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_Release_m3FE7870AF86DEA7F161AB605089BAF088BDE0CBD (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, RuntimeObject* ___0_owner, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IAERC_t69CBD4DE45FBA9F66D967261934D07F291315957_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* G_B3_0 = NULL;
	EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* G_B2_0 = NULL;
	{
		RuntimeObject* L_0 = __this->____aerc;
		RuntimeObject* L_1 = ___0_owner;
		NullCheck(L_0);
		InterfaceActionInvoker1< RuntimeObject* >::Invoke(2, IAERC_t69CBD4DE45FBA9F66D967261934D07F291315957_il2cpp_TypeInfo_var, L_0, L_1);
		RuntimeObject* L_2 = __this->____aerc;
		NullCheck(L_2);
		int32_t L_3;
		L_3 = InterfaceFuncInvoker0< int32_t >::Invoke(0, IAERC_t69CBD4DE45FBA9F66D967261934D07F291315957_il2cpp_TypeInfo_var, L_2);
		if (L_3)
		{
			goto IL_002a;
		}
	}
	{
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_4 = __this->___OnEntityReleased;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_5 = L_4;
		if (L_5)
		{
			G_B3_0 = L_5;
			goto IL_0024;
		}
		G_B2_0 = L_5;
	}
	{
		return;
	}

IL_0024:
	{
		NullCheck(G_B3_0);
		EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234_inline(G_B3_0, __this, NULL);
	}

IL_002a:
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_Destroy_mD3F6059226F9C43E48A2B8C8A8FB29E331AF6B1D (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) 
{
	EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* G_B4_0 = NULL;
	EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* G_B3_0 = NULL;
	{
		bool L_0 = __this->____isEnabled;
		if (L_0)
		{
			goto IL_0019;
		}
	}
	{
		String_t* L_1;
		L_1 = String_Format_mA8DBB4C2516B9723C5A41E6CB1E2FAF4BBE96DD8(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralF7014D5B895CFF0AD6A94980DA31BD4DB5B19472)), __this, NULL);
		EntityIsNotEnabledException_tC48798BE7CA57C50EF69705FC8BF2F440DD7957C* L_2 = (EntityIsNotEnabledException_tC48798BE7CA57C50EF69705FC8BF2F440DD7957C*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&EntityIsNotEnabledException_tC48798BE7CA57C50EF69705FC8BF2F440DD7957C_il2cpp_TypeInfo_var)));
		EntityIsNotEnabledException__ctor_m252F304FAE1EFD9D9674291D35E2D650648FDE08(L_2, L_1, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Entity_Destroy_mD3F6059226F9C43E48A2B8C8A8FB29E331AF6B1D_RuntimeMethod_var)));
	}

IL_0019:
	{
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_3 = __this->___OnDestroyEntity;
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* L_4 = L_3;
		if (L_4)
		{
			G_B4_0 = L_4;
			goto IL_0024;
		}
		G_B3_0 = L_4;
	}
	{
		return;
	}

IL_0024:
	{
		NullCheck(G_B4_0);
		EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234_inline(G_B4_0, __this, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_InternalDestroy_mDB2F678A7ABFCE2E5537941C01927FE83A6472E4 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) 
{
	{
		__this->____isEnabled = (bool)0;
		Entity_RemoveAllComponents_m6D3FEA2B1BCA3EC9FC0550DBCC30A80EB19756DA(__this, NULL);
		__this->___OnComponentAdded = (EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___OnComponentAdded), (void*)(EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*)NULL);
		__this->___OnComponentReplaced = (EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___OnComponentReplaced), (void*)(EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D*)NULL);
		__this->___OnComponentRemoved = (EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___OnComponentRemoved), (void*)(EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*)NULL);
		__this->___OnDestroyEntity = (EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___OnDestroyEntity), (void*)(EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*)NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entity_RemoveAllOnEntityReleasedHandlers_m771F18DDF4B6384B39C9E9531E8F0F57F4E91DE4 (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) 
{
	{
		__this->___OnEntityReleased = (EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___OnEntityReleased), (void*)(EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*)NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Entity_ToString_m8979549AF5DC8FB6812614BD2C4AB0745CAC61AD (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral758733BDBED83CBFF4F635AC26CA92AAE477F75D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA3DFC0C77ACADE0EE48DCC73E795A597D0270A73);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB3F14BF976EFD974E34846B742502C802FABAE9D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF5A4E134A104F68811845EBEE5EAFB427080DCA2);
		s_Il2CppMethodInitialized = true;
	}
	IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	RuntimeObject* V_3 = NULL;
	{
		String_t* L_0 = __this->____toStringCache;
		if (L_0)
		{
			goto IL_00bf;
		}
	}
	{
		StringBuilder_t* L_1 = __this->____toStringBuilder;
		if (L_1)
		{
			goto IL_001e;
		}
	}
	{
		StringBuilder_t* L_2 = (StringBuilder_t*)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m1D99713357DE05DAFA296633639DB55F8C30587D(L_2, NULL);
		__this->____toStringBuilder = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____toStringBuilder), (void*)L_2);
	}

IL_001e:
	{
		StringBuilder_t* L_3 = __this->____toStringBuilder;
		NullCheck(L_3);
		StringBuilder_set_Length_mE2427BDAEF91C4E4A6C80F3BDF1F6E01DBCC2414(L_3, 0, NULL);
		StringBuilder_t* L_4 = __this->____toStringBuilder;
		NullCheck(L_4);
		StringBuilder_t* L_5;
		L_5 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_4, _stringLiteralF5A4E134A104F68811845EBEE5EAFB427080DCA2, NULL);
		int32_t L_6 = __this->____creationIndex;
		NullCheck(L_5);
		StringBuilder_t* L_7;
		L_7 = StringBuilder_Append_m283B617AC29FB0DD6F3A7D8C01D385C25A5F0FAA(L_5, L_6, NULL);
		NullCheck(L_7);
		StringBuilder_t* L_8;
		L_8 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_7, _stringLiteralA3DFC0C77ACADE0EE48DCC73E795A597D0270A73, NULL);
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_9;
		L_9 = Entity_GetComponents_mFFEEBD86D8BC111D8148A0F816AF377DCF7CD693(__this, NULL);
		V_0 = L_9;
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_10 = V_0;
		NullCheck(L_10);
		V_1 = ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_10)->max_length)), 1));
		V_2 = 0;
		goto IL_0097;
	}

IL_0061:
	{
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_11 = V_0;
		int32_t L_12 = V_2;
		NullCheck(L_11);
		int32_t L_13 = L_12;
		RuntimeObject* L_14 = (L_11)->GetAt(static_cast<il2cpp_array_size_t>(L_13));
		V_3 = L_14;
		__this->____toStringCache = (String_t*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____toStringCache), (void*)(String_t*)NULL);
		StringBuilder_t* L_15 = __this->____toStringBuilder;
		RuntimeObject* L_16 = V_3;
		NullCheck(L_16);
		String_t* L_17;
		L_17 = VirtualFuncInvoker0< String_t* >::Invoke(3, L_16);
		NullCheck(L_15);
		StringBuilder_t* L_18;
		L_18 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_15, L_17, NULL);
		int32_t L_19 = V_2;
		int32_t L_20 = V_1;
		if ((((int32_t)L_19) >= ((int32_t)L_20)))
		{
			goto IL_0093;
		}
	}
	{
		StringBuilder_t* L_21 = __this->____toStringBuilder;
		NullCheck(L_21);
		StringBuilder_t* L_22;
		L_22 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_21, _stringLiteral758733BDBED83CBFF4F635AC26CA92AAE477F75D, NULL);
	}

IL_0093:
	{
		int32_t L_23 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_23, 1));
	}

IL_0097:
	{
		int32_t L_24 = V_2;
		IComponentU5BU5D_tB5BF3CD1AA11A5386760F64B9C69C07CA6CC1F50* L_25 = V_0;
		NullCheck(L_25);
		if ((((int32_t)L_24) < ((int32_t)((int32_t)(((RuntimeArray*)L_25)->max_length)))))
		{
			goto IL_0061;
		}
	}
	{
		StringBuilder_t* L_26 = __this->____toStringBuilder;
		NullCheck(L_26);
		StringBuilder_t* L_27;
		L_27 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_26, _stringLiteralB3F14BF976EFD974E34846B742502C802FABAE9D, NULL);
		StringBuilder_t* L_28 = __this->____toStringBuilder;
		NullCheck(L_28);
		String_t* L_29;
		L_29 = VirtualFuncInvoker0< String_t* >::Invoke(3, L_28);
		__this->____toStringCache = L_29;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____toStringCache), (void*)L_29);
	}

IL_00bf:
	{
		String_t* L_30 = __this->____toStringCache;
		return L_30;
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityAlreadyHasComponentException__ctor_mBA4E32B23CDDF8515EB6BC6A2CA509FB95C5B790 (EntityAlreadyHasComponentException_t180376056AF6FAEE24DCEA02957A565B06F3D63D* __this, int32_t ___0_index, String_t* ___1_message, String_t* ___2_hint, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE080F46B020E5B0229541CB5E558D863B4C83BA8);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___1_message;
		int32_t L_1 = ___0_index;
		int32_t L_2 = L_1;
		RuntimeObject* L_3 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_2);
		String_t* L_4;
		L_4 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(_stringLiteralE080F46B020E5B0229541CB5E558D863B4C83BA8, L_0, L_3, NULL);
		String_t* L_5 = ___2_hint;
		EntitasException__ctor_mE2E152AD2BDD2D60BA7D31980081F7FC5EC73E7E(__this, L_4, L_5, NULL);
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityDoesNotHaveComponentException__ctor_m79427698C1E92941BFFF19395ED18922D56941BB (EntityDoesNotHaveComponentException_t2204861A7C3C0EEA828CF52D0A151A00E413020C* __this, int32_t ___0_index, String_t* ___1_message, String_t* ___2_hint, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral43F28CD211DC51B56AA10E5BACE57607ECA413FA);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___1_message;
		int32_t L_1 = ___0_index;
		int32_t L_2 = L_1;
		RuntimeObject* L_3 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_2);
		String_t* L_4;
		L_4 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(_stringLiteral43F28CD211DC51B56AA10E5BACE57607ECA413FA, L_0, L_3, NULL);
		String_t* L_5 = ___2_hint;
		EntitasException__ctor_mE2E152AD2BDD2D60BA7D31980081F7FC5EC73E7E(__this, L_4, L_5, NULL);
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityIsAlreadyRetainedByOwnerException__ctor_m02B6DD1E20F09F4F4A1571B591B4075F41BC746E (EntityIsAlreadyRetainedByOwnerException_tB58BD16D6DB0C073D792DFE04F76CEBAE2EE58FE* __this, RuntimeObject* ___0_entity, RuntimeObject* ___1_owner, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB79F3D98860D557F6828ED8EE2B870DFE0DB88A5);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF2DB551E14481A942CC7D789D7D1AAAD3B2EE6EA);
		s_Il2CppMethodInitialized = true;
	}
	{
		RuntimeObject* L_0 = ___1_owner;
		RuntimeObject* L_1 = ___0_entity;
		String_t* L_2;
		L_2 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(_stringLiteralF2DB551E14481A942CC7D789D7D1AAAD3B2EE6EA, L_0, L_1, NULL);
		EntitasException__ctor_mE2E152AD2BDD2D60BA7D31980081F7FC5EC73E7E(__this, L_2, _stringLiteralB79F3D98860D557F6828ED8EE2B870DFE0DB88A5, NULL);
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityIsNotEnabledException__ctor_m252F304FAE1EFD9D9674291D35E2D650648FDE08 (EntityIsNotEnabledException_tC48798BE7CA57C50EF69705FC8BF2F440DD7957C* __this, String_t* ___0_message, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5DFC00054C72CA06D0162955D17D64895EB1837C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD93758B5185819AEFE21A48FB425EC792CD52046);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_message;
		String_t* L_1;
		L_1 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(L_0, _stringLiteralD93758B5185819AEFE21A48FB425EC792CD52046, NULL);
		EntitasException__ctor_mE2E152AD2BDD2D60BA7D31980081F7FC5EC73E7E(__this, L_1, _stringLiteral5DFC00054C72CA06D0162955D17D64895EB1837C, NULL);
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityIsNotRetainedByOwnerException__ctor_m2DCE0D9B0197B5C86B7A2038AFF8B06581976727 (EntityIsNotRetainedByOwnerException_t5C9A88040F783ECA528614B562071C871DF738DE* __this, RuntimeObject* ___0_entity, RuntimeObject* ___1_owner, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral552BA9BD8DC606651C356E825380CB6A7B858A73);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC87C3306A14EB48EDEB0E161294EA58A949D1584);
		s_Il2CppMethodInitialized = true;
	}
	{
		RuntimeObject* L_0 = ___1_owner;
		RuntimeObject* L_1 = ___0_entity;
		String_t* L_2;
		L_2 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(_stringLiteralC87C3306A14EB48EDEB0E161294EA58A949D1584, L_0, L_1, NULL);
		EntitasException__ctor_mE2E152AD2BDD2D60BA7D31980081F7FC5EC73E7E(__this, L_2, _stringLiteral552BA9BD8DC606651C356E825380CB6A7B858A73, NULL);
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
void EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14_Multicast(EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_component, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* currentDelegate = reinterpret_cast<EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, int32_t, RuntimeObject*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_entity, ___1_index, ___2_component, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14_OpenInst(EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_component, const RuntimeMethod* method)
{
	NullCheck(___0_entity);
	typedef void (*FunctionPointerType) (RuntimeObject*, int32_t, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_entity, ___1_index, ___2_component, method);
}
void EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14_OpenStatic(EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_component, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (RuntimeObject*, int32_t, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_entity, ___1_index, ___2_component, method);
}
void EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14_OpenVirtual(EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_component, const RuntimeMethod* method)
{
	NullCheck(___0_entity);
	VirtualActionInvoker2< int32_t, RuntimeObject* >::Invoke(il2cpp_codegen_method_get_slot(method), ___0_entity, ___1_index, ___2_component);
}
void EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14_OpenInterface(EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_component, const RuntimeMethod* method)
{
	NullCheck(___0_entity);
	InterfaceActionInvoker2< int32_t, RuntimeObject* >::Invoke(il2cpp_codegen_method_get_slot(method), il2cpp_codegen_method_get_declaring_type(method), ___0_entity, ___1_index, ___2_component);
}
void EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14_OpenGenericVirtual(EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_component, const RuntimeMethod* method)
{
	NullCheck(___0_entity);
	GenericVirtualActionInvoker2< int32_t, RuntimeObject* >::Invoke(method, ___0_entity, ___1_index, ___2_component);
}
void EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14_OpenGenericInterface(EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_component, const RuntimeMethod* method)
{
	NullCheck(___0_entity);
	GenericInterfaceActionInvoker2< int32_t, RuntimeObject* >::Invoke(method, ___0_entity, ___1_index, ___2_component);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityComponentChanged__ctor_m5683171ECE6AD229A8A2E39263D94D95A726FF7C (EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
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
			__this->___invoke_impl = (intptr_t)&EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14_OpenStatic;
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
						__this->___invoke_impl = (intptr_t)&EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14_OpenGenericInterface;
					else
						__this->___invoke_impl = (intptr_t)&EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14_OpenGenericVirtual;
				else
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14_OpenInterface;
					else
						__this->___invoke_impl = (intptr_t)&EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14_OpenVirtual;
			}
			else
			{
				__this->___invoke_impl = (intptr_t)&EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14_OpenInst;
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
	__this->___extra_arg = (intptr_t)&EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14_Multicast;
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14 (EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_component, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, int32_t, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_entity, ___1_index, ___2_component, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* EntityComponentChanged_BeginInvoke_m73EFD66695CCC009CC69A55598FE477FDA8D0C70 (EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_component, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___3_callback, RuntimeObject* ___4_object, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[4] = {0};
	__d_args[0] = ___0_entity;
	__d_args[1] = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &___1_index);
	__d_args[2] = ___2_component;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___3_callback, (RuntimeObject*)___4_object);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityComponentChanged_EndInvoke_mDA49E34A357C438EFD80FC685B7A395624F546C7 (EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* __this, RuntimeObject* ___0_result, const RuntimeMethod* method) 
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
void EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70_Multicast(EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_previousComponent, RuntimeObject* ___3_newComponent, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* currentDelegate = reinterpret_cast<EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, int32_t, RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_entity, ___1_index, ___2_previousComponent, ___3_newComponent, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70_OpenInst(EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_previousComponent, RuntimeObject* ___3_newComponent, const RuntimeMethod* method)
{
	NullCheck(___0_entity);
	typedef void (*FunctionPointerType) (RuntimeObject*, int32_t, RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_entity, ___1_index, ___2_previousComponent, ___3_newComponent, method);
}
void EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70_OpenStatic(EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_previousComponent, RuntimeObject* ___3_newComponent, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (RuntimeObject*, int32_t, RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_entity, ___1_index, ___2_previousComponent, ___3_newComponent, method);
}
void EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70_OpenVirtual(EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_previousComponent, RuntimeObject* ___3_newComponent, const RuntimeMethod* method)
{
	NullCheck(___0_entity);
	VirtualActionInvoker3< int32_t, RuntimeObject*, RuntimeObject* >::Invoke(il2cpp_codegen_method_get_slot(method), ___0_entity, ___1_index, ___2_previousComponent, ___3_newComponent);
}
void EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70_OpenInterface(EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_previousComponent, RuntimeObject* ___3_newComponent, const RuntimeMethod* method)
{
	NullCheck(___0_entity);
	InterfaceActionInvoker3< int32_t, RuntimeObject*, RuntimeObject* >::Invoke(il2cpp_codegen_method_get_slot(method), il2cpp_codegen_method_get_declaring_type(method), ___0_entity, ___1_index, ___2_previousComponent, ___3_newComponent);
}
void EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70_OpenGenericVirtual(EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_previousComponent, RuntimeObject* ___3_newComponent, const RuntimeMethod* method)
{
	NullCheck(___0_entity);
	GenericVirtualActionInvoker3< int32_t, RuntimeObject*, RuntimeObject* >::Invoke(method, ___0_entity, ___1_index, ___2_previousComponent, ___3_newComponent);
}
void EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70_OpenGenericInterface(EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_previousComponent, RuntimeObject* ___3_newComponent, const RuntimeMethod* method)
{
	NullCheck(___0_entity);
	GenericInterfaceActionInvoker3< int32_t, RuntimeObject*, RuntimeObject* >::Invoke(method, ___0_entity, ___1_index, ___2_previousComponent, ___3_newComponent);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityComponentReplaced__ctor_mAEDEA94CF108818A39027B490EDCEC4FF756E028 (EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 4;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70_OpenStatic;
		else
			{
				__this->___invoke_impl = __this->___method_ptr;
				__this->___method_code = (intptr_t)__this->___m_target;
			}
	}
	else
	{
		bool isOpen = parameterCount == 3;
		if (isOpen)
		{
			if (__this->___method_is_virtual)
			{
				if (il2cpp_codegen_method_is_generic_instance_method((RuntimeMethod*)___1_method))
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70_OpenGenericInterface;
					else
						__this->___invoke_impl = (intptr_t)&EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70_OpenGenericVirtual;
				else
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70_OpenInterface;
					else
						__this->___invoke_impl = (intptr_t)&EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70_OpenVirtual;
			}
			else
			{
				__this->___invoke_impl = (intptr_t)&EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70_OpenInst;
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
	__this->___extra_arg = (intptr_t)&EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70_Multicast;
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70 (EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_previousComponent, RuntimeObject* ___3_newComponent, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, int32_t, RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_entity, ___1_index, ___2_previousComponent, ___3_newComponent, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* EntityComponentReplaced_BeginInvoke_m635D00DF6538EA9416D4691BEC51FED1968F970D (EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_previousComponent, RuntimeObject* ___3_newComponent, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___4_callback, RuntimeObject* ___5_object, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[5] = {0};
	__d_args[0] = ___0_entity;
	__d_args[1] = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &___1_index);
	__d_args[2] = ___2_previousComponent;
	__d_args[3] = ___3_newComponent;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___4_callback, (RuntimeObject*)___5_object);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityComponentReplaced_EndInvoke_mCC1BA3BF183A92A4B3CF31AAB605D2C2BC44684A (EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* __this, RuntimeObject* ___0_result, const RuntimeMethod* method) 
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
void EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234_Multicast(EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* __this, RuntimeObject* ___0_entity, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* currentDelegate = reinterpret_cast<EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_entity, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234_OpenInst(EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* __this, RuntimeObject* ___0_entity, const RuntimeMethod* method)
{
	NullCheck(___0_entity);
	typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_entity, method);
}
void EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234_OpenStatic(EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* __this, RuntimeObject* ___0_entity, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_entity, method);
}
void EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234_OpenVirtual(EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* __this, RuntimeObject* ___0_entity, const RuntimeMethod* method)
{
	NullCheck(___0_entity);
	VirtualActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(method), ___0_entity);
}
void EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234_OpenInterface(EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* __this, RuntimeObject* ___0_entity, const RuntimeMethod* method)
{
	NullCheck(___0_entity);
	InterfaceActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(method), il2cpp_codegen_method_get_declaring_type(method), ___0_entity);
}
void EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234_OpenGenericVirtual(EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* __this, RuntimeObject* ___0_entity, const RuntimeMethod* method)
{
	NullCheck(___0_entity);
	GenericVirtualActionInvoker0::Invoke(method, ___0_entity);
}
void EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234_OpenGenericInterface(EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* __this, RuntimeObject* ___0_entity, const RuntimeMethod* method)
{
	NullCheck(___0_entity);
	GenericInterfaceActionInvoker0::Invoke(method, ___0_entity);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityEvent__ctor_mB962D865660CA65D5666F56D010725CDAE8E163E (EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 1;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234_OpenStatic;
		else
			{
				__this->___invoke_impl = __this->___method_ptr;
				__this->___method_code = (intptr_t)__this->___m_target;
			}
	}
	else
	{
		bool isOpen = parameterCount == 0;
		if (isOpen)
		{
			if (__this->___method_is_virtual)
			{
				if (il2cpp_codegen_method_is_generic_instance_method((RuntimeMethod*)___1_method))
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234_OpenGenericInterface;
					else
						__this->___invoke_impl = (intptr_t)&EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234_OpenGenericVirtual;
				else
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234_OpenInterface;
					else
						__this->___invoke_impl = (intptr_t)&EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234_OpenVirtual;
			}
			else
			{
				__this->___invoke_impl = (intptr_t)&EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234_OpenInst;
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
	__this->___extra_arg = (intptr_t)&EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234_Multicast;
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234 (EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* __this, RuntimeObject* ___0_entity, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_entity, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* EntityEvent_BeginInvoke_m110FADC053D453EC8B4B818EDE8946DB21272758 (EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* __this, RuntimeObject* ___0_entity, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___1_callback, RuntimeObject* ___2_object, const RuntimeMethod* method) 
{
	void *__d_args[2] = {0};
	__d_args[0] = ___0_entity;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___1_callback, (RuntimeObject*)___2_object);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityEvent_EndInvoke_mB148D9CC9DC5CBA247B21D012F09065B00E2EDE8 (EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* __this, RuntimeObject* ___0_result, const RuntimeMethod* method) 
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SafeAERC_get_retainCount_m68B5B5B0D483E39BE3C5002C569621A44BB98DF4 (SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_get_Count_m41CC85EEB7855CEFA3BC7A32F115387939318ED3_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* L_0 = __this->____owners;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = HashSet_1_get_Count_m41CC85EEB7855CEFA3BC7A32F115387939318ED3_inline(L_0, HashSet_1_get_Count_m41CC85EEB7855CEFA3BC7A32F115387939318ED3_RuntimeMethod_var);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* SafeAERC_get_owners_m1AB169D663164AA81CD105D5507E4F10EF283252 (SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2* __this, const RuntimeMethod* method) 
{
	{
		HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* L_0 = __this->____owners;
		return L_0;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SafeAERC__ctor_mC581C185C97CE4CF301AE39B0D2E26B5142FDEB4 (SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2* __this, RuntimeObject* ___0_entity, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1__ctor_m9132EE1422BAA45E44B7FFF495F378790D36D90E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* L_0 = (HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885*)il2cpp_codegen_object_new(HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885_il2cpp_TypeInfo_var);
		HashSet_1__ctor_m9132EE1422BAA45E44B7FFF495F378790D36D90E(L_0, HashSet_1__ctor_m9132EE1422BAA45E44B7FFF495F378790D36D90E_RuntimeMethod_var);
		__this->____owners = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____owners), (void*)L_0);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		RuntimeObject* L_1 = ___0_entity;
		__this->____entity = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____entity), (void*)L_1);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SafeAERC_Retain_mBE0924B7AC1821EA3C6F266EFFFE02CE4B5583D6 (SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2* __this, RuntimeObject* ___0_owner, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_Add_m2CD7657B3459B61DD4BBA47024AC71F7D319658B_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* L_0;
		L_0 = SafeAERC_get_owners_m1AB169D663164AA81CD105D5507E4F10EF283252_inline(__this, NULL);
		RuntimeObject* L_1 = ___0_owner;
		NullCheck(L_0);
		bool L_2;
		L_2 = HashSet_1_Add_m2CD7657B3459B61DD4BBA47024AC71F7D319658B(L_0, L_1, HashSet_1_Add_m2CD7657B3459B61DD4BBA47024AC71F7D319658B_RuntimeMethod_var);
		if (L_2)
		{
			goto IL_001b;
		}
	}
	{
		RuntimeObject* L_3 = __this->____entity;
		RuntimeObject* L_4 = ___0_owner;
		EntityIsAlreadyRetainedByOwnerException_tB58BD16D6DB0C073D792DFE04F76CEBAE2EE58FE* L_5 = (EntityIsAlreadyRetainedByOwnerException_tB58BD16D6DB0C073D792DFE04F76CEBAE2EE58FE*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&EntityIsAlreadyRetainedByOwnerException_tB58BD16D6DB0C073D792DFE04F76CEBAE2EE58FE_il2cpp_TypeInfo_var)));
		EntityIsAlreadyRetainedByOwnerException__ctor_m02B6DD1E20F09F4F4A1571B591B4075F41BC746E(L_5, L_3, L_4, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_5, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&SafeAERC_Retain_mBE0924B7AC1821EA3C6F266EFFFE02CE4B5583D6_RuntimeMethod_var)));
	}

IL_001b:
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SafeAERC_Release_m68ECDB31C850E8A2DB6BB6A097AD2EC02333D4B5 (SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2* __this, RuntimeObject* ___0_owner, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_Remove_mF1D84C0A2829DDA2A0CEE1D82A5B999B5F6627CB_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* L_0;
		L_0 = SafeAERC_get_owners_m1AB169D663164AA81CD105D5507E4F10EF283252_inline(__this, NULL);
		RuntimeObject* L_1 = ___0_owner;
		NullCheck(L_0);
		bool L_2;
		L_2 = HashSet_1_Remove_mF1D84C0A2829DDA2A0CEE1D82A5B999B5F6627CB(L_0, L_1, HashSet_1_Remove_mF1D84C0A2829DDA2A0CEE1D82A5B999B5F6627CB_RuntimeMethod_var);
		if (L_2)
		{
			goto IL_001b;
		}
	}
	{
		RuntimeObject* L_3 = __this->____entity;
		RuntimeObject* L_4 = ___0_owner;
		EntityIsNotRetainedByOwnerException_t5C9A88040F783ECA528614B562071C871DF738DE* L_5 = (EntityIsNotRetainedByOwnerException_t5C9A88040F783ECA528614B562071C871DF738DE*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&EntityIsNotRetainedByOwnerException_t5C9A88040F783ECA528614B562071C871DF738DE_il2cpp_TypeInfo_var)));
		EntityIsNotRetainedByOwnerException__ctor_m2DCE0D9B0197B5C86B7A2038AFF8B06581976727(L_5, L_3, L_4, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_5, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&SafeAERC_Release_m68ECDB31C850E8A2DB6BB6A097AD2EC02333D4B5_RuntimeMethod_var)));
	}

IL_001b:
	{
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t UnsafeAERC_get_retainCount_m4FB2DAF72CC78BDCB3798ECEC1C41209912554A1 (UnsafeAERC_tAE5B355208C71BFF1D4400DCE8C30652EFF2696F* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____retainCount;
		return L_0;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnsafeAERC_Retain_mF9274634CE1859165B7850CE7664EE9229EEB9B9 (UnsafeAERC_tAE5B355208C71BFF1D4400DCE8C30652EFF2696F* __this, RuntimeObject* ___0_owner, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____retainCount;
		__this->____retainCount = ((int32_t)il2cpp_codegen_add(L_0, 1));
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnsafeAERC_Release_m294300937C308CC833E6691AB069195318810B7F (UnsafeAERC_tAE5B355208C71BFF1D4400DCE8C30652EFF2696F* __this, RuntimeObject* ___0_owner, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____retainCount;
		__this->____retainCount = ((int32_t)il2cpp_codegen_subtract(L_0, 1));
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnsafeAERC__ctor_m4A8C0C254335509A68C6A6E40F425482914AF4DC (UnsafeAERC_tAE5B355208C71BFF1D4400DCE8C30652EFF2696F* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EntityIndexException__ctor_m1265A9363D62300CF73043A526A06B2755D8815D (EntityIndexException_t9BABEB3E99FFE1156DCFEC91285714BD7C96FED8* __this, String_t* ___0_message, String_t* ___1_hint, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___0_message;
		String_t* L_1 = ___1_hint;
		EntitasException__ctor_mE2E152AD2BDD2D60BA7D31980081F7FC5EC73E7E(__this, L_0, L_1, NULL);
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* CollectionExtension_SingleEntity_mFE455291EBCC96A8E7A04A189CB561182FD5EB3F (RuntimeObject* ___0_collection, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerable_First_TisIEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_m17BD4F6C644B3FAA39249ADCB412B1BB54243FC7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ICollection_1_t873BC7044D20F9CC7BA5AFA879A876DC31440F2A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		RuntimeObject* L_0 = ___0_collection;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = InterfaceFuncInvoker0< int32_t >::Invoke(0, ICollection_1_t873BC7044D20F9CC7BA5AFA879A876DC31440F2A_il2cpp_TypeInfo_var, L_0);
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0015;
		}
	}
	{
		RuntimeObject* L_2 = ___0_collection;
		NullCheck(L_2);
		int32_t L_3;
		L_3 = InterfaceFuncInvoker0< int32_t >::Invoke(0, ((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ICollection_1_t873BC7044D20F9CC7BA5AFA879A876DC31440F2A_il2cpp_TypeInfo_var)), L_2);
		SingleEntityException_t183BAB11477B2A57E37055080769CEA53FA77858* L_4 = (SingleEntityException_t183BAB11477B2A57E37055080769CEA53FA77858*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&SingleEntityException_t183BAB11477B2A57E37055080769CEA53FA77858_il2cpp_TypeInfo_var)));
		SingleEntityException__ctor_m4A81150F6003B9F03E3A073B980C5539F2BDB502(L_4, L_3, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&CollectionExtension_SingleEntity_mFE455291EBCC96A8E7A04A189CB561182FD5EB3F_RuntimeMethod_var)));
	}

IL_0015:
	{
		RuntimeObject* L_5 = ___0_collection;
		RuntimeObject* L_6;
		L_6 = Enumerable_First_TisIEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_m17BD4F6C644B3FAA39249ADCB412B1BB54243FC7(L_5, Enumerable_First_TisIEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_m17BD4F6C644B3FAA39249ADCB412B1BB54243FC7_RuntimeMethod_var);
		return L_6;
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SingleEntityException__ctor_m4A81150F6003B9F03E3A073B980C5539F2BDB502 (SingleEntityException_t183BAB11477B2A57E37055080769CEA53FA77858* __this, int32_t ___0_count, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7479CB2153D35E226E315DCE47F0D5024C373F2D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA0EE3D9CB3B08C45C63674FB94E4423D499457FC);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___0_count;
		int32_t L_1 = L_0;
		RuntimeObject* L_2 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_1);
		String_t* L_3;
		L_3 = String_Format_mA8DBB4C2516B9723C5A41E6CB1E2FAF4BBE96DD8(_stringLiteralA0EE3D9CB3B08C45C63674FB94E4423D499457FC, L_2, NULL);
		EntitasException__ctor_mE2E152AD2BDD2D60BA7D31980081F7FC5EC73E7E(__this, L_3, _stringLiteral7479CB2153D35E226E315DCE47F0D5024C373F2D, NULL);
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* EntitasStringExtension_AddContextSuffix_m421E110FF3DDF36DFED3780D674ACEA1738E4E6C (String_t* ___0_str, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0849E26A6A4A2DAE7ACBD20B9787BC3CB5CF6F4D);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_str;
		String_t* L_1;
		L_1 = EntitasStringExtension_addSuffix_m1C778B10E5D5902E82B5462849EB930DAEAF85BF(L_0, _stringLiteral0849E26A6A4A2DAE7ACBD20B9787BC3CB5CF6F4D, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* EntitasStringExtension_RemoveContextSuffix_mA307FEEFF508661A61277B3E1B996B4B660F6A94 (String_t* ___0_str, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0849E26A6A4A2DAE7ACBD20B9787BC3CB5CF6F4D);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_str;
		String_t* L_1;
		L_1 = EntitasStringExtension_removeSuffix_mE16E89BECF4C68E7AB7D15758CE19B7DA8BF448A(L_0, _stringLiteral0849E26A6A4A2DAE7ACBD20B9787BC3CB5CF6F4D, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool EntitasStringExtension_HasContextSuffix_mD94471EEE5E72FE02F36C7140B57903F5D36945C (String_t* ___0_str, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0849E26A6A4A2DAE7ACBD20B9787BC3CB5CF6F4D);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_str;
		bool L_1;
		L_1 = EntitasStringExtension_hasSuffix_m59B90CCA8206264D5FB8D8CE282B8093A3D92D6F(L_0, _stringLiteral0849E26A6A4A2DAE7ACBD20B9787BC3CB5CF6F4D, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* EntitasStringExtension_AddEntitySuffix_m88D3C9387905C2C4A63F6C43FD32016E400D384A (String_t* ___0_str, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE006008788ACD78A3DA9418A85208D7602DC81D0);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_str;
		String_t* L_1;
		L_1 = EntitasStringExtension_addSuffix_m1C778B10E5D5902E82B5462849EB930DAEAF85BF(L_0, _stringLiteralE006008788ACD78A3DA9418A85208D7602DC81D0, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* EntitasStringExtension_RemoveEntitySuffix_m4412253ED886DE4A48498CB70B4C33B97B8AB33E (String_t* ___0_str, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE006008788ACD78A3DA9418A85208D7602DC81D0);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_str;
		String_t* L_1;
		L_1 = EntitasStringExtension_removeSuffix_mE16E89BECF4C68E7AB7D15758CE19B7DA8BF448A(L_0, _stringLiteralE006008788ACD78A3DA9418A85208D7602DC81D0, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool EntitasStringExtension_HasEntitySuffix_mCED8CD025869E8EF7A16877829B7E7F11B9A215C (String_t* ___0_str, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE006008788ACD78A3DA9418A85208D7602DC81D0);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_str;
		bool L_1;
		L_1 = EntitasStringExtension_hasSuffix_m59B90CCA8206264D5FB8D8CE282B8093A3D92D6F(L_0, _stringLiteralE006008788ACD78A3DA9418A85208D7602DC81D0, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* EntitasStringExtension_AddComponentSuffix_mCE62EC35C1CB2E004E2D66824B8FC9E3AAD3D2C9 (String_t* ___0_str, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDEF84EBA6C9A8E7BB2723A279F7980993BF92544);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_str;
		String_t* L_1;
		L_1 = EntitasStringExtension_addSuffix_m1C778B10E5D5902E82B5462849EB930DAEAF85BF(L_0, _stringLiteralDEF84EBA6C9A8E7BB2723A279F7980993BF92544, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* EntitasStringExtension_RemoveComponentSuffix_m5505F470C77C0DDD3AC8B0E762ADA685024CCC33 (String_t* ___0_str, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDEF84EBA6C9A8E7BB2723A279F7980993BF92544);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_str;
		String_t* L_1;
		L_1 = EntitasStringExtension_removeSuffix_mE16E89BECF4C68E7AB7D15758CE19B7DA8BF448A(L_0, _stringLiteralDEF84EBA6C9A8E7BB2723A279F7980993BF92544, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool EntitasStringExtension_HasComponentSuffix_m4F73E5A1EE6A4F68B05DAF94C78674261B01B94F (String_t* ___0_str, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDEF84EBA6C9A8E7BB2723A279F7980993BF92544);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_str;
		bool L_1;
		L_1 = EntitasStringExtension_hasSuffix_m59B90CCA8206264D5FB8D8CE282B8093A3D92D6F(L_0, _stringLiteralDEF84EBA6C9A8E7BB2723A279F7980993BF92544, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* EntitasStringExtension_AddSystemSuffix_mC6A625A914C5575F1287E4A4F3AD854A76C6593E (String_t* ___0_str, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5FF374709F3F171D980E4E8BEA80A7954877FE64);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_str;
		String_t* L_1;
		L_1 = EntitasStringExtension_addSuffix_m1C778B10E5D5902E82B5462849EB930DAEAF85BF(L_0, _stringLiteral5FF374709F3F171D980E4E8BEA80A7954877FE64, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* EntitasStringExtension_RemoveSystemSuffix_m1C6302DDC8E7B192D08A5AB56FAFF1DBE1A5890F (String_t* ___0_str, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5FF374709F3F171D980E4E8BEA80A7954877FE64);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_str;
		String_t* L_1;
		L_1 = EntitasStringExtension_removeSuffix_mE16E89BECF4C68E7AB7D15758CE19B7DA8BF448A(L_0, _stringLiteral5FF374709F3F171D980E4E8BEA80A7954877FE64, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool EntitasStringExtension_HasSystemSuffix_mB3CDC07C2B2969BBDDD7BB89774E10BEF2B14F8D (String_t* ___0_str, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5FF374709F3F171D980E4E8BEA80A7954877FE64);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_str;
		bool L_1;
		L_1 = EntitasStringExtension_hasSuffix_m59B90CCA8206264D5FB8D8CE282B8093A3D92D6F(L_0, _stringLiteral5FF374709F3F171D980E4E8BEA80A7954877FE64, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* EntitasStringExtension_AddMatcherSuffix_m144633BADA8FFAE24DAC4EA2130F943E12AB679E (String_t* ___0_str, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral57A73DDAE80B092D40521059D162EF5AF60EA12F);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_str;
		String_t* L_1;
		L_1 = EntitasStringExtension_addSuffix_m1C778B10E5D5902E82B5462849EB930DAEAF85BF(L_0, _stringLiteral57A73DDAE80B092D40521059D162EF5AF60EA12F, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* EntitasStringExtension_RemoveMatcherSuffix_m1F567772AA8EE10729E772F347BA7BE4DB919B6C (String_t* ___0_str, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral57A73DDAE80B092D40521059D162EF5AF60EA12F);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_str;
		String_t* L_1;
		L_1 = EntitasStringExtension_removeSuffix_mE16E89BECF4C68E7AB7D15758CE19B7DA8BF448A(L_0, _stringLiteral57A73DDAE80B092D40521059D162EF5AF60EA12F, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool EntitasStringExtension_HasMatcherSuffix_m4123FEDEBFD6B2A744850002DE59BE85140D78F7 (String_t* ___0_str, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral57A73DDAE80B092D40521059D162EF5AF60EA12F);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_str;
		bool L_1;
		L_1 = EntitasStringExtension_hasSuffix_m59B90CCA8206264D5FB8D8CE282B8093A3D92D6F(L_0, _stringLiteral57A73DDAE80B092D40521059D162EF5AF60EA12F, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* EntitasStringExtension_AddListenerSuffix_m80482921A7D832CF6B0DDE5FB4B5CBB1DC5A175A (String_t* ___0_str, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3125B63029085F66AA6486C20739994CD2F327DA);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_str;
		String_t* L_1;
		L_1 = EntitasStringExtension_addSuffix_m1C778B10E5D5902E82B5462849EB930DAEAF85BF(L_0, _stringLiteral3125B63029085F66AA6486C20739994CD2F327DA, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* EntitasStringExtension_RemoveListenerSuffix_m6F6109F4CEB6EDF1BC62CE24186BB54A0996A339 (String_t* ___0_str, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3125B63029085F66AA6486C20739994CD2F327DA);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_str;
		String_t* L_1;
		L_1 = EntitasStringExtension_removeSuffix_mE16E89BECF4C68E7AB7D15758CE19B7DA8BF448A(L_0, _stringLiteral3125B63029085F66AA6486C20739994CD2F327DA, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool EntitasStringExtension_HasListenerSuffix_m7FD4648CBED505EA92DBBA2AB58BF72980EE22EF (String_t* ___0_str, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3125B63029085F66AA6486C20739994CD2F327DA);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_str;
		bool L_1;
		L_1 = EntitasStringExtension_hasSuffix_m59B90CCA8206264D5FB8D8CE282B8093A3D92D6F(L_0, _stringLiteral3125B63029085F66AA6486C20739994CD2F327DA, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* EntitasStringExtension_addSuffix_m1C778B10E5D5902E82B5462849EB930DAEAF85BF (String_t* ___0_str, String_t* ___1_suffix, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___0_str;
		String_t* L_1 = ___1_suffix;
		bool L_2;
		L_2 = EntitasStringExtension_hasSuffix_m59B90CCA8206264D5FB8D8CE282B8093A3D92D6F(L_0, L_1, NULL);
		if (L_2)
		{
			goto IL_0011;
		}
	}
	{
		String_t* L_3 = ___0_str;
		String_t* L_4 = ___1_suffix;
		String_t* L_5;
		L_5 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(L_3, L_4, NULL);
		return L_5;
	}

IL_0011:
	{
		String_t* L_6 = ___0_str;
		return L_6;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* EntitasStringExtension_removeSuffix_mE16E89BECF4C68E7AB7D15758CE19B7DA8BF448A (String_t* ___0_str, String_t* ___1_suffix, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___0_str;
		String_t* L_1 = ___1_suffix;
		bool L_2;
		L_2 = EntitasStringExtension_hasSuffix_m59B90CCA8206264D5FB8D8CE282B8093A3D92D6F(L_0, L_1, NULL);
		if (L_2)
		{
			goto IL_000b;
		}
	}
	{
		String_t* L_3 = ___0_str;
		return L_3;
	}

IL_000b:
	{
		String_t* L_4 = ___0_str;
		String_t* L_5 = ___0_str;
		NullCheck(L_5);
		int32_t L_6;
		L_6 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_5, NULL);
		String_t* L_7 = ___1_suffix;
		NullCheck(L_7);
		int32_t L_8;
		L_8 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_7, NULL);
		NullCheck(L_4);
		String_t* L_9;
		L_9 = String_Substring_mB1D94F47935D22E130FF2C01DBB6A4135FBB76CE(L_4, 0, ((int32_t)il2cpp_codegen_subtract(L_6, L_8)), NULL);
		return L_9;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool EntitasStringExtension_hasSuffix_m59B90CCA8206264D5FB8D8CE282B8093A3D92D6F (String_t* ___0_str, String_t* ___1_suffix, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___0_str;
		String_t* L_1 = ___1_suffix;
		NullCheck(L_0);
		bool L_2;
		L_2 = String_EndsWith_m5E5D307CA6AEB7C08CE782B4693B19D07ADC9075(L_0, L_1, 4, NULL);
		return L_2;
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PublicMemberInfoEntityExtension_CopyTo_mE1322A26F48D5EDB8A207B591C8CD92FEEEA3450 (RuntimeObject* ___0_entity, RuntimeObject* ___1_target, bool ___2_replaceExisting, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___3_indices, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	RuntimeObject* V_3 = NULL;
	RuntimeObject* V_4 = NULL;
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* G_B3_0 = NULL;
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_0 = ___3_indices;
		NullCheck(L_0);
		if (!(((RuntimeArray*)L_0)->max_length))
		{
			goto IL_0007;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1 = ___3_indices;
		G_B3_0 = L_1;
		goto IL_000d;
	}

IL_0007:
	{
		RuntimeObject* L_2 = ___0_entity;
		NullCheck(L_2);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_3;
		L_3 = InterfaceFuncInvoker0< Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* >::Invoke(23, IEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_il2cpp_TypeInfo_var, L_2);
		G_B3_0 = L_3;
	}

IL_000d:
	{
		V_0 = G_B3_0;
		V_1 = 0;
		goto IL_0050;
	}

IL_0012:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_4 = V_0;
		int32_t L_5 = V_1;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		int32_t L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_2 = L_7;
		RuntimeObject* L_8 = ___0_entity;
		int32_t L_9 = V_2;
		NullCheck(L_8);
		RuntimeObject* L_10;
		L_10 = InterfaceFuncInvoker1< RuntimeObject*, int32_t >::Invoke(21, IEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_il2cpp_TypeInfo_var, L_8, L_9);
		V_3 = L_10;
		RuntimeObject* L_11 = ___1_target;
		int32_t L_12 = V_2;
		RuntimeObject* L_13 = V_3;
		NullCheck(L_13);
		Type_t* L_14;
		L_14 = Object_GetType_mE10A8FC1E57F3DF29972CCBC026C2DC3942263B3(L_13, NULL);
		NullCheck(L_11);
		RuntimeObject* L_15;
		L_15 = InterfaceFuncInvoker2< RuntimeObject*, int32_t, Type_t* >::Invoke(29, IEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_il2cpp_TypeInfo_var, L_11, L_12, L_14);
		V_4 = L_15;
		RuntimeObject* L_16 = V_3;
		RuntimeObject* L_17 = V_4;
		PublicMemberInfoExtension_CopyPublicMemberValues_m3C010A39C4784E74F286FAF10598EE167C107C9C(L_16, L_17, NULL);
		bool L_18 = ___2_replaceExisting;
		if (!L_18)
		{
			goto IL_0043;
		}
	}
	{
		RuntimeObject* L_19 = ___1_target;
		int32_t L_20 = V_2;
		RuntimeObject* L_21 = V_4;
		NullCheck(L_19);
		InterfaceActionInvoker2< int32_t, RuntimeObject* >::Invoke(20, IEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_il2cpp_TypeInfo_var, L_19, L_20, L_21);
		goto IL_004c;
	}

IL_0043:
	{
		RuntimeObject* L_22 = ___1_target;
		int32_t L_23 = V_2;
		RuntimeObject* L_24 = V_4;
		NullCheck(L_22);
		InterfaceActionInvoker2< int32_t, RuntimeObject* >::Invoke(18, IEntity_t16C38023789E4F2A4A32C4639EE8610DE0F9E97F_il2cpp_TypeInfo_var, L_22, L_23, L_24);
	}

IL_004c:
	{
		int32_t L_25 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_25, 1));
	}

IL_0050:
	{
		int32_t L_26 = V_1;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_27 = V_0;
		NullCheck(L_27);
		if ((((int32_t)L_26) < ((int32_t)((int32_t)(((RuntimeArray*)L_27)->max_length)))))
		{
			goto IL_0012;
		}
	}
	{
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MatcherException__ctor_m191E462E239DCD65CFE3B8397A5239735A46B488 (MatcherException_t98972F509249B23D4B5F525E68570C7AE8089BA4* __this, int32_t ___0_indices, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral30D6B7F89E28AF655DC86036AC3C892360265A99);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___0_indices;
		int32_t L_1 = L_0;
		RuntimeObject* L_2 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_1);
		String_t* L_3;
		L_3 = String_Format_mA8DBB4C2516B9723C5A41E6CB1E2FAF4BBE96DD8(_stringLiteral30D6B7F89E28AF655DC86036AC3C892360265A99, L_2, NULL);
		il2cpp_codegen_runtime_class_init_inline(Exception_t_il2cpp_TypeInfo_var);
		Exception__ctor_m9B2BD92CD68916245A75109105D9071C9D430E7F(__this, L_3, NULL);
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
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Systems__ctor_m2941125B4EBDC6C6AC31ACF2C1FB69FB417804FF (Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m2F2A619D23D0C508C3AB62A578A007B27C312C73_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m69A54ED11B9857404699079358C757A11363E887_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m857E572D5CC61334AB231EFA59092D30857DCFD3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m98C7F81FA64837DD6E162E5C70A13BDEF7C18C0F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4* L_0 = (List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4*)il2cpp_codegen_object_new(List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4_il2cpp_TypeInfo_var);
		List_1__ctor_m69A54ED11B9857404699079358C757A11363E887(L_0, List_1__ctor_m69A54ED11B9857404699079358C757A11363E887_RuntimeMethod_var);
		__this->____initializeSystems = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____initializeSystems), (void*)L_0);
		List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB* L_1 = (List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB*)il2cpp_codegen_object_new(List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB_il2cpp_TypeInfo_var);
		List_1__ctor_m857E572D5CC61334AB231EFA59092D30857DCFD3(L_1, List_1__ctor_m857E572D5CC61334AB231EFA59092D30857DCFD3_RuntimeMethod_var);
		__this->____executeSystems = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____executeSystems), (void*)L_1);
		List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4* L_2 = (List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4*)il2cpp_codegen_object_new(List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4_il2cpp_TypeInfo_var);
		List_1__ctor_m2F2A619D23D0C508C3AB62A578A007B27C312C73(L_2, List_1__ctor_m2F2A619D23D0C508C3AB62A578A007B27C312C73_RuntimeMethod_var);
		__this->____cleanupSystems = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____cleanupSystems), (void*)L_2);
		List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6* L_3 = (List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6*)il2cpp_codegen_object_new(List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6_il2cpp_TypeInfo_var);
		List_1__ctor_m98C7F81FA64837DD6E162E5C70A13BDEF7C18C0F(L_3, List_1__ctor_m98C7F81FA64837DD6E162E5C70A13BDEF7C18C0F_RuntimeMethod_var);
		__this->____tearDownSystems = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____tearDownSystems), (void*)L_3);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* Systems_Add_m4BCFCF1839B433C2F91B7D8E7CA60F8A49683061 (Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* __this, RuntimeObject* ___0_system, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ICleanupSystem_tF99E4939D5332AA0B91FEB2F59FB859B1215F0CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IExecuteSystem_t4E30FED777E2D68FE364CF650299C3CFC2EE2B75_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IInitializeSystem_t35D02C33CCCC76426F530F7A98156337997FAA21_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ITearDownSystem_t7690882D96402E660A661CF00AEEB2FD33CBBFB8_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m3470969576B79057EE94FCA211CB46D0AA243DF9_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m54A91912B2411D0D35AC46B000D66485CC8798BA_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m955BFC0F3B491F15CD74C678A961B4900A9874DA_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_mBD3B17EDD7711457A94E0B737F51E4A3035D8810_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	RuntimeObject* V_2 = NULL;
	RuntimeObject* V_3 = NULL;
	{
		RuntimeObject* L_0 = ___0_system;
		V_0 = ((RuntimeObject*)IsInst((RuntimeObject*)L_0, IInitializeSystem_t35D02C33CCCC76426F530F7A98156337997FAA21_il2cpp_TypeInfo_var));
		RuntimeObject* L_1 = V_0;
		if (!L_1)
		{
			goto IL_0016;
		}
	}
	{
		List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4* L_2 = __this->____initializeSystems;
		RuntimeObject* L_3 = V_0;
		NullCheck(L_2);
		List_1_Add_mBD3B17EDD7711457A94E0B737F51E4A3035D8810_inline(L_2, L_3, List_1_Add_mBD3B17EDD7711457A94E0B737F51E4A3035D8810_RuntimeMethod_var);
	}

IL_0016:
	{
		RuntimeObject* L_4 = ___0_system;
		V_1 = ((RuntimeObject*)IsInst((RuntimeObject*)L_4, IExecuteSystem_t4E30FED777E2D68FE364CF650299C3CFC2EE2B75_il2cpp_TypeInfo_var));
		RuntimeObject* L_5 = V_1;
		if (!L_5)
		{
			goto IL_002c;
		}
	}
	{
		List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB* L_6 = __this->____executeSystems;
		RuntimeObject* L_7 = V_1;
		NullCheck(L_6);
		List_1_Add_m955BFC0F3B491F15CD74C678A961B4900A9874DA_inline(L_6, L_7, List_1_Add_m955BFC0F3B491F15CD74C678A961B4900A9874DA_RuntimeMethod_var);
	}

IL_002c:
	{
		RuntimeObject* L_8 = ___0_system;
		V_2 = ((RuntimeObject*)IsInst((RuntimeObject*)L_8, ICleanupSystem_tF99E4939D5332AA0B91FEB2F59FB859B1215F0CE_il2cpp_TypeInfo_var));
		RuntimeObject* L_9 = V_2;
		if (!L_9)
		{
			goto IL_0042;
		}
	}
	{
		List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4* L_10 = __this->____cleanupSystems;
		RuntimeObject* L_11 = V_2;
		NullCheck(L_10);
		List_1_Add_m3470969576B79057EE94FCA211CB46D0AA243DF9_inline(L_10, L_11, List_1_Add_m3470969576B79057EE94FCA211CB46D0AA243DF9_RuntimeMethod_var);
	}

IL_0042:
	{
		RuntimeObject* L_12 = ___0_system;
		V_3 = ((RuntimeObject*)IsInst((RuntimeObject*)L_12, ITearDownSystem_t7690882D96402E660A661CF00AEEB2FD33CBBFB8_il2cpp_TypeInfo_var));
		RuntimeObject* L_13 = V_3;
		if (!L_13)
		{
			goto IL_0058;
		}
	}
	{
		List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6* L_14 = __this->____tearDownSystems;
		RuntimeObject* L_15 = V_3;
		NullCheck(L_14);
		List_1_Add_m54A91912B2411D0D35AC46B000D66485CC8798BA_inline(L_14, L_15, List_1_Add_m54A91912B2411D0D35AC46B000D66485CC8798BA_RuntimeMethod_var);
	}

IL_0058:
	{
		return __this;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Systems_Remove_m1A2E971C9580BE887569EFFB121CABBC5222A2EB (Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* __this, RuntimeObject* ___0_system, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ICleanupSystem_tF99E4939D5332AA0B91FEB2F59FB859B1215F0CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IExecuteSystem_t4E30FED777E2D68FE364CF650299C3CFC2EE2B75_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IInitializeSystem_t35D02C33CCCC76426F530F7A98156337997FAA21_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ITearDownSystem_t7690882D96402E660A661CF00AEEB2FD33CBBFB8_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Remove_m182DFED6A1B299DD2A354BA960398B9652725F25_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Remove_m32C3786ECC7F4F1AA1EA443227F00743B7650B6B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Remove_m9DB7970F74E8C72B6D41E372BA7CB82D2B3EA7C8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Remove_mFD32512352FDB857E97A6E36C8A0C1FEE19E6714_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	RuntimeObject* V_2 = NULL;
	RuntimeObject* V_3 = NULL;
	{
		RuntimeObject* L_0 = ___0_system;
		V_0 = ((RuntimeObject*)IsInst((RuntimeObject*)L_0, IInitializeSystem_t35D02C33CCCC76426F530F7A98156337997FAA21_il2cpp_TypeInfo_var));
		RuntimeObject* L_1 = V_0;
		if (!L_1)
		{
			goto IL_0017;
		}
	}
	{
		List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4* L_2 = __this->____initializeSystems;
		RuntimeObject* L_3 = V_0;
		NullCheck(L_2);
		bool L_4;
		L_4 = List_1_Remove_m182DFED6A1B299DD2A354BA960398B9652725F25(L_2, L_3, List_1_Remove_m182DFED6A1B299DD2A354BA960398B9652725F25_RuntimeMethod_var);
	}

IL_0017:
	{
		RuntimeObject* L_5 = ___0_system;
		V_1 = ((RuntimeObject*)IsInst((RuntimeObject*)L_5, IExecuteSystem_t4E30FED777E2D68FE364CF650299C3CFC2EE2B75_il2cpp_TypeInfo_var));
		RuntimeObject* L_6 = V_1;
		if (!L_6)
		{
			goto IL_002e;
		}
	}
	{
		List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB* L_7 = __this->____executeSystems;
		RuntimeObject* L_8 = V_1;
		NullCheck(L_7);
		bool L_9;
		L_9 = List_1_Remove_m9DB7970F74E8C72B6D41E372BA7CB82D2B3EA7C8(L_7, L_8, List_1_Remove_m9DB7970F74E8C72B6D41E372BA7CB82D2B3EA7C8_RuntimeMethod_var);
	}

IL_002e:
	{
		RuntimeObject* L_10 = ___0_system;
		V_2 = ((RuntimeObject*)IsInst((RuntimeObject*)L_10, ICleanupSystem_tF99E4939D5332AA0B91FEB2F59FB859B1215F0CE_il2cpp_TypeInfo_var));
		RuntimeObject* L_11 = V_2;
		if (!L_11)
		{
			goto IL_0045;
		}
	}
	{
		List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4* L_12 = __this->____cleanupSystems;
		RuntimeObject* L_13 = V_2;
		NullCheck(L_12);
		bool L_14;
		L_14 = List_1_Remove_m32C3786ECC7F4F1AA1EA443227F00743B7650B6B(L_12, L_13, List_1_Remove_m32C3786ECC7F4F1AA1EA443227F00743B7650B6B_RuntimeMethod_var);
	}

IL_0045:
	{
		RuntimeObject* L_15 = ___0_system;
		V_3 = ((RuntimeObject*)IsInst((RuntimeObject*)L_15, ITearDownSystem_t7690882D96402E660A661CF00AEEB2FD33CBBFB8_il2cpp_TypeInfo_var));
		RuntimeObject* L_16 = V_3;
		if (!L_16)
		{
			goto IL_005c;
		}
	}
	{
		List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6* L_17 = __this->____tearDownSystems;
		RuntimeObject* L_18 = V_3;
		NullCheck(L_17);
		bool L_19;
		L_19 = List_1_Remove_mFD32512352FDB857E97A6E36C8A0C1FEE19E6714(L_17, L_18, List_1_Remove_mFD32512352FDB857E97A6E36C8A0C1FEE19E6714_RuntimeMethod_var);
	}

IL_005c:
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Systems_Initialize_m7BE3CEA29EAA1865944C69369891753EF966B160 (Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IInitializeSystem_t35D02C33CCCC76426F530F7A98156337997FAA21_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_mBCC89E3A732616D2D45184D8A5D7780C41025B2E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_m008F12FFE7C434066EB70D102092AC7A3406DFE5_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		V_0 = 0;
		goto IL_0019;
	}

IL_0004:
	{
		List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4* L_0 = __this->____initializeSystems;
		int32_t L_1 = V_0;
		NullCheck(L_0);
		RuntimeObject* L_2;
		L_2 = List_1_get_Item_m008F12FFE7C434066EB70D102092AC7A3406DFE5(L_0, L_1, List_1_get_Item_m008F12FFE7C434066EB70D102092AC7A3406DFE5_RuntimeMethod_var);
		NullCheck(L_2);
		InterfaceActionInvoker0::Invoke(0, IInitializeSystem_t35D02C33CCCC76426F530F7A98156337997FAA21_il2cpp_TypeInfo_var, L_2);
		int32_t L_3 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_3, 1));
	}

IL_0019:
	{
		int32_t L_4 = V_0;
		List_1_tE6220CD1E2167FFF79D9EE391372CDAB30C438E4* L_5 = __this->____initializeSystems;
		NullCheck(L_5);
		int32_t L_6;
		L_6 = List_1_get_Count_mBCC89E3A732616D2D45184D8A5D7780C41025B2E_inline(L_5, List_1_get_Count_mBCC89E3A732616D2D45184D8A5D7780C41025B2E_RuntimeMethod_var);
		if ((((int32_t)L_4) < ((int32_t)L_6)))
		{
			goto IL_0004;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Systems_Execute_mFA3AC55E510E9DC064FF80C0950AB01D3A8DDED8 (Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IExecuteSystem_t4E30FED777E2D68FE364CF650299C3CFC2EE2B75_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m7639C2A449943F673350F560F544B8B9FAB8A37D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_mEF669AC0B44B77803D582B526D2C08269A722F4B_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		V_0 = 0;
		goto IL_0019;
	}

IL_0004:
	{
		List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB* L_0 = __this->____executeSystems;
		int32_t L_1 = V_0;
		NullCheck(L_0);
		RuntimeObject* L_2;
		L_2 = List_1_get_Item_mEF669AC0B44B77803D582B526D2C08269A722F4B(L_0, L_1, List_1_get_Item_mEF669AC0B44B77803D582B526D2C08269A722F4B_RuntimeMethod_var);
		NullCheck(L_2);
		InterfaceActionInvoker0::Invoke(0, IExecuteSystem_t4E30FED777E2D68FE364CF650299C3CFC2EE2B75_il2cpp_TypeInfo_var, L_2);
		int32_t L_3 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_3, 1));
	}

IL_0019:
	{
		int32_t L_4 = V_0;
		List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB* L_5 = __this->____executeSystems;
		NullCheck(L_5);
		int32_t L_6;
		L_6 = List_1_get_Count_m7639C2A449943F673350F560F544B8B9FAB8A37D_inline(L_5, List_1_get_Count_m7639C2A449943F673350F560F544B8B9FAB8A37D_RuntimeMethod_var);
		if ((((int32_t)L_4) < ((int32_t)L_6)))
		{
			goto IL_0004;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Systems_Cleanup_m37CF0DD2E95676A689BCBA97FD4CCAD9935D150B (Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ICleanupSystem_tF99E4939D5332AA0B91FEB2F59FB859B1215F0CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m34A818667B41D76E9D3322A642D03BB33900380B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_mAC23816FC8101220D796791157C5C1E7B74FE2F3_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		V_0 = 0;
		goto IL_0019;
	}

IL_0004:
	{
		List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4* L_0 = __this->____cleanupSystems;
		int32_t L_1 = V_0;
		NullCheck(L_0);
		RuntimeObject* L_2;
		L_2 = List_1_get_Item_mAC23816FC8101220D796791157C5C1E7B74FE2F3(L_0, L_1, List_1_get_Item_mAC23816FC8101220D796791157C5C1E7B74FE2F3_RuntimeMethod_var);
		NullCheck(L_2);
		InterfaceActionInvoker0::Invoke(0, ICleanupSystem_tF99E4939D5332AA0B91FEB2F59FB859B1215F0CE_il2cpp_TypeInfo_var, L_2);
		int32_t L_3 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_3, 1));
	}

IL_0019:
	{
		int32_t L_4 = V_0;
		List_1_tAEDBB8CA3ED279EA3ED6C66B30033E40280037A4* L_5 = __this->____cleanupSystems;
		NullCheck(L_5);
		int32_t L_6;
		L_6 = List_1_get_Count_m34A818667B41D76E9D3322A642D03BB33900380B_inline(L_5, List_1_get_Count_m34A818667B41D76E9D3322A642D03BB33900380B_RuntimeMethod_var);
		if ((((int32_t)L_4) < ((int32_t)L_6)))
		{
			goto IL_0004;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Systems_TearDown_mEA01AEDDC9BF2DC562440D646B47A164AD7E3736 (Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ITearDownSystem_t7690882D96402E660A661CF00AEEB2FD33CBBFB8_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_mC8EC69FAFB2FE4AB7E1CBC7465512DDA4A5C4B6D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_m136BBBD4A6AAF2E1775292CAD7C27A34F3738BA3_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		V_0 = 0;
		goto IL_0019;
	}

IL_0004:
	{
		List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6* L_0 = __this->____tearDownSystems;
		int32_t L_1 = V_0;
		NullCheck(L_0);
		RuntimeObject* L_2;
		L_2 = List_1_get_Item_m136BBBD4A6AAF2E1775292CAD7C27A34F3738BA3(L_0, L_1, List_1_get_Item_m136BBBD4A6AAF2E1775292CAD7C27A34F3738BA3_RuntimeMethod_var);
		NullCheck(L_2);
		InterfaceActionInvoker0::Invoke(0, ITearDownSystem_t7690882D96402E660A661CF00AEEB2FD33CBBFB8_il2cpp_TypeInfo_var, L_2);
		int32_t L_3 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_3, 1));
	}

IL_0019:
	{
		int32_t L_4 = V_0;
		List_1_tA65A399EA3B6F244C8045E14969A754766FAA6C6* L_5 = __this->____tearDownSystems;
		NullCheck(L_5);
		int32_t L_6;
		L_6 = List_1_get_Count_mC8EC69FAFB2FE4AB7E1CBC7465512DDA4A5C4B6D_inline(L_5, List_1_get_Count_mC8EC69FAFB2FE4AB7E1CBC7465512DDA4A5C4B6D_RuntimeMethod_var);
		if ((((int32_t)L_4) < ((int32_t)L_6)))
		{
			goto IL_0004;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Systems_ActivateReactiveSystems_m8CC189427D7FE5CB907A67FBCDCF9F96FDA7F0FC (Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IReactiveSystem_t097169972AA4253A075D1360A0EBED4AAC6E7F96_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m7639C2A449943F673350F560F544B8B9FAB8A37D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_mEF669AC0B44B77803D582B526D2C08269A722F4B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	RuntimeObject* V_1 = NULL;
	Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* V_2 = NULL;
	RuntimeObject* G_B3_0 = NULL;
	RuntimeObject* G_B2_0 = NULL;
	{
		V_0 = 0;
		goto IL_0033;
	}

IL_0004:
	{
		List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB* L_0 = __this->____executeSystems;
		int32_t L_1 = V_0;
		NullCheck(L_0);
		RuntimeObject* L_2;
		L_2 = List_1_get_Item_mEF669AC0B44B77803D582B526D2C08269A722F4B(L_0, L_1, List_1_get_Item_mEF669AC0B44B77803D582B526D2C08269A722F4B_RuntimeMethod_var);
		RuntimeObject* L_3 = L_2;
		V_1 = ((RuntimeObject*)IsInst((RuntimeObject*)L_3, IReactiveSystem_t097169972AA4253A075D1360A0EBED4AAC6E7F96_il2cpp_TypeInfo_var));
		RuntimeObject* L_4 = V_1;
		if (!L_4)
		{
			G_B3_0 = L_3;
			goto IL_0020;
		}
		G_B2_0 = L_3;
	}
	{
		RuntimeObject* L_5 = V_1;
		NullCheck(L_5);
		InterfaceActionInvoker0::Invoke(0, IReactiveSystem_t097169972AA4253A075D1360A0EBED4AAC6E7F96_il2cpp_TypeInfo_var, L_5);
		G_B3_0 = G_B2_0;
	}

IL_0020:
	{
		V_2 = ((Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E*)IsInstClass((RuntimeObject*)G_B3_0, Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E_il2cpp_TypeInfo_var));
		Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* L_6 = V_2;
		if (!L_6)
		{
			goto IL_002f;
		}
	}
	{
		Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* L_7 = V_2;
		NullCheck(L_7);
		Systems_ActivateReactiveSystems_m8CC189427D7FE5CB907A67FBCDCF9F96FDA7F0FC(L_7, NULL);
	}

IL_002f:
	{
		int32_t L_8 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_8, 1));
	}

IL_0033:
	{
		int32_t L_9 = V_0;
		List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB* L_10 = __this->____executeSystems;
		NullCheck(L_10);
		int32_t L_11;
		L_11 = List_1_get_Count_m7639C2A449943F673350F560F544B8B9FAB8A37D_inline(L_10, List_1_get_Count_m7639C2A449943F673350F560F544B8B9FAB8A37D_RuntimeMethod_var);
		if ((((int32_t)L_9) < ((int32_t)L_11)))
		{
			goto IL_0004;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Systems_DeactivateReactiveSystems_mCFF9E5EC8DD87FAF1437FF4314365C73592EFE42 (Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IReactiveSystem_t097169972AA4253A075D1360A0EBED4AAC6E7F96_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m7639C2A449943F673350F560F544B8B9FAB8A37D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_mEF669AC0B44B77803D582B526D2C08269A722F4B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	RuntimeObject* V_1 = NULL;
	Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* V_2 = NULL;
	RuntimeObject* G_B3_0 = NULL;
	RuntimeObject* G_B2_0 = NULL;
	{
		V_0 = 0;
		goto IL_0033;
	}

IL_0004:
	{
		List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB* L_0 = __this->____executeSystems;
		int32_t L_1 = V_0;
		NullCheck(L_0);
		RuntimeObject* L_2;
		L_2 = List_1_get_Item_mEF669AC0B44B77803D582B526D2C08269A722F4B(L_0, L_1, List_1_get_Item_mEF669AC0B44B77803D582B526D2C08269A722F4B_RuntimeMethod_var);
		RuntimeObject* L_3 = L_2;
		V_1 = ((RuntimeObject*)IsInst((RuntimeObject*)L_3, IReactiveSystem_t097169972AA4253A075D1360A0EBED4AAC6E7F96_il2cpp_TypeInfo_var));
		RuntimeObject* L_4 = V_1;
		if (!L_4)
		{
			G_B3_0 = L_3;
			goto IL_0020;
		}
		G_B2_0 = L_3;
	}
	{
		RuntimeObject* L_5 = V_1;
		NullCheck(L_5);
		InterfaceActionInvoker0::Invoke(1, IReactiveSystem_t097169972AA4253A075D1360A0EBED4AAC6E7F96_il2cpp_TypeInfo_var, L_5);
		G_B3_0 = G_B2_0;
	}

IL_0020:
	{
		V_2 = ((Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E*)IsInstClass((RuntimeObject*)G_B3_0, Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E_il2cpp_TypeInfo_var));
		Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* L_6 = V_2;
		if (!L_6)
		{
			goto IL_002f;
		}
	}
	{
		Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* L_7 = V_2;
		NullCheck(L_7);
		Systems_DeactivateReactiveSystems_mCFF9E5EC8DD87FAF1437FF4314365C73592EFE42(L_7, NULL);
	}

IL_002f:
	{
		int32_t L_8 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_8, 1));
	}

IL_0033:
	{
		int32_t L_9 = V_0;
		List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB* L_10 = __this->____executeSystems;
		NullCheck(L_10);
		int32_t L_11;
		L_11 = List_1_get_Count_m7639C2A449943F673350F560F544B8B9FAB8A37D_inline(L_10, List_1_get_Count_m7639C2A449943F673350F560F544B8B9FAB8A37D_RuntimeMethod_var);
		if ((((int32_t)L_9) < ((int32_t)L_11)))
		{
			goto IL_0004;
		}
	}
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Systems_ClearReactiveSystems_m944D8FA4D4324865D74EB78C392994B6170F5830 (Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IReactiveSystem_t097169972AA4253A075D1360A0EBED4AAC6E7F96_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m7639C2A449943F673350F560F544B8B9FAB8A37D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_mEF669AC0B44B77803D582B526D2C08269A722F4B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	RuntimeObject* V_1 = NULL;
	Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* V_2 = NULL;
	RuntimeObject* G_B3_0 = NULL;
	RuntimeObject* G_B2_0 = NULL;
	{
		V_0 = 0;
		goto IL_0033;
	}

IL_0004:
	{
		List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB* L_0 = __this->____executeSystems;
		int32_t L_1 = V_0;
		NullCheck(L_0);
		RuntimeObject* L_2;
		L_2 = List_1_get_Item_mEF669AC0B44B77803D582B526D2C08269A722F4B(L_0, L_1, List_1_get_Item_mEF669AC0B44B77803D582B526D2C08269A722F4B_RuntimeMethod_var);
		RuntimeObject* L_3 = L_2;
		V_1 = ((RuntimeObject*)IsInst((RuntimeObject*)L_3, IReactiveSystem_t097169972AA4253A075D1360A0EBED4AAC6E7F96_il2cpp_TypeInfo_var));
		RuntimeObject* L_4 = V_1;
		if (!L_4)
		{
			G_B3_0 = L_3;
			goto IL_0020;
		}
		G_B2_0 = L_3;
	}
	{
		RuntimeObject* L_5 = V_1;
		NullCheck(L_5);
		InterfaceActionInvoker0::Invoke(2, IReactiveSystem_t097169972AA4253A075D1360A0EBED4AAC6E7F96_il2cpp_TypeInfo_var, L_5);
		G_B3_0 = G_B2_0;
	}

IL_0020:
	{
		V_2 = ((Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E*)IsInstClass((RuntimeObject*)G_B3_0, Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E_il2cpp_TypeInfo_var));
		Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* L_6 = V_2;
		if (!L_6)
		{
			goto IL_002f;
		}
	}
	{
		Systems_t8159B225CAC3E3C13C9A931ED0EC460AF1F0AA7E* L_7 = V_2;
		NullCheck(L_7);
		Systems_ClearReactiveSystems_m944D8FA4D4324865D74EB78C392994B6170F5830(L_7, NULL);
	}

IL_002f:
	{
		int32_t L_8 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_8, 1));
	}

IL_0033:
	{
		int32_t L_9 = V_0;
		List_1_t8BB36283515257FA9CF8D70BF92105D506D81BEB* L_10 = __this->____executeSystems;
		NullCheck(L_10);
		int32_t L_11;
		L_11 = List_1_get_Count_m7639C2A449943F673350F560F544B8B9FAB8A37D_inline(L_10, List_1_get_Count_m7639C2A449943F673350F560F544B8B9FAB8A37D_RuntimeMethod_var);
		if ((((int32_t)L_9) < ((int32_t)L_11)))
		{
			goto IL_0004;
		}
	}
	{
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* SafeAERC_get_owners_m1AB169D663164AA81CD105D5507E4F10EF283252_inline (SafeAERC_t2ACCDA86D6EADCF4DEDF85944900E09DD7583AB2* __this, const RuntimeMethod* method) 
{
	{
		HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* L_0 = __this->____owners;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Entity_get_totalComponents_mCD78FA06E98D931D5E6AAA689358E3327A430A5E_inline (Entity_tB4178C475C4604A531B84ABE4E804A477025267D* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____totalComponents;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void EntityComponentChanged_Invoke_m5E851582F004CB7FF354B016D40721FBFAE7FC14_inline (EntityComponentChanged_t7192AC8B4239B99DBB58341AA2758EAFED39C9A4* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_component, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, int32_t, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_entity, ___1_index, ___2_component, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void EntityComponentReplaced_Invoke_m3579EB4DC908AEA8BCE78815E7D550A20D635F70_inline (EntityComponentReplaced_tAA437266DF1E9399927B52E8B71BE7C74B32B33D* __this, RuntimeObject* ___0_entity, int32_t ___1_index, RuntimeObject* ___2_previousComponent, RuntimeObject* ___3_newComponent, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, int32_t, RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_entity, ___1_index, ___2_previousComponent, ___3_newComponent, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void EntityEvent_Invoke_mE21E2A5329B7E1CA0100DB77E0DD4D8BC6F7A234_inline (EntityEvent_t816A324A62C6C1DE453EEB0A56E128C0F62299D0* __this, RuntimeObject* ___0_entity, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_entity, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline (String_t* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____stringLength;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) 
{
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* V_0 = NULL;
	int32_t V_1 = 0;
	{
		int32_t L_0 = __this->____version;
		__this->____version = ((int32_t)il2cpp_codegen_add(L_0, 1));
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_1 = __this->____items;
		V_0 = L_1;
		int32_t L_2 = __this->____size;
		V_1 = L_2;
		int32_t L_3 = V_1;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_4 = V_0;
		NullCheck(L_4);
		if ((!(((uint32_t)L_3) < ((uint32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))))))
		{
			goto IL_0034;
		}
	}
	{
		int32_t L_5 = V_1;
		__this->____size = ((int32_t)il2cpp_codegen_add(L_5, 1));
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_6 = V_0;
		int32_t L_7 = V_1;
		RuntimeObject* L_8 = ___0_item;
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (RuntimeObject*)L_8);
		return;
	}

IL_0034:
	{
		RuntimeObject* L_9 = ___0_item;
		List_1_AddWithResize_m79A9BF770BEF9C06BE40D5401E55E375F2726CC4(__this, L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 14));
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Clear_m16C1F2C61FED5955F10EB36BC1CB2DF34B128994_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->____version;
		__this->____version = ((int32_t)il2cpp_codegen_add(L_0, 1));
	}
	{
		int32_t L_1 = __this->____size;
		V_0 = L_1;
		__this->____size = 0;
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) <= ((int32_t)0)))
		{
			goto IL_003c;
		}
	}
	{
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_3 = __this->____items;
		int32_t L_4 = V_0;
		Array_Clear_m50BAA3751899858B097D3FF2ED31F284703FE5CB((RuntimeArray*)L_3, 0, L_4, NULL);
		return;
	}

IL_003c:
	{
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_gshared_inline (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___0_item, const RuntimeMethod* method) 
{
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* V_0 = NULL;
	int32_t V_1 = 0;
	{
		int32_t L_0 = __this->____version;
		__this->____version = ((int32_t)il2cpp_codegen_add(L_0, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1 = __this->____items;
		V_0 = L_1;
		int32_t L_2 = __this->____size;
		V_1 = L_2;
		int32_t L_3 = V_1;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_4 = V_0;
		NullCheck(L_4);
		if ((!(((uint32_t)L_3) < ((uint32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))))))
		{
			goto IL_0034;
		}
	}
	{
		int32_t L_5 = V_1;
		__this->____size = ((int32_t)il2cpp_codegen_add(L_5, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_6 = V_0;
		int32_t L_7 = V_1;
		int32_t L_8 = ___0_item;
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (int32_t)L_8);
		return;
	}

IL_0034:
	{
		int32_t L_9 = ___0_item;
		List_1_AddWithResize_m378B392086AAB6F400944FA9839516326B3F7BB8(__this, L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 14));
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_gshared_inline (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->____version;
		__this->____version = ((int32_t)il2cpp_codegen_add(L_0, 1));
		goto IL_0035;
	}

IL_0035:
	{
		__this->____size = 0;
	}

IL_003c:
	{
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Stack_1_get_Count_mD08AE71D49787D30DDD9D484BCD323D646744D2E_gshared_inline (Stack_1_tAD790A47551563636908E21E4F08C54C0C323EB5* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____size;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t HashSet_1_get_Count_m41CC85EEB7855CEFA3BC7A32F115387939318ED3_gshared_inline (HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____count;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____size;
		return L_0;
	}
}
